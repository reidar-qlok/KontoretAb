using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace KontoretAb.Models
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeId { get; set; } = 0;
        [Required]
        [StringLength(50)]
        [DisplayName("First name")]
        public string FirstMidName { get; set; } = default!;
        [Required]
        [StringLength(30)]
        [DisplayName("Last name")]
        public string LastName { get; set; } = default!;
        [StringLength(25)]
        public string Address { get; set; } = default!;
        [StringLength(25)]
        public string City { get; set; } = default!;
        public virtual ICollection<ProjectList>? ProjectLists { get; set; }
    }
}
