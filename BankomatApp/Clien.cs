﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankomatApp
{
    public class Client
    {
        public string Name { get; private set; }

        public Client(string name)
        {
            Name = name;
        }
    }
}