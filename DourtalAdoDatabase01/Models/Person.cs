﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  Models
{
    public class Person : object
    {
        public Person() //Constructor
        {

        }

#region Properties 
        public int Id { get; set; }
        public int Age { get; set; }
        public string FullName { get; set; }
        public bool IsSupervisor { get; set; }

        #endregion /Porperties

    }
}
