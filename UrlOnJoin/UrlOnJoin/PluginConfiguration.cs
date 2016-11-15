using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rocket.API;
using System.Xml.Serialization;
using UnityEngine;
using Steamworks;

namespace UrlOnJoin
{
    public class PluginConfiguration : IRocketPluginConfiguration
    {
        public bool enabled = true;
        public string description;
        public string url;
        public void LoadDefaults()
        {
            enabled = true;
            description = "Welcome to my server! Please check out our website!";
            url = "http://rawrfuls.com";
        }
    }
}
