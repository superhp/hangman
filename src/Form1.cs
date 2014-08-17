using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Media;


namespace Pakaruoklis
{
    public partial class Form1 : Form
    {
        //GLOBALIEJI KINTAMIEJI--------------------------------
        string[] zodziai;
        int sk;
        string sufleris;
        int kartai;
        string slapt;
        string[] bruksniai;
        int kark;
        int uzpildymas, neteisingi;
        int bandsk=6, laik=0;        
        //------------------------------------------------------

        public Form1()
        {
            InitializeComponent();            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            laikas.Text = "         " + laik.ToString() + " sek.";
            laik++;
        }  

        private void play1(int kuris)
        {           
            SoundPlayer click = new SoundPlayer(Properties.Resources.click);
            SoundPlayer agan = new SoundPlayer(Properties.Resources.agan);
            SoundPlayer won = new SoundPlayer(Properties.Resources.won);
            SoundPlayer lose = new SoundPlayer(Properties.Resources.lose);

            switch (kuris)
            {
                case 1:
                    click.Play();
                    break;  
                case 2:
                    agan.Play();
                    break;
                case 3:
                    won.Play();
                    break;
                case 4:
                    lose.Play();
                    break;
            }            
        }

        private void uzkrauti()
        {
            string input;

            zodziai = new string[50];

            sk = 0;            

            FileStream streamas = new FileStream("zodziai.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader failas = new StreamReader(streamas);  
            if ((input = failas.ReadLine()) != null)
                sufleris = input;
            input = null;
            while ((input = failas.ReadLine()) != null)
            {
                zodziai[sk] = input;
                sk++;
            }
            failas.Close();
            streamas.Close();

            if (sk == 0)
                temos();
            else
                ats.Text = "Tema - " + sufleris;
        }

        private void temos()
        {
            Random tem = new Random();
            int nr = tem.Next(1, 5);

            switch (nr)
            {
                case 1:
                    gyvunai();
                    break;
                case 2:
                    transportas();
                    break;
                case 3:
                    maistas();
                    break;
                case 4:
                    planetos();
                    break;
                case 5:
                    miestai();
                    break;
            }
        }

        private void miestai()
        {
            ats.Text = "Tema - miestai";
            sk = 5;
            zodziai = new string[] {"šliauliai", "vilnius", "kaunas", "klaipėda", "utena"};
        }

        private void planetos()
        {
            ats.Text = "Tema - planetos";
            sk = 8;
            zodziai = new string[] {"merkurijus", "venera", "žemė", "marsas", "saturnas",
                                    "jupiteris", "uranas", "neptūnas"};
        }

        private void transportas()
        {
            ats.Text = "Tema - transportas";
            sk = 7;
            zodziai = new string[] {"automobilis", "dviratis", "autobusas", "lėktuvas", "motociklas",
                                    "valtis", "laivas"};
        }

        private void maistas()
        {
            ats.Text = "Tema - maistas";
            sk = 5;
            zodziai = new string[] {"mišrainė", "kugelis", "cepelinai", "dešrelės", "šašlykai"};
        }

        private void gyvunai()
        {
            ats.Text = "Tema - gyvūnai";
            sk = 15;            
            zodziai = new string[] {"avis", "asilas", "arklys", "bebras", "barsukas", "briedis", "erelis",
                                    "lapė", "liūtas", "karvė", "kiaunė", "šuo", "žirafa", "žiogas", "žuvis"};
        }
     
        private void piesk()
        {
            Graphics gfx = this.CreateGraphics();
            Pen galunes = new Pen(Color.Black, 15);
            Pen virve = new Pen(Color.Black, 10);
            Pen tvirt = new Pen(Color.Black, 5);

            gfx.DrawLine(galunes, 60, 20, 60, 250);
            gfx.DrawLine(galunes, 100, 250, 30, 250);
            gfx.DrawLine(galunes, 50, 20, 180, 20);
            gfx.DrawLine(virve, 160, 20, 160, 50);
            gfx.DrawLine(tvirt, 100, 20, 60, 110);
        }

        private void zmogus()
        {
            Graphics psk = this.CreateGraphics();
            Pen zmogus = new Pen(Color.Black, 5);

            if (kark == 0)
                box.Image = Properties.Resources.zmg0;
            if (kark == 1)
            {
                box.Image = Properties.Resources.zmg1;
            }
            if (kark == 2)
                box.Image = Properties.Resources.zmg2;
            if (kark == 3)
            {
                box.Image = Properties.Resources.zmg3;
            }
            if (kark == 4)
                box.Image = Properties.Resources.zmg4;
            if (kark == 5)
                box.Image = Properties.Resources.zmg5;
            if (kark == 6)
                box.Image = Properties.Resources.ZMG;                           
        }
        
        private void spejimas_Click(object sender, EventArgs e)
        {
            if (spejimas.Text == "Pradėti")
            {            
                piesk();                

                rink();

                if (kartai > 0)
                    spejimas.Text = "Iš naujo";
            }
            else
                reset();
        }

        private void reset()
        {
            bandsk = 6;

            kark = 0;
            zmogus();

            uzpildymas = 0;
            neteisingi = 0;

            laik = 0;
            rink();

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
            button17.Enabled = true;
            button18.Enabled = true;
            button19.Enabled = true;
            button20.Enabled = true;
            button21.Enabled = true;
            button22.Enabled = true;
            button23.Enabled = true;
            button24.Enabled = true;
            button25.Enabled = true;
            button26.Enabled = true;
            button27.Enabled = true;
            button28.Enabled = true;
            button29.Enabled = true;
            button30.Enabled = true;
            button31.Enabled = true;
            button32.Enabled = true;          
        }

        private void vykdyk(string raid)
        {
            int ok = 0;            
            for (int i = 0; i < slapt.Length; i++)
                if (slapt[i].ToString() == raid)
                {
                    uzpildymas++;
                    bruksniai[i] = raid;
                    text.Text = "";
                    for (int j = 0; j < bruksniai.Length; j++)
                        text.Text += bruksniai[j] + " ";
                    ok = 1;
                    if (uzpildymas == slapt.Length)
                    {
                        play1(3);
                        laimejimas();
                    }
                    else
                        play1(1);

                }
            if (ok == 0)
            {
                neteisingi++;
                bandymai.Text = "Liko bandymų: " + (bandsk - neteisingi).ToString();
                kark++;
                zmogus();
                if (neteisingi == 6)
                {
                    play1(4);
                    pralaimejimas();
                }
                else
                    play1(1);
            }            
        }

        private void rink()
        {            
            uzkrauti();
            play1(2);
            timer1.Start();

            kartai++;
            
            bandymai.Text = "Liko bandymų: " + bandsk;            

            Random RandomClass = new Random();
            int nr = RandomClass.Next(0, sk);

            slapt = zodziai[nr];

            text.Text = "";
            bruksniai = new string[20];
            for (int i = 0; i < slapt.Length; i++)
            {
                bruksniai[i] = "_";
                text.Text += "_ ";
            }
        }

        private void laimejimas()
        {
            timer1.Stop();
            ats.Text = "Atspėjai!!!";
            kartai = 0;            
        }

        private void pralaimejimas()
        {
            timer1.Stop();
            ats.Text = "Amen...";            
            kartai = 0;            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {            
            if (kartai > 0)
            {
                vykdyk("a");
                button1.Enabled = false;           
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (kartai > 0)
            {
                vykdyk("ą");
                button2.Enabled = false;              
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (kartai > 0)
            {
                vykdyk("b");
                button3.Enabled = false;              
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (kartai > 0)
            {
                vykdyk("c");
                button4.Enabled = false;                
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (kartai > 0)
            {
                vykdyk("č");
                button5.Enabled = false;               
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (kartai > 0)
            {
                vykdyk("d");
                button6.Enabled = false;             
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (kartai > 0)
            {
                vykdyk("e");
                button7.Enabled = false;              
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (kartai > 0)
            {
                vykdyk("ę");
                button8.Enabled = false;              
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (kartai > 0)
            {
                vykdyk("ė");
                button9.Enabled = false;              
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (kartai > 0)
            {
                vykdyk("y");
                button15.Enabled = false;                
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (kartai > 0)
            {
                vykdyk("į");
                button14.Enabled = false;              
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (kartai > 0)
            {
                vykdyk("i");
                button13.Enabled = false;             
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (kartai > 0)
            {
                vykdyk("h");
                button12.Enabled = false;             
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (kartai > 0)
            {
                vykdyk("g");
                button11.Enabled = false;              
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (kartai > 0)
            {
                vykdyk("f");
                button10.Enabled = false;               
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (kartai > 0)
            {
                vykdyk("j");
                button16.Enabled = false;              
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (kartai > 0)
            {
                vykdyk("ž");
                button32.Enabled = false;               
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (kartai > 0)
            {
                vykdyk("z");
                button31.Enabled = false;           
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (kartai > 0)
            {
                vykdyk("v");
                button30.Enabled = false;
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (kartai > 0)
            {
                vykdyk("ū");
                button29.Enabled = false;            
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (kartai > 0)
            {
                vykdyk("ų");
                button28.Enabled = false;             
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (kartai > 0)
            {
                vykdyk("u");
                button27.Enabled = false;              
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (kartai > 0)
            {
                vykdyk("t");
                button26.Enabled = false;               
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (kartai > 0)
            {
                vykdyk("š");
                button25.Enabled = false;               
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (kartai > 0)
            {
                vykdyk("s");
                button24.Enabled = false;              
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (kartai > 0)
            {
                vykdyk("r");
                button23.Enabled = false;           
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (kartai > 0)
            {
                vykdyk("p");
                button22.Enabled = false;         
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (kartai > 0)
            {
                vykdyk("o");
                button21.Enabled = false;            
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (kartai > 0)
            {
                vykdyk("n");
                button20.Enabled = false;             
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (kartai > 0)
            {
                vykdyk("m");
                button19.Enabled = false;                
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (kartai > 0)
            {
                vykdyk("l");
                button18.Enabled = false;            
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (kartai > 0)
            {
                vykdyk("k");
                button17.Enabled = false;             
            }
        }

        private void btn_help_Click(object sender, EventArgs e)
        {

        }

            

        
    }
}