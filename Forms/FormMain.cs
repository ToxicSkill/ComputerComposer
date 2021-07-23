using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using ComputerComposerNsp.Models.Entities;
using ComputerComposerNsp.Repositories;
using ComputerComposerNsp.ViewModels;

namespace ComputerComposerNsp
{
    /// <summary>
    /// Main window 
    /// </summary>
    public partial class FormMain : Form
    {
        // creating computers repository
        private readonly ComputersRep computersRep = new ComputersRep();

        //creating new repositories
        readonly BoxRep boxRep = new BoxRep();
        readonly GraphicRep graphicRep = new GraphicRep();
        readonly OSystemRep oSystemRep = new OSystemRep();
        readonly PowerUnitRep powerUnitRep = new PowerUnitRep();
        readonly ProcessorRep processorRep = new ProcessorRep();
        readonly RamRep ramRep = new RamRep();

        //creating list of combo boxes
        readonly List<ComboBox> comboBoxes = new List<ComboBox>();

        //variable for price of chosen elements
        float actualPrice = 0;

        //list variable for holding each price of elements separately
        readonly List<float> prices = new List<float>();

        //    //bool variable for checking if it is first run of application 
        //    bool firstRun = true;

        /// <summary>
        /// Constructor
        /// </summary>
        public FormMain()
        {
            InitializeComponent();

            //starting in the center
            StartPosition = FormStartPosition.CenterScreen;
            //function for filling combo boxes
            FillComboBoxesList();
            //refreshing combo boxes
            RefreshComboBoxes();
        }

        /// <summary>
        /// Function for filling combo boxes
        /// </summary>
        private void FillComboBoxesList()
        {
            //adding each combo box to the list of them
            comboBoxes.Add(comboBoxBox);
            comboBoxes.Add(comboBoxGraphics);
            comboBoxes.Add(comboBoxSystem);
            comboBoxes.Add(comboBoxPowerUnit);
            comboBoxes.Add(comboBoxProcessor);
            comboBoxes.Add(comboBoxRam);

            //adding same count of prices as count of combo boxes
            for (var i = 0; i < comboBoxes.Count; ++i)
                prices.Add(0);
        }

        ///// <summary>
        ///// When main window is loaded
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        private void FormMain_Load(object sender, EventArgs e)
        {
            //refreshing data grid view when main window is loaded
            RefreshDataGridViewComputers();
            //assigning user login to the text box
            labelActualUser.Text = Program.user;
        }

        /// <summary>
        /// Method for refreshing combo boxes
        /// </summary>
        private void RefreshComboBoxes()
        {
            //index of current combo box
            int index = 0;

            foreach (var comboBox in comboBoxes)
            {
                DataTable table = new DataTable();
                BindingSource bindingSource = new BindingSource();

                //filling combo boxes with computer elements
                switch (index)
                {
                    case (int)Elements.Box:
                        //assigning list of names to binding source variable
                        bindingSource.DataSource = boxRep.GetStringList();
                        break;
                    case (int)Elements.Graphics:
                        bindingSource.DataSource = graphicRep.GetStringList();
                        break;
                    case (int)Elements.System:
                        bindingSource.DataSource = oSystemRep.GetStringList();
                        break;
                    case (int)Elements.PowerUnit:
                        bindingSource.DataSource = powerUnitRep.GetStringList();
                        break;
                    case (int)Elements.Processor:
                        bindingSource.DataSource = processorRep.GetStringList();
                        break;
                    case (int)Elements.Ram:
                        bindingSource.DataSource = ramRep.GetStringList();
                        break;
                    default:
                        break;
                }
                //assigning binding source to combo box
                comboBox.DataSource = bindingSource;
                //increase the index by one
                ++index;
            }
        }

