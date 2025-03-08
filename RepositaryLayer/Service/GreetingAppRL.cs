using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer.DTO;
using RepositaryLayer.Context;
using RepositaryLayer.Entity;
using RepositaryLayer.Interface;
using static ModelLayer.DTO.SavingGreetingModel;

namespace RepositaryLayer.Service
{
    public class GreetingAppRL : IGreetingAppRL
    {
        public readonly GreetingDbContext _dbContext;
        public GreetingAppRL(GreetingDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public GreetingEntity AddGreeting(SavingGreetingModel greetRequest)
        {
            var result = _dbContext.Greetings.FirstOrDefault<GreetingEntity>(e => e.GreetingMessage == greetRequest.GreetingMessage);
            if (result == null)
            {
                var greet = new GreetingEntity
                {
                    GreetingMessage = greetRequest.GreetingMessage
                };


                _dbContext.Add(greet);
                _dbContext.SaveChanges();
                return greet;
            }
            return result;
        }
    }
}
