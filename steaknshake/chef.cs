﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace steaknshake
{
    public class Chef : ICook
    {
        bool cookedMeat;
        public void addHeat()
        {
            cookedMeat = true;
        }
    }
}
