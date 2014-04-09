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

            _varioObjects.Add(

               new VarioObject()
               {
                   Id = 3,
                   ObjectName = "FAKTURA KOSZTOWA - NR 222",
                   DateCreated = "2013-10-22 13:28:00",
                   Client = " MYJNIA SAMOCHODOWA AB BOGDAN KOSTECKI ",
                   Value = "120,00 zł",
                   ValueNetto = "100,00 zł",
                   ValueVat ="20,00 zł",
                   Deadline = "2013-10-30",
                   WorkflowState = "W akceptacji GK",
                   EditState = "Dostępny",
                   ClientAddress = " MYJNIA SAMOCHODOWA AB BOGDAN KOSTECKI  32-020 WIELICZKA ul.DEMBOWSKIEGO 36   nr. 683-114-58-04",
                   Number = "FV/2013/106"
               });

_varioObjects.Add(

               new VarioObject()

               {

                   Id = 4,

                   ObjectName = "FV - KOSZTOWA MD TST 11",

                   DateCreated = "2014-02-25 09:35:00",

                   Client = " INOVA CENTRUM INNOWACJI TECHNICZNYCH SP. Z O.O. ",

                   Value = "8 548,00 zł",

                   ValueNetto = "7 777,00 zł",

                   ValueVat ="771,00 zł",

                   Deadline = "2014-02-28",

                   WorkflowState = "W księgowaniu",

                   EditState = "Dostępny",

                   ClientAddress = " INOVA CENTRUM INNOWACJI TECHNICZNYCH SP. Z O.O.  59-301 LUBIN ul.MARII SKŁODOWSKIEJ CURIE 183  nr. 692-000-00-59",

                   Number = "FV/2014/039"

               });
_varioObjects.Add(

               new VarioObject()

               {

                   Id = 5,

                   ObjectName = "FV - MD TST - NA PODMIOT",

                   DateCreated = "2013-10-24 11:16:00",

                   Client = "Podmiot - test 2",

                   Value = "333,00 zł",

                   ValueNetto = "222,00 zł",

                   ValueVat ="111,00 zł",

                   Deadline = "2013-10-24",

                   WorkflowState = "W akceptacji przełożonego",

                   EditState = "Dostępny",

                   ClientAddress = "Podmiot - test 2 99-999 Podmiotowo ul.ulica podmiotu nr. 222-222-22-22",

                   Number = "FV/2013/111"

               });
_varioObjects.Add(
               new VarioObject()
               {
                   Id = 6,
                   ObjectName = "FV - MD TST 010 - 5KA",
                   DateCreated = "2014-02-25 08:57:00",
                   Client = " INOVA CENTRUM INNOWACJI TECHNICZNYCH SP. Z O.O. ",
                   Value = "1 230,00 zł",
                   ValueNetto = "1 000,00 zł",
                   ValueVat = "230,00 zł",
                   Deadline = "2014-02-28",
                   WorkflowState = "W akceptacji przełożonego",
                   EditState = "Dostępny",
                   ClientAddress = " INOVA CENTRUM INNOWACJI TECHNICZNYCH SP. Z O.O.  59-301 LUBIN ul.MARII SKŁODOWSKIEJ CURIE 183  nr. 692-000-00-59",
                   Number = "FV/2014/038"
               });

_varioObjects.Add(

   new VarioObject()

   {

       Id = 7,

       ObjectName = "FV - MD TST 18 SIMPLE",

       DateCreated = "2013-10-31 16:16:00",

       Client = "GUARD ZAKLAD ZABEZPIECZEŃ ELEKTRONICZNYCH JANUSZ WIELGUS ",

       Value = "123,00 zł",

       ValueNetto = "100,00 zł",

       ValueVat = "23,00 zł",

       Deadline = "2013-10-31",

       WorkflowState = "Wysłane do Simple",

       EditState = "Dostępny",

       ClientAddress = "GUARD ZAKLAD ZABEZPIECZEŃ ELEKTRONICZNYCH JANUSZ WIELGUS    ul.   nr. 691-020-76-46",

       Number = "FV/2013/165"

   });
_varioObjects.Add(

               new VarioObject()

               {

                   Id = 8,

                   ObjectName = "FV KOSZT 05 AKCEPT",

                   DateCreated = "2014-02-24 11:48:00",

                   Client = " CENTRUM BADAŃ JAKOŚCI SP. Z O.O. ",

                   Value = "1 230,00 zł",

                   ValueNetto = "1 000,00 zł",

                   ValueVat = "230,00 zł",

                   Deadline = "2014-02-28",

                   WorkflowState = "W księgowaniu",

                   EditState = "Dostępny",

                   ClientAddress = " CENTRUM BADAŃ JAKOŚCI SP. Z O.O.  59-301 LUBIN ul.MARII SKŁODOWSKIEJ - CURIE 62  nr. 692-163-91-77",

                   Number = "FV/2014/034"

               });
