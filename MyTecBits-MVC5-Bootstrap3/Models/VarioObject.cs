using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyTecBits_MVC5_Bootstrap3.Models
{
    public class VarioObject
    {
        public int Id { get; set; }
        public string ObjectName { get; set; }
        public string Filename { get; set; }
        public string DateCreated { get; set; }
        public string Client { get; set; }
        public string Value { get; set; }
        public string ValueNetto { get; set; }
        public string Deadline { get; set; }
        public string WorkflowState { get; set; }
        public string EditState { get; set; }
        public string ClientAddress { get; set; }
        public string Number { get; set; }
    }
}