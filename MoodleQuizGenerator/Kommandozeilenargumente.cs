namespace MoodleQuizGenerator
{
    // ACHTUNG: Eine Klasse mit KI erzeugt, mit der man
    // Kommandozeilenargumente organisieren kann.
    // Hier muss besonders viel kontrolliert werden.
    class Kommandozeilenargumente
    {
        public string[] Argumente { get; private set; }
        public Kommandozeilenargumente(string[] args)
        {
            Argumente = args;
        }

        public string HoleArgument(string argument)
        {
            for (int i = 0; i < Argumente.Length; i++)
            {
                if (Argumente[i] == argument)
                {
                    if (i + 1 < Argumente.Length)
                    {
                        return Argumente[i + 1];
                    }
                    else
                    {
                        throw new ArgumentException("Fehlendes Argument für " + argument);
                    }
                }
            }
            throw new ArgumentException("Argument " + argument + " nicht gefunden");
        }
        public bool IstArgumentVorhanden(string argument)
        {
            for (int i = 0; i < Argumente.Length; i++)
            {
                if (Argumente[i] == argument)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
