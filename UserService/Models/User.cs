namespace UserService.Models
{
    public class User
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Bio { get; set; }
        public string? Secret { get; set; }
    }
}
