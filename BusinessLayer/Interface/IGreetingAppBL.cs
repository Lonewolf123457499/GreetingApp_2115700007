﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer.DTO;

namespace BusinessLayer.Interface
{
    public interface IGreetingAppBL
    {
        public string Greeting();
        public string GetGreeting(string firstname, string  lastname);
    }
}
