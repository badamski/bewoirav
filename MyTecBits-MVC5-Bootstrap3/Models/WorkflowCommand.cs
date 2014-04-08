using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyTecBits_MVC5_Bootstrap3.Models
{
    public class WorkflowCommand
    {
        public int Id { get; set; }

        [Display(Name = "Nazwa polecenia")]
        public string CommandName { get; set; }
        public string RelatedObjectName { get; set; }
        public int RelatedObjectId { get; set; }
        public string Date { get; set; }
        public string Author { get; set; }
    }
}