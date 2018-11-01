using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using OptimizationGlobals;
using System.Collections.ObjectModel;

namespace Communication
{
    public enum FileType { TXT, XLSX };

    class LagrangeInterpolation
    {
        private List<Vector> vectors;

        public ReadOnlyCollection<Vector> Vectors { get { return this.vectors.AsReadOnly(); } }

        public LagrangeInterpolation()
        {
            this.vectors = new List<Vector>();
        }

        public bool LoadFile(string path, FileType fileType)
        {
            //funkcja ktora wcyzta dane i zapisze je do list "vectors"
            //przyklad

            this.vectors.Clear();
            if (fileType == FileType.TXT)
            {
                //staramy sie wczytac plik txt
                try
                {
                    using (TextReader reader = new StreamReader(path))
                    {
                        try
                        {
                            //wczytujemy jedna linijke
                            string line = reader.ReadLine();

                            //funkcja ktora zamienia na punkty na vektor
                            Vector vector = new Vector();
                            vector.Values.Add(5); // punkty z pliku a nie 5


                            // na sam koniec dodajemy do listy
                            this.vectors.Add(vector);
                        }
                        catch (Exception ex)
                        {
                            //przy wczytywaniu cos poszlo nie tak
                            //dodajmy np licznik niepowodzen. jesli niew czytalo nam 5 linijek to retrun false
                            //jesli to tylko kilka linijek to mozemy kontynuowac bez przerwania
                            /*
                             * line_errors++;
                             * if(Debug.DebugState)
                             * {
                             *      Debug.Show(ex.Message);
                             * }
                             * if(line_errors == 5)
                             * {
                             *      return false;
                             * }
                             */
                        }
                    }
                }
                catch (Exception ex)
                {
                    if (Debug.DebugState)
                    {
                        Debug.Show(ex.Message);
                    }
                    throw new CommunicationException(CommunicationExceptionType.CannotLoadFile);
                }
            }
            else if (fileType == FileType.XLSX)
            {
                //staramy sie wczytac plik excela
            }

            //dotarlismy do konca wiec udalo sie wczytac plik
            return true;
        }

        public bool GenerateFunctionExpression(out string result, out string variables)
        {
            //funkcja bedzie wywolana po wczytaniu pliku wiec lista vektorow jest juz zapelniona
            //dla pewnosci mozna to jednak sprawdzic
            //ustawiamy domniemany result przed wyrzuceniem wyniku funkcji
            string function_expression = string.Empty;
            string function_variables = string.Empty;

            if (this.vectors.Count == 0)
            {
                result = string.Empty;
                variables = string.Empty;
                return false;
            }
            //mamy pewnosc ze mmay jakies vektory
            //this.vectors.Count mowi nam o ilosci wektorów czyli np: (-2,2), (5,6) =>mamy 2 wektory
            //this.vectors[0].Values.Count mowi nam o wielkosci wektora (w tym przypadku zeroweg) - (-3,2,4) da nam 3 bo wektor ma 3 punkty

            //petla przez wszystkie pary punkty - wektorow
            for (int i=0; i<this.vectors.Count; i++)
            {
                //petla przez wszystkie punkty w wektorze i
                for(int j=0; j<this.vectors[i].Values.Count; j++)
                {
                    //this.vectors[i].Values[j]
                }
            }

            result = function_expression;
            variables = function_variables;
            return true;
        }
    }
}
