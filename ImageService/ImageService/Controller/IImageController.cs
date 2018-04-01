﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageService.Controller
{
    /// <summary>
    /// An image controller that in charge of excecuting commands.
    /// </summary>
    public interface IImageController
    {
        /// <summary>
        /// Executing the command according the ID with the help of the Command Dictionary.
        /// </summary>
        /// <param name="commandID">The id of the command</param>
        /// <param name="args">Arguments to the command</param>
        /// <param name="resultSuccesful">Set to true if the we succesed and false otherwise</param>
        /// <returns>The command result</returns>
        string ExecuteCommand(int commandID, string[] args, out bool result);          // Executing the Command Request
    }
}
