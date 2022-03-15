using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeHub.Entities
{
    public class Contact
    {
        public int ContactId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Location { get; set; }
    }
}
