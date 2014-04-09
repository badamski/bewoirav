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
            _varioObjects = new List<VarioObject>();
            _workflowCommands = new List<WorkflowCommand>();

            _varioObjects.Add(
                new VarioObject()
                {
                    Id = 1,
                    ObjectName = "FV KOSZTOWA TST MD 002 1903",
                    DateCreated = "2014-03-19 10:52:00",
                    Client = " TELEFONIA DIALOG SA ",
                    Value = "1 230,00",
                    ValueNetto = "1 000,00",
                    ValueVat ="230",
                    Deadline = "2014-03-31",
                    WorkflowState = "W księgowaniu",
                    EditState = "Dostępny",
                    ClientAddress = "TELEFONIA DIALOG SA  50-136 WROCŁAW ul.PLAC JANA PAWŁA II 1  nr. 692-199-08-16",
                    Number = "FV/2014/082"
                });

            _varioObjects.Add(
new VarioObject()
{
    Id = 2,
    ObjectName = "FV KOSZTOWA MD 002 2103",
    DateCreated = "2014-03-21 10:19:00",
    Client = "4 WOJSKOWY SZPITAL KLINICZNY Z POLIKLINIKĄ - PARKING ",
    Value = "1 230,00",
    ValueNetto = "1000",
    ValueVat = "230",
    Deadline = "2014-03-21",
    WorkflowState = "W księgowaniu",
    EditState = "Dostępny",
    ClientAddress = "4 WOJSKOWY SZPITAL KLINICZNY Z POLIKLINIKĄ - PARKING  50-981 WROCŁAW ul.WEIGLA 5  nr. 899-222-89-56",
    Number = "FV/2014/120"
});

