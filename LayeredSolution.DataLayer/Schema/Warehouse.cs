﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayeredSolution.DataLayer.Schema
{
    public class Warehouse
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Location { get; set; }
    }
}
