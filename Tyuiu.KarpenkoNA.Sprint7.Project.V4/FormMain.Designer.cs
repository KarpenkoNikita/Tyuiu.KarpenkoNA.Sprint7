
namespace Tyuiu.KarpenkoNA.Sprint7.Project.V4
{
    partial class FormMain_KNA
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
            this.menuStripData_KNA = new System.Windows.Forms.MenuStrip();
            this.ToolStripMove_KNA = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem_KNA = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem_KNA = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem_KNA = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem_KNA = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripAboutProgram_KNA = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripExit_KNA = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewData_KNA = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Book_KNA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zhanr_KNA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year_KNA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor_KNA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gh = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBoxMoves_KNA = new System.Windows.Forms.GroupBox();
            this.buttonOpen_KNA = new System.Windows.Forms.Button();
            this.buttonHelp_KNA = new System.Windows.Forms.Button();
            this.buttonAddBook_KNA = new System.Windows.Forms.Button();
            this.buttonSave_KNA = new System.Windows.Forms.Button();
            this.saveFileDialogTable_KNA = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogTable_KNA = new System.Windows.Forms.OpenFileDialog();
            this.menuStripData_KNA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData_KNA)).BeginInit();
            this.groupBoxMoves_KNA.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripData_KNA
            // 
            this.menuStripData_KNA.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripData_KNA.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMove_KNA,
            this.ToolStripAboutProgram_KNA,
            this.exitToolStripExit_KNA});
            this.menuStripData_KNA.Location = new System.Drawing.Point(0, 0);
            this.menuStripData_KNA.Name = "menuStripData_KNA";
            this.menuStripData_KNA.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStripData_KNA.Size = new System.Drawing.Size(980, 24);
            this.menuStripData_KNA.TabIndex = 0;
            this.menuStripData_KNA.Text = "menuStrip_LVA";
            // 
            // ToolStripMove_KNA
            // 
            this.ToolStripMove_KNA.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem_KNA,
            this.saveToolStripMenuItem_KNA,
            this.addToolStripMenuItem_KNA,
            this.infoToolStripMenuItem_KNA});
            this.ToolStripMove_KNA.Name = "ToolStripMove_KNA";
            this.ToolStripMove_KNA.Size = new System.Drawing.Size(70, 20);
            this.ToolStripMove_KNA.Text = "Действия";
            // 
            // openToolStripMenuItem_KNA
            // 
            this.openToolStripMenuItem_KNA.Name = "openToolStripMenuItem_KNA";
            this.openToolStripMenuItem_KNA.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem_KNA.Text = "Открыть";
            this.openToolStripMenuItem_KNA.Click += new System.EventHandler(this.openToolStripMenuItem_KNA_Click);
            // 
            // saveToolStripMenuItem_KNA
            // 
            this.saveToolStripMenuItem_KNA.Name = "saveToolStripMenuItem_KNA";
            this.saveToolStripMenuItem_KNA.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem_KNA.Text = "Сохранить";
            this.saveToolStripMenuItem_KNA.Click += new System.EventHandler(this.saveToolStripMenuItem_KNA_Click);
            // 
            // addToolStripMenuItem_KNA
            // 
            this.addToolStripMenuItem_KNA.Name = "addToolStripMenuItem_KNA";
            this.addToolStripMenuItem_KNA.Size = new System.Drawing.Size(180, 22);
            this.addToolStripMenuItem_KNA.Text = "Добавить";
            this.addToolStripMenuItem_KNA.Click += new System.EventHandler(this.addToolStripMenuItem_KNA_Click);
            // 
            // infoToolStripMenuItem_KNA
            // 
            this.infoToolStripMenuItem_KNA.Name = "infoToolStripMenuItem_KNA";
            this.infoToolStripMenuItem_KNA.Size = new System.Drawing.Size(180, 22);
            this.infoToolStripMenuItem_KNA.Text = "Инфо";
            this.infoToolStripMenuItem_KNA.Click += new System.EventHandler(this.infoToolStripMenuItem_KNA_Click);
            // 
            // ToolStripAboutProgram_KNA
            // 
            this.ToolStripAboutProgram_KNA.Name = "ToolStripAboutProgram_KNA";
            this.ToolStripAboutProgram_KNA.Size = new System.Drawing.Size(94, 20);
            this.ToolStripAboutProgram_KNA.Text = "О программе";
            this.ToolStripAboutProgram_KNA.Click += new System.EventHandler(this.ToolStripAboutProgram_KNA_Click);
            // 
            // exitToolStripExit_KNA
            // 
            this.exitToolStripExit_KNA.Name = "exitToolStripExit_KNA";
            this.exitToolStripExit_KNA.Size = new System.Drawing.Size(54, 20);
            this.exitToolStripExit_KNA.Text = "Выход";
            this.exitToolStripExit_KNA.Click += new System.EventHandler(this.exitToolStripExit_KNA_Click);
            // 
            // dataGridViewData_KNA
            // 
            this.dataGridViewData_KNA.AllowUserToAddRows = false;
            this.dataGridViewData_KNA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewData_KNA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewData_KNA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewData_KNA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Book_KNA,
            this.Zhanr_KNA,
            this.Year_KNA,
            this.Autor_KNA,
            this.gh});
            this.dataGridViewData_KNA.Location = new System.Drawing.Point(315, 26);
            this.dataGridViewData_KNA.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewData_KNA.Name = "dataGridViewData_KNA";
            this.dataGridViewData_KNA.RowHeadersVisible = false;
            this.dataGridViewData_KNA.RowHeadersWidth = 51;
            this.dataGridViewData_KNA.RowTemplate.Height = 24;
            this.dataGridViewData_KNA.Size = new System.Drawing.Size(654, 447);
            this.dataGridViewData_KNA.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Book_KNA
            // 
            this.Book_KNA.HeaderText = "Название";
            this.Book_KNA.MinimumWidth = 6;
            this.Book_KNA.Name = "Book_KNA";
            // 
            // Zhanr_KNA
            // 
            this.Zhanr_KNA.HeaderText = "Жанр";
            this.Zhanr_KNA.Name = "Zhanr_KNA";
            // 
            // Year_KNA
            // 
            this.Year_KNA.HeaderText = "Автор";
            this.Year_KNA.MinimumWidth = 6;
            this.Year_KNA.Name = "Year_KNA";
            // 
            // Autor_KNA
            // 
            this.Autor_KNA.HeaderText = "Год издания";
            this.Autor_KNA.MinimumWidth = 6;
            this.Autor_KNA.Name = "Autor_KNA";
            // 
            // gh
            // 
            this.gh.HeaderText = "Прочитано";
            this.gh.Name = "gh";
            // 
            // groupBoxMoves_KNA
            // 
            this.groupBoxMoves_KNA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxMoves_KNA.BackColor = System.Drawing.SystemColors.Menu;
            this.groupBoxMoves_KNA.Controls.Add(this.buttonOpen_KNA);
            this.groupBoxMoves_KNA.Controls.Add(this.buttonHelp_KNA);
            this.groupBoxMoves_KNA.Controls.Add(this.buttonAddBook_KNA);
            this.groupBoxMoves_KNA.Controls.Add(this.buttonSave_KNA);
            this.groupBoxMoves_KNA.Location = new System.Drawing.Point(10, 26);
            this.groupBoxMoves_KNA.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxMoves_KNA.Name = "groupBoxMoves_KNA";
            this.groupBoxMoves_KNA.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxMoves_KNA.Size = new System.Drawing.Size(293, 447);
            this.groupBoxMoves_KNA.TabIndex = 2;
            this.groupBoxMoves_KNA.TabStop = false;
            this.groupBoxMoves_KNA.Text = "Панель действия";
            // 
            // buttonOpen_KNA
            // 
            this.buttonOpen_KNA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpen_KNA.Location = new System.Drawing.Point(4, 100);
            this.buttonOpen_KNA.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOpen_KNA.Name = "buttonOpen_KNA";
            this.buttonOpen_KNA.Size = new System.Drawing.Size(283, 39);
            this.buttonOpen_KNA.TabIndex = 0;
            this.buttonOpen_KNA.Text = "Открыть базу данных";
            this.buttonOpen_KNA.UseVisualStyleBackColor = true;
            this.buttonOpen_KNA.Click += new System.EventHandler(this.buttonOpen_KNA_Click);
            // 
            // buttonHelp_KNA
            // 
            this.buttonHelp_KNA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_KNA.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonHelp_KNA.Location = new System.Drawing.Point(4, 232);
            this.buttonHelp_KNA.Margin = new System.Windows.Forms.Padding(2);
            this.buttonHelp_KNA.Name = "buttonHelp_KNA";
            this.buttonHelp_KNA.Size = new System.Drawing.Size(283, 39);
            this.buttonHelp_KNA.TabIndex = 0;
            this.buttonHelp_KNA.Text = "Информация о разработчике программы";
            this.buttonHelp_KNA.UseVisualStyleBackColor = false;
            this.buttonHelp_KNA.Click += new System.EventHandler(this.buttonHelp_KNA_Click);
            // 
            // buttonAddBook_KNA
            // 
            this.buttonAddBook_KNA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddBook_KNA.Location = new System.Drawing.Point(4, 188);
            this.buttonAddBook_KNA.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddBook_KNA.Name = "buttonAddBook_KNA";
            this.buttonAddBook_KNA.Size = new System.Drawing.Size(283, 39);
            this.buttonAddBook_KNA.TabIndex = 0;
            this.buttonAddBook_KNA.Text = "Добавить книгу";
            this.buttonAddBook_KNA.UseVisualStyleBackColor = true;
            this.buttonAddBook_KNA.Click += new System.EventHandler(this.buttonAddBook_KNA_Click);
            // 
            // buttonSave_KNA
            // 
            this.buttonSave_KNA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave_KNA.Location = new System.Drawing.Point(4, 144);
            this.buttonSave_KNA.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSave_KNA.Name = "buttonSave_KNA";
            this.buttonSave_KNA.Size = new System.Drawing.Size(283, 39);
            this.buttonSave_KNA.TabIndex = 0;
            this.buttonSave_KNA.Text = "Сохранить базу данных";
            this.buttonSave_KNA.UseVisualStyleBackColor = true;
            this.buttonSave_KNA.Click += new System.EventHandler(this.buttonSave_KNA_Click);
            // 
            // openFileDialogTable_KNA
            // 
            this.openFileDialogTable_KNA.FileName = "openFileDialog1";
            // 
            // FormMain_KNA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 482);
            this.Controls.Add(this.groupBoxMoves_KNA);
            this.Controls.Add(this.dataGridViewData_KNA);
            this.Controls.Add(this.menuStripData_KNA);
            this.MainMenuStrip = this.menuStripData_KNA;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMain_KNA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Библиотека";
            this.menuStripData_KNA.ResumeLayout(false);
            this.menuStripData_KNA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData_KNA)).EndInit();
            this.groupBoxMoves_KNA.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripData_KNA;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMove_KNA;
        private System.Windows.Forms.ToolStripMenuItem ToolStripAboutProgram_KNA;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripExit_KNA;
        private System.Windows.Forms.DataGridView dataGridViewData_KNA;
        private System.Windows.Forms.GroupBox groupBoxMoves_KNA;
        private System.Windows.Forms.Button buttonOpen_KNA;
        private System.Windows.Forms.Button buttonHelp_KNA;
        private System.Windows.Forms.Button buttonAddBook_KNA;
        private System.Windows.Forms.Button buttonSave_KNA;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem_KNA;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem_KNA;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem_KNA;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem_KNA;
        private System.Windows.Forms.SaveFileDialog saveFileDialogTable_KNA;
        private System.Windows.Forms.OpenFileDialog openFileDialogTable_KNA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book_KNA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zhanr_KNA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year_KNA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor_KNA;
        private System.Windows.Forms.DataGridViewCheckBoxColumn gh;
    }

    
}

