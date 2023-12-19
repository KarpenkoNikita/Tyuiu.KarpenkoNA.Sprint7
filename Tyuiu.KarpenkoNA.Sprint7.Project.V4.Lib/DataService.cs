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
            string fileData = File.ReadAllText(filePath);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            int rows, columns;
            rows = lines.Length;
            columns = lines[0].Split(';').Length;
            string[,] arrayValue = new string[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                string[] line_r = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    arrayValue[i, j] = Convert.ToString(line_r[j]);
                }
            }
            return arrayValue;
        }
    }
}
