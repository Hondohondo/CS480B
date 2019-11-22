using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace hw3.Models
{
    public class Quote
    {
        public int ID { get; set; }  //primary key

        [Required]
        [Display(Name = "Quotation")]
        public string Quotation { get; set; }
    }
}
