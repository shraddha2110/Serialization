﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsAppDemo
{
    [Serializable] //this is attribute--->this inform to
    public class Department
    {
        public int Id { get; set; }
        public  string Name { get; set; }
        public string Location { get; set; }

    }
}
