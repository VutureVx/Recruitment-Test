using System.ComponentModel.DataAnnotations;
using Vuture.Constants;

namespace Vuture
{
    public class Contact
    {
        [Key] [Required] public int Id { get; set; }
        [Required] public string FirstName { get; set; } = "";
        [Required] public string LastName { get; set; } = "";
        [Required] public string EmailAddress { get; set; } = "";
        public string? Title { get; set; } = "";
        public string? Company { get; set; } = "";
        public string? Status { get; set; } = ContactStatus.Lead;
    }
}