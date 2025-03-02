
namespace MoodleQuizGenerator
{
    internal class View : IView
    {
        private IModel model;
        private IController controller;
        IModel IView.Model { set => model=value; }
        IController IView.Controller { set => controller=value; }

        void IView.anzeigen(List<Quizfrage> quizfragenListe)
        {
            throw new NotImplementedException();
        }

        void IView.anzeigen(Quizfrage quizfrage)
        {
            throw new NotImplementedException();
        }
    }
}