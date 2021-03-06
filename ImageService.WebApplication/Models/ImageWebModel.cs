﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ImageService.Communication.Model;
using System.ComponentModel.DataAnnotations;

namespace ImageService.WebApplication.Models
{
    public class ImageWebModel:TCPModel
    {
        public IEnumerable<Student> Students { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Service status")]
        public string Status { get;  private set; }
        [Required]
        [Display(Name = "Number of photos")]
        public int NumPhotos { get; set; }
        //A student that we can't set but we use it only for the display names
        public Student StudentInfo { get; private set; }

        public ImageWebModel():base()
        {
            //Check if the tcp client is connected
            if (communicate.IsConnected())
            {
                Status = "Started";
            }

            else
            {
                Status = "Stopped";
            }
        }

    }
}