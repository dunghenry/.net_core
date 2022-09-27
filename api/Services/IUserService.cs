using api.Models;

namespace api.Services
{
    public interface IUserService
    {
        List<UserModel> Get();
        UserModel Get(string id);
        UserModel Create(UserModel user);

        void Update(string id, UserModel user);
        void Delete(string id);
    }
}
