using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLubSystemControl
{
    class Createbron
    {

       public void createbron()
        {

            UserControl1.AddPanelEvent -= new UserControl1.AddPanelDelegate(createbron);
            Panel listbrun = new Panel();
            listbrun.Name = "listbrun" + countbron;
            listbrun.BorderStyle = BorderStyle.FixedSingle;
            switch (countbron)
            {
                case 0:
                    listbrun.Location = new Point(4, 47);
                    break;

                case 1:
                    listbrun.Location = new Point(4, (47 * 2) - 15);
                    break;

                case 2:
                    listbrun.Location = new Point(4, (47 * 3) - 30);
                    break;

                case 3:
                    listbrun.Location = new Point(4, (47 * 4) - 45);
                    break;
                case 4:
                    listbrun.Location = new Point(4, (47 * 5) - 60);
                    break;
                case 5:
                    listbrun.Location = new Point(4, (47 * 6) - 75);
                    break;
                case 6:
                    listbrun.Location = new Point(4, (47 * 7) - 90);
                    break;
                case 7:
                    listbrun.Location = new Point(4, (47 * 8) - 105);
                    break;
                case 8:
                    listbrun.Location = new Point(4, (47 * 9) - 120);
                    break;
                case 9:
                    listbrun.Location = new Point(4, (47 * 10) - 135);
                    break;
                case 10:
                    listbrun.Location = new Point(4, (47 * 11) - 150);
                    break;
                case 11:
                    listbrun.Location = new Point(4, (47 * 12) - 165);
                    break;
                case 12:
                    listbrun.Location = new Point(4, (47 * 13) - 180);
                    break;
                case 13:
                    listbrun.Location = new Point(4, (47 * 14) - 195);
                    break;
                case 14:
                    listbrun.Location = new Point(4, (47 * 15) - 210);
                    break;
                case 15:
                    listbrun.Location = new Point(4, (47 * 16) - 225);
                    break;
                case 16:
                    listbrun.Location = new Point(4, (47 * 17) - 240);
                    break;
            }

            listbrun.Name = "panel4" + countbron;
            listbrun.Size = new System.Drawing.Size(289, 41);
            listbrun.TabIndex = 10;
            panel1.Controls.Add(listbrun);

            Label inlistbron = new Label();
            inlistbron.AutoSize = true;
            inlistbron.Location = new System.Drawing.Point(64, 7);
            inlistbron.Name = "label5" + countbron;
            inlistbron.Size = new System.Drawing.Size(298, 660);
            inlistbron.TabIndex = 9;
            inlistbron.Text = "Александр : PS5 : 18-30 :4 часа";
            inlistbron.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            //  client.DownloadString("https://api.telegram.org/bot6240188359:AAFwBrvC_VaIVPDPzA-nlQrqET8afRUEkTg/sendmessage?chat_id=-1001920592858&text=😱Созданно бронирование😱\n 🗣ИМЯ: Александр 🗣\n 🎮ТИП: PS5🎮 \n ⏱Время:18-00⏱ \n ⏰Количество часов:100⏰ \n 📞Номер телефона: 888005553535📞");

            MessageBox.Show("Бронирование добавленно!");
        }

    }
}
