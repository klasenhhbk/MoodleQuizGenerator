namespace MoodleQuizGenerator
{
    internal interface IModel
    {
        IController Controller { set; }
        IView View { set; }

        void speichern(Quizfrage quizfrage);
        List<Quizfrage> suchen(Quizfrage quizfrage);
        List<Quizfrage> suchen(Quizfrage quizfrage, string praefix);
        void loeschen(Quizfrage quizfrage);
    }
}