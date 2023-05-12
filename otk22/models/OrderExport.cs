using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otk22.models
{
    internal class OrderExport
    {
        public Order order { get; set; }
        public User user { get; set; }
        public Service service { get; set; }
        public User admin { get; set; }
    }
}
