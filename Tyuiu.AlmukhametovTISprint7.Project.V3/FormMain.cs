﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.AlmukhametovTI.Sprint7.Project.V3.Lib;

namespace Tyuiu.AlmukhametovTISprint7.Project.V3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            //openFileDialog_URI.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Всефайлы(*.*)|*.*";
        }

        private void перейтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void перейтиКРазделуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormGraphyks formGraphyks = new FormGraphyks();
            formGraphyks.Show();
        }

        private void открытьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormGuied formGuied = new FormGuied();
            formGuied.Show();
        }

        static string openFile;
        static int rows;
        static int columns;
        static string[,] matrix;
        DataService ds = new DataService();

        private void открытьToolStripMenuItemFile_ATI_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog_ATI.ShowDialog();
                openFile = openFileDialog_ATI.FileName;

                matrix = ds.LoadFromDataFile(openFile);
                rows = matrix.GetLength(0);
                columns = matrix.GetLength(1);
                dataGridViewOpenFile_ATI.RowCount = rows + 1;
                dataGridViewOpenFile_ATI.ColumnCount = columns + 1;

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        dataGridViewOpenFile_ATI.Rows[i].Cells[j].Value = matrix[i, j];
                        dataGridViewOpenFile_ATI.Rows[i].Cells[j].Selected = false;
                    }
                }
                dataGridViewOpenFile_ATI.AutoResizeColumns();
            }
            catch
            {
                MessageBox.Show("Файл не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void сохранитьToolStripMenuItemFile_ATI_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog_ATI.FileName = ".csv";
                saveFileDialog_ATI.InitialDirectory = @":C";
                if (saveFileDialog_ATI.ShowDialog() == DialogResult.OK)
                {
                    string savepath = saveFileDialog_ATI.FileName;

                    if (File.Exists(savepath)) File.Delete(savepath);

                    int rows = dataGridViewOpenFile_ATI.RowCount;
                    int columns = dataGridViewOpenFile_ATI.ColumnCount;

                    StringBuilder strBuilder = new StringBuilder();

                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < columns; j++)
                        {
                            strBuilder.Append(dataGridViewOpenFile_ATI.Rows[i].Cells[j].Value);

                            if (j != columns - 1) strBuilder.Append(";");
                        }
                        strBuilder.AppendLine();
                    }
                    File.WriteAllText(savepath, strBuilder.ToString(), Encoding.GetEncoding(1251));
                    MessageBox.Show("Файл успешно сохранен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Файл не сохранен", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        static string[,] mtrxSearch;
        private void textBoxSearch_ATI_KeyDown(object sender, KeyEventArgs e)
        {
            if (dataGridViewOpenFile_ATI.RowCount != 0)
            {
                mtrxSearch = new string[dataGridViewOpenFile_ATI.RowCount, dataGridViewOpenFile_ATI.ColumnCount];
                for (int i = 0; i < dataGridViewOpenFile_ATI.RowCount - 1; i++)
                {
                    for (int j = 0; j < dataGridViewOpenFile_ATI.ColumnCount - 1; j++)
                    {
                        mtrxSearch[i, j] = Convert.ToString(dataGridViewOpenFile_ATI.Rows[i].Cells[j].Value);
                        dataGridViewOpenFile_ATI.Rows[i].Cells[j].Selected = false;
                    }
                }
            }
            else MessageBox.Show("Файл не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void textBoxSearch_ATI_KeyUp(object sender, KeyEventArgs e)
        {
            for (int i = 0; i < dataGridViewOpenFile_ATI.RowCount - 1; i++)
            {
                for (int j = 0; j < dataGridViewOpenFile_ATI.ColumnCount - 1; j++)
                {
                    dataGridViewOpenFile_ATI.Rows[i].Cells[j].Selected = false;
                }
            }
            if (e.KeyCode == Keys.Enter)
            {
                for (int i = 0; i < dataGridViewOpenFile_ATI.RowCount - 1; i++)
                {
                    for (int j = 0; j < dataGridViewOpenFile_ATI.ColumnCount - 1; j++)
                    {
                        if (dataGridViewOpenFile_ATI.Rows[i].Cells[j].Value != null)
                        {
                            string elmnt = dataGridViewOpenFile_ATI.Rows[i].Cells[j].Value.ToString().ToLower();
                            if (elmnt.Contains(textBoxSearch_ATI.Text.ToLower())) dataGridViewOpenFile_ATI.Rows[i].Cells[j].Selected = true;
                        }
                    }
                }

                int clear = 0;
                for (int r = 1; r < dataGridViewOpenFile_ATI.RowCount - 1; r++)
                {
                    for (int c = 0; c < dataGridViewOpenFile_ATI.ColumnCount - 1; c++)
                    {
                        if (dataGridViewOpenFile_ATI.Rows[r].Cells[c].Selected == true) clear += 1;
                    }
                    if (clear == 0) dataGridViewOpenFile_ATI.Rows[r].Visible = false;
                    else
                    {
                        dataGridViewOpenFile_ATI.Rows[r].Visible = true;
                        clear = 0;
                    }
                }
            }
            else MessageBox.Show("Файл не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void textBoxSearch_ATI_KeyPress(object sender, KeyPressEventArgs e)
        {
            for (int i = 0; i < dataGridViewOpenFile_ATI.RowCount - 1; i++)
            {
                for (int j = 0; j < dataGridViewOpenFile_ATI.ColumnCount - 1; j++)
                {
                    dataGridViewOpenFile_ATI.Rows[i].Cells[j].Value = mtrxSearch[i, j];
                    dataGridViewOpenFile_ATI.Rows[i].Cells[j].Selected = false;
                }
            }
        }

        private void buttonDelete_ATI_Click(object sender, EventArgs e)
        {
            if (dataGridViewOpenFile_ATI.RowCount != 0)
            {
                int konechno = 0;
                var result = MessageBox.Show($"{"Удалить данную строку?" + "\r"}{"Ее невозможно будет восстановить"}", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes) konechno = 1;
                if (konechno == 1)
                {
                    int a = dataGridViewOpenFile_ATI.CurrentCell.RowIndex;
                    dataGridViewOpenFile_ATI.Rows.Remove(dataGridViewOpenFile_ATI.Rows[a]);
                }
            }
            else MessageBox.Show("Файл не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonAdd_ATI_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewOpenFile_ATI.Rows.Add();
            }
            catch
            {
                MessageBox.Show("Файл не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}