        ///// <summary>
        ///// Method for changing appearance of main data grid view
        ///// </summary>
        private void CustomizeDataGridViewComputers()
        {
            //changing headers text
            dataGridViewComputers.Columns["Price"].HeaderText = "Price [zł]";
            dataGridViewComputers.Columns["RamCapacity"].HeaderText = "Ram [Gb]";
            dataGridViewComputers.Columns["OSystem"].HeaderText = "System";
            dataGridViewComputers.Columns["Graphic"].HeaderText = "Graphics";

            //changing alignment of cells to center
            foreach (DataGridViewColumn item in dataGridViewComputers.Columns)
            {
                item.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                item.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        /// <summary>
        /// Method for changing appearance of parts data grid view
        /// </summary>
        private void CustomizeDataGridViewParts()
        {
            //changing columns width
            dataGridViewParts.Columns["Computers"].Visible = false;
            dataGridViewParts.Columns["Id"].Width = 25;
            //changing alignment of cells to center
            foreach (DataGridViewColumn item in dataGridViewParts.Columns)
            {
                item.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                item.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        /// <summary>
        /// Method for refreshing main data grd
        /// </summary>
        private void RefreshDataGridViewComputers()
        {
            dataGridViewComputers.DataSource = computersRep.GetComputersSimpleViewModel();
            CustomizeDataGridViewComputers();
        }

        /// <summary>
        /// Method called when you press the button for adding a new computer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            bool deleteTexts = false;

            //evocation of method that extract values from combo boxes
            if (!GetChosenElements(out string name, out string graphics, out string processor, out string ram, out string box, out string powerUnit, out string system, out bool rgb, out float price))
                return;

            //checking if provided data is correct
            if (price > 0 && name.Length >= 2)
            {
                //Function for adding new computer to sql database
                computersRep.AddComputer(name, graphics, processor, ram, box, powerUnit, system, price, rgb);
                //chaning delete text variable as true
                deleteTexts = true;
            }
            else if(price == 0)//if provided data is not correct, showing info about error
                MessageBox.Show(text: "Price must be higher than 0.");
            else if(name.Length < 2)
                MessageBox.Show(text: "Length must be longer than 2 signs.");

            //Calling refresh method
            RefreshDataGridViewComputers();
            //Calling changing appearance method
            CustomizeDataGridViewComputers();

            //clearing text boxes
            if (deleteTexts)
            {
                textBoxPrice.Text = "0";
                textBoxName.Clear();
            }
        }

        ///// <summary>
        /////  Method called when you press the button for editing a computer
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            //evocation of method that extract values from combo boxes
            if (!GetChosenElements(out string name, out string graphics, out string processor, out string ram, out string box, out string powerUnit, out string system, out bool rgb, out float price, false))
                return;

            else if (price == 0)//if provided data is not correct, showing info about error
                MessageBox.Show(text: "Price must be higher than 0.");
            else if (name.Length < 2)
                MessageBox.Show(text: "Length must be longer than 2 signs.");

            //if chosen id is correct, calling method for editing computer
            if (CheckChosenId())
                computersRep.EditComputer(int.Parse(textBoxID.Text), name, graphics, processor, ram, box, powerUnit, system, price, rgb);
            else//if provided id is not correct, showiing message about it
                MessageBox.Show(text: "There is no computer with chosen ID in database.");

            //Calling refresh method
            RefreshDataGridViewComputers();
            //Calling changing appearance method
            CustomizeDataGridViewComputers();

            //clearing text box
            textBoxID.Clear();
        }

        ///// <summary>
        /////  Method called when you press the button for deleting a computer
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //Calling method for checking if provided id is correct
            if (CheckChosenId())
                //Calling method for deleting chosen computer
                computersRep.DeleteComputer(int.Parse(textBoxID.Text));
            else//if id is not correct, showing message about it
                MessageBox.Show(text: "There is no computer with chosen ID in database.");

            //Calling refreshing method
            RefreshDataGridViewComputers();
            //Calling changing appearance method
            CustomizeDataGridViewComputers();

            //clearing id text box
            textBoxID.Clear();
        }

        /// <summary>
        /// Method for extracting values from combo boxes
        /// </summary>
        /// <param name="deleteTexts"></param>
        /// <param name="name"></param>
        /// <param name="graphics"></param>
        /// <param name="processor"></param>
        /// <param name="ram"></param>
        /// <param name="box"></param>
        /// <param name="powerUnit"></param>
        /// <param name="system"></param>
        /// <param name="rgb"></param>
        /// <param name="price"></param>
        private bool GetChosenElements(out string name, out string graphics, out string processor, out string ram, out string box, out string powerUnit, out string system, out bool rgb, out float price, bool addMode = true)
        {
            bool isOK = true;

            //creating variables
            name = textBoxName.Text;
            graphics = comboBoxGraphics.Text;
            processor = comboBoxProcessor.Text;
            ram = comboBoxRam.Text;
            box = comboBoxBox.Text;
            powerUnit = comboBoxPowerUnit.Text;
            system = comboBoxSystem.Text;
            rgb = checkBoxRGB.Checked;
            price = 0;

            //calling method for checking if price value is correct (only numbers + greater than 0)
            if (IsDigitsOnly(textBoxPrice.Text))
                //if it is correct, parsing it to variable
                price = float.Parse(textBoxPrice.Text);
            else
            {//showing message if error occured
                MessageBox.Show(text: "Only digits are allowed");
                isOK = false;
            }
            //if name of compuet is empty, showing message about it
            if (name.Length == 0)
            {
                MessageBox.Show(text: "Add name (a least 2 characters)");
                isOK = false;
            }
            //checking if computer with this name already exist
            else if (computersRep.CheckNameExist(name))
            {
                if (addMode)
                {
                    //showing message if computer with given name already exist
                    MessageBox.Show(text: "This computer (name) already exist! Choose different name");
                    isOK = false;
                }
            }
            return isOK;
        }

        /// <summary>
        /// method for checking if string contains only numbers (price)
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }
            return true;
        }

