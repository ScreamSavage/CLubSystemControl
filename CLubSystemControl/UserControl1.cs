using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CLubSystemControl.MainForm1337;

namespace CLubSystemControl
{
    public partial class UserControl1 : UserControl
    {


        public delegate void AddPanelDelegate();
        public static event AddPanelDelegate AddPanelEvent;
        public UserControl1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void button1_Click(object sender, EventArgs e)
        {
             
            AddPanelEvent?.Invoke();
            this.Hide();

        }

        private void Namepaneltext_TextChanged(object sender, EventArgs e)
        {

            MainForm1337 mainForm1337 = new MainForm1337();
          mainForm1337.namebron = Namepaneltext.Text;
            mainForm1337.phonenumber = textBox3.Text;
            mainForm1337.typebron = comboBox1.SelectedText;
            mainForm1337.timebron = textBox1.Text;
            mainForm1337.counttimebron = textBox2.Text;

        }
    }
}
