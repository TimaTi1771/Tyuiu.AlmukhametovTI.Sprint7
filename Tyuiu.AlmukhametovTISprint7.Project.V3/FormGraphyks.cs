using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.AlmukhametovTI.Sprint7.Project.V3.Lib;

namespace Tyuiu.AlmukhametovTISprint7.Project.V3
{
    public partial class FormGraphyks : Form
    {
        public FormGraphyks()
        {
            InitializeComponent();
            openFileDialog_ATI.Filter = "Значения, разделенные запятыми(*.xlsx)|*.xlsx|Всефайлы(*.*)|*.*";
        }

        private void ToolStripMenuItemHelp_ATI_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void ToolStripMenuItemOpenGiued_ATI_Click(object sender, EventArgs e)
        {
            FormGuied formGuied = new FormGuied();
            formGuied.Show();
        }

        private void ToolStripMenuItemBack_ATI_Click(object sender, EventArgs e)
        {
            this.Close();
            FormMain formMain = new FormMain();
            formMain.Show();
        }

        private void ToolStripMenuItemSaveGraphiks_ATI_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog_ATI.FileName = ".xlsx";
                saveFileDialog_ATI.InitialDirectory = @":C";
                saveFileDialog_ATI.ShowDialog();
                string path = saveFileDialog_ATI.FileName;
                FileInfo fileInfo = new FileInfo(path);
                bool fileExists = fileInfo.Exists;
                if (fileExists)
                {
                    File.Delete(path);
                }
            }
            catch
            {
                MessageBox.Show("Файл не сохранен", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        static string openFile;
        static int rows;
        static int columns;
        DataService ds = new DataService();

        private void buttonOpenFile_ATI_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog_ATI.ShowDialog();
                openFile = openFileDialog_ATI.FileName;

                string[,] matrix = ds.LoadFromDataFile(openFile);
                rows = matrix.GetLength(0);
                columns = matrix.GetLength(1);
                dataGridViewGraphyks_ATI.RowCount = 250;
                dataGridViewGraphyks_ATI.ColumnCount = 50;

                for (int i = 0; i < rows; i++)
                {
                    dataGridViewGraphyks_ATI.Columns[i].Width = 135;
                }
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        dataGridViewGraphyks_ATI.Rows[i].Cells[j].Value = matrix[i, j];
                    }
                }
            }
            catch
            {
                MessageBox.Show("Файл не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSaveFile_ATI_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog_ATI.FileName = ".xlsx";
                saveFileDialog_ATI.InitialDirectory = @":C";
                saveFileDialog_ATI.ShowDialog();
                string path = saveFileDialog_ATI.FileName;
                FileInfo fileInfo = new FileInfo(path);
                bool fileExists = fileInfo.Exists;
                if (fileExists)
                {
                    File.Delete(path);
                }
            }
            catch
            {
                MessageBox.Show("Файл не сохранен", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }   
}
