﻿using System;
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
        [Display(Name ="Article URL")]
        public string ArticleUrl { get; set; }
        [MaxLength(1000)]
        public string Description { get; set; }
        public Catagory Catagory { get; set; }

        //[ForeignKey("Catagory")]
        public int CatagoryID { get; set; }

        public string SubmittedBy { get; set; }
        public DateTime DateSubmitted { get; set; } = DateTime.Now.Date;
        public bool IsApproved { get; set; } = false;

    }
}
