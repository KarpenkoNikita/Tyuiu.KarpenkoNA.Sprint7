using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.KarpenkoNA.Sprint7.Project.V4.Lib;
using System.IO;

namespace Tyuiu.KarpenkoNA.Sprint7.Project.V4
{
    public partial class FormMain_KNA : Form
    {
        public FormMain_KNA()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        string openFilePath;
        int columns, rows;

        private void buttonHelp_KNA_Click(object sender, EventArgs e)
        {
            FormAbout formabout = new FormAbout();
            formabout.ShowDialog();
        }

        private void buttonAddBook_KNA_Click(object sender, EventArgs e)
        {
            dataGridViewData_KNA.Rows.Add();
            for (int i = 0; i < dataGridViewData_KNA.Rows.Count; i++)
            {
                dataGridViewData_KNA.Rows[i].Cells[0].Value = i;
            }
        }

        private void buttonSave_KNA_Click(object sender, EventArgs e)
        {
            saveFileDialogTable_KNA.FileName = "OutPutFileProject.csv";
            saveFileDialogTable_KNA.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogTable_KNA.ShowDialog();

            string path = saveFileDialogTable_KNA.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewData_KNA.RowCount;
            int columns = dataGridViewData_KNA.ColumnCount;
            string header = "";
            for (int j = 0; j < columns; j++)
            {
                if (j != columns - 1)
                {
                    header += dataGridViewData_KNA.Columns[j].HeaderText + ";";
                }
                else
                {
                    header += dataGridViewData_KNA.Columns[j].HeaderText;
                }
            }
            File.AppendAllText(path, header + Environment.NewLine, Encoding.UTF8);


            for (int i = 0; i < rows; i++)
            {
                string str = "";
                for (int j = 0; j < columns; j++)
                {

                    if (j != columns - 1)
                    {
                        str += dataGridViewData_KNA.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str += dataGridViewData_KNA.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine, Encoding.UTF8);

            }
        }

        private void openToolStripMenuItem_KNA_Click(object sender, EventArgs e)
        {
            openFileDialogTable_KNA.ShowDialog();
            openFilePath = openFileDialogTable_KNA.FileName;

            string[,] arrayValues = ds.LoadFromDataFile(openFilePath);
            dataGridViewData_KNA.ColumnCount = columns = arrayValues.GetLength(1);
            dataGridViewData_KNA.RowCount = rows = arrayValues.GetLength(0);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewData_KNA.Rows[i].Cells[j].Value = arrayValues[i, j];
                }
            }

            for (int i = 0; i < rows; i++)
            {
                if (arrayValues[i, 5] == "True")
                    dataGridViewData_KNA.Rows[i].Cells[5].Value = true;
                else
                    dataGridViewData_KNA.Rows[i].Cells[5].Value = false;
            }
        }

        private void saveToolStripMenuItem_KNA_Click(object sender, EventArgs e)
        {
            Encoding encoding = Encoding.Default;
            saveFileDialogTable_KNA.FileName = "OutPutFileProject.csv";
            saveFileDialogTable_KNA.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogTable_KNA.ShowDialog();

            string path = saveFileDialogTable_KNA.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewData_KNA.RowCount;
            int columns = dataGridViewData_KNA.ColumnCount;
            string header = "";
            for (int j = 0; j < columns; j++)
            {
                if (j != columns - 1)
                {
                    header += dataGridViewData_KNA.Columns[j].HeaderText + ";";
                }
                else
                {
                    header += dataGridViewData_KNA.Columns[j].HeaderText;
                }
            }
            File.AppendAllText(path, header + Environment.NewLine);


            for (int i = 0; i < rows; i++)
            {
                string str = "";
                for (int j = 0; j < columns; j++)
                {

                    if (j != columns - 1)
                    {
                        str += dataGridViewData_KNA.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str += dataGridViewData_KNA.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
            }

        }

        private void addToolStripMenuItem_KNA_Click(object sender, EventArgs e)
        {
            dataGridViewData_KNA.Rows.Add();
            for (int i = 0; i < dataGridViewData_KNA.Rows.Count; i++)
            {
                dataGridViewData_KNA.Rows[i].Cells[0].Value = i;
            }

        }



        private void infoToolStripMenuItem_KNA_Click(object sender, EventArgs e)
        {
            FormAbout formabout = new FormAbout();
            formabout.ShowDialog();
        }

        private void ToolStripAboutProgram_KNA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данная программа это приложение-библиотека, которая держит в себе информацию о книгах пользователя и позволяет добавлять новые книги, которые хочет прочитать пользователь и хранит уже прочитанные. ", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitToolStripExit_KNA_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonOpen_KNA_Click(object sender, EventArgs e)
        {
            openFileDialogTable_KNA.ShowDialog();
            openFilePath = openFileDialogTable_KNA.FileName;

            string[,] arrayValues = ds.LoadFromDataFile(openFilePath);
            dataGridViewData_KNA.RowCount = rows = arrayValues.GetLength(0);
            dataGridViewData_KNA.ColumnCount = columns = arrayValues.GetLength(1);
            

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewData_KNA.Rows[i].Cells[j].Value = arrayValues[i, j];
                }
            }

            for (int i = 0; i < rows; i++)
            {
                if (arrayValues[i, 5] == "True")
                    dataGridViewData_KNA.Rows[i].Cells[5].Value = true;
                else
                    dataGridViewData_KNA.Rows[i].Cells[5].Value = false;
            }
        }


       


    }
}
