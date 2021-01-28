using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;






namespace PiSayısı
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
            Random n = new Random();
            double a;
            int i;
            int noktaSayısı = 10000;
            double[] x = new double[noktaSayısı];
            for (i = 0; i<noktaSayısı; i++)    // X değerlerini rastgele olarak alıp dizi içerisine, oradan da listboxa
            {                                  // kaydediyoruz.
                a = n.NextDouble();
                x[i] = a;
                listBox1.Items.Add(a.ToString());
            }


            listBox2.Items.Clear();
            Random h = new Random();
            double s;
            int m;
            double[] y = new double[noktaSayısı];
            for ( m=0; m < noktaSayısı; m++)
            {                                // Y değerlerini rastgele olarak alıp dizi içerisine, oradan da listboxa
                s = h.NextDouble();          // kaydediyoruz.
                y[m] = s;
                listBox2.Items.Add(s.ToString());
            }

            double piyeDogru;
            double dogruDeneme = 0;

            // (x,y) koordinat sisteminde bir 0<=x<=1 0<=y<=1 birim karesini alalım ve buranın alanına K diyelim.
            // Yine bu koordinat sisteminde bir birim çember alalım. Bu alana da Ç diyelim, kare içerisinden rastgele
            // noktalar seçelim, bu noktaların birim çemberin içine düşmesi için x^2+y^2<=1 eşitliğinin sağlanması lazım.
            // Çünkü, x^2+y^2=1 bu eşitlik aslında birim bize birim çemberin kümesini vermektedir. Bizde bu kümenin 
            // içerisinde kalan noktaları bulacağız. Birim çemberin alanının pi olduğunu biliyoruz ve bu çemberin
            // sadece 4'te 1'i karenin üzerinde olduğu için alanı ise pi/4'dür. 

            // Yani 4*(eşitlik içerisindeki noktalar / tüm noktalar) bize yaklaşık olarak pi sayısını verecek.

            for(int k =0; k<noktaSayısı;k++)
            {
                piyeDogru = Math.Sqrt((Convert.ToDouble(listBox1.Items[k])) * (Convert.ToDouble(listBox1.Items[k])) + (Convert.ToDouble(listBox2.Items[k])) * (Convert.ToDouble(listBox2.Items[k])));
                if(piyeDogru <= 1)
                {                     
                    dogruDeneme++; 
                }
            }

            double yaklasıkPi = 4* (dogruDeneme / noktaSayısı);
            textBox1.Text = yaklasıkPi.ToString();


        }
    }
}
