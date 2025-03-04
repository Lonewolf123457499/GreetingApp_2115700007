using BusinessLayer.Interface;
using Microsoft.AspNetCore.Mvc;
using ModelLayer.DTO;
using NLog;

namespace GreetingApp_2115700007
{
    [ApiController]
    [Route("[controller]")]
    public class GreetingAppController : ControllerBase
    {
        IGreetingAppBL _greetingAppBL;
        public GreetingAppController(IGreetingAppBL greetingAppBL)
        {
            _greetingAppBL = greetingAppBL;
        }
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
       

        /// <summary>
        /// Handles GET requests to fetch a greeting.
        /// </summary>
        /// <returns>Returns a success response with a message.</returns>
        [HttpGet]
        public IActionResult GreetingAppGet()
        {
            logger.Info("GET request received at GreetingAppGet.");
            var result =_greetingAppBL.Greeting();
            var res = new Response<string>
            {
                success = true,
                message = "GET method executed successfully",
                data = result
            };
            return Ok(res);
        }

        /// <summary>
        /// Handles POST requests to create a greeting.
        /// </summary>
        /// <returns>Returns a success response with a message.</returns>
        [HttpPost]
        public IActionResult GreetingAppPost()
        {
            logger.Info("POST request received at GreetingAppPost.");
            var res = new Response<string>
            {
                success = true,
                message = "POST method executed successfully",
                data = ""
            };
            return Ok(res);
        }

        /// <summary>
        /// Handles PUT requests to update a greeting.
        /// </summary>
        /// <returns>Returns a success response with a message.</returns>
        [HttpPut]
        public IActionResult GreetingAppPut()
        {
            logger.Info("PUT request received at GreetingAppPut.");
            var res = new Response<string>
            {
                success = true,
                message = "PUT method executed successfully",
                data = ""
            };
            return Ok(res);
        }

        /// <summary>
        /// Handles DELETE requests to remove a greeting.
        /// </summary>
        /// <returns>Returns a success response with a message.</returns>
        [HttpDelete]
        public IActionResult GreetingAppDelete()
        {
            logger.Info("DELETE request received at GreetingAppDelete.");
            var res = new Response<string>
            {
                success = true,
                message = "DELETE method executed successfully",
                data = ""
            };
            return Ok(res);
        }

        /// <summary>
        /// Handles PATCH requests to modify a greeting.
        /// </summary>
        /// <returns>Returns a success response with a message.</returns>
        [HttpPatch]
        public IActionResult GreetingAppPatch()
        {
            logger.Info("PATCH request received at GreetingAppPatch.");
            var res = new Response<string>
            {
                success = true,
                message = "PATCH method executed successfully",
                data = ""
            };
            return Ok(res);
        }
    }
}
