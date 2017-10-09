﻿#pragma warning disable 0108
using com.clusterrr.hakchi_gui.Properties;
using System.Drawing;

namespace com.clusterrr.hakchi_gui
{
    public class N64Game : NesMiniApplication
    {
        public override string GoogleSuffix
        {
            get
            {
                return "nintendo 64";
            }
        }

        public N64Game(string path, bool ignoreEmptyConfig = false)
            : base(path, ignoreEmptyConfig)
        {
        }
    }
}

