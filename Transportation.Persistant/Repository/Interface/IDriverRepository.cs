using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transportation.Persistant.Models;

namespace Transportation.Persistant.Interface
{
    public interface IDriverRepository
    {
        bool CreateDriver(CreateDriverModel createDriverModel);
        bool UpdateDriver(UpdateDriverModel updateDriverModel);
        bool DeleteDriver(int id);
        List<DriverModel> GetAllDrivers();
    }
}
