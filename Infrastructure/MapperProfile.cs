using AutoMapper;
using ComputerComposerNsp.Models.Entities;
using ComputerComposerNsp.ViewModels;

namespace ComputerComposerNsp.Infrastructure
{
    /// <summary>
    /// Mapper class
    /// </summary>
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Computer, ComputerSimpleViewModel>()
                .ForMember(c=> c.Graphic, opt => opt.MapFrom(src => src.Graphic.Name))
                .ForMember(c => c.Processor, opt => opt.MapFrom(src => src.Processor.Name))
                .ForMember(c => c.OSystem, opt => opt.MapFrom(src => src.OSystem.Name));

            CreateMap<Computer, ComputerViewModel>()
                .ForMember(c => c.Box, opt => opt.MapFrom(src => src.Box.Name))
                .ForMember(c => c.BoxColor, opt => opt.MapFrom(src => src.Box.Color))
                .ForMember(c => c.BoxPrice, opt => opt.MapFrom(src => src.Box.Price))

                .ForMember(c => c.Graphic, opt => opt.MapFrom(src => src.Graphic.Name))
                .ForMember(c => c.GraphicSpeed, opt => opt.MapFrom(src => src.Graphic.Speed))
                .ForMember(c => c.GraphicVRam, opt => opt.MapFrom(src => src.Graphic.VRam))
                .ForMember(c => c.GraphicPrice, opt => opt.MapFrom(src => src.Graphic.Price))

                .ForMember(c => c.OSystem, opt => opt.MapFrom(src => src.OSystem.Name))
                .ForMember(c => c.OSystemPrice, opt => opt.MapFrom(src => src.OSystem.Price))

                .ForMember(c => c.PowerUnit, opt => opt.MapFrom(src => src.PowerUnit.Name))
                .ForMember(c => c.Power, opt => opt.MapFrom(src => src.PowerUnit.Power))
                .ForMember(c => c.PowerUnitPrice, opt => opt.MapFrom(src => src.PowerUnit.Price))

                .ForMember(c => c.Processor, opt => opt.MapFrom(src => src.Processor.Name))
                .ForMember(c => c.ProcessorCores, opt => opt.MapFrom(src => src.Processor.Cores))
                .ForMember(c => c.ProcessorThreads, opt => opt.MapFrom(src => src.Processor.Threads))
                .ForMember(c => c.ProcessorSpeed, opt => opt.MapFrom(src => src.Processor.Speed))
                .ForMember(c => c.ProcessorPrice, opt => opt.MapFrom(src => src.Processor.Price))

                .ForMember(c => c.Ram, opt => opt.MapFrom(src => src.Ram.Name))
                .ForMember(c => c.RamCapacity, opt => opt.MapFrom(src => src.Ram.Capacity))
                .ForMember(c => c.RamSpeed, opt => opt.MapFrom(src => src.Ram.Speed))
                .ForMember(c => c.RamPrice, opt => opt.MapFrom(src => src.Ram.Price));
        }
    }
}