_varioObjects.Add(

               new VarioObject()

               {

                   Id = 9,

                   ObjectName = "FV KOSZT 07 AKCEPT WF",

                   DateCreated = "2014-02-24 11:56:00",

                   Client = " FIRMA HANDLOWA EWA WĄCŁAWSKA MAREK WĄCŁASKI SPÓŁKA JAWNA ",

                   Value = "1 230,00 zł",

                   ValueNetto = "1 000,00 zł",

                   ValueVat = "230,00 zł",

                   Deadline = "2014-02-28",

                   WorkflowState = "W opisie",

                   EditState = "Dostępny",

                   ClientAddress = " FIRMA HANDLOWA EWA WĄCŁAWSKA MAREK WĄCŁASKI SPÓŁKA JAWNA  30-079 KRAKÓW ul.KIJOWSKA 12   nr. 677-224-06-58",

                   Number = "FV/2014/035"

               });
_varioObjects.Add(

               new VarioObject()

               {

                   Id = 10,

                   ObjectName = "FV KOSZTOWA MD 002 2103",

                   DateCreated = "2014-03-21 10:19:00",

                   Client = "4 WOJSKOWY SZPITAL KLINICZNY Z POLIKLINIKĄ - PARKING ",

                   Value = "1 230,00 zł",

                   ValueNetto = "1 000,00 zł",

                   ValueVat = "230,00 zł",

                   Deadline = "2014-03-21",

                   WorkflowState = "W księgowaniu",

                   EditState = "Dostępny",

                   ClientAddress = "4 WOJSKOWY SZPITAL KLINICZNY Z POLIKLINIKĄ - PARKING  50-981 WROCŁAW ul.WEIGLA 5  nr. 899-222-89-56",

                   Number = "FV/2014/120"

               });
_varioObjects.Add(

               new VarioObject()

               {

                   Id = 11,

                   ObjectName = "FV KOSZTOWA MD 007 1903",

                   DateCreated = "2014-03-19 15:00:00",

                   Client = "3 DELING BARTOSZ AJSZPUR ",

                   Value = "1 230,00 zł",

                   ValueNetto = "1 000,00 zł",

                   ValueVat = "230,00 zł",

                   Deadline = "2014-03-20",

                   WorkflowState = "Modyfikacja w akceptacji",

                   EditState = "Dostępny",

                   ClientAddress = "3 DELING BARTOSZ AJSZPUR  31-532 KRAKÓW ul.WINCENTEGO POLA 7/46   nr. 929-157-24-37",

                   Number = "FV/2014/104"

               });
_varioObjects.Add(

               new VarioObject()

               {

                   Id = 12,

                   ObjectName = "FV KOSZTOWA MD TST 001 2503",

                   DateCreated = "2014-03-25 09:24:00",

                   Client = "AUTO MYJNIA  BŁYSK ADRIANA RODAKIEWICZ ",

                   Value = "1 230,00 zł",

                   ValueNetto = "1 000,00 zł",

                   ValueVat = "230,00 zł",

                   Deadline = "2014-03-25",

                   WorkflowState = "W opisie",

                   EditState = "Dostępny",

                   ClientAddress = "AUTO MYJNIA  BŁYSK ADRIANA RODAKIEWICZ  54-201 WROCŁAW ul.PRZEDMIRJSKA 1   nr. 894-201-77-66",

                   Number = "FV/2014/133"

               });
