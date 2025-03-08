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

        public string GetGreetingById(int id)
        {
            var result = _dbContext.Greetings.FirstOrDefault<GreetingEntity>(e => e.Id == id);
            if (result != null)
            {
                return result.GreetingMessage;
            }
            return null;
        }

        public List<GreetingEntity> GetAllGreetings()
        {
            return _dbContext.Greetings.ToList();
        }


        public GreetingEntity UpdateGreeting(int Id ,string message)
        {
            var result = _dbContext.Greetings.FirstOrDefault<GreetingEntity>(e => e.Id == Id);
            if (result != null)
            {
                result.GreetingMessage = message;
                _dbContext.SaveChanges();
                return result;
            }
            return null;
        }
        public bool DeleteById(int id)
        {
            var result = _dbContext.Greetings.FirstOrDefault<GreetingEntity>(e => e.Id == id);
            if (result != null)
            {
                _dbContext.Greetings.Remove(result);
                _dbContext.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
