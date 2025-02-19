namespace NETCORE_Lesson03.Models.DataModels
{
    public class Member
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }

        public Member() { }
        public Member(int id, string name, string description, string phone, string address, string city, string region)
        {
            Id = id;
            Name = name;
            Description = description;
            Phone = phone;
            Address = address;
            City = city;
            Region = region;
        }
    }
}
