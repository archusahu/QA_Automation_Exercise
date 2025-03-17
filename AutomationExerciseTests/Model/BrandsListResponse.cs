using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationExerciseTests.Model
{
    public class Brands
    {
        public string id { get; set; }
        public string brand { get; set; }
    }

    public class BrandsListResponse
    {
        public string ResponseCode { get; set; }
        public List<Brands> brands { get; set; }
    }
}