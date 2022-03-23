namespace BlazorTraining.Model
{
    public class Company
    {
        public Company(int id, string companyName, CompanyAddress companyAddress)
        {
            Id = id;
            CompanyName = companyName;
            CompanyAddress = companyAddress;
        }

        public int Id { get; set;}
        public string CompanyName { get; set; }
        public CompanyAddress CompanyAddress { get; set; }
    }

    public class CompanyAddress
    {
        public CompanyAddress(string street, string city, string country)
        {
            Street = street;
            City = city;
            Country = country;
        }

        public string Street { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}