        /// <summary>
        /// Method for checking chosen id
        /// </summary>
        /// <returns></returns>
        private bool CheckChosenId()
        {
            //checking if text box is not empty and if contains only numbers
            if (textBoxID.Text.Length < 1 || !IsDigitsOnly(textBoxID.Text))
            {
                //if data is not correct, showing message about it
                MessageBox.Show(text: "Enter valid ID value");
                return false;
            }
            else
            {
                //creating list of ints for checking if provided id is actually in database
                List<int> ids = new List<int>();
                foreach (DataGridViewRow row in dataGridViewComputers.Rows)
                {
                    try
                    {
                        ids.Add((int)row.Cells[0].Value);
                    }
                    catch { }
                }
                //new variable for checning if chosen id exist
                bool exist = false;
                //parsing chosen id
                int chosenId = int.Parse(textBoxID.Text);
                //comparison of chosen id with computers ids
                for (var i = 0; i < ids.Count; ++i)
                    if (chosenId == ids[i])
                        exist = true;

                //if chosen id doesnt exist, returning false
                return exist;
            }
        }


        ///// <summary>
        /////  Method called when you press the graphics combo box
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        private void comboBoxGraphics_Click(object sender, EventArgs e)
        {
            //calling method for getting all items from of box type form database
            dataGridViewParts.DataSource = graphicRep.GetLists();
            //changing image
            pictureBoxElements.Image = pictureBoxGPU.Image;
            //change style of cells in data grid view of parts
            CustomizeDataGridViewParts();
            //changing label text
            labelAction.Text = "Graphic cards";
        }

        ///// <summary>
        ///// Method called when selected index of graphics combo box has changed
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        private void comboBoxGraphics_SelectedIndexChanged(object sender, EventArgs e)
        {
            //getting price of chosen element
            prices[(int)Elements.Graphics] = graphicRep.GetPriceByName(comboBoxGraphics.SelectedItem.ToString());
            //calling method to refresh price amount
            ComputePrice();
        }

        ///// <summary>
        /////  Method called when you press the processor combo box
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        private void comboBoxProcessor_Click(object sender, EventArgs e)
        {
            dataGridViewParts.DataSource = processorRep.GetLists();
            pictureBoxElements.Image = pictureBoxCPU.Image;
            CustomizeDataGridViewParts();
            labelAction.Text = "Processors";
        }

        ///// <summary>
        ///// Method called when selected index of processor combo box has changed
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        private void comboBoxProcessor_SelectedIndexChanged(object sender, EventArgs e)
        {
            prices[(int)Elements.Processor] = processorRep.GetPriceByName(comboBoxProcessor.SelectedItem.ToString());
            //calling method to refresh price amount
            ComputePrice();
        }

        ///// <summary>
        /////  Method called when you press the ram combo box
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        private void comboBoxRam_Click(object sender, EventArgs e)
        {
            dataGridViewParts.DataSource = ramRep.GetLists();
            pictureBoxElements.Image = pictureBoxRam.Image;
            CustomizeDataGridViewParts();
            labelAction.Text = "Ram memory";
        }

        ///// <summary>
        ///// Method called when selected index of ram combo box has changed
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        private void comboBoxRam_SelectedIndexChanged(object sender, EventArgs e)
        {
            prices[(int)Elements.Ram] = ramRep.GetPriceByName(comboBoxRam.SelectedItem.ToString());
            //calling method to refresh price amount
            ComputePrice();
        }

