using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        public MembershipType MembershipType { get; set; }

        [Display(Name = "Tipo de cliente")]
        public byte MembershipTypeId { get; set; }

        [Display(Name = "Fecha de Cumpleanos")]
        [Min18YearsIfAMember]
        public DateTime? Birthdate { get; set; }
    }
}