﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passaparola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruno = 0, dogru = 0, yanlis = 0;

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Text = "Sonraki";
            soruno++;
            this.Text=soruno.ToString();

            if(soruno == 1) 
            {
                richTextBox1.Text = "Ülkemizin güney kısmındaki kıyı bölgesi?";
                btnA.BackColor = Color.Yellow; 
            }
            if (soruno == 2)
            {
                richTextBox1.Text = "Ulucamisi le ünlü ilimiz?";
                btnB.BackColor = Color.Yellow;
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Müslümanların kutsal günü?";
                btnC.BackColor = Color.Yellow;
            }
            if (soruno == 4)
            {
                richTextBox1.Text = "Karpuzuyla ünlü ilimiz?";
                btnD.BackColor = Color.Yellow;
            }
            if (soruno == 5)
            {
                richTextBox1.Text = "'Yeni' kelimesinin zıt anlamlısı?";
                btnE.BackColor = Color.Yellow;
            }
            if (soruno == 6)
            {
                richTextBox1.Text = "Padişahın emirlerinin yazılı hali?";
                btnF.BackColor = Color.Yellow;
            }
            if (soruno == 7)
            {
                richTextBox1.Text = "Dünyanın ısı kaynağı?";
                btnG.BackColor = Color.Yellow;
            }
            if (soruno == 8)
            {
                richTextBox1.Text = "Öğrencilerin kötü karne getirince bakıştığı nesne?";
                btnH.BackColor = Color.Yellow;
            }
            if (soruno == 9)
            {
                richTextBox1.Text = "Gülüyle ünlü ilimiz?";
                btnI.BackColor = Color.Yellow;
            }
            if (soruno == 10)
            {
                richTextBox1.Text = "Mersinin diğer adı?";
                btnİ.BackColor = Color.Yellow;
            }
            if (soruno == 11)
            {
                richTextBox1.Text = "Askeri bir topluluk?";
                btnJ.BackColor = Color.Yellow;
            }
            if (soruno == 12)
            {
                richTextBox1.Text = "Malatyanın meşhur meyvesi?";
                btnK.BackColor = Color.Yellow;
            }
            if (soruno == 13)
            {
                richTextBox1.Text = "Her yıl bahar aylarında düzenlenen meşhur çiçek festivali?";
                btnL.BackColor = Color.Yellow;
            }
            if (soruno == 14)
            {
                richTextBox1.Text = "Yılın 3. ayı?";
                btnM.BackColor = Color.Yellow;
            }
            if (soruno == 15)
            {
                richTextBox1.Text = "Üflemeli müzük aleti?";
                btnN.BackColor = Color.Yellow;
            }
            if (soruno == 16)
            {
                richTextBox1.Text = "Halk şairi?";
                btnO.BackColor = Color.Yellow;
            }
            if (soruno == 17)
            {
                richTextBox1.Text = "Çocukların çok sevmediği sebze yemeği?";
                btnP.BackColor = Color.Yellow;
            }
            if (soruno == 18)
            {
                richTextBox1.Text = "11 ayın sultanı?";
                btnR.BackColor = Color.Yellow;
            }
            if (soruno == 19)
            {
                richTextBox1.Text = "İngilizcede yılan?";
                btnS.BackColor = Color.Yellow;
            }
            if (soruno == 20)
            {
                richTextBox1.Text = "Türkiyenin megastarı?";
                btnT.BackColor = Color.Yellow;
            }
            if (soruno == 21)
            {
                richTextBox1.Text = "Ümit kelimesinin eş anlamlısı?";
                btnU.BackColor = Color.Yellow;
            }
            if (soruno == 22)
            {
                richTextBox1.Text = "Kahvaltısı ile ünlü ilimiz?";
                btnV.BackColor = Color.Yellow;
            }
            if (soruno == 23)
            {
                richTextBox1.Text = "Şimşek kelimesinin eş anlamlısı?";
                btnY.BackColor = Color.Yellow;
            }
            if (soruno == 24)
            {
                richTextBox1.Text = "Ege bölgesinin en çok ağacı bulunun,yağı yapılan kahvaltı besini?";
                btnZ.BackColor = Color.Yellow;
            }

            
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                switch (soruno)
                {
                    case 1:
                        if (textBox1.Text == "akdeniz")
                        {
                            btnA.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            textBox1.Clear();
                        }
                        else
                        {
                            btnA.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            textBox1.Clear();
                        }
                        break;
                    case 2:
                        if (textBox1.Text == "bursa")
                        {
                            btnB.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            textBox1.Clear();
                        }
                        else
                        {
                            btnB.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            textBox1.Clear();
                        }
                        break;
                    case 3:
                        if (textBox1.Text == "cuma")
                        {
                            btnC.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            textBox1.Clear();
                        }
                        else
                        {
                            btnC.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            textBox1.Clear();
                        }
                        break;
                    case 4:
                        if (textBox1.Text == "diyarbakır")
                        {
                            btnD.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            textBox1.Clear();
                        }
                        else
                        {
                            btnD.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            textBox1.Clear();
                        }
                        break;
                    case 5:
                        if (textBox1.Text == "eski")
                        {
                            btnE.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            textBox1.Clear();
                        }
                        else
                        {
                            btnE.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            textBox1.Clear();
                        }
                        break;
                    case 6:
                        if (textBox1.Text == "ferman")
                        {
                            btnF.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            textBox1.Clear();
                        }
                        else
                        {
                            btnF.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            textBox1.Clear();
                        }
                        break;
                    case 7:
                        if (textBox1.Text == "güneş")
                        {
                            btnG.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            textBox1.Clear();
                        }
                        else
                        {
                            btnG.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            textBox1.Clear();
                        }
                        break;
                    case 8:
                        if (textBox1.Text == "halı")
                        {
                            btnH.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            textBox1.Clear();
                        }
                        else
                        {
                            btnH.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            textBox1.Clear();
                        }
                        break;
                    case 9:
                        if (textBox1.Text == "ısparta")
                        {
                            btnI.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            textBox1.Clear();
                        }
                        else
                        {
                            btnI.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            textBox1.Clear();
                        }
                        break;
                    case 10:
                        if (textBox1.Text == "içel")
                        {
                            btnİ.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            textBox1.Clear();
                        }
                        else
                        {
                            btnİ.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            textBox1.Clear();
                        }
                        break;
                    case 11:
                        if (textBox1.Text == "jandarma")
                        {
                            btnJ.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            textBox1.Clear();
                        }
                        else
                        {
                            btnJ.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            textBox1.Clear();
                        }
                        break;
                    case 12:
                        if (textBox1.Text == "kayısı")
                        {
                            btnK.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            textBox1.Clear();
                        }
                        else
                        {
                            btnK.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            textBox1.Clear();
                        }
                        break;
                    case 13:
                        if (textBox1.Text == "lale")
                        {
                            btnL.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            textBox1.Clear();
                        }
                        else
                        {
                            btnL.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            textBox1.Clear();
                        }
                        break;
                    case 14:
                        if (textBox1.Text == "mart")
                        {
                            btnM.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            textBox1.Clear();
                        }
                        else
                        {
                            btnM.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            textBox1.Clear();
                        }
                        break;
                    case 15:
                        if (textBox1.Text == "ney")
                        {
                            btnN.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            textBox1.Clear();
                        }
                        else
                        {
                            btnN.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            textBox1.Clear();
                        }
                        break;
                    case 16:
                        if (textBox1.Text == "ozan")
                        {
                            btnO.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            textBox1.Clear();
                        }
                        else
                        {
                            btnO.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            textBox1.Clear();
                        }
                        break;
                    case 17:
                        if (textBox1.Text == "pırasa")
                        {
                            btnP.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            textBox1.Clear();
                        }
                        else
                        {
                            btnP.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            textBox1.Clear();
                        }
                        break;
                    case 18:
                        if (textBox1.Text == "ramazan")
                        {
                            btnR.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            textBox1.Clear();
                        }
                        else
                        {
                            btnR.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            textBox1.Clear();
                        }
                        break;
                    case 19:
                        if (textBox1.Text == "snake")
                        {
                            btnS.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            textBox1.Clear();
                        }
                        else
                        {
                            btnS.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            textBox1.Clear();
                        }
                        break;
                    case 20:
                        if (textBox1.Text == "tarkan")
                        {
                            btnT.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            textBox1.Clear();
                        }
                        else
                        {
                            btnT.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            textBox1.Clear();
                        }
                        break;
                    case 21:
                        if (textBox1.Text == "umut")
                        {
                            btnU.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            textBox1.Clear();
                        }
                        else
                        {
                            btnU.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            textBox1.Clear();
                        }
                        break;
                    case 22:
                        if (textBox1.Text == "van")
                        {
                            btnV.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            textBox1.Clear();
                        }
                        else
                        {
                            btnV.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            textBox1.Clear();
                        }
                        break;
                    case 23:
                        if (textBox1.Text == "yıldırım")
                        {
                            btnY.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            textBox1.Clear();
                        }
                        else
                        {
                            btnY.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            textBox1.Clear();
                        }
                        break;
                    case 24:
                        if (textBox1.Text == "zeytin")
                        {
                            btnZ.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            textBox1.Clear();
                        }
                        else
                        {
                            btnZ.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            textBox1.Clear();
                        }
                        break;
                }
            }
        }
    }
}
