namespace FNQ
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonAddQuestion = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonLoadDataFile = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.buttonLoadRanking = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelWynik = new System.Windows.Forms.Label();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.labelAns1 = new System.Windows.Forms.Label();
            this.labelAns2 = new System.Windows.Forms.Label();
            this.labelAns4 = new System.Windows.Forms.Label();
            this.labelAns3 = new System.Windows.Forms.Label();
            this.buttonNextQuestion = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.textBoxImie = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1008, 729);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonAddQuestion);
            this.tabPage1.Controls.Add(this.buttonSave);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.buttonLoadDataFile);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1000, 703);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Data file";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonAddQuestion
            // 
            this.buttonAddQuestion.Enabled = false;
            this.buttonAddQuestion.Location = new System.Drawing.Point(234, 7);
            this.buttonAddQuestion.Name = "buttonAddQuestion";
            this.buttonAddQuestion.Size = new System.Drawing.Size(125, 23);
            this.buttonAddQuestion.TabIndex = 3;
            this.buttonAddQuestion.Text = "Add question";
            this.buttonAddQuestion.UseVisualStyleBackColor = true;
            this.buttonAddQuestion.Click += new System.EventHandler(this.buttonAddQuestion_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Enabled = false;
            this.buttonSave.Location = new System.Drawing.Point(152, 8);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(983, 660);
            this.dataGridView1.TabIndex = 1;
            // 
            // buttonLoadDataFile
            // 
            this.buttonLoadDataFile.Location = new System.Drawing.Point(7, 7);
            this.buttonLoadDataFile.Name = "buttonLoadDataFile";
            this.buttonLoadDataFile.Size = new System.Drawing.Size(139, 23);
            this.buttonLoadDataFile.TabIndex = 0;
            this.buttonLoadDataFile.Text = "Load data file";
            this.buttonLoadDataFile.UseVisualStyleBackColor = true;
            this.buttonLoadDataFile.Click += new System.EventHandler(this.buttonLoadDataFile_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.buttonLoadRanking);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1000, 703);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ranking";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(9, 36);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(983, 659);
            this.dataGridView2.TabIndex = 1;
            // 
            // buttonLoadRanking
            // 
            this.buttonLoadRanking.Location = new System.Drawing.Point(9, 7);
            this.buttonLoadRanking.Name = "buttonLoadRanking";
            this.buttonLoadRanking.Size = new System.Drawing.Size(151, 23);
            this.buttonLoadRanking.TabIndex = 0;
            this.buttonLoadRanking.Text = "Reload ranking";
            this.buttonLoadRanking.UseVisualStyleBackColor = true;
            this.buttonLoadRanking.Click += new System.EventHandler(this.buttonLoadRanking_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBoxImie);
            this.tabPage3.Controls.Add(this.buttonStart);
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1000, 703);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Quiz";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.CheckFileExists = true;
            this.saveFileDialog1.DefaultExt = "fnqdf";
            this.saveFileDialog1.Filter = "FNQ Data Files|*.fnqdf";
            this.saveFileDialog1.OverwritePrompt = false;
            this.saveFileDialog1.Title = "Select data file for game";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonNextQuestion);
            this.panel1.Controls.Add(this.labelAns4);
            this.panel1.Controls.Add(this.labelAns3);
            this.panel1.Controls.Add(this.labelAns2);
            this.panel1.Controls.Add(this.labelAns1);
            this.panel1.Controls.Add(this.labelQuestion);
            this.panel1.Controls.Add(this.labelWynik);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(8, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 607);
            this.panel1.TabIndex = 0;
            // 
            // labelWynik
            // 
            this.labelWynik.AutoSize = true;
            this.labelWynik.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWynik.Location = new System.Drawing.Point(12, 13);
            this.labelWynik.Name = "labelWynik";
            this.labelWynik.Size = new System.Drawing.Size(146, 40);
            this.labelWynik.TabIndex = 0;
            this.labelWynik.Text = "Wynik: 0";
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelQuestion.Location = new System.Drawing.Point(12, 123);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(130, 40);
            this.labelQuestion.TabIndex = 1;
            this.labelQuestion.Text = "Pytanie:";
            // 
            // labelAns1
            // 
            this.labelAns1.AutoSize = true;
            this.labelAns1.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAns1.Location = new System.Drawing.Point(9, 242);
            this.labelAns1.Name = "labelAns1";
            this.labelAns1.Size = new System.Drawing.Size(44, 40);
            this.labelAns1.TabIndex = 3;
            this.labelAns1.Text = "a)";
            this.labelAns1.Click += new System.EventHandler(this.labelAns1_Click);
            // 
            // labelAns2
            // 
            this.labelAns2.AutoSize = true;
            this.labelAns2.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAns2.Location = new System.Drawing.Point(10, 282);
            this.labelAns2.Name = "labelAns2";
            this.labelAns2.Size = new System.Drawing.Size(45, 40);
            this.labelAns2.TabIndex = 4;
            this.labelAns2.Text = "b)";
            this.labelAns2.Click += new System.EventHandler(this.labelAns2_Click);
            // 
            // labelAns4
            // 
            this.labelAns4.AutoSize = true;
            this.labelAns4.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAns4.Location = new System.Drawing.Point(8, 362);
            this.labelAns4.Name = "labelAns4";
            this.labelAns4.Size = new System.Drawing.Size(45, 40);
            this.labelAns4.TabIndex = 6;
            this.labelAns4.Text = "d)";
            this.labelAns4.Click += new System.EventHandler(this.labelAns4_Click);
            // 
            // labelAns3
            // 
            this.labelAns3.AutoSize = true;
            this.labelAns3.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAns3.Location = new System.Drawing.Point(10, 322);
            this.labelAns3.Name = "labelAns3";
            this.labelAns3.Size = new System.Drawing.Size(43, 40);
            this.labelAns3.TabIndex = 5;
            this.labelAns3.Text = "c)";
            this.labelAns3.Click += new System.EventHandler(this.labelAns3_Click);
            // 
            // buttonNextQuestion
            // 
            this.buttonNextQuestion.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonNextQuestion.Location = new System.Drawing.Point(818, 13);
            this.buttonNextQuestion.Name = "buttonNextQuestion";
            this.buttonNextQuestion.Size = new System.Drawing.Size(148, 54);
            this.buttonNextQuestion.TabIndex = 8;
            this.buttonNextQuestion.Text = "Dalej";
            this.buttonNextQuestion.UseVisualStyleBackColor = true;
            this.buttonNextQuestion.Click += new System.EventHandler(this.buttonNextQuestion_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonStart.Location = new System.Drawing.Point(826, 12);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(148, 54);
            this.buttonStart.TabIndex = 9;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // textBoxImie
            // 
            this.textBoxImie.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxImie.Location = new System.Drawing.Point(27, 24);
            this.textBoxImie.Name = "textBoxImie";
            this.textBoxImie.Size = new System.Drawing.Size(169, 48);
            this.textBoxImie.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "FNQ - Festiwal Nauki Quiz";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button buttonLoadDataFile;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonAddQuestion;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button buttonLoadRanking;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonNextQuestion;
        private System.Windows.Forms.Label labelAns4;
        private System.Windows.Forms.Label labelAns3;
        private System.Windows.Forms.Label labelAns2;
        private System.Windows.Forms.Label labelAns1;
        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.Label labelWynik;
        private System.Windows.Forms.TextBox textBoxImie;
        private System.Windows.Forms.Button buttonStart;
    }
}

