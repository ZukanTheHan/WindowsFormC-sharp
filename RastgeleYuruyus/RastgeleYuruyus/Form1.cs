using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace RastgeleYuruyus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Random r = new Random();
            int baslangıcx = 0;           // Rastgele olarak 100 sayı aldım. Bunlar yürüyüşümdeki yönleri belirtecek.
            int baslangıcy = 0;
            int x1 = 0;
            int y1 = 0;
            int sayi;
            int i;
            int[] ilerleyis = new int[100];
            for(i =0; i < 100; i++)
            {
                sayi = r.Next(1, 5);
                ilerleyis[i] = sayi;
                listBox1.Items.Add(sayi.ToString());
            }

            // Her bir yön için birer sayı atadım.
            for(int k = 0; k < 100; k++)
            {
                if(Convert.ToInt32(listBox1.Items[k]) == 1)
                {
                    listBox2.Items.Add("İleri");
                }
                else if(Convert.ToInt32(listBox1.Items[k]) == 2)
                {
                    listBox2.Items.Add("Sağa");
                }
                else if (Convert.ToInt32(listBox1.Items[k]) == 3)
                {
                    listBox2.Items.Add("Sola");
                }
                else if (Convert.ToInt32(listBox1.Items[k]) == 4)
                {
                    listBox2.Items.Add("Geri");
                }
            }
            // Belirlediğim yönlerin belirlediğim (x1, y1) noktasını nasıl etkileyeceğini yazdım.
            for (int l = 0; l < 100; l++)
            {
                if (Convert.ToInt32(listBox1.Items[l]) == 1)
                {
                    y1 = y1 + 1;
                }
                else if (Convert.ToInt32(listBox1.Items[l]) == 2)
                {
                    x1 = x1 + 1;
                }
                else if (Convert.ToInt32(listBox1.Items[l]) == 3)
                {
                    x1 = x1 - 1;
                }
                else if (Convert.ToInt32(listBox1.Items[l]) == 4)
                {
                    y1 = y1 - 1;
                }
            }

            // Pisagor yönteminden yararlanarak başlangıç noktası ile yürüyüşümün sonunda belirlenen nokta arasındaki
            // uzaklığı buldum.
            double uzaklık = 0;
            uzaklık = Math.Sqrt((x1 - baslangıcx) * (x1 - baslangıcx) + ((y1 - baslangıcy) * (y1 - baslangıcy)));

            textBox1.Text = uzaklık.ToString();






        }
    }
}
