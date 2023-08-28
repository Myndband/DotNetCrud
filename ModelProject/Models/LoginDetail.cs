using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelProject.Models
{
    public class LoginDetail
    {
        [Key]
        public long UserID { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }

    }
}
