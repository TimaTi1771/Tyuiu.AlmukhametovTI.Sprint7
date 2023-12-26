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
            buttonAdd_ATI.Visible = false;
            buttonDelete_ATI.Visible = false;
            buttonAddGraphyks_ATI.Visible = false;
            buttonDeleteGraphuks_ATI.Visible = false;
           // splitContainerFunction_ATI.Visible = false;

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

        static string openFile;
        static int rows;
        static int columns;
        static string[,] matrix;
        DataService ds = new DataService();

        private void buttonOpenFile_ATI_Click(object sender, EventArgs e)
        {
            try
            {
                buttonDelete_ATI.Visible = true;
                buttonAdd_ATI.Visible = true;
                buttonAddGraphyks_ATI.Visible = true;
                buttonDeleteGraphuks_ATI.Visible = true;
                splitContainerFunction_ATI.Visible = true;

                openFileDialog_ATI.ShowDialog();
                openFile = openFileDialog_ATI.FileName;

                matrix = ds.LoadFromDataFile(openFile);
                rows = matrix.GetLength(0);
                columns = matrix.GetLength(1);

                dataGridViewOpenFile_ATI.Rows.Clear();
                dataGridViewOpenFile_ATI.Columns.Clear();
                dataGridViewOpenFile_ATI.RowCount = rows + 1;
                dataGridViewOpenFile_ATI.ColumnCount = columns + 10;

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        dataGridViewOpenFile_ATI.Rows[i].Cells[j].Value = matrix[i, j];
                        dataGridViewOpenFile_ATI.Rows[i].Cells[j].Selected = false;
                    }
                }
                this.dataGridViewOpenFile_ATI.DefaultCellStyle.Font = new Font("Tahoma", 9);
                dataGridViewOpenFile_ATI.AutoResizeColumns();
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
                saveFileDialog_ATI.FileName = ".csv";
                saveFileDialog_ATI.InitialDirectory = @":C";
                if (saveFileDialog_ATI.ShowDialog() == DialogResult.OK)
                {
                    string savepath = saveFileDialog_ATI.FileName;

                    if (File.Exists(savepath)) File.Delete(savepath);

                    int rows = dataGridViewOpenFile_ATI.RowCount - 1;
                    int columns = dataGridViewOpenFile_ATI.ColumnCount - 1;

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

        private void buttonDelete_ATI_Click(object sender, EventArgs e)
        {
            if (dataGridViewOpenFile_ATI.RowCount != 0)
            {
                int nugno = -1;
                for (int i = 0; i < dataGridViewOpenFile_ATI.RowCount - 1; i++)
                {
                    for (int j = 0; j < dataGridViewOpenFile_ATI.ColumnCount - 1; j++)
                    {
                        if (dataGridViewOpenFile_ATI.Rows[i].Cells[j].Selected == true)
                        {
                            nugno = j;
                            break;
                        }
                    }
                    if (nugno > -1) break;
                }
                if (nugno > -1)
                {
                    if (dataGridViewOpenFile_ATI.Rows[0].Cells[nugno].Selected == true) MessageBox.Show("Первую строку нельзя удалить", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        var result = MessageBox.Show($"{"Удалить данную строку?" + "\r"}{"Ее невозможно будет восстановить"}", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            int k = -1; int udal = 0;
                            for (int i = 1; i < dataGridViewOpenFile_ATI.RowCount - 1; i++)
                            {
                                if (dataGridViewOpenFile_ATI.Rows[i].Cells[nugno].Selected == true)
                                {
                                    k = i;
                                    break;
                                }
                                if (k > -1) break;
                            }
                            for (int i = 1; i < dataGridViewOpenFile_ATI.RowCount - 1; i++)
                            {
                                if (dataGridViewOpenFile_ATI.Rows[i].Cells[nugno].Selected == true) udal++;
                            }
                            for (int r = 0; r < udal; r++) dataGridViewOpenFile_ATI.Rows.Remove(dataGridViewOpenFile_ATI.Rows[k]);
                            for (int i = 0; i < dataGridViewOpenFile_ATI.RowCount - 1; i++)
                            {
                                for (int j = 0; j < dataGridViewOpenFile_ATI.ColumnCount - 1; j++)
                                {
                                    dataGridViewOpenFile_ATI.Rows[i].Cells[j].Selected = false;
                                }
                            }
                        }
                    }
                }
                else MessageBox.Show("Выберите строку, которую ходите удалить", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Файл не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonDeleteGraphuks_ATI_Click(object sender, EventArgs e)
        {
            if (dataGridViewOpenFile_ATI.RowCount != 0) chartFunction_ATI.Series[0].Points.Clear();
            else MessageBox.Show("Файл не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonAddGraphyks_ATI_Click(object sender, EventArgs e)
        {
            if (dataGridViewOpenFile_ATI.RowCount != 0)
            {
                if (dataGridViewOpenFile_ATI.RowCount > 2)
                {
                    int nugno = -1;
                    for (int i = 0; i < dataGridViewOpenFile_ATI.RowCount - 1; i++)
                    {
                        for (int j = 0; j < dataGridViewOpenFile_ATI.ColumnCount - 1; j++)
                        {
                            if (dataGridViewOpenFile_ATI.Rows[i].Cells[j].Value != null)
                            {
                                if (dataGridViewOpenFile_ATI.Rows[i].Cells[j].Selected == true)
                                {
                                    nugno = j;
                                    break;
                                }
                            }
                            if (nugno > -1) break;
                        }
                    }

                    if (nugno > -1)
                    {
                        int kaktak = 0;
                        for (int i = 0; i < dataGridViewOpenFile_ATI.RowCount - 1; i++)
                        {
                            if (dataGridViewOpenFile_ATI.Rows[i].Cells[0].Selected == true) kaktak++;
                        }
                        if (kaktak == 0)
                        {
                            int nadopodumati = 0;
                            for (int i = 1; i < dataGridViewOpenFile_ATI.RowCount - 1; i++)
                            {
                                if (dataGridViewOpenFile_ATI.Rows[i].Cells[nugno].Value != null)
                                {
                                    double cellValue;
                                    if (double.TryParse(dataGridViewOpenFile_ATI.Rows[i].Cells[nugno].Value.ToString(), out cellValue)) nadopodumati += 0;
                                    else if (dataGridViewOpenFile_ATI.Rows[i].Cells[nugno].ValueType.ToString().Any(char.IsLetter)) nadopodumati++;
                                }
                            }
                            if (nadopodumati == 0)
                            {
                                this.chartFunction_ATI.ChartAreas[0].AxisX.Title = "ID";
                                string name = Convert.ToString(dataGridViewOpenFile_ATI.Rows[0].Cells[nugno].Value);
                                this.chartFunction_ATI.ChartAreas[0].AxisY.Title = name;

                                int startValue = Convert.ToInt32(dataGridViewOpenFile_ATI.Rows[1].Cells[0].Value);
                                for (int i = 1; i < dataGridViewOpenFile_ATI.RowCount - 1; i++)
                                {
                                    this.chartFunction_ATI.Series[0].Points.AddXY(startValue, Convert.ToDouble(dataGridViewOpenFile_ATI.Rows[i].Cells[nugno].Value));
                                    startValue++;
                                }
                            }
                            else MessageBox.Show("Пожалуйста, выберите столбец с числами!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else MessageBox.Show("Нельзя выбрать первый столбец", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else MessageBox.Show("Не выбран столбец", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else MessageBox.Show("Нет данных для построения графика", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Файл не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }      
    }
}
