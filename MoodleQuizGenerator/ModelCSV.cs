namespace MoodleQuizGenerator
{
    internal class ModelCSV : IModel
    {
        IController IModel.Controller { set => throw new NotImplementedException(); }
        IView IModel.View { set => throw new NotImplementedException(); }

        void IModel.loeschen(Quizfrage quizfrage)
        {
            throw new NotImplementedException();
        }

        void IModel.speichern(Quizfrage quizfrage)
        {
            throw new NotImplementedException();
        }

        List<Quizfrage> IModel.suchen(Quizfrage quizfrage, string praefix)
        {
            List<Quizfrage> ergebnis= new List<Quizfrage>();
            Quizfrage treffer = new Quizfrage("", "", "", "", "", "", "", "", "", "", "", "");

            try
            {
                // Set a variable to the My Documents path.
                string docPath = ".";
                //Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                var files = Directory.EnumerateFiles(docPath, "*.csv", SearchOption.AllDirectories);
                foreach (string dateiname in files)
                {
                    List<string> list = new List<string>();
                    using (StreamReader r = new StreamReader(dateiname))
                    {
                        string line;
                        while ((line = r.ReadLine()) != null)
                        {
                            list.Add(line);
                        }
                    }

                    foreach (string line in list)
                    {
                        string[] subs = line.Split(';');
                        int number = 0;
                        treffer = new Quizfrage("", "", "", "", "", "", "", "", "", "", "", "");
                        if (subs.Length == 12)
                        {
                            if (int.TryParse(subs[0], out number))
                            {
                                if (subs[0]!=""
                                    && subs[1] != ""
                                    && subs[2] != ""
                                    && subs[3] != ""
                                    && subs[4] != ""
                                    && subs[5] != ""
                                    && subs[6] != ""
                                    && subs[7] != ""
                                    && subs[8] != ""
                                    && subs[9] != ""
                                    && subs[10] != ""
                                    && subs[11] != ""
                                    ) {
                                    int rcount = 0;
                                    string fractionR = "0";
                                    string fractionF = "0";

                                    treffer.Fragennummer = subs[0];
                                    treffer.Frage = subs[1];
                                    treffer.Antwort1 = subs[2];
                                    if (subs[3].ToUpper() == "R")
                                        rcount++;
                                    treffer.Antwort2 = subs[4];
                                    if (subs[5].ToUpper() == "R")
                                        rcount++;
                                    treffer.Antwort3 = subs[6];
                                    if (subs[7].ToUpper() == "R")
                                        rcount++;
                                    treffer.Antwort4 = subs[8];
                                    if (subs[9].ToUpper() == "R")
                                        rcount++;
                                    treffer.Antwort5 = subs[10];
                                    if (subs[11].ToUpper() == "R")
                                        rcount++;

                                    fractionR = Convert.ToString(
                                                                    Math.Round(
                                                                                (100 / Convert.ToDouble(rcount))
                                                                                , 5
                                                                               )
                                                                    , new System.Globalization.CultureInfo("en-US")
                                                                );
                                    fractionF = Convert.ToString(
                                                                    Math.Round(
                                                                                ((double)-100.0 / ((double)5.0 - Convert.ToDouble(rcount)))
                                                                                , 5
                                                                                )
                                                                    , new System.Globalization.CultureInfo("en-US")

                                                                );

                                    if (subs[3].ToUpper() == "R")
                                        treffer.Fraction1 = fractionR;
                                    else
                                        treffer.Fraction1 = fractionF;
                                    if (subs[5].ToUpper() == "R")
                                        treffer.Fraction2 = fractionR;
                                    else
                                        treffer.Fraction2 = fractionF;
                                    if (subs[7].ToUpper() == "R")
                                        treffer.Fraction3 = fractionR;
                                    else
                                        treffer.Fraction3 = fractionF;
                                    if (subs[9].ToUpper() == "R")
                                        treffer.Fraction4 = fractionR;
                                    else
                                        treffer.Fraction4 = fractionF;
                                    if (subs[11].ToUpper() == "R")
                                        treffer.Fraction5 = fractionR;
                                    else
                                        treffer.Fraction5 = fractionF;


                                    ergebnis.Add(treffer);
                                }
                                else {
                                    if ((dateiname.Split(praefix)).Length > 1)
                                    {
                                        Console.WriteLine((dateiname.Split(praefix)[1]).Split(".csv")[0] +
                                            " wie wäre es mit Inhalt?");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Was ist das denn?? Weder Inhalt noch Dateiname richtig!");
                                        Console.WriteLine(dateiname);
                                    }
                                }
                            }
                        }
                        else
                        {
                           
                            try
                            {
                                Console.Write((dateiname.Split(praefix)[1]).Split(".csv")[0]);

                                Console.WriteLine(" Incorrect length(" + subs.Length + ") in file");// + dateiname);
                                                                                                   //Console.WriteLine("Length:"+);
                            }
                            catch(Exception exc)
                            {
                                Console.WriteLine("Weder Länge noch Name der Datei stimmt:");
                                Console.WriteLine(dateiname);
                            }
                        }
                    }
                }

            }
            catch (UnauthorizedAccessException uAEx)
            {
                Console.WriteLine(uAEx.Message);
            }
            catch (PathTooLongException pathEx)
            {
                Console.WriteLine(pathEx.Message);
            }
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Modelcsv");
            //    //Console.WriteLine(files);
            //    Console.WriteLine(ex.Message);
            //}

            return ergebnis;
        }

        List<Quizfrage> IModel.suchen(Quizfrage quizfrage)
        {
            throw new NotImplementedException();
        }
    }
}
