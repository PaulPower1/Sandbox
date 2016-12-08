using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace PaulsSecurity.Models
{
    public class Customer
    {
        public string File_As { get; set; }
        public string ContactName { get; set; }
        public int ID { get; set; }
        public string Company { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }
        public string JobTitle { get; set; }
        public string BusinessPhone { get; set; }
        public string HomePhone { get; set; }
        public string MobilePhone { get; set; }
    }
}