using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerceSite.Models
{
    public class Member
    {
        //Data Annotations validation and DB markep
        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        //int is automatically required because type=int
        [Key]//This is Primary key
        public int MemberId { get; set; }

        [DataType(DataType.Password)]
        [Required]
        public string Password { get; set; }

    }
}
