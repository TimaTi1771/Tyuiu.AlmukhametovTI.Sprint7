namespace Tyuiu.AlmukhametovTISprint7.Project.V3
{
    partial class FormGraphyks
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGraphyks));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.toolTipAddRow_ATI = new System.Windows.Forms.ToolTip(this.components);
            this.buttonAdd_ATI = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.назадToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemBack_ATI = new System.Windows.Forms.ToolStripMenuItem();
            this.графикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSaveGraphiks_ATI = new System.Windows.Forms.ToolStripMenuItem();
            this.краткоеРуководствоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemOpenGiued_ATI = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemHelp_ATI = new System.Windows.Forms.ToolStripMenuItem();
            this.panel5 = new System.Windows.Forms.Panel();
            this.buttonDelete_ATI = new System.Windows.Forms.Button();
            this.buttonSaveFile_ATI = new System.Windows.Forms.Button();
            this.buttonOpenFile_ATI = new System.Windows.Forms.Button();
            this.saveFileDialog_ATI = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog_ATI = new System.Windows.Forms.OpenFileDialog();
            this.toolTipOpenFilee_ATI = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipSave_File_ATI = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipDeletGrafik_ATI = new System.Windows.Forms.ToolTip(this.components);
            this.buttonDeleteGraphuks_ATI = new System.Windows.Forms.Button();
            this.toolTip_Построить_ATI = new System.Windows.Forms.ToolTip(this.components);
            this.buttonAddGraphyks_ATI = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitContainerFunction_ATI = new System.Windows.Forms.SplitContainer();
            this.dataGridViewOpenFile_ATI = new System.Windows.Forms.DataGridView();
            this.chartFunction_ATI = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.toolTipDeleteRow_ATI = new System.Windows.Forms.ToolTip(this.components);
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerFunction_ATI)).BeginInit();
            this.splitContainerFunction_ATI.Panel1.SuspendLayout();
            this.splitContainerFunction_ATI.Panel2.SuspendLayout();
            this.splitContainerFunction_ATI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOpenFile_ATI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_ATI)).BeginInit();
            this.SuspendLayout();
            // 
            // toolTipAddRow_ATI
            // 
            this.toolTipAddRow_ATI.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipAddRow_ATI.ToolTipTitle = "Добавить ";
            // 
            // buttonAdd_ATI
            // 
            this.buttonAdd_ATI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd_ATI.Location = new System.Drawing.Point(12, 189);
            this.buttonAdd_ATI.Name = "buttonAdd_ATI";
            this.buttonAdd_ATI.Size = new System.Drawing.Size(96, 64);
            this.buttonAdd_ATI.TabIndex = 2;
            this.buttonAdd_ATI.Text = "Добавить";
            this.toolTipAddRow_ATI.SetToolTip(this.buttonAdd_ATI, "Добавить строку ");
            this.buttonAdd_ATI.UseVisualStyleBackColor = true;
            this.buttonAdd_ATI.Click += new System.EventHandler(this.buttonAdd_ATI_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1157, 32);
            this.panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.назадToolStripMenuItem,
            this.графикиToolStripMenuItem,
            this.краткоеРуководствоToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1157, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // назадToolStripMenuItem
            // 
            this.назадToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemBack_ATI});
            this.назадToolStripMenuItem.Name = "назадToolStripMenuItem";
            this.назадToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.назадToolStripMenuItem.Text = "Назад";
            // 
            // ToolStripMenuItemBack_ATI
            // 
            this.ToolStripMenuItemBack_ATI.Name = "ToolStripMenuItemBack_ATI";
            this.ToolStripMenuItemBack_ATI.Size = new System.Drawing.Size(207, 26);
            this.ToolStripMenuItemBack_ATI.Text = "Вернуться назад";
            this.ToolStripMenuItemBack_ATI.Click += new System.EventHandler(this.ToolStripMenuItemBack_ATI_Click);
            // 
            // графикиToolStripMenuItem
            // 
            this.графикиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemSaveGraphiks_ATI});
            this.графикиToolStripMenuItem.Name = "графикиToolStripMenuItem";
            this.графикиToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.графикиToolStripMenuItem.Text = "Графики";
            // 
            // ToolStripMenuItemSaveGraphiks_ATI
            // 
            this.ToolStripMenuItemSaveGraphiks_ATI.Name = "ToolStripMenuItemSaveGraphiks_ATI";
            this.ToolStripMenuItemSaveGraphiks_ATI.Size = new System.Drawing.Size(166, 26);
            this.ToolStripMenuItemSaveGraphiks_ATI.Text = "Сохранить";
            // 
            // краткоеРуководствоToolStripMenuItem
            // 
            this.краткоеРуководствоToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemOpenGiued_ATI});
            this.краткоеРуководствоToolStripMenuItem.Name = "краткоеРуководствоToolStripMenuItem";
            this.краткоеРуководствоToolStripMenuItem.Size = new System.Drawing.Size(170, 24);
            this.краткоеРуководствоToolStripMenuItem.Text = "Краткое руководство";
            // 
            // ToolStripMenuItemOpenGiued_ATI
            // 
            this.ToolStripMenuItemOpenGiued_ATI.Name = "ToolStripMenuItemOpenGiued_ATI";
            this.ToolStripMenuItemOpenGiued_ATI.Size = new System.Drawing.Size(150, 26);
            this.ToolStripMenuItemOpenGiued_ATI.Text = "Открыть";
            this.ToolStripMenuItemOpenGiued_ATI.Click += new System.EventHandler(this.ToolStripMenuItemOpenGiued_ATI_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemHelp_ATI});
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // ToolStripMenuItemHelp_ATI
            // 
            this.ToolStripMenuItemHelp_ATI.Name = "ToolStripMenuItemHelp_ATI";
            this.ToolStripMenuItemHelp_ATI.Size = new System.Drawing.Size(224, 26);
            this.ToolStripMenuItemHelp_ATI.Text = "Перейти";
            this.ToolStripMenuItemHelp_ATI.Click += new System.EventHandler(this.ToolStripMenuItemHelp_ATI_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.buttonDelete_ATI);
            this.panel5.Controls.Add(this.buttonAdd_ATI);
            this.panel5.Controls.Add(this.buttonSaveFile_ATI);
            this.panel5.Controls.Add(this.buttonOpenFile_ATI);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 32);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(129, 674);
            this.panel5.TabIndex = 4;
            // 
            // buttonDelete_ATI
            // 
            this.buttonDelete_ATI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete_ATI.Location = new System.Drawing.Point(12, 279);
            this.buttonDelete_ATI.Name = "buttonDelete_ATI";
            this.buttonDelete_ATI.Size = new System.Drawing.Size(96, 61);
            this.buttonDelete_ATI.TabIndex = 3;
            this.buttonDelete_ATI.Text = "Удалить  ";
            this.toolTipDeleteRow_ATI.SetToolTip(this.buttonDelete_ATI, "Удалить строку \r\n");
            this.buttonDelete_ATI.UseVisualStyleBackColor = true;
            this.buttonDelete_ATI.Click += new System.EventHandler(this.buttonDelete_ATI_Click);
            // 
            // buttonSaveFile_ATI
            // 
            this.buttonSaveFile_ATI.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSaveFile_ATI.BackgroundImage")));
            this.buttonSaveFile_ATI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonSaveFile_ATI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSaveFile_ATI.Location = new System.Drawing.Point(12, 102);
            this.buttonSaveFile_ATI.Name = "buttonSaveFile_ATI";
            this.buttonSaveFile_ATI.Size = new System.Drawing.Size(96, 64);
            this.buttonSaveFile_ATI.TabIndex = 0;
            this.toolTipSave_File_ATI.SetToolTip(this.buttonSaveFile_ATI, "Сохраните исполняемый файл");
            this.buttonSaveFile_ATI.UseVisualStyleBackColor = true;
            this.buttonSaveFile_ATI.Click += new System.EventHandler(this.buttonSaveFile_ATI_Click);
            // 
            // buttonOpenFile_ATI
            // 
            this.buttonOpenFile_ATI.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_ATI.BackgroundImage")));
            this.buttonOpenFile_ATI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonOpenFile_ATI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOpenFile_ATI.Location = new System.Drawing.Point(12, 16);
            this.buttonOpenFile_ATI.Name = "buttonOpenFile_ATI";
            this.buttonOpenFile_ATI.Size = new System.Drawing.Size(96, 64);
            this.buttonOpenFile_ATI.TabIndex = 1;
            this.toolTipOpenFilee_ATI.SetToolTip(this.buttonOpenFile_ATI, "Откройте исполняемый файл");
            this.buttonOpenFile_ATI.UseVisualStyleBackColor = true;
            this.buttonOpenFile_ATI.Click += new System.EventHandler(this.buttonOpenFile_ATI_Click);
            // 
            // openFileDialog_ATI
            // 
            this.openFileDialog_ATI.FileName = "openFileDialog1";
            // 
            // toolTipOpenFilee_ATI
            // 
            this.toolTipOpenFilee_ATI.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipOpenFilee_ATI.ToolTipTitle = "Открыть файл";
            // 
            // toolTipSave_File_ATI
            // 
            this.toolTipSave_File_ATI.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipSave_File_ATI.ToolTipTitle = "Сохранить файл";
            // 
            // toolTipDeletGrafik_ATI
            // 
            this.toolTipDeletGrafik_ATI.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.toolTipDeletGrafik_ATI.ToolTipTitle = "Удалить ";
            // 
            // buttonDeleteGraphuks_ATI
            // 
            this.buttonDeleteGraphuks_ATI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeleteGraphuks_ATI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDeleteGraphuks_ATI.Location = new System.Drawing.Point(826, 35);
            this.buttonDeleteGraphuks_ATI.Name = "buttonDeleteGraphuks_ATI";
            this.buttonDeleteGraphuks_ATI.Size = new System.Drawing.Size(176, 34);
            this.buttonDeleteGraphuks_ATI.TabIndex = 1;
            this.buttonDeleteGraphuks_ATI.Text = "Удалить график ";
            this.toolTipDeletGrafik_ATI.SetToolTip(this.buttonDeleteGraphuks_ATI, "Удалить график ");
            this.buttonDeleteGraphuks_ATI.UseVisualStyleBackColor = true;
            this.buttonDeleteGraphuks_ATI.Click += new System.EventHandler(this.buttonDeleteGraphuks_ATI_Click);
            // 
            // toolTip_Построить_ATI
            // 
            this.toolTip_Построить_ATI.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_Построить_ATI.ToolTipTitle = "Построить";
            // 
            // buttonAddGraphyks_ATI
            // 
            this.buttonAddGraphyks_ATI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAddGraphyks_ATI.BackColor = System.Drawing.Color.IndianRed;
            this.buttonAddGraphyks_ATI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddGraphyks_ATI.Location = new System.Drawing.Point(27, 35);
            this.buttonAddGraphyks_ATI.Name = "buttonAddGraphyks_ATI";
            this.buttonAddGraphyks_ATI.Size = new System.Drawing.Size(176, 34);
            this.buttonAddGraphyks_ATI.TabIndex = 0;
            this.buttonAddGraphyks_ATI.Text = "Добавить график ";
            this.toolTip_Построить_ATI.SetToolTip(this.buttonAddGraphyks_ATI, "Построить график ");
            this.buttonAddGraphyks_ATI.UseVisualStyleBackColor = false;
            this.buttonAddGraphyks_ATI.Click += new System.EventHandler(this.buttonAddGraphyks_ATI_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.buttonDeleteGraphuks_ATI);
            this.panel2.Controls.Add(this.buttonAddGraphyks_ATI);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(129, 606);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1028, 100);
            this.panel2.TabIndex = 5;
            // 
            // splitContainerFunction_ATI
            // 
            this.splitContainerFunction_ATI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerFunction_ATI.Location = new System.Drawing.Point(129, 32);
            this.splitContainerFunction_ATI.Name = "splitContainerFunction_ATI";
            // 
            // splitContainerFunction_ATI.Panel1
            // 
            this.splitContainerFunction_ATI.Panel1.Controls.Add(this.dataGridViewOpenFile_ATI);
            // 
            // splitContainerFunction_ATI.Panel2
            // 
            this.splitContainerFunction_ATI.Panel2.Controls.Add(this.chartFunction_ATI);
            this.splitContainerFunction_ATI.Size = new System.Drawing.Size(1028, 574);
            this.splitContainerFunction_ATI.SplitterDistance = 503;
            this.splitContainerFunction_ATI.TabIndex = 6;
            // 
            // dataGridViewOpenFile_ATI
            // 
            this.dataGridViewOpenFile_ATI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOpenFile_ATI.ColumnHeadersVisible = false;
            this.dataGridViewOpenFile_ATI.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridViewOpenFile_ATI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOpenFile_ATI.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewOpenFile_ATI.Name = "dataGridViewOpenFile_ATI";
            this.dataGridViewOpenFile_ATI.RowHeadersVisible = false;
            this.dataGridViewOpenFile_ATI.RowHeadersWidth = 51;
            this.dataGridViewOpenFile_ATI.RowTemplate.Height = 24;
            this.dataGridViewOpenFile_ATI.Size = new System.Drawing.Size(503, 574);
            this.dataGridViewOpenFile_ATI.TabIndex = 0;
            // 
            // chartFunction_ATI
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction_ATI.ChartAreas.Add(chartArea1);
            this.chartFunction_ATI.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartFunction_ATI.Legends.Add(legend1);
            this.chartFunction_ATI.Location = new System.Drawing.Point(0, 0);
            this.chartFunction_ATI.Name = "chartFunction_ATI";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction_ATI.Series.Add(series1);
            this.chartFunction_ATI.Size = new System.Drawing.Size(521, 574);
            this.chartFunction_ATI.TabIndex = 0;
            this.chartFunction_ATI.Text = "chart1";
            // 
            // toolTipDeleteRow_ATI
            // 
            this.toolTipDeleteRow_ATI.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.toolTipDeleteRow_ATI.ToolTipTitle = "Осторожно";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column5.Width = 125;
            // 
            // FormGraphyks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 706);
            this.Controls.Add(this.splitContainerFunction_ATI);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1101, 686);
            this.Name = "FormGraphyks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Построение графиков";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.splitContainerFunction_ATI.Panel1.ResumeLayout(false);
            this.splitContainerFunction_ATI.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerFunction_ATI)).EndInit();
            this.splitContainerFunction_ATI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOpenFile_ATI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_ATI)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTipAddRow_ATI;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem назадToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemBack_ATI;
        private System.Windows.Forms.ToolStripMenuItem графикиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSaveGraphiks_ATI;
        private System.Windows.Forms.ToolStripMenuItem краткоеРуководствоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemOpenGiued_ATI;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemHelp_ATI;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button buttonSaveFile_ATI;
        private System.Windows.Forms.Button buttonOpenFile_ATI;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_ATI;
        private System.Windows.Forms.OpenFileDialog openFileDialog_ATI;
        private System.Windows.Forms.ToolTip toolTipOpenFilee_ATI;
        private System.Windows.Forms.ToolTip toolTipSave_File_ATI;
        private System.Windows.Forms.ToolTip toolTipDeletGrafik_ATI;
        private System.Windows.Forms.ToolTip toolTip_Построить_ATI;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonDelete_ATI;
        private System.Windows.Forms.Button buttonAdd_ATI;
        private System.Windows.Forms.Button buttonDeleteGraphuks_ATI;
        private System.Windows.Forms.Button buttonAddGraphyks_ATI;
        private System.Windows.Forms.SplitContainer splitContainerFunction_ATI;
        private System.Windows.Forms.DataGridView dataGridViewOpenFile_ATI;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_ATI;
        private System.Windows.Forms.ToolTip toolTipDeleteRow_ATI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}