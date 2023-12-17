using System.Collections.Generic;
using Transportation.Persistant.Models;

namespace Transportation.Persistant.Interface
{
    public interface IDriverTransportationRepository
    {
        bool CreateDriverTransportation(CreateDriverModel createDriverModel);
        bool UpdateDriverTransportation(UpdateDriverModel updateDriverModel);
        bool DeleteDriverTransportation(int  id);

        List <DriverTransportationModel> GetAllDriverTransportations ();
    }
}
