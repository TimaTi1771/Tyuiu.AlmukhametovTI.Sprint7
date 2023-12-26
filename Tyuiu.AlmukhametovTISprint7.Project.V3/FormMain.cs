using System;
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
                //this.dataGridViewOpenFile_URI.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 9);
                //this.dataGridViewOpenFile_URI.DefaultCellStyle.Font = new Font("Segoe UI", 9);
                //this.dataGridViewOpenFile_URI.DefaultCellStyle.Font = new Font("Arial", 10.99F, GraphicsUnit.Pixel);
                this.dataGridViewOpenFile_ATI.DefaultCellStyle.Font = new Font("Tahoma", 9);
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
                for (int i = 0; i < mtrxSearch.GetUpperBound(0); i++)
                {
                    for (int j = 0; j < mtrxSearch.GetUpperBound(1); j++)
                    {
                        mtrxSearch[i, j] = Convert.ToString(dataGridViewOpenFile_ATI.Rows[i].Cells[j].Value);
                        dataGridViewOpenFile_ATI.Rows[i].Cells[j].Selected = false;
                    }
                }

                textBoxQuantity_ATI.Text = "";
                textBoxSum_ATI.Text = "";
                textBoxMiddleValue_ATI.Text = "";
                textBoxMinValue_ATI.Text = "";
                textBoxMaxValue_ATI.Text = "";
            }
            else MessageBox.Show("Файл не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    

        private void textBoxSearch_ATI_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                for (int i = 0; i < mtrxSearch.GetUpperBound(0); i++)
                {
                    for (int j = 0; j < mtrxSearch.GetUpperBound(1); j++)
                    {
                        if (mtrxSearch[i, j] != null)
                        {
                            string elmnt = mtrxSearch[i, j].ToLower();
                            if (elmnt.Contains(textBoxSearch_ATI.Text.ToLower())) dataGridViewOpenFile_ATI.Rows[i].Cells[j].Selected = true;
                        }
                    }
                }
            }
        }

        static string[,] mtrxSort;
        static int tralivali = 0;
        private void comboBoxSort_ATI_KeyDown(object sender, KeyEventArgs e)
        {
            if (dataGridViewOpenFile_ATI.RowCount != 0)
            {
                mtrxSort = new string[dataGridViewOpenFile_ATI.RowCount, dataGridViewOpenFile_ATI.ColumnCount];
                for (int i = 0; i < dataGridViewOpenFile_ATI.RowCount - 1; i++)
                {
                    for (int j = 0; j < dataGridViewOpenFile_ATI.ColumnCount - 1; j++)
                    {
                        mtrxSort[i, j] = Convert.ToString(dataGridViewOpenFile_ATI.Rows[i].Cells[j].Value);
                    }
                }
                tralivali++;

                int vozmogno = 0; int k = -1;
                for (int i = 1; i < dataGridViewOpenFile_ATI.RowCount - 1; i++)
                {
                    for (int j = 0; j < dataGridViewOpenFile_ATI.ColumnCount; j++)
                    {
                        if (dataGridViewOpenFile_ATI.Rows[i].Cells[j].Value == null) vozmogno++;
                    }
                    if (vozmogno == dataGridViewOpenFile_ATI.ColumnCount)
                    {
                        k = i;
                        break;
                    }
                    else vozmogno = 0;
                }
                if (k > 0) MessageBox.Show("Пожалуйста, удалите все пустые строки, кроме последней", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Файл не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void comboBoxSort_ATI_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSort_ATI.SelectedItem != null && dataGridViewOpenFile_ATI.RowCount != 0)
            {
                int vozmogno = 0; int k = -1;
                for (int i = 1; i < dataGridViewOpenFile_ATI.RowCount - 1; i++)
                {
                    for (int j = 0; j < dataGridViewOpenFile_ATI.ColumnCount; j++)
                    {
                        if (dataGridViewOpenFile_ATI.Rows[i].Cells[j].Value == null) vozmogno++;
                    }
                    textBoxMaxValue_ATI.Text = Convert.ToString(vozmogno);
                    if (vozmogno == dataGridViewOpenFile_ATI.ColumnCount)
                    {
                        k = i;
                        break;
                    }
                    else vozmogno = 0;
                }
                if (k > 0) MessageBox.Show("Пожалуйста, удалите все пустые строки, кроме последней", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    int kakbuda = 0;
                    for (int i = 0; i < dataGridViewOpenFile_ATI.RowCount - 1; i++)
                    {
                        for (int j = 0; j < dataGridViewOpenFile_ATI.ColumnCount - 1; j++)
                        {
                            if (dataGridViewOpenFile_ATI.Rows[i].Cells[j].Selected == false) kakbuda++;
                        }
                    }
                    if (kakbuda != (dataGridViewOpenFile_ATI.RowCount - 1) * (dataGridViewOpenFile_ATI.ColumnCount - 1))
                    {
                        int columnIndex = -1;
                        for (int i = 0; i < dataGridViewOpenFile_ATI.RowCount - 1; i++)
                        {
                            for (int j = 0; j < dataGridViewOpenFile_ATI.ColumnCount - 1; j++)
                            {
                                if (dataGridViewOpenFile_ATI.Rows[i].Cells[j].Value != null)
                                {
                                    if (dataGridViewOpenFile_ATI.Rows[i].Cells[j].Selected == true)
                                    {
                                        columnIndex = j;
                                        break;
                                    }
                                }
                            }
                            if (columnIndex > -1) break;
                        }

                        for (int i = 1; i < dataGridViewOpenFile_ATI.RowCount - 1; i++)
                        {
                            double cellValue;
                            if (dataGridViewOpenFile_ATI.Rows[i].Cells[columnIndex].Value != null && double.TryParse(dataGridViewOpenFile_ATI.Rows[i].Cells[columnIndex].Value.ToString(), out cellValue))
                            {
                                dataGridViewOpenFile_ATI.Rows[i].Cells[columnIndex].Value = cellValue;
                            }
                        }

                        string selectedItem = comboBoxSort_ATI.SelectedItem.ToString();
                        if (selectedItem == "По возрастанию ( от А до Я )" && tralivali != 0)
                        {
                            DataGridViewRow row = dataGridViewOpenFile_ATI.Rows[0];
                            dataGridViewOpenFile_ATI.Rows.Remove(dataGridViewOpenFile_ATI.Rows[0]);

                            DataGridViewColumn column = dataGridViewOpenFile_ATI.Columns[columnIndex];

                            dataGridViewOpenFile_ATI.Sort(column, ListSortDirection.Ascending);
                            dataGridViewOpenFile_ATI.Rows.Insert(0, row);

                            for (int i = 0; i < dataGridViewOpenFile_ATI.RowCount - 1; i++)
                            {
                                for (int j = 0; j < dataGridViewOpenFile_ATI.ColumnCount - 1; j++)
                                {
                                    dataGridViewOpenFile_ATI.Rows[i].Cells[j].Selected = false;
                                }
                            }
                        }
                        else if (selectedItem == "По убыванию ( от Я до А )" && tralivali != 0)
                        {
                            DataGridViewRow row = dataGridViewOpenFile_ATI.Rows[0];
                            dataGridViewOpenFile_ATI.Rows.Remove(dataGridViewOpenFile_ATI.Rows[0]);

                            DataGridViewColumn column = dataGridViewOpenFile_ATI.Columns[columnIndex];

                            dataGridViewOpenFile_ATI.Sort(column, ListSortDirection.Descending);
                            dataGridViewOpenFile_ATI.Rows.Insert(0, row);

                            for (int i = 0; i < dataGridViewOpenFile_ATI.RowCount - 1; i++)
                            {
                                for (int j = 0; j < dataGridViewOpenFile_ATI.ColumnCount - 1; j++)
                                {
                                    dataGridViewOpenFile_ATI.Rows[i].Cells[j].Selected = false;
                                }
                            }
                        }
                        else MessageBox.Show("Не забудьте нажать на пустое поле ввода сортирвоки!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        textBoxQuantity_ATI.Text = "";
                        textBoxSum_ATI.Text = "";
                        textBoxMiddleValue_ATI.Text = "";
                        textBoxMinValue_ATI.Text = "";
                        textBoxMaxValue_ATI.Text = "";
                    }
                    else if (kakbuda == (dataGridViewOpenFile_ATI.RowCount - 1) * (dataGridViewOpenFile_ATI.ColumnCount - 1) && tralivali != 0)
                    {
                        MessageBox.Show("Пожалуйста, выберите столбец", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (kakbuda == (dataGridViewOpenFile_ATI.RowCount - 1) * (dataGridViewOpenFile_ATI.ColumnCount - 1) && tralivali == 0)
                    {
                        MessageBox.Show($"{"Пожалуйста, выберите столбец." + "\r"}{"Не забудьте нажать на пустое поле ввода сортирвоки!"}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else MessageBox.Show("Файл не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    
    

        private void buttonSort_ATI_Click(object sender, EventArgs e)
        {
            if (dataGridViewOpenFile_ATI.RowCount != 0 && tralivali != 0)
            {
                for (int i = 0; i < dataGridViewOpenFile_ATI.RowCount - 1; i++)
                {
                    for (int j = 0; j < dataGridViewOpenFile_ATI.ColumnCount - 1; j++)
                    {
                        dataGridViewOpenFile_ATI.Rows[i].Cells[j].Value = mtrxSort[i, j];
                        dataGridViewOpenFile_ATI.Rows[i].Cells[j].Selected = false;
                    }
                }
            }
            else if (dataGridViewOpenFile_ATI.RowCount != 0 && tralivali == 0) MessageBox.Show("А надо было нажимать на пустое поле ввода сортировки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else MessageBox.Show("Файл не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        static string[,] mtrxFilter;
        static int bulo = 0;

        private void textBoxFilter_ATI_KeyDown(object sender, KeyEventArgs e)
        {
            if (dataGridViewOpenFile_ATI.RowCount != 0)
            {
                mtrxFilter = new string[dataGridViewOpenFile_ATI.RowCount, dataGridViewOpenFile_ATI.ColumnCount];
                for (int i = 0; i < dataGridViewOpenFile_ATI.RowCount - 1; i++)
                {
                    for (int j = 0; j < dataGridViewOpenFile_ATI.ColumnCount - 1; j++)
                    {
                        mtrxFilter[i, j] = Convert.ToString(dataGridViewOpenFile_ATI.Rows[i].Cells[j].Value);
                    }
                }
                bulo++;
            }
            else MessageBox.Show("Файл не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void textBoxFilter_ATI_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
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
                for (int i = 0; i < dataGridViewOpenFile_ATI.RowCount - 1; i++)
                {
                    for (int j = 0; j < dataGridViewOpenFile_ATI.ColumnCount - 1; j++)
                    {
                        dataGridViewOpenFile_ATI.Rows[i].Cells[j].Selected = false;
                    }
                }

                if (nugno > -1)
                {
                    for (int i = 0; i < dataGridViewOpenFile_ATI.RowCount; i++)
                    {
                        if (dataGridViewOpenFile_ATI.Rows[i].Cells[nugno].Value != null)
                        {
                            string elmnt = dataGridViewOpenFile_ATI.Rows[i].Cells[nugno].Value.ToString().ToLower();
                            if (elmnt.Contains(textBoxFilter_ATI.Text.ToLower())) dataGridViewOpenFile_ATI.Rows[i].Cells[nugno].Selected = true;
                            //if (elmnt.StartsWith(textBoxFilter_URI.Text.ToLower())) dataGridViewOpenFile_URI.Rows[i].Cells[nugno].Selected = true;
                        }
                    }

                    for (int r = 1; r < dataGridViewOpenFile_ATI.RowCount - 1; r++)
                    {
                        if (dataGridViewOpenFile_ATI.Rows[r].Cells[nugno].Selected != true) dataGridViewOpenFile_ATI.Rows[r].Visible = false;
                    }

                    for (int i = 0; i < dataGridViewOpenFile_ATI.RowCount - 1; i++)
                    {
                        for (int j = 0; j < dataGridViewOpenFile_ATI.ColumnCount - 1; j++)
                        {
                            dataGridViewOpenFile_ATI.Rows[i].Cells[j].Selected = false;
                        }
                    }

                    textBoxQuantity_ATI.Text = "";
                    textBoxSum_ATI.Text = "";
                    textBoxMiddleValue_ATI.Text = "";
                    textBoxMinValue_ATI.Text = "";
                    textBoxMaxValue_ATI.Text = "";
                }
                else MessageBox.Show("Не выбран столбец", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonFiltr_ATI_Click(object sender, EventArgs e)
        {
            if (dataGridViewOpenFile_ATI.RowCount != 0 && bulo != 0)
            {
                dataGridViewOpenFile_ATI.Rows.Clear();
                dataGridViewOpenFile_ATI.Columns.Clear();
                dataGridViewOpenFile_ATI.RowCount = mtrxFilter.GetUpperBound(0) + 1;
                dataGridViewOpenFile_ATI.ColumnCount = mtrxFilter.GetUpperBound(1) + 1;
                textBoxMaxValue_ATI.Text = Convert.ToString(mtrxFilter.GetUpperBound(0) + 1);
                textBoxMinValue_ATI.Text = Convert.ToString(mtrxFilter.GetUpperBound(1) + 10);
                for (int i = 0; i < dataGridViewOpenFile_ATI.RowCount - 1; i++)
                {
                    for (int j = 0; j < dataGridViewOpenFile_ATI.ColumnCount - 1; j++)
                    {
                        dataGridViewOpenFile_ATI.Rows[i].Cells[j].Value = mtrxFilter[i, j];
                    }
                }
                dataGridViewOpenFile_ATI.AutoResizeColumns();

                for (int i = 0; i < dataGridViewOpenFile_ATI.RowCount - 1; i++)
                {
                    for (int j = 0; j < dataGridViewOpenFile_ATI.ColumnCount - 1; j++)
                    {
                        dataGridViewOpenFile_ATI.Rows[i].Cells[j].Selected = false;
                    }
                }

                textBoxFilter_ATI.Text = "";
                textBoxQuantity_ATI.Text = "";
                textBoxSum_ATI.Text = "";
                textBoxMiddleValue_ATI.Text = "";
                textBoxMinValue_ATI.Text = "";
                textBoxMaxValue_ATI.Text = "";
            }
            else if (dataGridViewOpenFile_ATI.RowCount != 0 && bulo == 0) MessageBox.Show("Еще не были применены фильтры", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else MessageBox.Show("Файл не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void buttonAdd_ATI_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewOpenFile_ATI.Rows.Add();
                for (int i = 0; i < dataGridViewOpenFile_ATI.RowCount - 1; i++)
                {
                    for (int j = 0; j < dataGridViewOpenFile_ATI.ColumnCount - 1; j++)
                    {
                        dataGridViewOpenFile_ATI.Rows[i].Cells[j].Selected = false;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Файл не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxQuantity_ATI_KeyUp(object sender, KeyEventArgs e)
        {
            if (dataGridViewOpenFile_ATI.RowCount != 0)
            {
                if (e.KeyCode == Keys.Enter)
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

                    int counter = 0;
                    for (int r = 0; r < dataGridViewOpenFile_ATI.RowCount - 1; r++)
                    {
                        if (dataGridViewOpenFile_ATI.Rows[r].Cells[nugno].Selected == true) counter++;
                    }
                    textBoxQuantity_ATI.Text = Convert.ToString(counter);
                }
            }
            else MessageBox.Show("Файл не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void textBoxSum_ATI_KeyUp(object sender, KeyEventArgs e)
        {
            if (dataGridViewOpenFile_ATI.RowCount != 0)
            {
                if (e.KeyCode == Keys.Enter)
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
                        if (dataGridViewOpenFile_ATI.Rows[0].Cells[nugno].Selected != true)
                        {
                            double sum = 0;
                            for (int i = 1; i < dataGridViewOpenFile_ATI.RowCount - 1; i++)
                            {
                                if (dataGridViewOpenFile_ATI.Rows[i].Cells[nugno].Selected == true)
                                {
                                    double cellValue;
                                    if (dataGridViewOpenFile_ATI.Rows[i].Cells[nugno].Value != null && double.TryParse(dataGridViewOpenFile_ATI.Rows[i].Cells[nugno].Value.ToString(), out cellValue))
                                    {
                                        dataGridViewOpenFile_ATI.Rows[i].Cells[nugno].Value = cellValue;
                                        sum += Convert.ToDouble(dataGridViewOpenFile_ATI.Rows[i].Cells[nugno].Value.ToString());
                                    }
                                }
                            }
                            if (sum != 0) textBoxSum_ATI.Text = Convert.ToString(sum);
                            else
                            {
                                MessageBox.Show("Пожалуйста, выберите диапозон ячеек с числами", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                textBoxSum_ATI.Text = "";

                                textBoxMiddleValue_ATI.Text = "";
                                textBoxMinValue_ATI.Text = "";
                                textBoxMaxValue_ATI.Text = "";
                            }
                        }
                        else
                        {
                            MessageBox.Show("Пожалуйста, выберите диапозон ячеек с числами", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            textBoxSum_ATI.Text = "";

                            textBoxMiddleValue_ATI.Text = "";
                            textBoxMinValue_ATI.Text = "";
                            textBoxMaxValue_ATI.Text = "";
                        }
                    }
                    else MessageBox.Show("Не выбран столбец", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("Файл не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    

        private void textBoxMiddleValue_ATI_KeyUp(object sender, KeyEventArgs e)
        {
            if (dataGridViewOpenFile_ATI.RowCount != 0)
            {
                if (e.KeyCode == Keys.Enter)
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
                        if (dataGridViewOpenFile_ATI.Rows[0].Cells[nugno].Selected != true)
                        {
                            double srznach = 0; int kol = 0;
                            for (int i = 1; i < dataGridViewOpenFile_ATI.RowCount - 1; i++)
                            {
                                if (dataGridViewOpenFile_ATI.Rows[i].Cells[nugno].Selected == true)
                                {
                                    double cellValue;
                                    if (dataGridViewOpenFile_ATI.Rows[i].Cells[nugno].Value != null && double.TryParse(dataGridViewOpenFile_ATI.Rows[i].Cells[nugno].Value.ToString(), out cellValue))
                                    {
                                        dataGridViewOpenFile_ATI.Rows[i].Cells[nugno].Value = cellValue;
                                        srznach += Convert.ToDouble(dataGridViewOpenFile_ATI.Rows[i].Cells[nugno].Value.ToString());
                                        kol++;
                                    }
                                }
                            }
                            if (srznach != 0) textBoxMiddleValue_ATI.Text = Convert.ToString(Math.Round(srznach / kol, 5));
                            else
                            {
                                MessageBox.Show("Пожалуйста, выберите диапозон ячеек с числами", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                textBoxMiddleValue_ATI.Text = "";

                                textBoxSum_ATI.Text = "";
                                textBoxMinValue_ATI.Text = "";
                                textBoxMaxValue_ATI.Text = "";
                            }
                        }
                        else
                        {
                            MessageBox.Show("Пожалуйста, выберите диапозон ячеек с числами", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            textBoxMiddleValue_ATI.Text = "";

                            textBoxSum_ATI.Text = "";
                            textBoxMinValue_ATI.Text = "";
                            textBoxMaxValue_ATI.Text = "";
                        }
                    }
                    else MessageBox.Show("Не выбран столбец", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("Файл не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void textBoxMinValue_ATI_KeyUp(object sender, KeyEventArgs e)
        {
            if (dataGridViewOpenFile_ATI.RowCount != 0)
            {
                if (e.KeyCode == Keys.Enter)
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
                        if (dataGridViewOpenFile_ATI.Rows[0].Cells[nugno].Selected != true)
                        {
                            double min = 9999999;
                            for (int i = 1; i < dataGridViewOpenFile_ATI.RowCount - 1; i++)
                            {
                                if (dataGridViewOpenFile_ATI.Rows[i].Cells[nugno].Selected == true)
                                {
                                    double cellValue;
                                    if (dataGridViewOpenFile_ATI.Rows[i].Cells[nugno].Value != null && double.TryParse(dataGridViewOpenFile_ATI.Rows[i].Cells[nugno].Value.ToString(), out cellValue))
                                    {
                                        dataGridViewOpenFile_ATI.Rows[i].Cells[nugno].Value = cellValue;
                                        min = Math.Min(Convert.ToDouble(dataGridViewOpenFile_ATI.Rows[i].Cells[nugno].Value.ToString()), min);
                                    }
                                }
                            }
                            if (min != 9999999) textBoxMinValue_ATI.Text = Convert.ToString(min);
                            else
                            {
                                MessageBox.Show("Пожалуйста, выберите диапозон ячеек с числами", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                textBoxMinValue_ATI.Text = "";

                                textBoxSum_ATI.Text = "";
                                textBoxMiddleValue_ATI.Text = "";
                                textBoxMaxValue_ATI.Text = "";
                            }
                        }
                        else
                        {
                            MessageBox.Show("Пожалуйста, выберите диапозон ячеек с числами", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            textBoxMinValue_ATI.Text = "";

                            textBoxSum_ATI.Text = "";
                            textBoxMiddleValue_ATI.Text = "";
                            textBoxMaxValue_ATI.Text = "";
                        }
                    }
                    else MessageBox.Show("Не выбран столбец", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("Файл не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    

        private void textBoxMaxValue_ATI_KeyUp(object sender, KeyEventArgs e)
        {
            if (dataGridViewOpenFile_ATI.RowCount != 0)
            {
                if (e.KeyCode == Keys.Enter)
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
                        if (dataGridViewOpenFile_ATI.Rows[0].Cells[nugno].Selected != true)
                        {
                            double max = -9999999;
                            for (int i = 1; i < dataGridViewOpenFile_ATI.RowCount - 1; i++)
                            {

                                if (dataGridViewOpenFile_ATI.Rows[i].Cells[nugno].Selected == true)
                                {
                                    double cellValue;
                                    if (dataGridViewOpenFile_ATI.Rows[i].Cells[nugno].Value != null && double.TryParse(dataGridViewOpenFile_ATI.Rows[i].Cells[nugno].Value.ToString(), out cellValue))
                                    {
                                        dataGridViewOpenFile_ATI.Rows[i].Cells[nugno].Value = cellValue;
                                        max = Math.Max(Convert.ToDouble(dataGridViewOpenFile_ATI.Rows[i].Cells[nugno].Value.ToString()), max);
                                    }
                                }
                            }
                            if (max != -9999999) textBoxMaxValue_ATI.Text = Convert.ToString(max);
                            else
                            {
                                MessageBox.Show("Пожалуйста, выберите диапозон ячеек с числами", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                textBoxMaxValue_ATI.Text = "";

                                textBoxSum_ATI.Text = "";
                                textBoxMiddleValue_ATI.Text = "";
                                textBoxMinValue_ATI.Text = "";
                            }
                        }
                        else
                        {
                            MessageBox.Show("Пожалуйста, выберите диапозон ячеек с числами", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            textBoxMaxValue_ATI.Text = "";

                            textBoxSum_ATI.Text = "";
                            textBoxMiddleValue_ATI.Text = "";
                            textBoxMinValue_ATI.Text = "";
                        }
                    }
                    else MessageBox.Show("Не выбран столбец", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("Файл не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }       
    }
}
        

           

