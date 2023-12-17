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
    public class UserRepository : IUserRepository
    {
        private TransportationContext _context= new TransportationContext();
        public bool CreateUser(CreateUserModel createUserModel)
        {
            try

            {
                _context.tbl_User.
                return true;
            }
            
            catch (Exception)
            {

                throw;
            }
        }

        public bool DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public List<UserModel> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public bool UpdateUser(UpdateUserModel updateUserModel)
        {
            throw new NotImplementedException();
        }
    }
}
