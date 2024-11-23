using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SliderApplication.Models
{
    public class Slider
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SliderId { get; set; }
        [Required]
        public string Name {  get; set; }
        [Required]
        public bool Status {  get; set; }
        public string FilePath { get; set; }
        [NotMapped]
        public HttpFileCollectionBase Files {  get; set; }
    }
}