using api.Models;
using MongoDB.Driver;
namespace api.Services
{
    public class UserService : IUserService
    {
        private readonly IMongoCollection<UserModel> _users;

        public UserService(IUserStoreDatabaseSettings settings, IMongoClient mongoClient){
            var db = mongoClient.GetDatabase(settings.DatabaseName);
            _users = db.GetCollection<UserModel>(settings.UserCollectionName);

        }

        public UserModel Create(UserModel user)
        {
            _users.InsertOne(user);
            return user;
        }

        public void Delete(string id)
        {
            _users.DeleteOne(student => student.Id == id);
        }

        public List<UserModel> Get()
        {
            return _users.Find(student => true).ToList();
        }

        public UserModel Get(string id)
        {
            return _users.Find(student => student.Id == id).FirstOrDefault();
        }

        public void Update(string id, UserModel user)
        {
            _users.ReplaceOne(student => student.Id == id, user);
        }
    }
}
