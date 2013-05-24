using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LumenWorks.Framework.IO.Csv;
using System.IO;
using System.Windows.Forms;

namespace car
{
    class CSV
    {
        public CSV(string pathcsv)
        {
            this.pathcsv = pathcsv;
        }

        string pathcsv = "";    

        public void Add(List<string> row)
        {
            var sb = new StringBuilder();
            using (var wr = new StreamWriter(pathcsv, true, System.Text.Encoding.UTF8))
            {
                foreach (string value in row)
                {

                    sb.Append(value);
                    sb.Append(";");


                }              
                wr.WriteLine(sb.ToString());
            }
        }

        public CsvReader connect()
        {
            CsvReader csv = new CsvReader(new StreamReader(pathcsv), true, ';');
            return csv;
        }

        public void Remove(int idFile)
        {
            string line;
            string[] stroka;
            int n = 0;
            int j = 0;
            using (var read = new StreamReader(pathcsv, true))
            {
                while ((line = read.ReadLine()) != null && n == 0)
                {
                    stroka = line.Split(';');                  
                        if (stroka[0].Contains(idFile.ToString()))
                        {
                            n = j;
                            break;
                        }                   
                    j++;
                }

            }
            List<string> lines = File.ReadLines(pathcsv).ToList();            
            lines.RemoveAt(n);            
            //lines.Add(Environment.NewLine);
            File.WriteAllText(pathcsv, string.Join(Environment.NewLine, lines));

            using (var wr = new StreamWriter(pathcsv, true, System.Text.Encoding.UTF8))
            {
                wr.WriteLine();
            }
        }

        public void Edit(int idFile, string st)
        {
            string line;
            string[] stroka;
            int n = 0;
            int j = 0;
            using (var read = new StreamReader(pathcsv, true))
            {
                while ((line = read.ReadLine()) != null && n == 0)
                {
                    stroka = line.Split(';');
                    if (stroka[0].Contains(idFile.ToString()))
                    {
                        n = j;
                        break;
                    }
                    j++;
                }

            }           
            List<string> lines = File.ReadLines(pathcsv).ToList();
            lines.RemoveAt(n);
            lines.Insert(n, st);

            File.WriteAllText(pathcsv, string.Join(Environment.NewLine, lines));

            using (var wr = new StreamWriter(pathcsv, true, System.Text.Encoding.UTF8))
            {
                wr.WriteLine();
            }
        }

        public int Find(string st)
        {
            string line;
            string[] stroka;
            int n = 0;
            int j = 0;
            using (var read = new StreamReader(pathcsv, true))
            {
                while ((line = read.ReadLine()) != null && n == 0)
                {
                    stroka = line.Split(';');
                    for (int i = 0; i < stroka.Length; i++)
                    {
                        if (stroka[i].Contains(st))
                        {
                            n = int.Parse(stroka[0]);
                        }
                    }
                    j++;
                }

            }
            return n;
        }

        public string lastId()
        {
            using (CsvReader csv = new CsvReader(new StreamReader(pathcsv), true, ';'))
            {
                int n = csv.Count();
                if (n == 0)
                    return "0";
                else
                    return csv[n - 1, 0];
            }            
        }     

    }



       
}
