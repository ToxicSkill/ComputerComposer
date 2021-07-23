using System;
using System.Collections.Generic;
using System.Linq;
using ComputerComposerNsp.Models.Entities;
using ComputerComposerNsp.Repositories.Interfaces;
using ComputerComposerNsp.ViewModels;

namespace ComputerComposerNsp.Repositories
{
    /// <summary>
    /// Enum variable for unequivocal calling types of elements
    /// </summary>
    enum Elements
    {
        Box = 0,Graphics,System,PowerUnit,Processor,Ram
    }

    /// <summary>
    /// Class for defining methods which are connected to Computer table repository
    /// </summary>
    public class ComputersRep : Repository, IComputersRep
    {
        /// <summary>
        /// Method for gettiing list of computers form database
        /// </summary>
        /// <returns></returns>
        public List<ComputerViewModel> GetComputers()
        {
            List<Computer> computers = DbContext.Computers.ToList();
            return Mapper.Map<List<Computer>, List<ComputerViewModel>>(computers);
        }

        /// <summary>
        /// Method for getting list of simplified computers from database
        /// </summary>
        /// <returns></returns>
        public List<ComputerSimpleViewModel> GetComputersSimpleViewModel()
        {
            List<Computer> computers = DbContext.Computers.ToList();
            return Mapper.Map<List<Computer>, List<ComputerSimpleViewModel>>(computers);
        }

        /// <summary>
        /// Method for adding new computer to database
        /// </summary>
        /// <param name="sName"></param>
        /// <param name="sGraphics"></param>
        /// <param name="sProcessor"></param>
        /// <param name="sRam"></param>
        /// <param name="sBox"></param>
        /// <param name="sPowerUnit"></param>
        /// <param name="sSystem"></param>
        /// <param name="fPrice"></param>
        /// <param name="bRgb"></param>
        /// <returns></returns>
        public bool AddComputer(string sName, string sGraphics, string sProcessor, string sRam, string sBox, string sPowerUnit, string sSystem, float fPrice, bool bRgb)
        {
            Box box;
            Graphic graphic;
            OSystem system;
            PowerUnit powerUnit;
            Processor processor;
            Ram ram;

            //calling method for getting chosen elements from database 
            if (!GetChosenElements(sGraphics, sProcessor, sRam, sBox, sPowerUnit, sSystem, out box, out graphic, out system, out powerUnit, out processor, out ram))
                return false;

            //creating new computer 
            Computer computerToAdd = new Computer()
            {
                BoxId = box.Id,
                GraphicId = graphic.Id,
                OSystemId = system.Id,
                PowerUnitId = powerUnit.Id,
                ProcessorId = processor.Id,
                RamId = ram.Id,
                Name = sName,
                RGB = bRgb,
                Price = fPrice,
            };

            //adding new computer to database
            DbContext.Computers.Add(computerToAdd);

            //saving changes
            return DbContext.SaveChanges() > 0;
        }

        /// <summary>
        /// Method for deleting computer by given id
        /// </summary>
        /// <param name="computerID"></param>
        /// <returns></returns>
        public bool DeleteComputer(int computerID)
        {
            //searching computer by given id
            Computer computer = DbContext.Computers.SingleOrDefault(c => c.Id == computerID);
            //checking if computer exist
            if (computer == null)
                return false;
            //removing computer from database
            DbContext.Computers.Remove(computer);
            //saving changes
            return DbContext.SaveChanges() > 0;
        }

