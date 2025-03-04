using BusinessLayer.Interface;
using ModelLayer.DTO;

namespace BusinessLayer.Service
{
    public class GreetingAppBL : IGreetingAppBL
    {
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

    }
}
