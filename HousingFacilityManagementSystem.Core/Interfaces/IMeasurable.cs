﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Interfaces
{
    public interface IMeasurable
    {
        public int IndexMeter { get; set; }
        public int CurrentMonthIndex { get; set; }
    }
}
