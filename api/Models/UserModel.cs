using System.ComponentModel.DataAnnotations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace api.Models
{
    [BsonIgnoreExtraElements]
    public class UserModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = String.Empty;

        [BsonElement("name")]
        public string Name { get; set; } = String.Empty;

        [BsonElement("email")]
        public string Email { get; set; }

        [BsonElement("graduated")]
        public bool IsGraduated { get; set; }

        [BsonElement("hobbies")]
        public string[]? Hobbies { get; set; }

        [BsonElement("gender")]
        public string Gender { get; set; }

        [BsonElement("age")]
        public int Age { get; set; }
    }
}
