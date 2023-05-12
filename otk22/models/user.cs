using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otk22.models
{
    public class User
    {
        public String? login { get; set; }
        public String? name { get; set; }
        public Int32 customerId { get; set; }
        public String? roleCode { get; set; }
        public String? password;
    }
}
