namespace api.Models
{
    public class UserStoreDatabaseSettings:IUserStoreDatabaseSettings
    {
        public string ConnectionString { get; set; } = String.Empty;

        public string DatabaseName { get; set; } = String.Empty;

        public string UserCollectionName { get; set; } = String.Empty;
    }
}
