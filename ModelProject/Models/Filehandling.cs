using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelProject.Models
{
    public class Filehandling
    {
        [Key]
        public long Id { get; set; }
        public string UserID { get; set; }
        public string FileStream { get; set; }
    }
}
