namespace Vuture.Models.Dtos
{
    public class ReadContactDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string EmailAddress { get; set; } = "";
        public string Title { get; set; } = "";
        public string Company { get; set; } = "";
        public string Status { get; set; } = "";
    }
}