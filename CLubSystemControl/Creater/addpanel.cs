using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLubSystemControl
{
    class addpanel
    {
        public void AddPanel()
        {

            Panel createpanel = new Panel();
            createpanel.Location = new Point(panel2.Location.X, panel2.Location.Y);
            createpanel.BorderStyle = BorderStyle.FixedSingle;
            createpanel.Size = panel2.Size;
            createpanel.Name = "PanelNew" + countPanel;
            createpanel.BackColor = Color.White;
            Controls.Add(createpanel);
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
                if (createpanel.Visible = false)
                    createpanel.Visible = true;

            };
            createpanel.Controls.Add(createbuttondclose);


            Button createbuttonstarttime = new Button();
            createbuttonstarttime.Location = new Point(-1, 201);
            createbuttonstarttime.Size = new System.Drawing.Size(200, 29);
            createbuttonstarttime.Name = "tarttime" + countPanel;
            createbuttonstarttime.BackColor = Color.Black;
            createbuttonstarttime.UseVisualStyleBackColor = true;
            createbuttonstarttime.Text = "Запустить время";
            createpanel.Controls.Add(createbuttonstarttime);


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
            skidon.Name = "label3";
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
            timertoend.Text = "0:00";
            createpanel.Controls.Add(timertoend);
            countPanel++;


        }

    }
}