        ///// <summary>
        /////  Method called when you press the box combo box
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        private void comboBoxBox_Click(object sender, EventArgs e)
        {
            dataGridViewParts.DataSource = boxRep.GetLists();
            pictureBoxElements.Image = pictureBoxBox.Image;
            CustomizeDataGridViewParts();
            labelAction.Text = "Computer boxes";
        }

        ///// <summary>
        ///// Method called when selected index of graphics combo box has changed
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        private void comboBoxBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            prices[(int)Elements.Box] = boxRep.GetPriceByName(comboBoxBox.SelectedItem.ToString());
            //calling method to refresh price amount
            ComputePrice();
        }

        ///// <summary>
        /////  Method called when you press the system combo box
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        private void comboBoxSystem_Click(object sender, EventArgs e)
        {
            dataGridViewParts.DataSource = oSystemRep.GetLists();
            pictureBoxElements.Image = pictureBoxSystem.Image;
            CustomizeDataGridViewParts();
            labelAction.Text = "Operating systems";
        }

        ///// <summary>
        ///// Method called when selected index of system combo box has changed
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        private void comboBoxSystem_SelectedIndexChanged(object sender, EventArgs e)
        {
            prices[(int)Elements.System] = oSystemRep.GetPriceByName(comboBoxSystem.SelectedItem.ToString());
            //calling method to refresh price amount
            ComputePrice();
        }

        ///// <summary>
        /////  Method called when you press the power unit combo box
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        private void comboBoxPowerUnit_Click(object sender, EventArgs e)
        {
            dataGridViewParts.DataSource = powerUnitRep.GetLists();
            pictureBoxElements.Image = pictureBoxPowerUnit.Image;
            CustomizeDataGridViewParts();
            labelAction.Text = "Power units";
        }

        ///// <summary>
        ///// Method called when selected index of power unit combo box has changed
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        private void comboBoxPowerUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            prices[(int)Elements.PowerUnit] = powerUnitRep.GetPriceByName(comboBoxPowerUnit.SelectedItem.ToString());
            //calling method to refresh price amount
            ComputePrice();
        }

        /// <summary>
        /// Method called when selected computer changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewComputers_SelectionChanged(object sender, EventArgs e)
        {
            //changing label text
            labelAction.Text = "Selected computer";

            //getting selected computer into new Computer variable
            ComputerSimpleViewModel computer = (ComputerSimpleViewModel)dataGridViewComputers.CurrentRow.DataBoundItem;

            //checking if chosen computer exist
            if (!computersRep.CheckComputerExist(computer.Id) || computer == null)
                return;

            //calling method for update combo boxes with chosen parts of computer
            UpdateComboBoxes(computersRep.GetComputerById(computer.Id));

            //assigning computer details to data grid view of parts
            dataGridViewParts.DataSource = computersRep.GetSingleComputerById(computer.Id);

            //changing image
            pictureBoxElements.Image = pictureBoxSingleComputer.Image;
        }

        /// <summary>
        /// Method for updating combo boxes
        /// </summary>
        /// <param name="computerModel"></param>
        private void UpdateComboBoxes(Computer computerModel)
        {
            //changing actual indexes of combo boxes
            comboBoxBox.SelectedIndex = comboBoxBox.Items.IndexOf(computerModel.Box.Name.ToString());
            comboBoxGraphics.SelectedIndex = comboBoxGraphics.Items.IndexOf(computerModel.Graphic.Name.ToString());
            comboBoxSystem.SelectedIndex = comboBoxSystem.Items.IndexOf(computerModel.OSystem.Name.ToString());
            comboBoxPowerUnit.SelectedIndex = comboBoxPowerUnit.Items.IndexOf(computerModel.PowerUnit.Name.ToString());
            comboBoxProcessor.SelectedIndex = comboBoxProcessor.Items.IndexOf(computerModel.Processor.Name.ToString());
            comboBoxRam.SelectedIndex = comboBoxRam.Items.IndexOf(computerModel.Ram.Name.ToString());
            textBoxID.Text = computerModel.Id.ToString();
            checkBoxRGB.Checked = computerModel.RGB;
            textBoxName.Text = computerModel.Name.ToString();
        }

        /// <summary>
        /// Method for computing actual price of chosen components
        /// </summary>
        private void ComputePrice()
        {
            //reseting price value
            actualPrice = 0;
            //adding each component price to whole amount
            foreach (var elementPrice in prices)
                actualPrice += elementPrice;
            //assigning computed value to text box
            textBoxPrice.Text = actualPrice.ToString();
        }
    }
}