_varioObjects.Add(

               new VarioObject()

               {

                   Id = 13,

                   ObjectName = "FV KOSZTOWA TST MD 002 1903",

                   DateCreated = "2014-03-19 10:52:00",

                   Client = " TELEFONIA DIALOG SA ",

                   Value = "1 230,00 zł",

                   ValueNetto = "1 000,00 zł",

                   ValueVat = "230,00 zł",

                   Deadline = "2014-03-31",

                   WorkflowState = "W księgowaniu",

                   EditState = "Dostępny",

                   ClientAddress = " TELEFONIA DIALOG SA  50-136 WROCŁAW ul.PLAC JANA PAWŁA II 1  nr. 692-199-08-16",

                   Number = "FV/2014/082"

               });

            //_workflowCommands.Add(new WorkflowCommand() { Id = 1,  RelatedObjectName = GetVarioObjName(1), CommandName = "Umowa zarejestrowana w Simple", RelatedObjectId = 1, Date = "2014-04-04 14:44", Author = "E.Patyra" });
            //_workflowCommands.Add(new WorkflowCommand() { Id = 2,  RelatedObjectName = GetVarioObjName(1), CommandName = "Oferta do wysłania", RelatedObjectId = 1, Date = "2014-04-03 16:33", Author = "K. Olejniczak" });
            //_workflowCommands.Add(new WorkflowCommand() { Id = 3,  RelatedObjectName = GetVarioObjName(1), CommandName = "Umowa zarejestrowana w Simple", RelatedObjectId = 1, Date = "2014-04-02 14:46", Author = "E.Patyra" });
            //_workflowCommands.Add(new WorkflowCommand() { Id = 4,  RelatedObjectName = GetVarioObjName(1), CommandName = "Umowa zarejestrowana w Simple", RelatedObjectId = 1, Date = "2014-04-02 14:27", Author = "M. Żołądek" });
            //_workflowCommands.Add(new WorkflowCommand() { Id = 5,  RelatedObjectName = GetVarioObjName(1), CommandName = "Nowy Projekt do realizacji", RelatedObjectId = 1, Date = "2014-03-26 13:11", Author = "K. Olejniczak" });
            _workflowCommands.Add(new WorkflowCommand() { Id = 6,  RelatedObjectName = GetVarioObjName(1), CommandName = "Proszę o uzupełnienie załączonej faktury kosztowej", RelatedObjectId = 1, Date = "2014-03-24 11:26", Author = "Z. Pawlik" });
            _workflowCommands.Add(new WorkflowCommand() { Id = 7,  RelatedObjectName = GetVarioObjName(2), CommandName = "Pozycje faktury uzupełnione", RelatedObjectId = 2, Date = "2014-03-21 12:13", Author = "Z. Pawlik" });
            _workflowCommands.Add(new WorkflowCommand() { Id = 8,  RelatedObjectName = GetVarioObjName(3), CommandName = "Proszę o uzupełnienie danych", RelatedObjectId = 3, Date = "2014-03-20 10:58", Author = "K. Olejniczak" });
            _workflowCommands.Add(new WorkflowCommand() { Id = 9,  RelatedObjectName = GetVarioObjName(4), CommandName = "Pozycje faktury uzupełnione", RelatedObjectId = 4, Date = "2014-03-19 15:30", Author = "M. Żołądek" });
            _workflowCommands.Add(new WorkflowCommand() { Id = 10, RelatedObjectName = GetVarioObjName(5), CommandName = "Proszę o uzupełnienie danych", RelatedObjectId = 5, Date = "2014-03-19 14:57", Author = "E.Patyra" });
            _workflowCommands.Add(new WorkflowCommand() { Id = 11, RelatedObjectName = GetVarioObjName(6), CommandName = "Pozycje faktury uzupełnione", RelatedObjectId = 6, Date = "2014-03-19 12:33", Author = "Z. Pawlik" });
            _workflowCommands.Add(new WorkflowCommand() { Id = 12, RelatedObjectName = GetVarioObjName(7), CommandName = "Pozycje faktury uzupełnione", RelatedObjectId = 7, Date = "2014-03-19 09:56", Author = "K. Olejniczak" });
            _workflowCommands.Add(new WorkflowCommand() { Id = 13, RelatedObjectName = GetVarioObjName(8), CommandName = "Proszę o uzupełnienie danych", RelatedObjectId = 8, Date = "2014-03-19 09:34", Author = "E.Patyra" });
            _workflowCommands.Add(new WorkflowCommand() { Id = 14, RelatedObjectName = GetVarioObjName(9), CommandName = "Proszę o uzupełnienie danych", RelatedObjectId = 9, Date = "2014-03-19 08:17", Author = "E.Patyra" });
            _workflowCommands.Add(new WorkflowCommand() { Id = 15, RelatedObjectName = GetVarioObjName(10), CommandName = "Faktura kosztowa do opisu", RelatedObjectId = 10, Date = "2014-03-13 13:59", Author = "M. Żołądek" });
            _workflowCommands.Add(new WorkflowCommand() { Id = 16, RelatedObjectName = GetVarioObjName(11), CommandName = "Proszę o uzupełnienie danych", RelatedObjectId = 11, Date = "2014-03-11 14:38", Author = "E.Patyra" });
            _workflowCommands.Add(new WorkflowCommand() { Id = 17, RelatedObjectName = GetVarioObjName(12), CommandName = "Faktura kosztowa do opisu", RelatedObjectId = 12, Date = "2014-03-11 14:24", Author = "K. Olejnicza" });
            //_workflowCommands.Add(new WorkflowCommand() { Id = 18, RelatedObjectName = GetVarioObjName(1), CommandName = "Formularz kooperacji do weryfikacji", RelatedObjectId = 1, Date = "2014-03-03 12:11", Author = "M. Żołądek" });
            _workflowCommands.Add(new WorkflowCommand() { Id = 19, RelatedObjectName = GetVarioObjName(13), CommandName = "Proszę o uzupełnienie danych na załączonej fakturze kosztowej", RelatedObjectId = 13, Date = "2014-02-12 08:39", Author = "E.Patyra" });
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


        public IList<VarioObject> GetObjects()
        {
            return _varioObjects; ;
        }

        public int GetCommandsCount()
        {
            return _workflowCommands.Count;
        }
    }
}