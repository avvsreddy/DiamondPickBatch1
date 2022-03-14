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
        [Required(ErrorMessage ="Kindly provide catagory title")]
        [MaxLength(50)]
        [Display(Name="Title")]
        public string CatagoryName { get; set; }
        [MaxLength(500)]
        [Display(Name ="Description")]
        public string CatagoryDescription { get; set; }
    }
}
