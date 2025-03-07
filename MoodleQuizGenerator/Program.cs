using System.Data;

namespace MoodleQuizGenerator
{
    internal class Program
    {
        private static IModel modelXML = new ModelXML();
        private static IModel modelCSV = new ModelCSV();
        private static IView view = new View();
        private static IController controller = new Controller();
        static void Main(string[] args)
        {
            modelXML.View = view;
            modelXML.Controller = controller;
            view.Model = modelXML;
            view.Controller = controller;
            controller.Model = modelXML;
            controller.View = view;

            string praefix = "Aufgabe";

            // ACHTUNG: Diese Klasse ist rein mit KI erzeugt.
            Kommandozeilenargumente kommandozeilenargumente = new Kommandozeilenargumente(args);

            // Kommandozeilenargument fuer die Abfrage, ob die Anzahl an Quizfragen festgelegt wurde
            bool anzahlFragenFix = true;
            if (kommandozeilenargumente.IstArgumentVorhanden("-f"))
            {
                string anzahlFragenFixStr = kommandozeilenargumente.HoleArgument("-f");
                if (anzahlFragenFixStr.ToLower() == "false")
                {
                    anzahlFragenFix = false;
                }
            }

            if (kommandozeilenargumente.IstArgumentVorhanden("-p"))
            {
                praefix = kommandozeilenargumente.HoleArgument("-p");
                Console.WriteLine("Suche nach Dateien mit Praefix:" + praefix);
            }
            else
            {
                Console.Write("Praefix: ");
                praefix = Console.ReadLine();
            }
            List<Quizfrage> quizfragen = modelCSV.suchen(new Quizfrage("", "", new List<string>(), new List<string>()), praefix, anzahlFragenFix);

            // Dateiname der XML-Datei-Ausgabe mit klarem Bezug versehen
            (modelXML as ModelXML).Path = praefix + ".xml";

            foreach (Quizfrage quizfrage in quizfragen)
            {
                modelXML.speichern(quizfrage);
            }
             
            Console.WriteLine("Ende!");
            Console.ReadLine();

            
        }
    }
}
