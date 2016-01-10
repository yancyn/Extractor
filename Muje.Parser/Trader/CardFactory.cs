﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExtractBusinessCard
{
    public abstract class CardFactory
    {
        public const string OUTPUT = "output.csv";
        public abstract void Extract(string uri);
        public abstract void Process();
    }
}