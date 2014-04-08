using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyTecBits_MVC5_Bootstrap3.Models
{
    public class VarioObject
    {
        public int Id { get; set; }

        [Display(Name = "Nazwa:")]
        public string ObjectName { get; set; }
        [Display(Name = "Nazwa pliku:")]
        public string Filename { get; set; }
        [Display(Name = "Utworzony:")]
        public string DateCreated { get; set; }
        [Display(Name = "Wystawca:")]
        public string Client { get; set; }
        [Display(Name = "Wartość:")]
        public string Value { get; set; }
        [Display(Name = "Wartość netto:")]
        public string ValueNetto { get; set; }
        [Display(Name = "Wartość VAT:")]
        public string ValueVat { get; set; }
        [Display(Name = "Termin płatności:")]
        public string Deadline { get; set; }
        [Display(Name = "Stan obiegu:")]
        public string WorkflowState { get; set; }
        [Display(Name = "Status edycji:")]
        public string EditState { get; set; }
        [Display(Name = "Dane adresowe:")]
        public string ClientAddress { get; set; }
        [Display(Name = "Nr faktury:")]
        public string Number { get; set; }
    }
}