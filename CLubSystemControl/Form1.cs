
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CLubSystemControl.Form2;
using static CLubSystemControl.UserControl1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using Label = System.Windows.Forms.Label;
using static CLubSystemControl.Form3;
using static CLubSystemControl.UserControl1;


namespace CLubSystemControl
{
    public partial class MainForm1337 : Form
    {
        public MainForm1337()
        {
            InitializeComponent();
            form2 = new Form2(this);
            form3 = new Form3();
            UserControl userControl = new UserControl();


        }
        string newX = "";
        string newy = "";
        string newyW = "";
        private int secondsPassed = 0;
        public static string namebrone;
        private int _secondsElapsed;

        public string namebron;
        public string phonenumber;
        public string typebron;
        public string timebron;
        public string counttimebron;


        int countPanel = 0;
        int countbron = 0;
        WebClient client = new WebClient();
        public delegate void UpdateTextDelegate(string Namepanel);

        private Form2 form2 = new Form2();
        private Form3 form3 = new Form3();
        private UserControl1 MycontrolForm = new UserControl1();
        Panel createpanel = new Panel();

 
        private void addpanel_Click(object sender, EventArgs e)
        {

            form2.Show();
            form2.AddPanelEvent += new Form2.AddPanelDelegate(AddPanel);


        }

        private void addpanel_MouseDown(object sender, MouseEventArgs e)
        {
            this.panelnew.ForeColor = Color.Green;
        }

        private void addpanel_MouseUp(object sender, MouseEventArgs e)
        {
            this.panelnew.ForeColor = Color.Black;
        }

        private void sellorbonus_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void nameunit_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            UserControl1.AddPanelEvent += new UserControl1.AddPanelDelegate(createbron);
            UserControl1 myControl = new UserControl1();
            myControl.BringToFront();
            this.Controls.Add(myControl);
            myControl.Location = new Point(558, 284);
            myControl.Size = new System.Drawing.Size(281, 268);
            myControl.Show();
            myControl.BringToFront();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
      
        private void dropTime_Click(object sender, EventArgs e)
        {
         
        }
        
        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            form3.Show();

        }

