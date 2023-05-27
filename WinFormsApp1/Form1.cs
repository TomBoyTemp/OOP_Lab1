using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace WinFormsApp1
{
    public partial class ParentForm : Form
    {
        int global_x, global_y, i=0;
        public ParentForm()
        { 
            InitializeComponent();
            Text = "Lab №1";
            this.BackColor = Color.Silver;
            spData.Text = Convert.ToString(System.DateTime.Today.ToLongDateString());
           
        }
        private void ParentForm_Load(object sender, EventArgs e)
        {
        
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
             this.Controls.Remove(sender as Button); 
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMe_MouseMove(object sender, MouseEventArgs e)
        {
            btnMe.Top -= e.Y;
            btnMe.Left += e.X;
            if (btnMe.Top < 30 || btnMe.Top > 180)
                btnMe.Top = 50;
            if (btnMe.Left < 0 || btnMe.Left > 180)
                btnMe.Left = 150;
        }

        private void ParentForm_MouseMove(object sender, MouseEventArgs e)
        {
            locX.Text = e.X.ToString();
            global_x = int.Parse(locX.Text);
            locY.Text = e.Y.ToString();
            global_y = int.Parse(locY.Text);
        }

        private void NewMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm newForm = new ChildForm();
            newForm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WindowCascadeMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
            spWin.Text = "Windows is cascade";
        }

        private void WindowTitleMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
            spWin.Text = "Windows is horizontal";
        }

        private void NewMenuItem_Click_1(object sender, EventArgs e)
        {
            ChildForm newChild = new ChildForm();
            newChild.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbPeopleList.Text.Length != 0)
            {
                clbMemberList.Items.Add(cbPeopleList.Text);
            }
            else MessageBox.Show("Выбирете элемент из списка или ввидите новый");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            while (clbMemberList.CheckedIndices.Count > 0)
                clbMemberList.Items.RemoveAt(clbMemberList.CheckedIndices[0]);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
           
        }

        private void ParentForm_MouseClick(object sender, MouseEventArgs e)
        {
            System.Windows.Forms.Button btn = new System.Windows.Forms.Button();
            btn.Location = new System.Drawing.Point(e.X - btn.Size.Width / 2, e.Y - btn.Size.Height / 2);
            btn.Click += new System.EventHandler(this.btnOK_Click);
            this.Controls.Add(btn);
        }

        private void timer2_Tick(object sender, EventArgs e)
        { 
            if(timer2.Enabled)
            {
                i++;
                lbTm.Text = i.ToString();
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            timer2.Enabled = !timer2.Enabled;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer2.Enabled = false;
        }

        private void BackGroundMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                richTextBox1.BackColor = colorDialog1.Color;
        }

        private void but_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
                this.but.Text = "First";
            else if (radioButton2.Checked == true)
                this.but.Text = "Second";

        }
        private void ParentForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            lbKey.Text = e.KeyChar.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            clbMemberList.Sorted = true;
        }
    }
}
