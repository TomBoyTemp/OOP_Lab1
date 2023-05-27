
namespace WinFormsApp1
{
    partial class ParentForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gp = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.but = new System.Windows.Forms.Button();
            this.btnMe = new System.Windows.Forms.Button();
            this.locX = new System.Windows.Forms.Label();
            this.locY = new System.Windows.Forms.Label();
            this.statAusStrip1 = new System.Windows.Forms.StatusStrip();
            this.spWin = new System.Windows.Forms.ToolStripStatusLabel();
            this.spData = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WindowMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WindowCascadeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WindowTileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BackGroundMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gpBox = new System.Windows.Forms.GroupBox();
            this.cbPeopleList = new System.Windows.Forms.ComboBox();
            this.clbMemberList = new System.Windows.Forms.CheckedListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lblTimer = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lbTm = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbKey = new System.Windows.Forms.Label();
            this.gp.SuspendLayout();
            this.statAusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.gpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // gp
            // 
            this.gp.Controls.Add(this.radioButton2);
            this.gp.Controls.Add(this.radioButton1);
            this.gp.Location = new System.Drawing.Point(12, 206);
            this.gp.Name = "gp";
            this.gp.Size = new System.Drawing.Size(200, 100);
            this.gp.TabIndex = 1;
            this.gp.TabStop = false;
            this.gp.Text = "Choice";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(21, 47);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(94, 19);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(21, 22);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(94, 19);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // but
            // 
            this.but.Location = new System.Drawing.Point(12, 323);
            this.but.Name = "but";
            this.but.Size = new System.Drawing.Size(75, 23);
            this.but.TabIndex = 0;
            this.but.UseVisualStyleBackColor = true;
            this.but.Click += new System.EventHandler(this.but_Click);
            // 
            // btnMe
            // 
            this.btnMe.Location = new System.Drawing.Point(50, 150);
            this.btnMe.Name = "btnMe";
            this.btnMe.Size = new System.Drawing.Size(107, 23);
            this.btnMe.TabIndex = 0;
            this.btnMe.TabStop = false;
            this.btnMe.Text = "Нажми на меня";
            this.btnMe.UseVisualStyleBackColor = true;
            this.btnMe.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnMe_MouseMove);
            // 
            // locX
            // 
            this.locX.AutoSize = true;
            this.locX.Location = new System.Drawing.Point(12, 369);
            this.locX.Name = "locX";
            this.locX.Size = new System.Drawing.Size(0, 15);
            this.locX.TabIndex = 2;
            // 
            // locY
            // 
            this.locY.AutoSize = true;
            this.locY.Location = new System.Drawing.Point(60, 369);
            this.locY.Name = "locY";
            this.locY.Size = new System.Drawing.Size(0, 15);
            this.locY.TabIndex = 3;
            // 
            // statAusStrip1
            // 
            this.statAusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spWin,
            this.spData});
            this.statAusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statAusStrip1.Name = "statAusStrip1";
            this.statAusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statAusStrip1.TabIndex = 5;
            // 
            // spWin
            // 
            this.spWin.Name = "spWin";
            this.spWin.Size = new System.Drawing.Size(39, 17);
            this.spWin.Text = "Status";
            // 
            // spData
            // 
            this.spData.Name = "spData";
            this.spData.Size = new System.Drawing.Size(31, 17);
            this.spData.Text = "Data";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuItem,
            this.WindowMenuItem,
            this.formatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileMenuItem
            // 
            this.FileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.FileMenuItem.Name = "FileMenuItem";
            this.FileMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileMenuItem.Text = "&File";
            // 
            // NewMenuItem
            // 
            this.NewMenuItem.Name = "NewMenuItem";
            this.NewMenuItem.Size = new System.Drawing.Size(98, 22);
            this.NewMenuItem.Text = "&New";
            this.NewMenuItem.Click += new System.EventHandler(this.NewMenuItem_Click_1);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(95, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            // 
            // WindowMenuItem
            // 
            this.WindowMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WindowCascadeMenuItem,
            this.WindowTileMenuItem});
            this.WindowMenuItem.Name = "WindowMenuItem";
            this.WindowMenuItem.Size = new System.Drawing.Size(63, 20);
            this.WindowMenuItem.Text = "&Window";
            // 
            // WindowCascadeMenuItem
            // 
            this.WindowCascadeMenuItem.Name = "WindowCascadeMenuItem";
            this.WindowCascadeMenuItem.Size = new System.Drawing.Size(118, 22);
            this.WindowCascadeMenuItem.Text = "&Cascade";
            this.WindowCascadeMenuItem.Click += new System.EventHandler(this.WindowCascadeMenuItem_Click);
            // 
            // WindowTileMenuItem
            // 
            this.WindowTileMenuItem.Name = "WindowTileMenuItem";
            this.WindowTileMenuItem.Size = new System.Drawing.Size(118, 22);
            this.WindowTileMenuItem.Text = "&Tile";
            this.WindowTileMenuItem.Click += new System.EventHandler(this.WindowTitleMenuItem_Click);
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BackGroundMenuItem});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.formatToolStripMenuItem.Text = "&Format";
            // 
            // BackGroundMenuItem
            // 
            this.BackGroundMenuItem.Name = "BackGroundMenuItem";
            this.BackGroundMenuItem.Size = new System.Drawing.Size(171, 22);
            this.BackGroundMenuItem.Text = "BackGround Color";
            this.BackGroundMenuItem.Click += new System.EventHandler(this.BackGroundMenuItem_Click);
            // 
            // gpBox
            // 
            this.gpBox.Controls.Add(this.cbPeopleList);
            this.gpBox.Controls.Add(this.clbMemberList);
            this.gpBox.Location = new System.Drawing.Point(328, 196);
            this.gpBox.Name = "gpBox";
            this.gpBox.Size = new System.Drawing.Size(261, 188);
            this.gpBox.TabIndex = 7;
            this.gpBox.TabStop = false;
            this.gpBox.Text = "Список участников";
            // 
            // cbPeopleList
            // 
            this.cbPeopleList.FormattingEnabled = true;
            this.cbPeopleList.Items.AddRange(new object[] {
            "Иванов И.И.",
            "Сидоров П.К.",
            "Петров А.М.",
            "Шорохов Н.И."});
            this.cbPeopleList.Location = new System.Drawing.Point(132, 39);
            this.cbPeopleList.Name = "cbPeopleList";
            this.cbPeopleList.Size = new System.Drawing.Size(121, 23);
            this.cbPeopleList.TabIndex = 1;
            // 
            // clbMemberList
            // 
            this.clbMemberList.FormattingEnabled = true;
            this.clbMemberList.Location = new System.Drawing.Point(6, 39);
            this.clbMemberList.Name = "clbMemberList";
            this.clbMemberList.Size = new System.Drawing.Size(120, 94);
            this.clbMemberList.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(611, 235);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(87, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(611, 264);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(611, 293);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(87, 23);
            this.btnSort.TabIndex = 9;
            this.btnSort.Text = "Сортировать";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(713, 38);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(698, 431);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 13;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(599, 401);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(0, 15);
            this.lblTimer.TabIndex = 14;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(668, 397);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(80, 23);
            this.btnStop.TabIndex = 15;
            this.btnStop.Text = "Остановить";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(587, 397);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 16;
            this.btnPlay.Text = "Запустить";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(328, 39);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(230, 96);
            this.richTextBox1.TabIndex = 17;
            this.richTextBox1.Text = "";
            // 
            // lbTm
            // 
            this.lbTm.AutoSize = true;
            this.lbTm.Location = new System.Drawing.Point(662, 369);
            this.lbTm.Name = "lbTm";
            this.lbTm.Size = new System.Drawing.Size(0, 15);
            this.lbTm.TabIndex = 18;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 0;
            // 
            // lbKey
            // 
            this.lbKey.AutoSize = true;
            this.lbKey.Location = new System.Drawing.Point(13, 397);
            this.lbKey.Name = "lbKey";
            this.lbKey.Size = new System.Drawing.Size(0, 15);
            this.lbKey.TabIndex = 19;
            // 
            // ParentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbKey);
            this.Controls.Add(this.lbTm);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gpBox);
            this.Controls.Add(this.statAusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.locY);
            this.Controls.Add(this.locX);
            this.Controls.Add(this.btnMe);
            this.Controls.Add(this.but);
            this.Controls.Add(this.gp);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ParentForm";
            this.Text = "Parent Form";
            this.Load += new System.EventHandler(this.ParentForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ParentForm_KeyPress);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ParentForm_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ParentForm_MouseMove);
            this.gp.ResumeLayout(false);
            this.gp.PerformLayout();
            this.statAusStrip1.ResumeLayout(false);
            this.statAusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gpBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gp;
        private System.Windows.Forms.Button but;
        private System.Windows.Forms.Button btnMe;
        private System.Windows.Forms.Label locX;
        private System.Windows.Forms.Label locY;
        private System.Windows.Forms.StatusStrip statAusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel spWin;
        private System.Windows.Forms.ToolStripStatusLabel spData;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WindowMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WindowCascadeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WindowTileMenuItem;
        private System.Windows.Forms.GroupBox gpBox;
        private System.Windows.Forms.ComboBox cbPeopleList;
        private System.Windows.Forms.CheckedListBox clbMemberList;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BackGroundMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label lbTm;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbKey;
    }
}

