using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ndpodev
{


    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer timer;
        //sayac 
        private int counter = 60;
        // puanları tutmak için
        private int puans = 0;
        int cntrl = 0; // yeni oyuna basılmasını kontrol etmek için 1 olunca uygulamayı yeniden başlatıcak


        // nesneleri tanımladım
        private Atik cam;
        private Atik bardak;
        private Atik gazete;
        private Atik dergi;
        private Atik domates;
        private Atik salatalik;
        private Atik kola;
        private Atik salca;

        AtikKutusu organikKutusu;

        AtikKutusu kagitKutusu;

        AtikKutusu camKutusu;

        AtikKutusu metalKutusu;


        public Form1()
        {
            InitializeComponent();
            this.Text = "Atık Oyunu";

            // kutuların ilk değerleri verildi. 
            organikKutusu = new AtikKutusu(0, 700, 0, 0); 
            kagitKutusu = new AtikKutusu(1000, 1200, 0, 0);
            camKutusu = new AtikKutusu(600, 2200, 0, 0);
            metalKutusu = new AtikKutusu(800, 2300, 0, 0);


            // atik nesnelerinin değerleri constructor ile atandı
            cam = new Atik(600, Image.FromFile("cam.jpg"), "Cam");
            bardak = new Atik(250, Image.FromFile("bardak.jpg"), "Bardak");
            gazete = new Atik(250, Image.FromFile("gazete.jpg"), "Gazete");
            dergi = new Atik(200, Image.FromFile("dergi.jpg"), "Dergi");
            domates = new Atik(150, Image.FromFile("domates.jpg"), "Domates");
            salatalik = new Atik(120, Image.FromFile("salatalik.jpg"), "Salatalik");
            kola = new Atik(350, Image.FromFile("kola.jpg"), "Kola");
            salca = new Atik(550, Image.FromFile("salca.jpg"), "Salça");





        }

        // her çağrıldığında random olarak resim üreticek
        private void RandomImage()
        {
            List<Atik> atiks = new List<Atik>();
            atiks.Add(cam);
            atiks.Add(bardak);
            atiks.Add(gazete);
            atiks.Add(dergi);
            atiks.Add(domates);
            atiks.Add(salatalik);
            atiks.Add(kola);
            atiks.Add(salca);

            Random r = new Random();
            int random = r.Next(0, atiks.Count); //random sayı üretiyoruz
            pictureBox1.Image = atiks[random].Image;
            pictureBox1.Name = atiks[random].Name;



        }

        private void yazdir(ListBox listname, Atik atik)
        {
            // gonderilen listbox gonderilen atığı eklemek için kullanılıyor
            listname.Items.Add(atik.Name + "(" + atik.Hacim + ")");
            // eklenen atık hacmi kadar puan kazanıldı
            puans += atik.Hacim;
            puan.Text = puans.ToString();
            //random resim uretildi .
            RandomImage();
        }



        private void organik_btn_Click(object sender, EventArgs e)
        {
            // progress bar için min ve max sınırları belirlendi.
            organik_progress.Minimum = 0;
            organik_progress.Maximum = organikKutusu.Kapasite;

           

            if (pictureBox1.Name == domates.Name)
            {
                // eğer domates eklenmek istenirse yapılacak işlemler

                if (organikKutusu.Ekle(domates) == true)
                {// domatesin hacmi kadar organik kutusuna ekleme yapıldı
                    organikKutusu.DoluHacim += domates.Hacim;


                    // eğer eklendiğinde hacim maximumu geçmiyorsa listboxa yazdirma işlemi başlatılır.
                    if (organikKutusu.DoluHacim < organik_progress.Maximum)
                    {
                        organik_progress.Value = organikKutusu.DoluHacim;
                        yazdir(organik_list, domates);

                    }
                    // maximumu geçiyorsa konulan nesne çıkarılır.
                    else
                        organikKutusu.DoluHacim -= domates.Hacim;





                }



            }

            else if (pictureBox1.Name == salatalik.Name)
            {
              


                if (organikKutusu.Ekle(salatalik) == true)
                {
                    organikKutusu.DoluHacim += salatalik.Hacim;

                    if (organikKutusu.DoluHacim < organik_progress.Maximum)
                    {
                        organik_progress.Value = organikKutusu.DoluHacim;

                        yazdir(organik_list, salatalik);
                    }

                    else
                    {
                        organikKutusu.DoluHacim -= salatalik.Hacim;

                    }

                }



            }


        }

        private void kagit_btn_Click(object sender, EventArgs e)
        {
            kagit_progress.Minimum = 0;
            kagit_progress.Maximum = kagitKutusu.Kapasite;

          

            if (pictureBox1.Name == dergi.Name)
            {
                


                if (kagitKutusu.Ekle(dergi) == true)
                {

                    kagitKutusu.DoluHacim += dergi.Hacim;

                    if (kagitKutusu.DoluHacim < kagit_progress.Maximum)
                    {
                        kagit_progress.Value = kagitKutusu.DoluHacim;
                        yazdir(kagit_list, dergi);


                    }
                    else
                    {
                        kagitKutusu.DoluHacim -= dergi.Hacim;

                    }





                }


            }

            else if (pictureBox1.Name == gazete.Name)
            {
                

                if (kagitKutusu.Ekle(gazete) == true)
                {
                    kagitKutusu.DoluHacim += gazete.Hacim;

                    if (kagitKutusu.DoluHacim < kagit_progress.Maximum)
                    {
                        kagit_progress.Value = kagitKutusu.DoluHacim;
                        yazdir(kagit_list, gazete);


                    }
                    else
                    {
                        kagitKutusu.DoluHacim -= gazete.Hacim;

                    }



                }

            }





        }

        private void cam_btn_Click(object sender, EventArgs e)
        {
            cam_progress.Minimum = 0;
            cam_progress.Maximum = camKutusu.Kapasite;


            if (pictureBox1.Name == cam.Name)
            {

                if (camKutusu.Ekle(cam) == true)
                {
                    camKutusu.DoluHacim += cam.Hacim;

                    if (camKutusu.DoluHacim < cam_progress.Maximum)
                    {
                        cam_progress.Value = camKutusu.DoluHacim;
                        yazdir(cam_list, cam);


                    }
                    else
                        camKutusu.DoluHacim -= cam.Hacim;

                }



            }

            else if (pictureBox1.Name == bardak.Name)
            {
                if (camKutusu.Ekle(bardak) == true)
                {
                    camKutusu.DoluHacim += bardak.Hacim;


                    if (camKutusu.DoluHacim < cam_progress.Maximum)
                    {
                        yazdir(cam_list, bardak);
                        cam_progress.Value = camKutusu.DoluHacim;


                    }
                    else
                        camKutusu.DoluHacim -= bardak.Hacim;

                }

            }






        }

        private void metal_btn_Click(object sender, EventArgs e)
        {
            metal_progress.Minimum = 0;
            metal_progress.Maximum = metalKutusu.Kapasite;

         

            if (pictureBox1.Name == kola.Name)
            {
                if (camKutusu.Ekle(kola) == true)
                {
                    metalKutusu.DoluHacim += kola.Hacim;


                    if (metalKutusu.DoluHacim < metal_progress.Maximum)
                    {
                        metal_progress.Value = metalKutusu.DoluHacim;
                        yazdir(metal_list, kola);
                    }
                    else
                        metalKutusu.DoluHacim -= kola.Hacim;

                }


            }

            if (pictureBox1.Name == salca.Name)
            {




                if (camKutusu.Ekle(salca) == true)
                {
                    metalKutusu.DoluHacim += salca.Hacim;

                    if (metalKutusu.DoluHacim < metal_progress.Maximum)
                    {
                        yazdir(metal_list, salca);
                        metal_progress.Value = metalKutusu.DoluHacim;

                    }
                    else
                        metalKutusu.DoluHacim -= salca.Hacim;

                }


            }



        }

        private void yeni_oyun_Click(object sender, EventArgs e)
        {
            // kontrol edilip yeni oyun butonuna ikinci kez basıldığında uygulamayı yeniden başlatır
            if (cntrl == 1)
            {
                Application.Restart();
            }
            cntrl = 1;
            // random image üretir.
            RandomImage();
            timer = new System.Windows.Forms.Timer();
            timer.Tick += new EventHandler(timer2_Tick);
            timer.Interval = 1000; // 1 saniye
            timer.Start();
            sure.Text = counter.ToString(); // süreyi yazıyoruz


        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            counter--;
            if (counter == 0)
                timer.Stop();
            sure.Text = counter.ToString();
        }


        // organik kutusu boşaltma butonu
        private void organik_bosalt_Click(object sender, EventArgs e)
        {

            // organik kutusu 75 altındaysa if e girer
            if (organikKutusu.Bosalt() == true)
            {
                // progress değeri sıfırlanır 
                organik_progress.Value = 0;
                // hacim sıfırlanır
                organikKutusu.DoluHacim = 0;
                // süreye 3 saniye eklenir .
                counter += 3;
                // listbox temizlenir.
                organik_list.Items.Clear();
                // doluluk oranı 0 lanır 
                organikKutusu.DolulukOrani = 0;

            }


        }

        private void kagit_bosalt_Click(object sender, EventArgs e)
        {

            if (kagitKutusu.Bosalt() == true)
            {
                kagit_progress.Value = 0;
                puans += kagitKutusu.BosaltmaPuani;
                puan.Text = puans.ToString();
                kagit_list.Items.Clear();
                kagitKutusu.DoluHacim = 0;
                counter += 3;
                kagitKutusu.DolulukOrani = 0;


            }

        }

        private void cam_bosalt_Click(object sender, EventArgs e)
        {

            if (camKutusu.Bosalt() == true)
            {

                cam_progress.Value = 0;
                puans += camKutusu.BosaltmaPuani;
                puan.Text = puans.ToString();
                cam_list.Items.Clear();

                camKutusu.DoluHacim = 0;
                counter += 3;
                camKutusu.DolulukOrani = 0;


            }

        }

        private void metal_bosalt_Click(object sender, EventArgs e)
        {


            if (metalKutusu.Bosalt() == true)
            {

                metal_progress.Value = 0;
                puans += metalKutusu.BosaltmaPuani;
                puan.Text = puans.ToString();
                metal_list.Items.Clear();

                metalKutusu.DoluHacim = 0;
                counter += 3;
                metalKutusu.DolulukOrani = 0;


            }
        }

        private void cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}