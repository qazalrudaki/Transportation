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
                _context.SaveChanges();
                
                return true;
            }
            catch
            {
                return false;
            }

        }

        public bool DeleteDriver(int id)
        {
            //throw new NotImplementedException();
            //TransportationContext _context = new TransportationContext();
            List<DriverModel> driverModels = new List<DriverModel>();
            var DelDriver = driverModels.FirstOrDefault(x => x.Id == id);
            if (DelDriver != null)
            {
                driverModels.Remove(DelDriver);
            }
            return true;
        }

        public List<DriverModel> GetAllDrivers()
        {
            throw new NotImplementedException();
        }

        public bool UpdateDriver(UpdateDriverModel updateDriverModel)
        {
            //throw new NotImplementedException();
            List<DriverModel> driverModels = new List<DriverModel>();
            var UpdateDriverModel = driverModels.FirstOrDefault(d => d.Id == updateDriverModel.Id);
            if (UpdateDriverModel != null)
            {
                UpdateDriverModel.UpdatedBy = updateDriverModel.UpdatedBy;
                UpdateDriverModel.CreatedBy = updateDriverModel.CreatedBy;
                UpdateDriverModel.CarColor = updateDriverModel.CarColor;
                UpdateDriverModel.CarName = updateDriverModel.CarName;
                UpdateDriverModel.CarTag = updateDriverModel.CarTag;
                UpdateDriverModel.DriverFamily = updateDriverModel.DriverFamily;
                UpdateDriverModel.DriverFamily = UpdateDriverModel.DriverFamily;
                UpdateDriverModel.NationalCode = updateDriverModel.NationalCode;
            }

            return true;
        }
    }
}
