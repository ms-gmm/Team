using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Blog.Core
{
   public class Blogs
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public int Prasie { get; set; }

        public string Comments { get; set; }

        public int MyProperty { get; set; }

        public int UserId { get; set; }

        [ForeignKey("UserId")]

        public virtual User User { get; set; }
    }
}
