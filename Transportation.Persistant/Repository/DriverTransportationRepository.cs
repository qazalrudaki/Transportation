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
    public class DriverTransportationRepository : IDriverTransportationRepository
    {
        public bool CreateDriverTransportation(CreateDriverModel createDriverModel)
        {
            TransportationContext _context = new TransportationContext(); // couldnt be PRIVATE
            try
            {
                _context.tbl_DriverTransaction.Add(new tbl_DriverTransaction
                {
                    EnterDate = DateTime.Now,
                    ExitDate = DateTime.Now,
                    CreatedDateTime = DateTime.Now,
                });
                
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteDriverTransportation(int id)
        {
            //throw new NotImplementedException();
            List<DriverTransportationModel> driverTransportationModels = new List<DriverTransportationModel>();
            var DelDriverTransportation = driverTransportationModels.FirstOrDefault(d => d.Id == id);
            if (DelDriverTransportation != null)
            {
                driverTransportationModels.Remove(DelDriverTransportation);
            }
            return true;
        }

        public List<DriverTransportationModel> GetAllDriverTransportations()
        {
            throw new NotImplementedException();
        }

        public bool UpdateDriverTransportation(UpdateDriverModel updateDriverModel)
        {
            //throw new NotImplementedException();
            List<DriverTransportationModel> driverTransportationModels = new List<DriverTransportationModel>();
            var UPdateDriverTransportation = driverTransportationModels.FirstOrDefault(d => d.Id == updateDriverModel.Id);
            if (UPdateDriverTransportation != null)
            {
                
            }
            return true;
        }
    }
}
