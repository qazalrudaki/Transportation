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
            throw new NotImplementedException();
        }

        public List<DriverTransportationModel> GetAllDriverTransportations()
        {
            throw new NotImplementedException();
        }

        public bool UpdateDriverTransportation(UpdateDriverModel updateDriverModel)
        {
            throw new NotImplementedException();
        }
    }
}
