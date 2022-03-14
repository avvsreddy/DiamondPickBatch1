using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeHub.Entities
{
    public class Catagory
    {
        public int CatagoryID { get; set; }
        [Required]
        [MaxLength(50)]
        
        public string CatagoryName { get; set; }
        [MaxLength(500)]
        public string CatagoryDescription { get; set; }
    }
}
