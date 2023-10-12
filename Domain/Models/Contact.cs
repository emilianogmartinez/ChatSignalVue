using System.ComponentModel.DataAnnotations;

namespace VueChatAPI.Domain.Models
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        public Guid UserId { get; set; }
        public Guid ContactId { get; set; }
    }
}
