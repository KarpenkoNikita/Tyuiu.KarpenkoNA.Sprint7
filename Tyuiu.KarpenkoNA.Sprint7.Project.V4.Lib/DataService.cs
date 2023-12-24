using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;



namespace Tyuiu.KarpenkoNA.Sprint7.Project.V4.Lib
{
    public class DataService
    {
        public string[,] LoadFromDataFile(string filePath)
        {
            string fileDta = File.ReadAllText(filePath);
            fileDta = fileDta.Replace('\n', '\r');
            string[] lines = fileDta.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            if (lines.Length < 2)
            {
                return null;
            }

            int rows, columns;
            rows = lines.Length - 1;
            columns = lines[0].Split(';').Length;

            string[,] arrayValues = new string[rows, columns];

            for (int i = 1; i < lines.Length; i++)
            {
                string[] line_r = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    arrayValues[i - 1, j] = Convert.ToString(line_r[j]);
                }
            }

            return arrayValues;
        }
    }
}
