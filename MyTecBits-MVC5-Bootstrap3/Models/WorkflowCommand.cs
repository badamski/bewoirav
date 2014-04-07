using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyTecBits_MVC5_Bootstrap3.Models
{
    public class WorkflowCommand
    {
        public int Id { get; set; }
        public string CommandName { get; set; }
        public string RelatedObjectType { get; set; }
        public VarioObject RelatedObject { get; set; }
        public string Date { get; set; }
        public string Author { get; set; }
    }
}