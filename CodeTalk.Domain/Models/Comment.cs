using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTalk.Domain.Models
{
    public class Comment
    {
        public int Id { get; set; }
        [Required]
        public string Body { get; set; }
        [Required]
        public string CommenterName { get; set; }

        public int TalkId { get; set; }

        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }

         public Comment()
        {
            DateCreated = DateTime.Now;
            DateModified = DateTime.Now;
        }
    }
}
