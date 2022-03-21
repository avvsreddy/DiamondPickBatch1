using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace KnowledgeHub.Entities
{
    public class Article
    {

        
        public int ArticleID { get; set; }
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
        [Required]
        [MaxLength(500)]
        [Display(Name = "Article URL")]
        public string ArticleUrl { get; set; }
        [MaxLength(1000)]
        public string Description { get; set; }
        public Catagory Catagory { get; set; }

        //[ForeignKey("Catagory")]
        [Display(Name ="Catagory")]
        public int CatagoryID { get; set; }

        [Display(Name ="Owner")]
        public string SubmittedBy { get; set; }
        [Display(Name ="Date Submitted")]
        public DateTime DateSubmitted { get; set; } = DateTime.Now;
        public bool IsApproved { get; set; } = false;

    }
}
