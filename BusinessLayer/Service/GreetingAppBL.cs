using BusinessLayer.Interface;
using ModelLayer.DTO;
using RepositaryLayer.Entity;
using RepositaryLayer.Interface;

namespace BusinessLayer.Service
{
    public class GreetingAppBL : IGreetingAppBL
    {
        public IGreetingAppRL _greetingRL;
        public GreetingAppBL(IGreetingAppRL greetingRL)
        {
            _greetingRL = greetingRL;
        }
        public string Greeting()
        {
            return "Hello World!";
        }
        public string GetGreeting(string firstName,string lastName)
        {
            //string firstName = user.firstName;
            //string lastName = user.lastName;
            // Both first and last name provided
            if (!string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(lastName))
            {
                return $"Hello {firstName} {lastName}";
            }
            // Only first name provided
            else if (!string.IsNullOrEmpty(firstName))
            {
                return $"Hello {firstName}";
            }
            // Only last name provided
            else if (!string.IsNullOrEmpty(lastName))
            {
                return $"Hello {lastName}";
            }
            // No names provided
            else
            {
                return "Hello World";
            }
        }


        public GreetingEntity AddGreeting(SavingGreetingModel greetRequest)
        {
            var result = _greetingRL.AddGreeting(greetRequest);
            return result;
        }

        public string GetGreetingById(int id)
        {
            var result = _greetingRL.GetGreetingById(id);
            return result;
        }

        public List<GreetingEntity> GetAllGreetings()
        {
            var result = _greetingRL.GetAllGreetings();
            return result;
        }


        public GreetingEntity UpdateGreeting(int id, string message)
        {
            var result = _greetingRL.UpdateGreeting(id, message);
            return result;
        }
        public bool DeleteById(int id)
        {
            var result = _greetingRL.DeleteById(id);
            return result;
        }

    }
}
