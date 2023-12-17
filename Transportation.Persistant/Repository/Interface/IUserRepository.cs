using System.Collections.Generic;
using Transportation.Persistant.Models;

namespace Transportation.Persistant.Interface
{
    public interface IUserRepository
    {
        bool CreateUser(CreateUserModel createUserModel);
        bool UpdateUser(UpdateUserModel updateUserModel);
        bool DeleteUser(int id);
        List <UserModel> GetAllUsers ();
    }
}
