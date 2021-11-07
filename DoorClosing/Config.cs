using System.Collections.Generic;
using System.ComponentModel;
using Exiled.API.Interfaces;

namespace DoorClosing
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;

        [Description("Work doors to closing")]
        public List<string> Doortoclose { get; set; } = new List<string>()
        {
            "GATE_A",
            "096"
        };
        
    }
}