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
        private TransportationContext _context = new TransportationContext();
        public bool CreateUser(CreateUserModel createUserModel)
        {
            try
            {
               _context.tbl_User.Add(new tbl_User
               {
                    FirstName = createUserModel.FirstName,
                    LastName = createUserModel.LastName,
                    UserName = createUserModel.UserName,
                    Password = createUserModel.Password,
               });
                _context.SaveChanges();
                
                return true;
            }
            
            catch (Exception)
            {

                return false;
            }
        }

        public bool DeleteUser(int id)
        {
            //throw new NotImplementedException();
            List<UserModel> userModels = new List<UserModel> ();
            var DelUserModel = userModels.FirstOrDefault(u => u.Id == id);
            if (DelUserModel != null)
            {
                userModels.Remove(DelUserModel);
            }
            return true;
        }

        public List<UserModel> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public bool UpdateUser(UpdateUserModel updateUserModel)
        {
            //throw new NotImplementedException();
            List<UserModel> userModels = new List<UserModel>();
            var UpdateUserModel = userModels.FirstOrDefault(s => s.Id == updateUserModel.Id);
            if (UpdateUserModel != null)
            {
                UpdateUserModel.UserName = updateUserModel.UserName;
                UpdateUserModel.LastName = updateUserModel.LastName;
                UpdateUserModel.FirstName = updateUserModel.FirstName;
                UpdateUserModel.Password = updateUserModel.Password;
            }
            return true;
        }
    }
}