        #region добавление панели
        public void AddPanel()
        {

            Panel createpanel = new Panel();
            createpanel.Location = new Point(panel2.Location.X, panel2.Location.Y);
            createpanel.BorderStyle = BorderStyle.FixedSingle;
            createpanel.Size = panel2.Size;
            createpanel.Name = "PanelNew" + countPanel;
            createpanel.BackColor = Color.White;
            tableLayoutPanel1.Controls.Add(createpanel);
            form2.AddPanelEvent -= new Form2.AddPanelDelegate(AddPanel);
            if (countPanel <= 2)
            {
                panel2.Location = new Point(createpanel.Location.X + createpanel.Width + 5, createpanel.Location.Y);
            }
            else
            {
                panel2.Location = new Point(createpanel.Location.X - ((createpanel.Width) * 3) - 14, createpanel.Location.Y + createpanel.Height + 5);
            }
            if (countPanel >= 4)
            {
                panel2.Location = new Point(createpanel.Location.X + createpanel.Width + 5, createpanel.Location.Y);
            }

            if (countPanel >= 7)
            {
                panel2.Visible = false;
            }

            Button createbuttondroptime = new Button();
            createbuttondroptime.Location = new System.Drawing.Point(-1, 237);
            createbuttondroptime.Size = new System.Drawing.Size(200, 29);
            createbuttondroptime.Name = "ButtonNew" + countPanel;
            createbuttondroptime.BackColor = Color.Black;
            createbuttondroptime.UseVisualStyleBackColor = true;
            createbuttondroptime.Text = "Остановить Время";
            createpanel.Controls.Add(createbuttondroptime);

            Button createbuttondclose = new Button();
            createbuttondclose.Location = new System.Drawing.Point(177, -1);
            createbuttondclose.Name = "buttondclose" + countPanel;
            createbuttondclose.Size = new System.Drawing.Size(22, 22);
            createbuttondclose.TabIndex = 9;
            createbuttondclose.Text = "✖";
            createbuttondclose.UseVisualStyleBackColor = true;
            createbuttondclose.Click += new System.EventHandler(this.dropTime_Click);
            createbuttondclose.Click += (sender, e) =>
            {
                createpanel.Dispose();
                countPanel--;
                panel2.Location = new Point(createpanel.Location.X, createpanel.Location.Y);
                if (createpanel.Visible == false)
                    panel2.Visible = true;

            };
            createpanel.Controls.Add(createbuttondclose);


           


            System.Windows.Forms.Label nameuser = new System.Windows.Forms.Label(); ;
            nameuser.AutoSize = false;
            nameuser.Height = 24;
            nameuser.Width = 200;
            nameuser.Location = new Point((createpanel.Width - nameuser.Width) / 2, 87);
            nameuser.Name = "nameuser" + countPanel;
            nameuser.Size = nameuser.Size;
            nameuser.TabIndex = 4;
            nameuser.TextAlign = ContentAlignment.MiddleCenter;
            nameuser.Text = this.form2.nameunitpanel1;
            createpanel.Controls.Add(nameuser);

            System.Windows.Forms.Label numberboard = new System.Windows.Forms.Label();
            numberboard.AutoSize = true;
            numberboard.Location = new Point((createpanel.Width - numberboard.Width) / 2, 112);
            numberboard.Name = "numberboard" + countPanel;
            numberboard.TabIndex = 8;
            numberboard.Text = "Номер_стола: " + form2.comboBox4text.ToString();
            createpanel.Controls.Add(numberboard);

            System.Windows.Forms.Label nameunit = new System.Windows.Forms.Label();
            nameunit.Location = new System.Drawing.Point(76, 135);
            nameunit.AutoSize = true;
            nameunit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            nameunit.ForeColor = System.Drawing.Color.Red;
            nameunit.Name = "nameunit";
            nameunit.Size = new System.Drawing.Size(62, 25);
            nameunit.TabIndex = 6;
            nameunit.Text = this.form2.nameunittext;
            nameunit.Click += new System.EventHandler(this.nameunit_Click);
            createpanel.Controls.Add(nameunit);


            System.Windows.Forms.Label skidon = new System.Windows.Forms.Label();
            skidon.AutoSize = true;
            skidon.Location = new System.Drawing.Point(3, 3);
            skidon.Name = "skidka";
            skidon.Size = new System.Drawing.Size(64, 13);
            skidon.TabIndex = 7;
            skidon.Text = this.form2.skidonint + "%";
            createpanel.Controls.Add(skidon);

            System.Windows.Forms.Label timertoend = new System.Windows.Forms.Label();
            numberboard.Location = new Point(panel2.Width / 2 - numberboard.Width / 2, numberboard.Location.Y);
            timertoend.AutoSize = true;
            timertoend.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            timertoend.Location = new System.Drawing.Point(76, 169);
            timertoend.Name = "timerTable";
            timertoend.Size = new System.Drawing.Size(54, 25);
            timertoend.TabIndex = 2;
            timertoend.Text =form2.TimerBoxHour.Text.Replace(" Ч","") + ":"+ form2.TimerBoxMin.Text;
            createpanel.Controls.Add(timertoend);



            Button createbuttonstarttime = new Button();
            createbuttonstarttime.Location = new Point(-1, 201);
            createbuttonstarttime.Size = new System.Drawing.Size(200, 29);
            createbuttonstarttime.Name = "starttime" + countPanel;
            createbuttonstarttime.BackColor = Color.Black;
            createbuttonstarttime.UseVisualStyleBackColor = true;
            createbuttonstarttime.Text = "Запустить время";
            createbuttonstarttime.Click += (sender, e) =>
            {
                Timer timer = new Timer();
                timer.Interval = 10000; // задаем интервал в миллисекундах
                timer.Tick += new EventHandler(timer_Tick);
                timer.Start(); // запускаем таймер
                timertoend.Text = _secondsElapsed.ToString();

            };
            createpanel.Controls.Add(createbuttonstarttime);



            countPanel++;


        }
        #endregion


