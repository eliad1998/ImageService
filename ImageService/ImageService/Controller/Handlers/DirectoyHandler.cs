﻿using ImageService.Modal;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageService.Infrastructure;
using ImageService.Infrastructure.Enums;
using ImageService.Logging;
using ImageService.Logging.Modal;
using System.Text.RegularExpressions;

namespace ImageService.Controller.Handlers
{
    public class DirectoyHandler : IDirectoryHandler
    {
        #region Members
        private IImageController m_controller;              // The Image Processing Controller
        private ILoggingService m_logging;
        private FileSystemWatcher[] m_dirWatcher;             // The Watcher of the Dir
    //    private string m_path;                              // The Path of directory
        #endregion
        // The Event That Notifies that the Directory is being closed
        public event EventHandler<DirectoryCloseEventArgs> DirectoryClose;    
        
        public DirectoyHandler(IImageController controller, ILoggingService logger)//, string path)
        {
            this.m_controller = controller;
            this.m_logging = logger;
            //Creating array for watchers.
            // Each watcher is for different file type .jpg,.png,.gif,.bmp
            this.m_dirWatcher = new FileSystemWatcher[4];

           // this.m_path = path;

        }

        public void StartHandleDirectory(string dirPath)
        {
         //   this.m_path = dirPath;
            ///Creating the watchers for each file type;
            string[] fileTypes = { "*.jpg", "*.png", "*.gif", "*.bmp" };
            for (int i = 0; i < fileTypes.Length; i++)
            {
                //Initializing the file system watcher with our dirPath
                m_dirWatcher[i] = new FileSystemWatcher(dirPath);
                m_dirWatcher[i].Filter = fileTypes[i];
                
                //Adding function to occur to our event.
                //This what happan when we add new file
                m_dirWatcher[i].Created += DirectoyHandler_Created;
                //If there is a problem add
                m_dirWatcher[i].EnableRaisingEvents = true;
         //       m_dirWatcher[i].Deleted += 
            }
        }

        private void DirectoyHandler_Created(object sender, FileSystemEventArgs e)
        {
            //The argument willl be the path of the picture.
            string[] args = { e.FullPath };
            //When someone adds file to our folder we will apply the add file command - i have oncommand recieved so ill use it
            CommandRecievedEventArgs commandEventArgs = new CommandRecievedEventArgs((int)CommandEnum.NewFileCommand, args, args[0]);

            //We don't want to write code twice so we will use this function.
            OnCommandRecieved(this, commandEventArgs);
           // m_controller.ExecuteCommand((int)CommandEnum.NewFileCommand, args , out result);
            //When someone adds file we will write it into the logs file
        }

     

        public void OnCommandRecieved(object sender, CommandRecievedEventArgs e)
        {
            bool resultSuccesful;
            //First we will excecute the command
            string msg = m_controller.ExecuteCommand(e.CommandID, e.Args, out resultSuccesful);   
            //Than we will write into the logger - we will use our boolean in order to know if succeeded or not
            if (resultSuccesful)
            {
                m_logging.Log(msg, MessageTypeEnum.INFO);
            }
            //Did not succeed
            else
            {
                m_logging.Log(msg, MessageTypeEnum.FAIL);

            }
        }

        public void onCloseServer(object sender, CommandRecievedEventArgs e)
        {
            for (int i = 0; i < this.m_dirWatcher.Length; i++)
            {
                //When closing we want the dir watcher will stop to watch our directory.
                // So we will remove the function from the delegate for each watcher.
                m_dirWatcher[i].Changed -= DirectoyHandler_Created;
            }

            //Invoking to the image server
            DirectoryCloseEventArgs dclose = new DirectoryCloseEventArgs(e.RequestDirPath, "Directory close");

            
            DirectoryClose?.Invoke(this, dclose);




        }

        // Implement Here!
    }
}
