using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.DTO
{
    public class RequestModel
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public override string ToString()
        {
            return $"First Name: {firstName}, Last Name: {lastName}";
        }
    }
}
