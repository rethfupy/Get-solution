
namespace GetSolution
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelTop = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.labelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.labelC = new System.Windows.Forms.Label();
            this.textboxA = new System.Windows.Forms.TextBox();
            this.textboxB = new System.Windows.Forms.TextBox();
            this.textboxC = new System.Windows.Forms.TextBox();
            this.buttonSum = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.labelBot = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.clearMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.infoMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTop
            // 
            this.labelTop.BackColor = System.Drawing.Color.Transparent;
            this.labelTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTop.Location = new System.Drawing.Point(12, 45);
            this.labelTop.Name = "labelTop";
            this.labelTop.Size = new System.Drawing.Size(435, 54);
            this.labelTop.TabIndex = 0;
            this.labelTop.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(199, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 136);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбор типа уравнения:";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(28, 46);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(204, 22);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Квадратное уравнение";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(28, 86);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(187, 22);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "Линейное уравнение";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.BackColor = System.Drawing.Color.Transparent;
            this.labelA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelA.Location = new System.Drawing.Point(13, 122);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(27, 18);
            this.labelA.TabIndex = 2;
            this.labelA.Text = "a :";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.BackColor = System.Drawing.Color.Transparent;
            this.labelB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelB.Location = new System.Drawing.Point(13, 164);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(27, 18);
            this.labelB.TabIndex = 3;
            this.labelB.Text = "b :";
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.BackColor = System.Drawing.Color.Transparent;
            this.labelC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelC.Location = new System.Drawing.Point(13, 205);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(27, 18);
            this.labelC.TabIndex = 4;
            this.labelC.Text = "c :";
            // 
            // textboxA
            // 
            this.textboxA.Location = new System.Drawing.Point(46, 123);
            this.textboxA.Name = "textboxA";
            this.textboxA.Size = new System.Drawing.Size(132, 20);
            this.textboxA.TabIndex = 5;
            this.textboxA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxA_KeyPress);
            this.textboxA.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textboxA_KeyUp);
            this.textboxA.Validating += new System.ComponentModel.CancelEventHandler(this.textboxA_Validating);
            // 
            // textboxB
            // 
            this.textboxB.Location = new System.Drawing.Point(46, 165);
            this.textboxB.Name = "textboxB";
            this.textboxB.Size = new System.Drawing.Size(132, 20);
            this.textboxB.TabIndex = 6;
            this.textboxB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxA_KeyPress);
            this.textboxB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textboxA_KeyUp);
            this.textboxB.Validating += new System.ComponentModel.CancelEventHandler(this.textboxA_Validating);
            // 
            // textboxC
            // 
            this.textboxC.Location = new System.Drawing.Point(46, 206);
            this.textboxC.Name = "textboxC";
            this.textboxC.Size = new System.Drawing.Size(132, 20);
            this.textboxC.TabIndex = 7;
            this.textboxC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxA_KeyPress);
            this.textboxC.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textboxA_KeyUp);
            this.textboxC.Validating += new System.ComponentModel.CancelEventHandler(this.textboxA_Validating);
            // 
            // buttonSum
            // 
            this.buttonSum.Enabled = false;
            this.buttonSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSum.Location = new System.Drawing.Point(67, 288);
            this.buttonSum.Name = "buttonSum";
            this.buttonSum.Size = new System.Drawing.Size(102, 28);
            this.buttonSum.TabIndex = 8;
            this.buttonSum.Text = "Вычислить";
            this.buttonSum.UseVisualStyleBackColor = true;
            this.buttonSum.Click += new System.EventHandler(this.buttonSum_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClear.Location = new System.Drawing.Point(199, 288);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(102, 28);
            this.buttonClear.TabIndex = 9;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // labelBot
            // 
            this.labelBot.BackColor = System.Drawing.Color.Transparent;
            this.labelBot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBot.Location = new System.Drawing.Point(12, 356);
            this.labelBot.Name = "labelBot";
            this.labelBot.Size = new System.Drawing.Size(435, 54);
            this.labelBot.TabIndex = 10;
            this.labelBot.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.infoMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(459, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearMenu,
            this.toolStripSeparator1,
            this.exitMenu});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(48, 20);
            this.fileMenu.Text = "&Файл";
            // 
            // clearMenu
            // 
            this.clearMenu.Name = "clearMenu";
            this.clearMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.clearMenu.Size = new System.Drawing.Size(164, 22);
            this.clearMenu.Text = "&Очистить";
            this.clearMenu.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(161, 6);
            // 
            // exitMenu
            // 
            this.exitMenu.Name = "exitMenu";
            this.exitMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.exitMenu.Size = new System.Drawing.Size(164, 22);
            this.exitMenu.Text = "&Выход";
            this.exitMenu.Click += new System.EventHandler(this.exitMenu_Click);
            // 
            // infoMenu
            // 
            this.infoMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMenu});
            this.infoMenu.Name = "infoMenu";
            this.infoMenu.Size = new System.Drawing.Size(51, 20);
            this.infoMenu.Text = "Инфо";
            // 
            // aboutMenu
            // 
            this.aboutMenu.Name = "aboutMenu";
            this.aboutMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.I)));
            this.aboutMenu.Size = new System.Drawing.Size(182, 22);
            this.aboutMenu.Text = "&О программе";
            this.aboutMenu.Click += new System.EventHandler(this.aboutMenu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GetSolution.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(459, 450);
            this.Controls.Add(this.labelBot);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonSum);
            this.Controls.Add(this.textboxC);
            this.Controls.Add(this.textboxB);
            this.Controls.Add(this.textboxA);
            this.Controls.Add(this.labelC);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelTop);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = " ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.TextBox textboxA;
        private System.Windows.Forms.TextBox textboxB;
        private System.Windows.Forms.TextBox textboxC;
        private System.Windows.Forms.Button buttonSum;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label labelBot;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem clearMenu;
        private System.Windows.Forms.ToolStripMenuItem infoMenu;
        private System.Windows.Forms.ToolStripMenuItem aboutMenu;
        private System.Windows.Forms.ToolStripMenuItem exitMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

