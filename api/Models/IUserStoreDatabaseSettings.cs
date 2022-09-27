namespace api.Models
{
    public interface IUserStoreDatabaseSettings
    {
        public string ConnectionString { get; set; }

        public string DatabaseName { get; set; }

        public string UserCollectionName { get; set; }
    }
}
