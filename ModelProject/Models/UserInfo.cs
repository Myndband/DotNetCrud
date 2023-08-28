using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelProject.Models
{
    public class UserInfo
    {
        [Key]
        public long Id { get; set; }
        public string? UserID { get; set; } 
        public string? UserName { get; set; }
        public string? Address { get; set; }
        [Range(18,60)]
        public int? Age { get; set; }
        public int Mobile { get; set; }

    }
}
