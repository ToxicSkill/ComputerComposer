using AutoMapper;
using ComputerComposerNsp.Infrastructure;
using ComputerComposerNsp.Models;

namespace ComputerComposerNsp.Repositories
{
    /// <summary>
    /// An abstract class having the variables and / or methods that each repository should contain
    /// </summary>
    public abstract class Repository
    {
        /// <summary>
        /// Variable for holding connection
        /// </summary>
        protected readonly DataBaseContext DbContext = new DataBaseContext();

        private static MapperConfiguration MapperConfig = new MapperConfiguration(cfg => cfg.AddProfile(new MapperProfile()));

        protected readonly IMapper Mapper = MapperConfig.CreateMapper();
    }
}
