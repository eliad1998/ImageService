﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using ImageService.Infrastructure.Interfaces;
using Newtonsoft.Json.Linq;

namespace ImageService.Infrastructure.Classes
{
    public class Configure:Jsonable
    {
        //The folders we want to handle.
        public List<string> Handlers { get; set; }
        //The Output directory.
        public string OutPutDir { get; set; }
        //The source name in the event log
        public string SourceName { get; set; }
        //The log name
        public string LogName { get; set; }
        //The thumbnail picture size
        public int ThumbnailSize { get; set; }
        /// <summary>
        /// the Configure constructor, setting the values according to the app.config.
        /// </summary>
        /// <param name="path">The path of the app config</param>
        public Configure(string path)
        {
            //Making the list of handlers folders by splitting it by ; character.
            this.Handlers = new List<string>(ConfigurationManager.AppSettings["Handler"].Split(new char[] { ';' }));
            this.OutPutDir = ConfigurationManager.AppSettings.Get("OutPutDir");
            this.SourceName = ConfigurationManager.AppSettings["SourceName"];
            this.LogName = ConfigurationManager.AppSettings["LogName"];
            this.ThumbnailSize = int.Parse(ConfigurationManager.AppSettings["ThumbnailSize"]);
        }

        public Configure()
        {

        }


        public string ToJSON()
        {
            JObject configObj = new JObject();
            //Converting the list to json
            configObj["Handlers"] = JToken.FromObject(Handlers);
            configObj["OutputDir"] = OutPutDir;
            configObj["SourceName"] = SourceName;
            configObj["LogName"] = LogName;
            configObj["ThumbnailSize"] = ThumbnailSize;

            return configObj.ToString();

        }

        public void FromJson(string str)
        {
            JObject configObj = JObject.Parse(str);
            Handlers = (configObj["Handlers"]).ToObject<List<string>>();
            LogName = (string)configObj["LogName"];

            SourceName = (string)configObj["SourceName"];
            OutPutDir = (string)configObj["OutputDir"];
            ThumbnailSize = (int)configObj["ThumbnailSize"];

        }


    }
}