using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkLearn.Models
{
    public class Car
    {
        public int CarId { get; set; }
        public int UserId { get; set; }
        public string CarName { get; set; }
    }
}
