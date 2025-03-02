namespace MoodleQuizGenerator
{
    public class Quizfrage
    {
        private string fragennummer;
        private string frage;
        private string antwort1;
        private string fraction1;
        private string antwort2;
        private string fraction2;
        private string antwort3;
        private string fraction3;
        private string antwort4;
        private string fraction4;
        private string antwort5;
        private string fraction5;

        public string Fragennummer { get => fragennummer; set => fragennummer = value; }
        public string Frage { get => frage; set => frage = value; }
        public string Antwort1 { get => antwort1; set => antwort1 = value; }
        public string Fraction1 { get => fraction1; set => fraction1 = value; }
        public string Antwort2 { get => antwort2; set => antwort2 = value; }
        public string Fraction2 { get => fraction2; set => fraction2 = value; }
        public string Antwort3 { get => antwort3; set => antwort3 = value; }
        public string Fraction3 { get => fraction3; set => fraction3 = value; }
        public string Antwort4 { get => antwort4; set => antwort4 = value; }
        public string Fraction4 { get => fraction4; set => fraction4 = value; }
        public string Antwort5 { get => antwort5; set => antwort5 = value; }
        public string Fraction5 { get => fraction5; set => fraction5 = value; }

        public Quizfrage(string fragennummer,string frage,
                            string antwort1,string fraction1,
                            string antwort2, string fraction2,
                            string antwort3, string fraction3,
                            string antwort4, string fraction4,
                            string antwort5, string fraction5)
        {
            Fragennummer=fragennummer;
            Frage = frage;
            Antwort1=antwort1;
            Antwort2=antwort2;
            Antwort3=antwort3;
            Antwort4=antwort4;
            Antwort5=antwort5;
            Fraction1=fraction1;
            Fraction2=fraction2;
            Fraction3=fraction3;
            Fraction4=fraction4;
            Fraction5=fraction5;
        }
    }
}