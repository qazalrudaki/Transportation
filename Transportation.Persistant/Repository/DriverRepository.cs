using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transportation.DataLayer.Models;
using Transportation.Persistant.Interface;
using Transportation.Persistant.Models;

namespace Transportation.Persistant.Repository
{
    public class DriverRepository : IDriverRepository
    {
        TransportationContext _context = new TransportationContext();
        public bool CreateDriver(CreateDriverModel createDriverModel)
        {
            try
            {
                _context.tbl_Driver.Add(new tbl_Driver
                {
                    DriverName = createDriverModel.DriverName,
                    DriverFamily = createDriverModel.DriverFamily,
                    CarTag = createDriverModel.CarTag,
                    CarName = createDriverModel.CarName,
                    CarColor = createDriverModel.CarColor,
                    NationalCode = createDriverModel.NationalCode,
                    CreatedBy = createDriverModel.CreatedBy,
                    UpdatedBy = createDriverModel.UpdatedBy,
                });
                return true;
            }
            catch
            {
                return false;
            }
            
        }

        public bool DeleteDriver(int id)
        {
            throw new NotImplementedException();
        }

        public List<DriverModel> GetAllDrivers()
        {
            throw new NotImplementedException();
        }

        public bool UpdateDriver(UpdateDriverModel updateDriverModel)
        {
            throw new NotImplementedException();
        }
    }
}
