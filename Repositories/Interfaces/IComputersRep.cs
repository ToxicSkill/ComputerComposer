using System.Collections.Generic;
using ComputerComposerNsp.Models.Entities;
using ComputerComposerNsp.ViewModels;

namespace ComputerComposerNsp.Repositories.Interfaces
{
    /// <summary>
    /// Interface for defining methods which are connected to Computer table repository
    /// </summary>
    public interface IComputersRep
    {
        /// <summary>
        /// Abstarct method for getting all computers from Computer table
        /// </summary>
        /// <returns></returns>
        List<ComputerViewModel> GetComputers();

        /// <summary>
        /// Abstarct method for getting simplified computers from Computer table
        /// </summary>
        /// <returns></returns>
        List<ComputerSimpleViewModel> GetComputersSimpleViewModel();

        /// <summary>
        /// Abstract method searching computer by Id
        /// </summary>
        /// <param name="computerID"></param>
        Computer GetComputerById(int Id);

        /// <summary>
        /// Abstarct method for adding new computer to the table
        /// </summary>
        /// <param name="name"></param>
        /// <param name="graphics"></param>
        /// <param name="processor"></param>
        /// <param name="ram"></param>
        /// <param name="box"></param>
        /// <param name="powerUnit"></param>
        /// <param name="system"></param>
        /// <param name="price"></param>
        /// <param name="rgb"></param>
        bool AddComputer(string sName, string sGraphics, string sProcessor, string sRam, string sBox, string sPowerUnit, string sSystem, float fPrice, bool bRgb);

        /// <summary>
        /// Abstract method for deleting chosen computer from table - based on computer id
        /// </summary>
        /// <param name="computerID"></param>
        bool DeleteComputer(int computerID);

        /// <summary>
        /// Abstarct method for editing computer from the table - based on editing computer id
        /// </summary>
        /// <param name="computerID"></param>
        /// <param name="name"></param>
        /// <param name="graphics"></param>
        /// <param name="processor"></param>
        /// <param name="ram"></param>
        /// <param name="box"></param>
        /// <param name="powerUnit"></param>
        /// <param name="system"></param>
        /// <param name="price"></param>
        /// <param name="rgb"></param>
        bool EditComputer(int computerID, string sName, string sGraphics, string sProcessor, string sRam, string sBox, string sPowerUnit, string sSystem, float fPrice, bool bRgb);
    }
}