        /// <summary>
        /// Method for editing computer 
        /// </summary>
        /// <param name="computerID"></param>
        /// <param name="sName"></param>
        /// <param name="sGraphics"></param>
        /// <param name="sProcessor"></param>
        /// <param name="sRam"></param>
        /// <param name="sBox"></param>
        /// <param name="sPowerUnit"></param>
        /// <param name="sSystem"></param>
        /// <param name="fPrice"></param>
        /// <param name="bRgb"></param>
        /// <returns></returns>
        public bool EditComputer(int computerID, string sName, string sGraphics, string sProcessor, string sRam, string sBox, string sPowerUnit, string sSystem, float fPrice, bool bRgb)
        {
            //searchiing computer by given id
            Computer computer = DbContext.Computers.SingleOrDefault(c => c.Id == computerID);

            //checking if computer exist
            if (computer == null)
                return false;

            Box box;
            Graphic graphic;
            OSystem system;
            PowerUnit powerUnit;
            Processor processor;
            Ram ram;

            //calling method for getting chosen elements from database 
            if (!GetChosenElements(sGraphics, sProcessor, sRam, sBox, sPowerUnit, sSystem, out box, out graphic, out system, out powerUnit, out processor, out ram))
                return false;

            //assigning properties of edited computer
            computer.BoxId = box.Id;
            computer.GraphicId = graphic.Id;
            computer.OSystemId = system.Id;
            computer.PowerUnitId = powerUnit.Id;
            computer.ProcessorId = processor.Id;
            computer.RamId = ram.Id;
            computer.Name = sName;
            computer.RGB = bRgb;
            computer.Price = fPrice;

            //saving changes
            return DbContext.SaveChanges() > 0;
        }

        /// <summary>
        /// Method for getting elements names from database
        /// </summary>
        /// <param name="sGraphics"></param>
        /// <param name="sProcessor"></param>
        /// <param name="sRam"></param>
        /// <param name="sBox"></param>
        /// <param name="sPowerUnit"></param>
        /// <param name="sSystem"></param>
        /// <param name="box"></param>
        /// <param name="graphic"></param>
        /// <param name="system"></param>
        /// <param name="powerUnit"></param>
        /// <param name="processor"></param>
        /// <param name="ram"></param>
        /// <returns></returns>
        private bool GetChosenElements(string sGraphics, string sProcessor, string sRam, string sBox, string sPowerUnit, string sSystem, out Box box, out Graphic graphic, out OSystem system, out PowerUnit powerUnit, out Processor processor, out Ram ram)
        {
            box = DbContext.Boxes.SingleOrDefault(c => c.Name == sBox);
            graphic = DbContext.Graphics.SingleOrDefault(c => c.Name == sGraphics);
            system = DbContext.OSystems.SingleOrDefault(c => c.Name == sSystem);
            powerUnit = DbContext.PowerUnits.SingleOrDefault(c => c.Name == sPowerUnit);
            processor = DbContext.Processors.SingleOrDefault(c => c.Name == sProcessor);
            ram = DbContext.Rams.SingleOrDefault(c => c.Name == sRam);

            //checking if strings are correct
            if (box == null || graphic == null || system == null || powerUnit == null || processor == null || ram == null)
                return false;

            return true;
        }

        /// <summary>
        /// Method for getting computer by Id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public Computer GetComputerById(int Id)
        {
            //returning computer by given id
            return DbContext.Computers.Single(c => c.Id == Id);
        }

        /// <summary>
        /// Method for getting signel computer as a list by given id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<ComputerViewModel> GetSingleComputerById(int id)
        {
            //creating new list of computer
            List<Computer> singleComputer = new List<Computer>();
            //adding to the list single computer found by id
            singleComputer.Add(DbContext.Computers.Single(c => c.Id == id)); 
            //returning single computer
            return Mapper.Map<List<Computer>, List<ComputerViewModel>>(singleComputer);
        }

        /// <summary>
        /// Method for checking if computer by given Id exist
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool CheckComputerExist(int id)
        {
            try
            {
                Computer comp = DbContext.Computers.Single(c => c.Id == id);
            }
            catch(Exception)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Method for checking if computer by given name exist
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public bool CheckNameExist(string name)
        {
            try
            {
                Computer comp = DbContext.Computers.Single(c => c.Name == name);
            }
            catch(Exception)
            {
                return false;
            }
            return true;
        }
    }
}