        private void timer_Tick(object sender, EventArgs e)
        {
            _secondsElapsed++;
            
        }


        #region создание бронирование
        public void createbron()
        {
            UserControl1 usercontrol1 = new UserControl1();
            UserControl1.AddPanelEvent -= new UserControl1.AddPanelDelegate(createbron);
            Panel listbrun = new Panel();
            listbrun.Name = "listbrun" + countbron;
            listbrun.BorderStyle = BorderStyle.FixedSingle;
            // switch (countbron)
            listbrun.Location = new Point(4, 47);
            listbrun.Name = "panel4" + countbron;
            listbrun.Size = new System.Drawing.Size(289, 41);
            listbrun.TabIndex = 10;
            tableLayoutPanel2.Controls.Add(listbrun);

            Label inlistbron = new Label();
            inlistbron.AutoSize = true;
            inlistbron.Location = new System.Drawing.Point(64, 7);
            inlistbron.Name = "label5" + countbron;
            inlistbron.Size = new System.Drawing.Size(298, 660);
            inlistbron.ForeColor = Color.Black;
            inlistbron.TabIndex = 9;

            inlistbron.Text = namebron; // "Александр : PS5 : 18-30 :4 часа";
            inlistbron.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            MessageBox.Show(inlistbron.Text);
            listbrun.Controls.Add(inlistbron);

            Label numberhpotebrone = new Label();
            numberhpotebrone.AutoSize = true;
            numberhpotebrone.Height = 41;
            numberhpotebrone.Width = 280;
            numberhpotebrone.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            numberhpotebrone.Location = new Point((listbrun.Width - numberhpotebrone.Width) / 2, 22);
            numberhpotebrone.Name = "label6";
            numberhpotebrone.Size = new System.Drawing.Size(67, 13);
            numberhpotebrone.TabIndex = 10;
            numberhpotebrone.Text = "                     Номер телефона:7999351993";
            listbrun.Controls.Add(numberhpotebrone);

            /*
            namebron;
            phonenumber;
            typebron;
            timebron;
            counttimebron;
            */

            //  client.DownloadString("https://api.telegram.org/bot6240188359:AAFwBrvC_VaIVPDPzA-nlQrqET8afRUEkTg/sendmessage?chat_id=-1001920592858&text=😱Созданно бронирование😱\n 🗣ИМЯ: Александр 🗣\n 🎮ТИП: PS5🎮 \n ⏱Время:18-00⏱ \n ⏰Количество часов:100⏰ \n 📞Номер телефона: 888005553535📞");
            Button broneclose = new Button();
            broneclose.Location = new System.Drawing.Point(266, -1);
            broneclose.Name = "button4";
            broneclose.Size = new System.Drawing.Size(22, 22);
            broneclose.TabIndex = 10;
            broneclose.Text = "✖";
            broneclose.UseVisualStyleBackColor = true;
            broneclose.Click += new System.EventHandler(this.dropTime_Click);

            listbrun.Controls.Add(broneclose);
            countbron++;
            broneclose.Click += (sender, e) =>
            {
                listbrun.Dispose();
                countbron--;
                MessageBox.Show(countPanel.ToString());

            };
             //client.DownloadString("https://api.telegram.org/bot6240188359:AAFwBrvC_VaIVPDPzA-nlQrqET8afRUEkTg/sendmessage?chat_id=-1001920592858&text=😱Созданно бронирование😱\n 🗣ИМЯ: Александр 🗣\n 🎮ТИП: PS5🎮 \n ⏱Время:18-00⏱ \n ⏰Количество часов:100⏰ \n 📞Номер телефона: 888005553535📞");

            MessageBox.Show("Бронирование добавленно!");
        }

        #endregion
    }
}
