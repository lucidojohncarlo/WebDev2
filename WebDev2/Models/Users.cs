using System.ComponentModel.DataAnnotations;

namespace WebDev2.Models
{
    public class Users
    {
        [Key]
        public int UserID { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public DateTime datetimeadded { get; set; }
    }
}
