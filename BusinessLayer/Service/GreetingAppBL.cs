using BusinessLayer.Interface;

namespace BusinessLayer.Service
{
    public class GreetingAppBL : IGreetingAppBL
    {
        public string Greeting()
        {
            return "Hello World!";
        }
    }
}
