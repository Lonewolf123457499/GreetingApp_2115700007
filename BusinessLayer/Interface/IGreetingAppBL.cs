using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer.DTO;
using RepositaryLayer.Entity;
using static ModelLayer.DTO.SavingGreetingModel;

namespace BusinessLayer.Interface
{
    public interface IGreetingAppBL
    {
        public string Greeting();
        public string GetGreeting(string firstname, string  lastname);
        GreetingEntity AddGreeting(SavingGreetingModel greetRequest);
    }
}
