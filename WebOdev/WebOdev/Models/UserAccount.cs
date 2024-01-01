using System.ComponentModel.DataAnnotations;

namespace WebOdev.Models
{
    public class UserAccount
    {
        [Key]
        public int UserID { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
    }
}
