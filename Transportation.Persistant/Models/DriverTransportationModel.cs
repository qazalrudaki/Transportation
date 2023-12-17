using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation.Persistant.Models
{
    public class DriverTransportationModel
    {
        public int Id { get; set; }
        public string DriverTransactionTypeText { get; set; }
    }

    public class CreateDriverTransportation
    {
        public string DriverTransactionTypeText { get; set; }
    }

    public class UpdateDriverTransportation
    {
        public int Id { get; set; }
        public string DriverTransactionTypeText { get; set; }
    }
}
