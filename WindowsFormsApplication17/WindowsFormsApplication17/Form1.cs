using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication17
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            activity_menu.Hide();
            outpartyledger_table.Hide();
            outparty_menu.Hide();
            member_table.Hide();
            ledger_table.Hide();
            panel2.Hide();
            pictureBox2.Hide();
            metroTile9.Hide();
            member_menu.Hide();
            office_menu.Hide();

        }

        private void metroTile7_Click(object sender, EventArgs e)
        {
            office_menu.Show();
            panel2.Hide();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {


            panel1.Hide();
            panel2.Show();
            pictureBox1.Hide();
            pictureBox2.Show();

            metroTile9.Show();
        }

        private void metroTile9_Click(object sender, EventArgs e)
        {

            panel1.Show();
            panel2.Hide();
            pictureBox1.Show();
            pictureBox2.Hide();

            metroTile9.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panel2.Show();
            outparty_menu.Hide();
            member_menu.Hide();
            office_menu.Hide();
            activity_menu.Hide();
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            member_menu.Show();
            member_table.Show();
            panel2.Hide();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            ledger_table.Show();
            member_table.Hide();
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            activity_menu.Show();
            panel2.Hide();

            //for rectangle in picture box

            Size gridSize = new Size(emailFormating.Width / 3, emailFormating.Height);

            int x = emailFormating.Width, y = emailFormating.Height;
            label1.Text = y.ToString();
            grids.Add(new Grid(new Point(0, 0), gridSize, "ONE"));
            grids.Add(new Grid(new Point(x / 3, 0), gridSize, "TWO"));
            grids.Add(new Grid(new Point((2 * x) / 3, 0), gridSize, "THREE"));
        }
        List<Grid> grids = new List<Grid>();
        private void metroTile12_Click(object sender, EventArgs e)
        {
            outparty_table.Hide();
            outpartyledger_table.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }



        private void metroTile8_Click_1(object sender, EventArgs e)
        {

            outparty_menu.Show();
            panel2.Hide();
            activity_menu.Hide();
        }

        private void metroTile11_Click(object sender, EventArgs e)
        {
            outparty_table.Show();
            outpartyledger_table.Hide();
        }

        private void metroTile22_Click(object sender, EventArgs e)
        {
            ledger_table.Hide();
            member_table.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            email aa = new email();
            if (String.IsNullOrEmpty(messageBox.Text))
                MessageBox.Show("Messages is empty");
            else
                MessageBox.Show( aa.sendEmail(messageBox.Text,openFileDialog1.FileName.ToString()));
        }

        private void emailFormating_MouseMove(object sender, MouseEventArgs e)
        {
            /*get location of mouse
            Point mouse = new Point(e.X, e.Y);
            //search grids to find one the one containing the mouses location
            Grid CurrentGrid = grids.Find(delegate(Grid g) { return g.Rectangle.Contains(mouse) == true; });
            if (CurrentGrid != null)
                //print grid name to a label
               
                messageBox.Text = CurrentGrid.GridName + e.X.ToString();*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                MessageBox.Show(openFileDialog1.FileName.ToString());
            }
            
        }
    }

}