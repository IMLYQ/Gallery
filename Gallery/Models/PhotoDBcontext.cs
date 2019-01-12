using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Gallery.Models
{
    public class PhotoDBcontext:DbContext
    {
        public PhotoDBcontext() : base("connetionstring") {}

        public DbSet<photo> photo { get; set; }

        public DbSet<place> place { get; set; }
    }
}