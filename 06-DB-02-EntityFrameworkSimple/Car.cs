using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_EF_Simple
{
    public class Car
    {
        public int Id { get; set; }
        public string RegPlate { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public DateTime Purchased { get; set; }
    }
}
