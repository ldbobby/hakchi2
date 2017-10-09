﻿#pragma warning disable 0108
using com.clusterrr.hakchi_gui.Properties;
using System.Drawing;

namespace com.clusterrr.hakchi_gui
{
    public class GbGame : NesMiniApplication
    {
        public override string GoogleSuffix
        {
            get
            {
                return "(gameboy | game boy)";
            }
        }

        public GbGame(string path, bool ignoreEmptyConfig = false)
            : base(path, ignoreEmptyConfig)
        {
        }
    }
}

