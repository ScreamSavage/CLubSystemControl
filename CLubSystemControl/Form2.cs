using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CLubSystemControl.MainForm1337;

namespace CLubSystemControl
{
    public partial class Form2 : Form
    {

        public string Namepanel1 = "";
        public string nameunitpanel1 = "";
        public string comboBox4text = "";
        public string nameunittext = "";
        public int skidonint = 0;

        

        
        public Form2(MainForm1337 MainForm1337)
        {
            InitializeComponent();
            
        }
        public delegate void AddPanelDelegate();
        public event AddPanelDelegate AddPanelEvent;
       
        
        
        public Form2()
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            { 
                nameunitpanel1 = Namepaneltext.Text; 
            }
            catch {

                MessageBox.Show("Не введенно имя стола!");
            
            }




            try
            {
                comboBox4text = comboBox4.SelectedItem.ToString();
                comboBox4text = comboBox4.SelectedItem.ToString();
            }
            catch 
            
            {
                MessageBox.Show("не выбран номер стола!");
                return;
            }


            try
            {
                nameunittext = comboBox1.SelectedItem.ToString();
            }
            catch

            {
                MessageBox.Show("не выбран тип стола!");
                return;
            }

            try
            {
                skidonint = int.Parse(comboBox5.SelectedItem.ToString());
            }
            catch

            {
                MessageBox.Show("скидка не установленна!");
                return;
            }
            

            AddPanelEvent?.Invoke();
            this.Hide();
            
        }

        public void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8) 
            {
                e.Handled = true;
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Namepaneltext_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
