using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Models
{
    public class User
    {
        [Required]
        [Key]
        [JsonPropertyName("userName")]
        public string userName { get; set; }
        
        [Required]
        [JsonPropertyName("password")]
        public string password { get; set; }
        
        [JsonPropertyName("domain")]
        public string Domain { get; set; }
        
        [JsonPropertyName("city")]
        public string City { get; set; }
        
        [JsonPropertyName("birthYear")]
        public int BirthYear { get; set; }
        
        [JsonPropertyName("role")]
        public string Role { get; set; }
        
        [JsonPropertyName("securityLevel")]
        public int SecurityLevel { get; set; }
    }
}