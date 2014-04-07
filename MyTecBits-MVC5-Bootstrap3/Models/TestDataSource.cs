using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyTecBits_MVC5_Bootstrap3.Models
{
    public class TestDataSource
    {
        private List<WorkflowCommand> _workflowCommands;
        private List<VarioObject> _varioObjects;

        public TestDataSource()
        {
            _varioObjects.Add(
                new VarioObject()
                {

                });

            //_workflowCommands.Add(
            //    new WorkflowCommand() { 
            //      CommandName ="Umowa zarejestrowana w Simple", RelatedObject = "", Date = "2014-04-04 14:44", Author = "" });
            //    { CommandName ="Oferta do wysłania", RelatedObject = "", Date ="2014-04-03 16:33", Author ="" });
            //    { CommandName ="Umowa zarejestrowana w Simple", RelatedObject = "2014-04-02 14:46", Date ="", Author ="" });
            //    { CommandName ="Umowa zarejestrowana w Simple", RelatedObject = "", Date ="2014-04-02 14:27", Author ="" });
            //    { CommandName ="Nowy Projekt do realizacji", RelatedObject = "", Date ="2014-03-26 13:11", Author ="" });
            //    { CommandName ="Proszę o uzupełnienie załączonej faktury kosztowej", RelatedObject = "", Date ="2014-03-24 11:26", Author ="" });
            //    { CommandName ="Pozycje faktury uzupełnione", RelatedObject = "", Date ="2014-03-21 12:13", Author ="" });
            //    { CommandName ="Proszę o uzupełnienie danych", RelatedObject = "", Date ="2014-03-20 10:58", Author ="" });
            //    { CommandName ="Pozycje faktury uzupełnione", RelatedObject = "", Date ="2014-03-19 15:30", Author ="" });
            //    { CommandName ="Proszę o uzupełnienie danych", RelatedObject = "", Date ="2014-03-19 14:57", Author ="" });
            //    { CommandName ="Pozycje faktury uzupełnione", RelatedObject = "", Date ="2014-03-19 12:33", Author ="" });
            //    { CommandName ="Pozycje faktury uzupełnione", RelatedObject = "", Date ="2014-03-19 09:56", Author ="" });
            //    { CommandName ="Proszę o uzupełnienie danych", RelatedObject = "", Date ="2014-03-19 09:34", Author ="" });
            //    { CommandName ="Proszę o uzupełnienie danych", RelatedObject = "", Date ="2014-03-19 08:17", Author ="" });
            //    { CommandName ="Faktura kosztowa do opisu", RelatedObject = "", Date ="2014-03-13 13:59", Author ="" });
            //    { CommandName ="Proszę o uzupełnienie danych", RelatedObject = "", Date ="2014-03-11 14:38", Author ="" });
            //    { CommandName ="Faktura kosztowa do opisu", RelatedObject = "", Date ="2014-03-11 14:24", Author ="" });
            //    { CommandName ="Formularz kooperacji do weryfikacji", RelatedObject = "", Date ="2014-03-03 12:11", Author ="" });
            //    { CommandName ="Proszę o uzupełnienie danych na załączonej fakturze kosztowej", RelatedObject = "2014-02-12 08:39", Date ="", Author ="" });
            //    { CommandName ="Nowy Projekt do realizacji", RelatedObject = "", Date ="2014-02-12 08:25", Author ="" });
            //    { CommandName ="Nowy Etap Projektu do realizacji", RelatedObject = "", Date ="2014-02-10 16:59", Author ="" });
        }

        public IList<WorkflowCommand> GetCommands()
        {
            return _workflowCommands;
        }
    }
}