//            _varioObjects.Add(
//    new VarioObject()
//    {
//        Id = 3,
//        ObjectName = "FTK25",
//        DateCreated = "2013-10-24 10:14:00",
//        Client = " WARSZAWSKA FABRYKA PLATEROW  HEFRA SA ",
//        Value = "30 690,00 zł",
//        ValueNetto = "30 000,00 zł",
//        ValueVat = "690",
//        Deadline = "2013-10-31",
//        WorkflowState = "W księgowaniu",
//        EditState = "Dostępny",
//        ClientAddress = " WARSZAWSKA FABRYKA PLATEROW  HEFRA SA  59-220 LEGNICA ul.ŻEGLARSKA 8  nr. 527-020-60-10
//",
//        Number = ""
//    });

            //_workflowCommands.Add(new WorkflowCommand() { Id = 1,  RelatedObjectName = GetVarioObjName(1), CommandName = "Umowa zarejestrowana w Simple", RelatedObjectId = 1, Date = "2014-04-04 14:44", Author = "E.Patyra" });
            //_workflowCommands.Add(new WorkflowCommand() { Id = 2,  RelatedObjectName = GetVarioObjName(1), CommandName = "Oferta do wysłania", RelatedObjectId = 1, Date = "2014-04-03 16:33", Author = "K. Olejniczak" });
            //_workflowCommands.Add(new WorkflowCommand() { Id = 3,  RelatedObjectName = GetVarioObjName(1), CommandName = "Umowa zarejestrowana w Simple", RelatedObjectId = 1, Date = "2014-04-02 14:46", Author = "E.Patyra" });
            //_workflowCommands.Add(new WorkflowCommand() { Id = 4,  RelatedObjectName = GetVarioObjName(1), CommandName = "Umowa zarejestrowana w Simple", RelatedObjectId = 1, Date = "2014-04-02 14:27", Author = "M. Żołądek" });
            //_workflowCommands.Add(new WorkflowCommand() { Id = 5,  RelatedObjectName = GetVarioObjName(1), CommandName = "Nowy Projekt do realizacji", RelatedObjectId = 1, Date = "2014-03-26 13:11", Author = "K. Olejniczak" });
            _workflowCommands.Add(new WorkflowCommand() { Id = 6,  RelatedObjectName = GetVarioObjName(1), CommandName = "Proszę o uzupełnienie załączonej faktury kosztowej", RelatedObjectId = 1, Date = "2014-03-24 11:26", Author = "Z. Pawlik" });
            _workflowCommands.Add(new WorkflowCommand() { Id = 7,  RelatedObjectName = GetVarioObjName(1), CommandName = "Pozycje faktury uzupełnione", RelatedObjectId = 1, Date = "2014-03-21 12:13", Author = "Z. Pawlik" });
            _workflowCommands.Add(new WorkflowCommand() { Id = 8,  RelatedObjectName = GetVarioObjName(1), CommandName = "Proszę o uzupełnienie danych", RelatedObjectId = 1, Date = "2014-03-20 10:58", Author = "K. Olejniczak" });
            _workflowCommands.Add(new WorkflowCommand() { Id = 9,  RelatedObjectName = GetVarioObjName(1), CommandName = "Pozycje faktury uzupełnione", RelatedObjectId = 1, Date = "2014-03-19 15:30", Author = "M. Żołądek" });
            _workflowCommands.Add(new WorkflowCommand() { Id = 10, RelatedObjectName = GetVarioObjName(1), CommandName = "Proszę o uzupełnienie danych", RelatedObjectId = 1, Date = "2014-03-19 14:57", Author = "E.Patyra" });
            _workflowCommands.Add(new WorkflowCommand() { Id = 11, RelatedObjectName = GetVarioObjName(1), CommandName = "Pozycje faktury uzupełnione", RelatedObjectId = 1, Date = "2014-03-19 12:33", Author = "Z. Pawlik" });
            _workflowCommands.Add(new WorkflowCommand() { Id = 12, RelatedObjectName = GetVarioObjName(1), CommandName = "Pozycje faktury uzupełnione", RelatedObjectId = 1, Date = "2014-03-19 09:56", Author = "K. Olejniczak" });
            _workflowCommands.Add(new WorkflowCommand() { Id = 13, RelatedObjectName = GetVarioObjName(1), CommandName = "Proszę o uzupełnienie danych", RelatedObjectId = 1, Date = "2014-03-19 09:34", Author = "E.Patyra" });
            _workflowCommands.Add(new WorkflowCommand() { Id = 14, RelatedObjectName = GetVarioObjName(1), CommandName = "Proszę o uzupełnienie danych", RelatedObjectId = 1, Date = "2014-03-19 08:17", Author = "E.Patyra" });
            _workflowCommands.Add(new WorkflowCommand() { Id = 15, RelatedObjectName = GetVarioObjName(1), CommandName = "Faktura kosztowa do opisu", RelatedObjectId = 1, Date = "2014-03-13 13:59", Author = "M. Żołądek" });
            _workflowCommands.Add(new WorkflowCommand() { Id = 16, RelatedObjectName = GetVarioObjName(1), CommandName = "Proszę o uzupełnienie danych", RelatedObjectId = 1, Date = "2014-03-11 14:38", Author = "E.Patyra" });
            _workflowCommands.Add(new WorkflowCommand() { Id = 17, RelatedObjectName = GetVarioObjName(1), CommandName = "Faktura kosztowa do opisu", RelatedObjectId = 1, Date = "2014-03-11 14:24", Author = "K. Olejnicza" });
            //_workflowCommands.Add(new WorkflowCommand() { Id = 18, RelatedObjectName = GetVarioObjName(1), CommandName = "Formularz kooperacji do weryfikacji", RelatedObjectId = 1, Date = "2014-03-03 12:11", Author = "M. Żołądek" });
            _workflowCommands.Add(new WorkflowCommand() { Id = 19, RelatedObjectName = GetVarioObjName(1), CommandName = "Proszę o uzupełnienie danych na załączonej fakturze kosztowej", RelatedObjectId = 1, Date = "2014-02-12 08:39", Author = "E.Patyra" });
            //_workflowCommands.Add(new WorkflowCommand() { Id = 20, RelatedObjectName = GetVarioObjName(1), CommandName = "Nowy Projekt do realizacji", RelatedObjectId = 1, Date = "2014-02-12 08:25", Author = "K. Olejniczak" });
            //_workflowCommands.Add(new WorkflowCommand() { Id = 21, RelatedObjectName = GetVarioObjName(1), CommandName = "Nowy Etap Projektu do realizacji", RelatedObjectId = 1, Date = "2014-02-10 16:59", Author = "Z. Pawlik" });
        }

        public VarioObject GetObject(int objectId)
        {
            return _varioObjects.First(o => o.Id == objectId);
        }

        private string GetVarioObjName(int objectId)
        {
            return _varioObjects.First(o => o.Id == objectId).ObjectName;
        }

        public IList<WorkflowCommand> GetCommands()
        {
            return _workflowCommands;
        }

        public int GetCommandsCount()
        {
            return _workflowCommands.Count;
        }
    }
}