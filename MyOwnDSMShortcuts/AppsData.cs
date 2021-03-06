﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BeatificaBytes.Synology.Mods
{
    public class Package
    {
        public Package()
        {
            items = new Dictionary<string, AppsData>();
        }

        [JsonProperty(PropertyName = ".url")]
        public Dictionary<string, AppsData> items { get; set; }
    }

    public class AppsData
    {
        public AppsData()
        {
            type = "url";
            icon = "images/default_{0}.png";
            guid = Guid.NewGuid();
            itemType = -1;
        }

        internal Guid guid { get; set; }
        public string type { get; set; }
        public bool allUsers { get; set; }
        public string title { get; set; }
        public string desc { get; set; }
        public string icon { get; set; }
        public string protocol { get; set; }
        public string url { get; set; }
        public int port { get; set; }
        public int itemType { get; set; }
        public bool allowMultiInstance { get; set; }
    }
}
