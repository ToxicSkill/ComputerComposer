namespace ComputerComposerNsp.ViewModels
{
    /// <summary>
    ///  Class for computer model
    /// </summary>
    public class ComputerViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public float Price { get; set; }

        public bool RGB { get; set; }

        public string Box { get; set; }
        public string BoxColor { get; set; }
        public float BoxPrice { get; set; }

        public string Graphic { get; set; }
        public int GraphicSpeed { get; set; }
        public int GraphicVRam { get; set; }
        public float GraphicPrice { get; set; }

        public string OSystem { get; set; }
        public float OSystemPrice { get; set; }

        public string PowerUnit { get; set; }
        public int Power { get; set; }
        public float PowerUnitPrice { get; set; }

        public string Processor { get; set; }
        public int ProcessorCores { get; set; }
        public int ProcessorThreads { get; set; }
        public float ProcessorSpeed { get; set; }
        public float ProcessorPrice { get; set; }

        public string Ram { get; set; }
        public int RamSpeed { get; set; }
        public int RamCapacity { get; set; }
        public float RamPrice { get; set; }
    }
}
