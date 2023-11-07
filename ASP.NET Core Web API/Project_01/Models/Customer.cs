using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Project_01.Models
{
    public class Customer
    {
        [DisplayName("Customer Id")]
        public int CustomerId { get; set; }
        [Required,StringLength(50)]
        [DisplayName("Customer Name")]
        public string CustomerName { get; set; } = default!;
        public int Age { get; set; }
        [StringLength(15)]
        public string City { get; set; }= default!;
        [StringLength(15)]
        public string Country { get; set; }= default!;
        [Required, StringLength(25)]
        public string Phone { get; set; } = default!;
    }
}
