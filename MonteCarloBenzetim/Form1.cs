using System;
using System.Windows.Forms;





namespace denemeödev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //****************************//
            // Önce x ve y noktalarını random olarak ürettik.
            listBox1.Items.Clear();
            Random r = new Random();
            double sayi;
            int i;
            double[] x1 = new double[1000];
            for (i = 0; i < 1000; i++)   // Burada x1 noktalarını bir dizi içine yazdırıyoruz. 
            {
                sayi = r.NextDouble();
                x1[i] = sayi;
                listBox1.Items.Add(sayi.ToString());
            }

            listBox2.Items.Clear();
            Random k = new Random();
            double sayi1;
            int m;
            double[] y1 = new double[1000];
            for (m = 0; m < 1000; m++)      // Burada ise y1 noktalarını bir dizi içerisine yazdırıyoruz.
            {
                sayi1 = k.NextDouble();
                y1[m] = sayi1;
                listBox2.Items.Add(sayi1.ToString());
            }

            listBox3.Items.Clear();
            Random h = new Random();
            double sayi2;
            int z;
            double[] x2 = new double[1000];
            for (z = 0; z < 1000; z++)      // Burada ise x2 noktalarını bir dizi içerisine yazdırıyoruz.
            {
                sayi2 = h.NextDouble();
                x2[z] = sayi2;
                listBox3.Items.Add(sayi2.ToString());
            }

            listBox4.Items.Clear();
            Random g = new Random();
            double sayi3;
            int v;
            double[] y2 = new double[1000];
            for (v = 0; v < 1000; v++)      // Burada ise y2 noktalarını bir dizi içerisine yazdırıyoruz.
            {
                sayi3 = g.NextDouble();
                y2[v] = sayi3;
                listBox4.Items.Add(sayi3.ToString());
            }



            double sonuc;
            double n = 0;
            // Oluşturduğumuz noktaların arasındaki uzaklık bize d uzunluğunu verecek.
            // Bunun için ise pisagor teoreminden yararlanacağız. 
            // d=sqrt((x1-x2)^2 + (y1-y2)^2)

            for (int j = 0; j < 1000; j++)
            {
                sonuc = Math.Sqrt((((Convert.ToDouble(listBox1.Items[j])) - (Convert.ToDouble(listBox3.Items[j]))) * ((Convert.ToDouble(listBox1.Items[j])) - (Convert.ToDouble(listBox3.Items[j])))) + (((Convert.ToDouble(listBox2.Items[j])) - (Convert.ToDouble(listBox4.Items[j]))) * ((Convert.ToDouble(listBox2.Items[j])) - (Convert.ToDouble(listBox4.Items[j])))));
                if (sonuc < 0.8)
                {
                    n++;
                }
            }
            // Listelere eklediğimiz x1, x2, y1 ve  y2 değerleri aracılığı ile d uzunluğunu buluyoruz.

            textBox1.Text = Convert.ToString(n / 1000); // Burada da o.8 den küçük olan uzunlukların sayısının toplam 
                                                        // bulunan uzunluk sayısına oranı bize olaşılığı veriyor.

        }

    }
}
