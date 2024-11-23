using SliderApplication.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SliderApplication.DAL
{
    public class SliderContext:DbContext
    {
        public SliderContext()
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Slider>().ToTable("Slider");
        }
        public DbSet<Slider>sliders { get; set; }
    }
}