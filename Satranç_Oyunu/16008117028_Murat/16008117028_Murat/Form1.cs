using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16008117028_Murat
{
    public partial class Form1 : Form
    {
        int sıra = 0;//Yapay zeka '0' ilk yapay zeka başlasın
        int hml = 0;
        int t = 0;
        int kvar;
        int pvar;

        public Form1()
        {
            InitializeComponent();
        }

        int[] sşah = new int[23];
        int[] spiyon1 = new int[13];
        int[] spiyon2 = new int[13];
        int[] skale = new int[32];

        int[] p1öncekiadım = new int[2];
        int[] p2öncekiadım = new int[2];
    
        public void hamletanı()
        {
            int s = 0;
            kvar = 0;
            pvar = 0;
            for (int j = 0; j < satrancKareleri.GetLength(0); j++)
            {
                for (int k = 0; k < satrancKareleri.GetLength(1); k++)
                {
                    if (satrancKareleri[j, k].ImageIndex == 4)
                    {
                        if(s==0)
                        {
                            pvar = 1;
                            spiyon1[0] = j;
                            spiyon1[1] = k;
                            s = s + 1;
                        }
                     
                      if(s>0)
                        {
                            spiyon2[0] = j;
                            spiyon2[1] = k;
                        }
                      
                    }
                    if (satrancKareleri[j, k].ImageIndex == 5)
                    {
                        skale[0] = j;
                        skale[1] = k;

                        skale[2] = j;
                        skale[3] = k;

                        skale[4] = j;
                        skale[5] = k;

                        skale[6] = j;
                        skale[7] = k;

                        skale[8] = j;
                        skale[9] = k;

                        skale[10] = j;
                        skale[11] = k;

                        skale[12] = j;
                        skale[13] = k;

                        skale[14] = j;
                        skale[15] = k;
                        //

                        skale[16] = j;
                        skale[17] = k;

                        skale[18] = j;
                        skale[19] = k;

                        skale[20] = j;
                        skale[21] = k;

                        skale[26] = j;
                        skale[27] = k;

                        kvar = 1;
                    }
                    if (satrancKareleri[j, k].ImageIndex == 6)
                    {
                        sşah[0] = j;
                        sşah[1] = k;

                        sşah[2] = j;
                        sşah[3] = k;

                        sşah[21] = j;
                        sşah[22] = k;

                    }
                    if (satrancKareleri[j, k].ImageIndex == 3)
                    {
                        skale[30] = j;
                        skale[31] = k;
                    }
                }

            }
        }
        public void AI_YE()
        {
            int yes = 0;

            t = 0;

            //ŞAH İLERİ
            if (sşah[0]+1 > -1 && sşah[0]+1 < 6 && sşah[1] < 6 && sşah[1] > -1)
            {
                if (satrancKareleri[sşah[0] + 1, sşah[1]].ImageIndex < 4 && satrancKareleri[sşah[0] + 1, sşah[1]].ImageIndex > 0)
                {
                    if(yes==0)
                    {
                        sşah[4] = sşah[0] + 1;
                        satrancKareleri[sşah[0], sşah[1]].ImageIndex = 0;
                        satrancKareleri[sşah[4], sşah[1]].ImageIndex = 6;
                        t = 1;
                        yes = 1;
                    }
                   
                   
                }
            }

            //ŞAH GERİ
            if (sşah[0]-1 > -1 && sşah[0]-1 < 6 && sşah[0] < 6 && sşah[1] > -1)
            {
                if (satrancKareleri[sşah[0] - 1, sşah[1]].ImageIndex < 4 && satrancKareleri[sşah[0] - 1, sşah[1]].ImageIndex > 0)
                {
                    if(yes == 0)
                    {
                        satrancKareleri[sşah[0], sşah[1]].ImageIndex = 0;
                        satrancKareleri[sşah[0] - 1, sşah[1]].ImageIndex = 6;
                        t = 1;
                        yes = 1;
                    }
                   
                   
                }
            }

            //ŞAH SAĞ SOL YE
            if (sşah[0] > -1 && sşah[0] < 6 && sşah[1] - 1 < 6 && sşah[1] - 1 > -1)
            {
                if (satrancKareleri[sşah[0], sşah[1] - 1].ImageIndex < 4 && satrancKareleri[sşah[0], sşah[1] - 1].ImageIndex > 0)
                {
                    if (yes == 0)
                    {
                        satrancKareleri[sşah[0], sşah[1]].ImageIndex = 0;
                        satrancKareleri[sşah[0], sşah[1] - 1].ImageIndex = 6;
                        t = 1;
                        yes = 1;
                    }
                   
                    
                }
            }
            if (sşah[0] > -1 && sşah[0] + 1 < 6 && sşah[1] + 1 < 6 && sşah[1] + 1 > -1)
            {

                if (satrancKareleri[sşah[0] , sşah[1] + 1].ImageIndex < 4 && satrancKareleri[sşah[0] , sşah[1] + 1].ImageIndex > 0)
                {
                    if (yes == 0)
                    {
                        satrancKareleri[sşah[0], sşah[1]].ImageIndex = 0;
                        satrancKareleri[sşah[0], sşah[1] + 1].ImageIndex = 6;
                        t = 1;
                        yes = 1;
                    }
                   
                    
                }

            }

            //ŞAH SAĞ VE SOL ÇAPRAZ YE
            if (sşah[0]+1 > -1 && sşah[0]+1 < 6 && sşah[1]-1 < 6 && sşah[1]-1 > -1)
            {
                if (satrancKareleri[sşah[0] + 1, sşah[1] - 1].ImageIndex < 4 && satrancKareleri[sşah[0] + 1, sşah[1] - 1].ImageIndex > 0)
                {
                    if (yes == 0)
                    {
                        satrancKareleri[sşah[0], sşah[1]].ImageIndex = 0;
                        satrancKareleri[sşah[0] + 1, sşah[1] - 1].ImageIndex = 6;
                        t = 1;
                        yes = 1;
                    }
                   
                    
                }
            }
            if (sşah[0]+1 > -1 && sşah[0]+1 < 6 && sşah[1]+1 < 6 && sşah[1]+1 > -1)
            {
              
                    if (satrancKareleri[sşah[0] + 1, sşah[1] + 1].ImageIndex < 4 && satrancKareleri[sşah[0] + 1, sşah[1] + 1].ImageIndex > 0)
                    {
                    if (yes == 0)
                    {
                        satrancKareleri[sşah[0], sşah[1]].ImageIndex = 0;
                        satrancKareleri[sşah[0] + 1, sşah[1] + 1].ImageIndex = 6;
                        t = 1;
                        yes = 1;
                    }
                 
                      
                }

            }

            //ŞAH ARKA SAĞ VE SOL ÇAPRAZ YE
            if (sşah[0] - 1 > -1 && sşah[0] - 1 < 6 && sşah[1] - 1 < 6 && sşah[1] - 1 > -1)
            {
                if (satrancKareleri[sşah[0] - 1, sşah[1] - 1].ImageIndex < 4 && satrancKareleri[sşah[0] - 1, sşah[1] - 1].ImageIndex > 0)
                {
                    if (yes == 0)
                    {
                        satrancKareleri[sşah[0], sşah[1]].ImageIndex = 0;
                        satrancKareleri[sşah[0] - 1, sşah[1] - 1].ImageIndex = 6;
                        t = 1;
                        yes = 1;
                    }
                   
                 
                }
            }
            if (sşah[0] - 1 > -1 && sşah[0] - 1 < 6 && sşah[1] + 1 < 6 && sşah[1] + 1 > -1)
            {

                if (satrancKareleri[sşah[0] - 1, sşah[1] + 1].ImageIndex < 4 && satrancKareleri[sşah[0] - 1, sşah[1] + 1].ImageIndex > 0)
                {
                    if (yes == 0)
                    {
                        satrancKareleri[sşah[0], sşah[1]].ImageIndex = 0;
                        satrancKareleri[sşah[0] - 1, sşah[1] + 1].ImageIndex = 6;
                        t = 1;
                        yes = 1;
                    }
                   
                  
                }

            }


            //PİYON YE
            if (spiyon1[0] + 1 > -1 && spiyon1[0] + 1 < 6 && spiyon1[1] + 1 < 6 && spiyon1[1] + 1 > -1)
            {
                if (satrancKareleri[spiyon1[0] + 1, spiyon1[1] + 1].ImageIndex < 4 && satrancKareleri[spiyon1[0] + 1, spiyon1[1] + 1].ImageIndex > 0)
                {
                    if (yes == 0)
                    {
                        p1öncekiadım[0] = spiyon1[0];
                        p1öncekiadım[1] = spiyon1[1];
                        satrancKareleri[spiyon1[0], spiyon1[1]].ImageIndex = 0;
                        satrancKareleri[spiyon1[0] + 1, spiyon1[1] + 1].ImageIndex = 4;
                        t = 1;
                        yes = 1;
                    }
                   
               
                }
            }
            if (spiyon1[0] + 1 > -1 && spiyon1[0] + 1 < 6 && spiyon1[1] - 1 < 6 && spiyon1[1] - 1 > -1)
            {

                if (satrancKareleri[spiyon1[0] + 1, spiyon1[1] - 1].ImageIndex < 4 && satrancKareleri[spiyon1[0] + 1, spiyon1[1] - 1].ImageIndex > 0)
                {
                    if (yes == 0)
                    {
                        p1öncekiadım[0] = spiyon1[0] + 1;
                        p1öncekiadım[1] = spiyon1[1] -1 ;
                        satrancKareleri[spiyon1[0], spiyon1[1]].ImageIndex = 0;
                        satrancKareleri[spiyon1[0] + 1, spiyon1[1] - 1].ImageIndex = 4;
                        t = 1;
                        yes = 1;
                    }
                  
                  
                }

            }
            if (spiyon2[0] + 1 > -1 && spiyon2[0] + 1 < 6 && spiyon2[1] - 1 < 6 && spiyon2[1] - 1 > -1)
            {
                if (satrancKareleri[spiyon2[0] + 1, spiyon2[1] - 1].ImageIndex < 4 && satrancKareleri[spiyon2[0] + 1, spiyon2[1] - 1].ImageIndex > 0)
                {
                    if (yes == 0)
                    {
                        satrancKareleri[spiyon2[0], spiyon2[1]].ImageIndex = 0;
                        satrancKareleri[spiyon2[0] + 1, spiyon2[1] - 1].ImageIndex = 4;
                        t = 1;
                        yes = 1;
                    }
                  
                    
                }

            }
            if (spiyon2[0] > -1 && spiyon2[0] < 6 && spiyon2[1] < 6 && spiyon2[1] > -1)
            {
                if (spiyon2[1] < 6)
                {
                    if (spiyon2[0] + 1 < 6 && spiyon2[0] + 1 > -1 && spiyon2[1] + 1 < 6 && spiyon2[1] + 1 > -1)
                    {
                        if (satrancKareleri[spiyon2[0] + 1, spiyon2[1] + 1].ImageIndex < 4 && satrancKareleri[spiyon2[0] + 1, spiyon2[1] + 1].ImageIndex > 0)
                        {
                            if (yes == 0)
                            {
                                satrancKareleri[spiyon2[0], spiyon2[1]].ImageIndex = 0;
                                satrancKareleri[spiyon2[0] + 1, spiyon2[1] + 1].ImageIndex = 4;
                                t = 1;
                                yes = 1;
                            }
                       
                          
                        }
                    }

                }

            }


            //KALE İLERİ YE
    
            if (skale[0] > -1 && skale[0] < 6 && skale[1] > -1 && skale[1] < 6)
            {
                int ye = 0;
                for (int ileri = 1; ileri < satrancKareleri.GetLength(0); ileri++)
                {
                   
                    skale[0] = skale[0] + 1;
                    if (skale[0] > -1 && skale[0] < 6 && skale[1] > -1 && skale[1] < 6)
                    {
                        if (ye == 0)
                        {
                            if (satrancKareleri[skale[0], skale[1]].ImageIndex < 4 && satrancKareleri[skale[0], skale[1]].ImageIndex > 0)
                            {
                                if (yes == 0)
                                {
                                    satrancKareleri[skale[2], skale[3]].ImageIndex = 0;
                                    satrancKareleri[skale[0], skale[1]].ImageIndex = 5;
                                    ye = ye + 1;
                                    t = 1;
                                    yes = 1;
                                }
                            
                              

                            }
                        }
                       


                    }
                }
            }

            //KALE GERİ YE
            if (skale[4] > -1 && skale[4] < 6 && skale[5] > -1 && skale[5] < 6)
            {

                for (int geri = 0; geri < satrancKareleri.GetLength(0); geri++)
                {

                    skale[4] = skale[4] - 1;
                    if (skale[4] > -1 && skale[4] < 6 && skale[5] > -1 && skale[5] < 6)
                    {

                        if (satrancKareleri[skale[4], skale[5]].ImageIndex < 4 && satrancKareleri[skale[4], skale[5]].ImageIndex > 0)
                        {
                            if (yes == 0)
                            {
                                satrancKareleri[skale[6], skale[7]].ImageIndex = 0;
                                satrancKareleri[skale[4], skale[5]].ImageIndex = 5;
                                t = 1;
                                yes = 1;
                            }
                      
                        }

                    }
                }
            }

                //KALE SAĞ YE
                if (skale[8] > -1 && skale[8] < 6 && skale[9] > -1 && skale[9] < 6)
                {

                    for (int geri = 0; geri < satrancKareleri.GetLength(0); geri++)
                    {

                        skale[9] = skale[9] + 1;
                        if (skale[11] > -1 && skale[11] < 6 && skale[9] > -1 && skale[9] < 6)
                        {

                            if (satrancKareleri[skale[8], skale[9]].ImageIndex < 4 && satrancKareleri[skale[8], skale[9]].ImageIndex > 0)
                            {
                            if (yes == 0)
                            {
                                satrancKareleri[skale[10], skale[11]].ImageIndex = 0;
                                satrancKareleri[skale[8], skale[9]].ImageIndex = 5;
                                t = 1;
                                yes = 1;
                            }
                            
                           
                        }

                        }
                    }
                }

                //KALE SOL YE
                if (skale[12] > -1 && skale[12] < 6 && skale[13] > -1 && skale[13] < 6)
                {

                    for (int geri = 0; geri < satrancKareleri.GetLength(0); geri++)
                    {

                        skale[13] = skale[13] - 1;
                        if (skale[12] > -1 && skale[12] < 6 && skale[13] > -1 && skale[13] < 6)
                        {

                            if (satrancKareleri[skale[12], skale[13]].ImageIndex < 4 && satrancKareleri[skale[12], skale[13]].ImageIndex > 0)
                            {
                            if (yes == 0)
                            {
                                satrancKareleri[skale[14], skale[15]].ImageIndex = 0;
                                satrancKareleri[skale[12], skale[13]].ImageIndex = 5;
                                t = 1;
                                yes = 1;
                            }
                         
                           
                            }
    
                        }
                    }
                }

        }
        public void AI_İLERİ_HAMLE()
        {
            
            int[] kscore;
            kscore = new int[8];
       

            int[] p1score;
            p1score = new int[8];
          

            int[] p2score;
            p2score = new int[8];
      

            int[] şscore;
            şscore = new int[8];
         

            int[] tscore;
            tscore = new int[8];
            tscore[0] = -10;
            tscore[1] = 100;//piyon
            tscore[2] = 200;//kale
            tscore[3] = 900;//şah
            tscore[4] = 10;

            //ŞAH İLERİ

            if (sşah[0] + 2 > -1 && sşah[0] + 2 < 6 && sşah[1] < 6 && sşah[1] > -1)
            {
                sşah[21] = sşah[0];
                sşah[22] = sşah[1];
                if (satrancKareleri[sşah[0] + 2, sşah[1]].ImageIndex == 1)
                {
                    şscore[0] = tscore[1];
                    sşah[21] = sşah[0]+1;
                    sşah[22] = sşah[1];
                }
                if (satrancKareleri[sşah[0] + 2, sşah[1]].ImageIndex == 2)
                {
                    şscore[1] = tscore[2];
                    sşah[21] = sşah[0] + 1;
                    sşah[22] = sşah[1];
                }
                if (satrancKareleri[sşah[0] + 2, sşah[1]].ImageIndex == 3)
                {
                    şscore[2] = tscore[3];
                    sşah[21] = sşah[0] + 1;
                    sşah[22] = sşah[1];
                }
            }

            //ŞAH GERİ
            if (sşah[10] - 2 > -1 && sşah[10] - 2 < 6 && sşah[11] < 6 && sşah[11] > -1)
            {
                if (satrancKareleri[sşah[10] - 2, sşah[11]].ImageIndex == 1)
                {
                    şscore[0] = tscore[1];
                    sşah[21] = sşah[0] - 1;
                    sşah[22] = sşah[1];
                }
                if (satrancKareleri[sşah[0] - 2, sşah[1]].ImageIndex == 2)
                {
                    şscore[1] = tscore[2];
                    sşah[21] = sşah[0] - 1;
                    sşah[22] = sşah[1];
                }
                if (satrancKareleri[sşah[0] - 2, sşah[1]].ImageIndex == 3)
                {
                    şscore[2] = tscore[3];
                    sşah[21] = sşah[0] - 1;
                    sşah[22] = sşah[1];
                }
            }

            //ŞAH SAĞ SOL 
            if (sşah[0] > -2 && sşah[0] < 6 && sşah[1] - 2 < 6 && sşah[1] - 2 > -1)
            {
                if (satrancKareleri[sşah[0], sşah[1] - 2].ImageIndex == 1)
                {
                    şscore[0] = tscore[1];
                    sşah[21] = sşah[0];
                    sşah[22] = sşah[1]-1;
                }
                if (satrancKareleri[sşah[0], sşah[1] - 2].ImageIndex == 2)
                {
                    şscore[1] = tscore[2];
                    sşah[21] = sşah[0];
                    sşah[22] = sşah[1] - 1;
                }
                if (satrancKareleri[sşah[0], sşah[1] - 2].ImageIndex == 3)
                {
                    şscore[2] = tscore[3];
                    sşah[21] = sşah[0];
                    sşah[22] = sşah[1] - 1;
                }
            }
            if (sşah[0] > -1 && sşah[0] + 2 < 6 && sşah[1] + 2 < 6 && sşah[1] + 1 > -1)
            {

                if (satrancKareleri[sşah[8], sşah[9] + 2].ImageIndex == 1)
                {
                    şscore[0] = tscore[1];
                    sşah[21] = sşah[0];
                    sşah[22] = sşah[1] + 1;
                }
                if (satrancKareleri[sşah[0], sşah[1] + 2].ImageIndex == 2)
                {
                    şscore[1] = tscore[2];
                    sşah[21] = sşah[0];
                    sşah[22] = sşah[1] + 1;
                }
                if (satrancKareleri[sşah[0], sşah[1] + 2].ImageIndex == 3)
                {
                    şscore[2] = tscore[3];
                    sşah[21] = sşah[0];
                    sşah[22] = sşah[1] + 1;
                }

            }

            //ŞAH SAĞ VE SOL ÇAPRAZ 
            if (sşah[0] + 2 > -1 && sşah[0] + 2 < 6 && sşah[1] - 2 < 6 && sşah[1] - 2 > -1)
            {
                if (satrancKareleri[sşah[0] + 2, sşah[1] - 2].ImageIndex == 1)
                {
                    şscore[0] = tscore[1];
                    sşah[21] = sşah[0] + 1;
                    sşah[22] = sşah[1] - 1;
                }
                if (satrancKareleri[sşah[0] + 2, sşah[1] - 2].ImageIndex == 2)
                {
                    şscore[1] = tscore[2];
                    sşah[21] = sşah[0] + 1;
                    sşah[22] = sşah[1] - 1;
                }
                if (satrancKareleri[sşah[0] + 2, sşah[1] - 2].ImageIndex == 3)
                {
                    şscore[2] = tscore[3];
                    sşah[21] = sşah[0] + 1;
                    sşah[22] = sşah[1] - 1;
                }
            }
            if (sşah[0] + 1 > -2 && sşah[0] + 2 < 6 && sşah[1] + 2 < 6 && sşah[1] + 2 > -1)
            {

                if (satrancKareleri[sşah[0] + 2, sşah[1] + 2].ImageIndex == 1)
                {
                    şscore[0] = tscore[1];
                    sşah[21] = sşah[0] + 1;
                    sşah[22] = sşah[1] + 1;
                }
                if (satrancKareleri[sşah[0] + 2, sşah[1] + 2].ImageIndex == 2)
                {
                    şscore[1] = tscore[2];
                    sşah[21] = sşah[0] + 1;
                    sşah[22] = sşah[1] + 1;
                }
                if (satrancKareleri[sşah[0] + 2, sşah[1] + 2].ImageIndex == 3)
                {
                    şscore[2] = tscore[3];
                    sşah[21] = sşah[0] + 1;
                    sşah[22] = sşah[1] + 1;
                }

            }

            //ŞAH ARKA SAĞ VE SOL ÇAPRAZ 
            if (sşah[0] - 2 > -1 && sşah[0] - 2 < 6 && sşah[1] - 2 < 6 && sşah[1] - 2 > -1)
            {
                if (satrancKareleri[sşah[0] - 2, sşah[1] - 2].ImageIndex == 1)
                {
                    şscore[0] = tscore[1];
                    sşah[21] = sşah[0] + 1;
                    sşah[22] = sşah[1] - 1;
                }
                if (satrancKareleri[sşah[0] - 2, sşah[1] - 2].ImageIndex == 2)
                {
                    şscore[1] = tscore[2];
                    sşah[21] = sşah[0] + 1;
                    sşah[22] = sşah[1] - 1;
                }
                if (satrancKareleri[sşah[0] - 2, sşah[1] - 2].ImageIndex == 3)
                {
                    şscore[2] = tscore[3];
                    sşah[21] = sşah[0] + 1;
                    sşah[22] = sşah[1] - 1;
                }
            }
            if (sşah[0] - 2 > -1 && sşah[0] - 2 < 6 && sşah[1] + 2 < 6 && sşah[1] + 2 > -1)
            {

                if (satrancKareleri[sşah[0] - 2, sşah[1] + -2].ImageIndex == 1)
                {
                    şscore[0] = tscore[1];
                    sşah[21] = sşah[0] - 1;
                    sşah[22] = sşah[15] - 1;
                }
                if (satrancKareleri[sşah[0] - 2, sşah[1] + 2].ImageIndex == 2)
                {
                    şscore[1] = tscore[2];
                    sşah[21] = sşah[0] - 1;
                    sşah[22] = sşah[1] - 1;
                }
                if (satrancKareleri[sşah[0] - 2, sşah[1] + 2].ImageIndex == 3)
                {
                    şscore[2] = tscore[3];
                    sşah[21] = sşah[0] - 1;
                    sşah[22] = sşah[1] - 1;
                }

            }


            //PİYON 
            spiyon1[0] += 1;
            if (spiyon1[0] + 1 > -1 && spiyon1[0] + 1 < 6 && spiyon1[1] + 1 < 6 && spiyon1[1] + 1 > -1)
            {
                
                if (satrancKareleri[spiyon1[0] + 1, spiyon1[1] + 1].ImageIndex == 1)
                {
                    p1score[0] = tscore[1];
                    spiyon1[11] = spiyon1[0];
                    spiyon1[12] = spiyon1[1];
                }
                if (satrancKareleri[spiyon1[0] + 1, spiyon1[1] + 1].ImageIndex == 2)
                {
                    p1score[1] = tscore[2];
                    spiyon1[11] = spiyon1[0];
                    spiyon1[12] = spiyon1[1];
                }
                if (satrancKareleri[spiyon1[0] + 1, spiyon1[1] + 1].ImageIndex == 3)
                {
                    p1score[2] = tscore[3];
                    spiyon1[11] = spiyon1[0];
                    spiyon1[12] = spiyon1[1];
                }
            }
            if (spiyon1[0] + 1 > -1 && spiyon1[0] + 1 < 6 && spiyon1[1] - 1 < 6 && spiyon1[1] - 1 > -1)
            {

                if (satrancKareleri[spiyon1[0] + 1, spiyon1[1] - 1].ImageIndex == 1)
                {
                    p1score[0] = tscore[1];
                    spiyon1[11] = spiyon1[0];
                    spiyon1[12] = spiyon1[1];
                }
                if (satrancKareleri[spiyon1[0] + 1, spiyon1[1] - 1].ImageIndex == 2)
                {
                    p1score[1] = tscore[2];
                    spiyon1[11] = spiyon1[0];
                    spiyon1[12] = spiyon1[1];
                }
                if (satrancKareleri[spiyon1[0] + 1, spiyon1[1] - 1].ImageIndex == 3)
                {
                    p1score[2] = tscore[3];
                    spiyon1[11] = spiyon1[0];
                    spiyon1[12] = spiyon1[1];
                }

            }
            spiyon2[0] += 1;
            if (spiyon2[0] + 1 > -1 && spiyon2[0] + 1 < 6 && spiyon2[1] - 1 < 6 && spiyon2[1] - 1 > -1)
            {
                if (satrancKareleri[spiyon2[0] + 1, spiyon2[1] - 1].ImageIndex == 1)
                {
                    p2score[0] = tscore[1];
                    spiyon2[11] = spiyon2[0] + 1;
                    spiyon2[11] = spiyon2[1] ;
                }
                if (satrancKareleri[spiyon2[0] + 1, spiyon2[1] - 1].ImageIndex == 2)
                {
                    p2score[1] = tscore[2];
                    spiyon2[11] = spiyon2[0] + 1;
                    spiyon2[11] = spiyon2[1];
                }
                if (satrancKareleri[spiyon2[0] + 1, spiyon2[1] - 1].ImageIndex == 3)
                {
                    p2score[2] = tscore[3];
                    spiyon2[11] = spiyon2[0] + 1;
                    spiyon2[11] = spiyon2[1];
                }

            }
            if (spiyon2[0] > -1 && spiyon2[0] < 6 && spiyon2[1] < 6 && spiyon2[1] > -1)
            {
                if (spiyon2[1] < 6)
                {
                    if (spiyon2[0] + 1 < 6 && spiyon2[0] + 1 > -1 && spiyon2[1] + 1 < 6 && spiyon2[1] + 1 > -1)
                    {
                        if (satrancKareleri[spiyon2[0] + 1, spiyon2[1] + 1].ImageIndex == 1)
                        {
                            p2score[0] = tscore[1];
                            spiyon2[11] = spiyon2[0] + 1;
                            spiyon2[11] = spiyon2[1];
                        }
                        if (satrancKareleri[spiyon2[0] + 1, spiyon2[1] + 1].ImageIndex == 2)
                        {
                            p2score[1] = tscore[2];
                            spiyon2[11] = spiyon2[0] + 1;
                            spiyon2[11] = spiyon2[1];
                        }
                        if (satrancKareleri[spiyon2[0] + 1, spiyon2[1] + 1].ImageIndex == 3)
                        {
                            p2score[2] = tscore[3];
                            spiyon2[11] = spiyon2[0] + 1;
                            spiyon2[11] = spiyon2[1];
                        }
                    }

                }

            }


            //KALE İLERİ
            if (skale[0] > -1 && skale[0] < 6 && skale[1] > -1 && skale[1] < 6)
            {
              
                for (int ileri = 0; ileri < satrancKareleri.GetLength(0); ileri++)
                {
                    skale[1] = skale[1] + 1;
                    for (int xleri = 0; xleri < satrancKareleri.GetLength(0); xleri++)
                    {
                        skale[1] = skale[1] + 1;

                        if (skale[0] > -1 && skale[0] < 6 && skale[1] > -1 && skale[1] < 6)
                        {
                            if (satrancKareleri[skale[0], skale[1]].ImageIndex == 0)
                            {
                                if (satrancKareleri[skale[0], skale[1]].ImageIndex == 1)
                                {
                                    kscore[0] = tscore[1];
                                    skale[26] = skale[0];
                                    skale[27] = skale[1];
                                }
                                if (satrancKareleri[skale[0], skale[1]].ImageIndex == 2)
                                {
                                    kscore[1] = tscore[2];
                                    skale[26] = skale[0];
                                    skale[27] = skale[1];
                                }
                                if (satrancKareleri[skale[0], skale[1]].ImageIndex == 3)
                                {
                                    kscore[2] = tscore[3];
                                    skale[26] = skale[0];
                                    skale[27] = skale[1];
                                }
                            }

                        }
                    }
                      
                }
            }

            //KALE GERİ 
            if (skale[4] > -1 && skale[4] < 6 && skale[5] > -1 && skale[5] < 6)
            {

                for (int geri = 0; geri < satrancKareleri.GetLength(0); geri++)
                {

                    skale[4] = skale[4] - 1;
                    if (skale[4] > -1 && skale[4] < 6 && skale[5] > -1 && skale[5] < 6)
                    {

                        if (satrancKareleri[skale[4], skale[5]].ImageIndex == 1)
                        {
                            kscore[0] = tscore[1];
                            skale[26] = skale[4];
                            skale[27] = skale[5];
                        }
                        if (satrancKareleri[skale[4], skale[5]].ImageIndex == 2)
                        {
                            kscore[1] = tscore[2];
                            skale[26] = skale[4];
                            skale[27] = skale[5];
                        }
                        if (satrancKareleri[skale[4], skale[5]].ImageIndex == 3)
                        {
                            kscore[2] = tscore[3];
                            skale[26] = skale[4];
                            skale[27] = skale[5];
                        }

                    }
                }
            }

            //KALE SAĞ YE
            if (skale[8] > -1 && skale[8] < 6 && skale[9] > -1 && skale[9] < 6)
            {

                for (int geri = 0; geri < satrancKareleri.GetLength(0); geri++)
                {

                    skale[9] = skale[9] + 1;
                    if (skale[11] > -1 && skale[11] < 6 && skale[9] > -1 && skale[9] < 6)
                    {
                            for (int ileri = 1; ileri < satrancKareleri.GetLength(0); ileri++)
                            {

                                skale[0] = skale[0] + 1;
                                if (skale[0] > -1 && skale[0] < 6 && skale[1] > -1 && skale[1] < 6)
                                {

                                    if (satrancKareleri[skale[0], skale[1]].ImageIndex == 1)
                                    {
                                    kscore[0] = tscore[1];
                                    skale[26] = skale[0];
                                    skale[27] = skale[9];
                                    }
                                    if (satrancKareleri[skale[0], skale[1]].ImageIndex == 2)
                                    {
                                    kscore[1] = tscore[2];
                                    skale[26] = skale[0];
                                    skale[27] = skale[9];
                                    }
                                    if (satrancKareleri[skale[0], skale[1]].ImageIndex == 3)
                                    {
                                    kscore[2] = tscore[3];
                                    skale[26] = skale[0];
                                    skale[27] = skale[9];
                                    }

                                }
                            }
                        

                    }
                }
            }

            //KALE SOL YE
            if (skale[12] > -1 && skale[12] < 6 && skale[13] > -1 && skale[13] < 6)
            {

                for (int geri = 0; geri < satrancKareleri.GetLength(0); geri++)
                {

                    skale[13] = skale[13] - 1;
                    if (skale[12] > -1 && skale[12] < 6 && skale[13] > -1 && skale[13] < 6)
                    {

                        if (satrancKareleri[skale[12], skale[13]].ImageIndex == 1)
                        {
                            kscore[0] = tscore[1];
                            skale[26] = skale[12];
                            skale[27] = skale[13];
                        }
                        if (satrancKareleri[skale[12], skale[13]].ImageIndex == 2)
                        {
                            kscore[1] = tscore[2];
                            skale[26] = skale[12];
                            skale[27] = skale[13];
                        }

                        if (satrancKareleri[skale[12], skale[13]].ImageIndex == 3)
                        {
                            kscore[2] = tscore[3];
                            skale[26] = skale[12];
                            skale[27] = skale[13];
                        }
                       

                    }
                }
            }
            // en büyük kale skoru
            int keb = kscore[0];
            for (int i = 0; i < kscore.Length; i++)
            {
                if (kscore[i] > keb)/// büyüktür işareti oldugu için büyük sayıyı gösterecek
                {
                    keb = kscore[i];
                }
            }

            //en büyük piyon1 skoru
            int p1eb = 0;
            for (int i = 0; i < p1score.Length; i++)
            {
                if (p1score[i] > p1eb)/// büyüktür işareti oldugu için büyük sayıyı gösterecek
                {
                    p1eb = p1score[i];
                }
            }
            //en büyük piyon2 skoru
            int p2eb = p2score[0];
            for (int i = 0; i < p2score.Length; i++)
            {
                if (p2score[i] > p2eb)/// büyüktür işareti oldugu için büyük sayıyı gösterecek
                {
                    p2eb = p2score[i];
                }
            }

            //en büyük ş skoru
            int şeb = şscore[0];
            for (int i = 0; i < şscore.Length; i++)
            {
                if (şscore[i] > şeb)/// büyüktür işareti oldugu için büyük sayıyı gösterecek
                {
                    şeb = şscore[i];
                }
            }
            int tek = 0;
            if (keb >= şeb && keb >= p1eb && keb >= p2eb && tek == 0 && kvar==1)
            {
                AI_K();
                tek = 1;
            }
       
            if (p1eb >= p2eb && tek == 0)
            {
                AI_P1();
                tek = 1;
            }
            if (şeb >= p2eb && şeb > keb && tek == 1)
            {
                AI_Ş();
                tek = 1;
            }
        
            if (p2eb >= şeb && tek == 0)
            {
                AI_P2();
                tek = 1;
            }
       
           else if(tek==0)
            {
                AI_P1();
            }
            
        }
       
        public void AI_Ş()
        {
            if(satrancKareleri[sşah[21],sşah[22]].ImageIndex<1)
            {
                satrancKareleri[sşah[0], sşah[1]].ImageIndex = 0;
                satrancKareleri[sşah[21], sşah[22]].ImageIndex = 6;
            }
           
        }
        public void AI_K()
        {
            if(skale[30]>-1 && skale[11]>-1 && skale[11]<6 && skale[30]<6)
            {
                if (satrancKareleri[skale[30], skale[11]].ImageIndex < 1)
                {
                    if(satrancKareleri[skale[16], skale[17]].ImageIndex != 0)
                    {
                        satrancKareleri[skale[16], skale[17]].ImageIndex = 0;
                        satrancKareleri[skale[30], skale[11]].ImageIndex = 5;
                    }
                    
                }
            }
        }
        public void AI_P1()
        {
            if (spiyon1[0] > -1 && spiyon1[1] > -1 && spiyon1[1] < 6 && spiyon1[0] < 6)
            {
                if (satrancKareleri[spiyon1[0], spiyon1[1]].ImageIndex < 1)
                {
                    if (pvar==1)
                    {
                        satrancKareleri[spiyon1[0] - 1, spiyon1[1]].ImageIndex = 0;
                        satrancKareleri[spiyon1[0], spiyon1[1]].ImageIndex = 4;
                    }
                }
                else
                {
                    AI_Ş();
                }
             
            }
        }
        public void AI_P2()
        {
            if (spiyon2[0] > -1 && spiyon2[1] > -1 && spiyon2[1] < 6 && spiyon2[0] < 6)
            {
                if (satrancKareleri[spiyon2[0], spiyon2[1]].ImageIndex < 1)
                {
                    if (pvar==1)
                    {
                        satrancKareleri[spiyon2[0] - 1, spiyon2[1]].ImageIndex = 0;
                        satrancKareleri[spiyon2[0], spiyon2[1]].ImageIndex = 4;
                    }

                }


            }    
        }

        public void AI_Hamle()
        {
            hamletanı();
            AI_YE();
            if(t==0)
            {
                AI_İLERİ_HAMLE();
            }
        }
        public void AI(int x,int y)
        {
            if (hml == 0)
            {
                if(radioButton1.Checked == true)
                {
                    satrancKareleri[0, 0].ImageIndex = 0;
                    satrancKareleri[1, 0].ImageIndex = 5;
                    sıra = 1;
                }
                if(radioButton2.Checked==true)
                {
                    sıra = 1;
                }
            }
          if (hml>0)
            {
                AI_Hamle();
                sıra = 1;
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            yerlestir();
        }

        int[] adim = new int[4];

        int[] kx = new int[10];
        int[] ky = new int[10];
        int[] sah = new int[6];
        
        //Tahta oluşturma fonksiyonum
        public Button[,] satrancKareleri = new Button[6, 6];


        public void yerlestir()
        {
            int en = 50;
            int boy = 50;

            int yukseklik = 20;
            for (int satir = 0; satir < 6; satir++)
            {
                int sol = 20;
                for (int sutun = 0; sutun < 6; sutun++)
                {
                    satrancKareleri[satir, sutun] = new Button();
                    satrancKareleri[satir, sutun].Size = new Size(en, boy);
                    satrancKareleri[satir, sutun].Left = sol;
                    satrancKareleri[satir, sutun].Top = yukseklik;

                    satrancKareleri[satir, sutun].AutoSize = false;
                    //satrancKareleri[satir, sutun].Text = satir + ";" + sutun;
                    //Ancak koordinat numaralarını sadece ben görmeliyim, kullanıcının görmesine gerek yok.
                    satrancKareleri[satir, sutun].Tag = satir + ";" + sutun;

                    if ((satir + sutun) % 2 == 0)
                    {
                        satrancKareleri[satir, sutun].BackColor = Color.White;
                    }
                    else
                    {
                        satrancKareleri[satir, sutun].BackColor = Color.Gray;
                    }

                    this.Controls.Add(satrancKareleri[satir, sutun]);
                    satrancKareleri[satir, sutun].Click += new EventHandler(Button_Click);
                    sol += en;
                    //satrancKareleri[satir, sutun].Width; yerine "en" yazmamız daha iyi:

                    //BOŞ_KARE İNDEX =0
                    satrancKareleri[satir, sutun].ImageList = taslar;
                    satrancKareleri[satir, sutun].ImageIndex = 0;


                }

                yukseklik += boy;
            }


            //SİYAH_KALE index = 5
            satrancKareleri[0, 0].ImageList = taslar;
            satrancKareleri[0, 0].ImageIndex = 5;

            //SİYAH_PİYON index = 4
            satrancKareleri[0, 2].ImageList = taslar;
            satrancKareleri[0, 2].ImageIndex = 4;

            //SİYAH_ŞAH index = 6
            satrancKareleri[0, 3].ImageList = taslar;
            satrancKareleri[0, 3].ImageIndex = 6;

            //SİYAH_PİYON index = 4
            satrancKareleri[0, 4].ImageList = taslar;
            satrancKareleri[0, 4].ImageIndex = 4;


            //BEYAZ_piyon index = 1
            satrancKareleri[5, 2].ImageList = taslar;
            satrancKareleri[5, 2].ImageIndex = 1;

            //BEYAZ_Şah index = 3
            satrancKareleri[5, 3].ImageList = taslar;
            satrancKareleri[5, 3].ImageIndex = 3;

            //BEYAZ_Piyon index = 1
            satrancKareleri[5, 4].ImageList = taslar;
            satrancKareleri[5, 4].ImageIndex = 1;

            //BEYAZ_Kale index = 2
            satrancKareleri[5, 5].ImageList = taslar;
            satrancKareleri[5, 5].ImageIndex = 2;
            timer1.Enabled = true;

        }

        
        int hareket = 0;
        int piyonh = 0;
        public void Button_Click(object sender, EventArgs e)
        {
            
            if (sıra == 1)
            {
                Button tiklananKare = sender as Button;
                string kordinat = tiklananKare.Tag.ToString();
                int x = Convert.ToInt32(kordinat.Split(';')[0]);
                //Split dizi oluşturuyordu, 0. eleman:
                int y = Convert.ToInt32(kordinat.Split(';')[1]);
                kazanan();
                
                if (hareket == 0)
                {
                    adim[0] = x;
                    adim[1] = y;
                    if (satrancKareleri[x, y].ImageIndex == 0)
                    {
                        return;
                    }
                    //Piyon Hareket
                    if (satrancKareleri[x, y].ImageIndex == 1)
                    {                  
                            int xp = x;
                            int yp = y;
                            int yesa = y;
                            int yeso = y;
                            for (int ileri = 5; ileri < satrancKareleri.GetLength(0); ileri++)
                            {
                                xp = xp - 1;
                                if (xp > -1)
                                {
                                    if (satrancKareleri[xp, yp].ImageIndex != 0)
                                    {
                                        ileri = satrancKareleri.GetLength(1);
                                    }
                                    if (satrancKareleri[xp, yp].ImageIndex == 0)
                                    {
                                        satrancKareleri[xp, yp].ImageIndex = 7;
                                        satrancKareleri[xp, yp].Click += piyon;
                                        hareket = 1;
                                        piyonh = 1;
                                    }
                                    yesa = yesa + 1;
                                    if (yesa < 6)
                                    {
                                        if (satrancKareleri[xp, yesa].ImageIndex > 3 && satrancKareleri[xp, yesa].ImageIndex < 7)
                                        {
                                            satrancKareleri[xp, yesa].Click += piyon;
                                            satrancKareleri[xp, yesa].FlatStyle = FlatStyle.Flat;
                                            satrancKareleri[xp, yesa].FlatAppearance.BorderColor = Color.Red;
                                            hareket = 1;
                                            piyonh = 1;
                                        }
                                    }
                                    yeso = yeso - 1;
                                    if (satrancKareleri[xp, yeso].ImageIndex > 3 && satrancKareleri[xp, yeso].ImageIndex < 7)
                                    {
                                        satrancKareleri[xp, yeso].Click += piyon;
                                        satrancKareleri[xp, yeso].FlatStyle = FlatStyle.Flat;
                                        satrancKareleri[xp, yeso].FlatAppearance.BorderColor = Color.Red;
                                        hareket = 1;
                                         piyonh = 1;

                                    }

                                }
                            }
                        }
                   
                    //Kale hareket
                    if (satrancKareleri[x, y].ImageIndex == 2)
                    {
                        reset();
                        int yki = y;
                        int xki = x;

                        int ykg = y;
                        int xkg = x;

                        int yksa = y;
                        int xksa = x;

                        int ykso = y;
                        int xkso = x;
                        //Getlength(0) satırlar için kontrol
                        //ileri
                        for (int ileri = 1; ileri < satrancKareleri.GetLength(0); ileri++)
                        {
                            xki = xki - 1;
                            if (xki > -1)
                            {
                                if (satrancKareleri[xki, yki].ImageIndex != 0)
                                {
                                    ileri = satrancKareleri.GetLength(1);
                                }
                                if (satrancKareleri[xki, yki].ImageIndex == 0)
                                {
                                    satrancKareleri[xki, yki].ImageIndex = 7;
                                    kx[ileri] = xki;//gidebilecek adımları dizide tuttum
                                    satrancKareleri[xki, yki].Click += kale;
                                    hareket = 1;
                                }
                                if (satrancKareleri[xki, yki].ImageIndex > 3 && satrancKareleri[xki, yki].ImageIndex < 7)
                                {
                                    satrancKareleri[xki, yki].FlatStyle = FlatStyle.Flat;
                                    satrancKareleri[xki, yki].FlatAppearance.BorderColor = Color.Red;
                                    satrancKareleri[xki, yki].Click += kale;
                                    hareket = 1;
                                }
                            }
                        }
                        //geri
                        for (int geri = 1; geri < satrancKareleri.GetLength(0); geri++)
                        {
                            xkg = xkg + 1;
                            if (xkg < 6)
                            {
                                if (satrancKareleri[xkg, ykg].ImageIndex != 0)
                                {
                                    geri = satrancKareleri.GetLength(1);
                                }
                                if (satrancKareleri[xkg, ykg].ImageIndex == 0)
                                {
                                    satrancKareleri[xkg, ykg].ImageIndex = 7;
                                    satrancKareleri[xkg, ykg].Click += kale;
                                    hareket = 1;
                                }
                                if (satrancKareleri[xkg, ykg].ImageIndex > 3 && satrancKareleri[xkg, ykg].ImageIndex < 7)
                                {
                                    satrancKareleri[xkg, ykg].FlatStyle = FlatStyle.Flat;
                                    satrancKareleri[xkg, ykg].FlatAppearance.BorderColor = Color.Red;
                                    satrancKareleri[xkg, ykg].Click += kale;
                                    hareket = 1;
                                }
                            }
                        }

                        //GetLength(1)sütun için kontrol
                        //sağ
                        for (int sag = 1; sag < satrancKareleri.GetLength(1); sag++)
                        {
                            yksa = yksa + 1;
                            if (yksa < 6)
                            {
                                if (satrancKareleri[xksa, yksa].ImageIndex != 0)
                                {
                                    sag = satrancKareleri.GetLength(1) + 1;
                                }
                                if (satrancKareleri[xksa, yksa].ImageIndex == 0)
                                {
                                    satrancKareleri[xksa, yksa].ImageIndex = 7;
                                    satrancKareleri[xksa, yksa].Click += kale;
                                    hareket = 1;

                                }
                                if (satrancKareleri[xksa, yksa].ImageIndex > 3 && satrancKareleri[xksa, yksa].ImageIndex < 7)
                                {
                                    satrancKareleri[xksa, yksa].FlatStyle = FlatStyle.Flat;
                                    satrancKareleri[xksa, yksa].FlatAppearance.BorderColor = Color.Red;
                                    satrancKareleri[xksa, yksa].Click += kale;
                                    hareket = 1;
                                }
                            }


                        }
                        //sol
                        for (int sol = 1; sol < satrancKareleri.GetLength(1); sol++)
                        {
                            ykso = ykso - 1;
                            if (ykso > -1)
                            {
                                if (satrancKareleri[xkso, ykso].ImageIndex != 0)
                                {
                                    sol = satrancKareleri.GetLength(1);
                                }

                                if (satrancKareleri[xkso, ykso].ImageIndex == 0)
                                {
                                    satrancKareleri[xkso, ykso].ImageIndex = 7;
                                    satrancKareleri[xkso, ykso].Click += kale;
                                    hareket = 1;

                                }
                                if (satrancKareleri[xkso, ykso].ImageIndex > 3 && satrancKareleri[xkso, ykso].ImageIndex < 7)
                                {
                                    satrancKareleri[xkso, ykso].FlatStyle = FlatStyle.Flat;
                                    satrancKareleri[xkso, ykso].FlatAppearance.BorderColor = Color.Red;
                                    satrancKareleri[xkso, ykso].Click += kale;
                                    hareket = 1;
                                }
                            }
                        }

                    }

                    ////////////Şah hareket//////////////////

                    if (satrancKareleri[x, y].ImageIndex == 3)
                    {
                        if (piyonh == 0)
                        {
                            reset();

                            int yi = y;
                            int xi = x;

                            int yg = y;
                            int xg = x;

                            int ysa = y;
                            int xsa = x;

                            int yso = y;
                            int xso = x;

                            int ygsa = y;
                            int xgsa = x;

                            int ygso = y;
                            int xgso = x;

                            int yiso = y;
                            int xiso = x;

                            int yisa = y;
                            int xisa = x;

                            //ileri
                            for (int ileri = 5; ileri < satrancKareleri.GetLength(0); ileri++)
                            {
                                xi = xi - 1;
                                if (xi > -1)
                                {
                                    if (satrancKareleri[xi, y].ImageIndex > 3 && satrancKareleri[xi, y].ImageIndex < 7)
                                    {
                                        satrancKareleri[xi, y].FlatStyle = FlatStyle.Flat;
                                        satrancKareleri[xi, y].FlatAppearance.BorderColor = Color.Red;

                                    }
                                    if (satrancKareleri[xi, y].ImageIndex != 0)
                                    {
                                        ileri = satrancKareleri.GetLength(1);
                                    }
                                    if (satrancKareleri[xi, y].ImageIndex == 0)
                                    {
                                        satrancKareleri[xi, y].ImageIndex = 7;
                                        satrancKareleri[xi, y].Click += şah;
                                        hareket = 1;
                                    }
                                    if (satrancKareleri[xi, y].ImageIndex > 3 && satrancKareleri[xi, y].ImageIndex < 7)
                                    {
                                        satrancKareleri[xi, y].FlatStyle = FlatStyle.Flat;
                                        satrancKareleri[xi, y].FlatAppearance.BorderColor = Color.Red;
                                        satrancKareleri[xi, y].Click += şah;
                                        hareket = 1;
                                    }
                                }
                            }

                            //ileri-sağ
                            for (int ileri = 5; ileri < satrancKareleri.GetLength(0); ileri++)
                            {

                                xisa = xisa - 1;
                                yisa = yisa + 1;

                                if (yisa > -1 && yisa < 6 && xisa > -1 && xisa < 6)
                                {

                                    if (satrancKareleri[xisa, yisa].ImageIndex != 0)//eğer boş değilse adım göstermesin 
                                    {
                                        ileri = satrancKareleri.GetLength(1);
                                    }
                                    if (satrancKareleri[xisa, yisa].ImageIndex == 0)
                                    {
                                        satrancKareleri[xisa, yisa].ImageIndex = 7;
                                        satrancKareleri[xisa, yisa].Click += şah;
                                        hareket = 1;
                                    }
                                    if (satrancKareleri[xisa, yisa].ImageIndex > 3 && satrancKareleri[xisa, yisa].ImageIndex < 7)
                                    {
                                        satrancKareleri[xisa, yisa].FlatStyle = FlatStyle.Flat;
                                        satrancKareleri[xisa, yisa].FlatAppearance.BorderColor = Color.Red;
                                        satrancKareleri[xisa, yisa].Click += şah;
                                        hareket = 1;
                                    }
                                }
                            }

                            //ileri-sol (0) satır için
                            for (int ileri = 5; ileri < satrancKareleri.GetLength(1); ileri++)
                            {
                                xiso = xiso - 1;
                                yiso = yiso - 1;
                                if (yiso > -1 && xiso > -1 && yiso < 6 && xiso < 6)
                                {
                                    if (satrancKareleri[xiso, yiso].ImageIndex > 3 && satrancKareleri[xiso, yiso].ImageIndex < 7)
                                    {
                                        satrancKareleri[xiso, yiso].FlatStyle = FlatStyle.Flat;
                                        satrancKareleri[xiso, yiso].FlatAppearance.BorderColor = Color.Red;

                                    }
                                    if (satrancKareleri[xiso, yiso].ImageIndex != 0)
                                    {
                                        ileri = satrancKareleri.GetLength(1);
                                    }
                                    if (satrancKareleri[xiso, yiso].ImageIndex == 0)
                                    {
                                        satrancKareleri[xiso, yiso].ImageIndex = 7;
                                        satrancKareleri[xiso, yiso].Click += şah;
                                        hareket = 1;
                                    }
                                    if (satrancKareleri[xiso, yiso].ImageIndex > 3 && satrancKareleri[xiso, yiso].ImageIndex < 7)
                                    {
                                        satrancKareleri[xiso, yiso].FlatStyle = FlatStyle.Flat;
                                        satrancKareleri[xiso, yiso].FlatAppearance.BorderColor = Color.Red;
                                        satrancKareleri[xiso, yiso].Click += şah;
                                        hareket = 1;
                                    }

                                }
                            }


                            //sağ 

                            for (int ileri = 5; ileri < satrancKareleri.GetLength(1); ileri++)
                            {

                                ysa = ysa + 1;
                                if (ysa < 6 && ysa > -1)
                                {
                                    if (satrancKareleri[xsa, ysa].ImageIndex > 3 && satrancKareleri[xsa, ysa].ImageIndex < 7)
                                    {
                                        satrancKareleri[xsa, ysa].FlatStyle = FlatStyle.Flat;
                                        satrancKareleri[xsa, ysa].FlatAppearance.BorderColor = Color.Red;

                                    }
                                    if (satrancKareleri[xsa, ysa].ImageIndex != 0)
                                    {
                                        ileri = satrancKareleri.GetLength(1);
                                    }
                                    if (satrancKareleri[xsa, ysa].ImageIndex == 0)
                                    {
                                        satrancKareleri[xsa, ysa].ImageIndex = 7;
                                        satrancKareleri[xsa, ysa].Click += şah;
                                        hareket = 1;

                                    }
                                    if (satrancKareleri[xsa, ysa].ImageIndex > 3 && satrancKareleri[xsa, ysa].ImageIndex < 7)
                                    {
                                        satrancKareleri[xsa, ysa].FlatStyle = FlatStyle.Flat;
                                        satrancKareleri[xsa, ysa].FlatAppearance.BorderColor = Color.Red;
                                        satrancKareleri[xsa, ysa].Click += şah;
                                        hareket = 1;
                                    }
                                }

                            }




                            //sol 
                            for (int ileri = 5; ileri < satrancKareleri.GetLength(1); ileri++)
                            {
                                yso = yso - 1;
                                if (yso < 6 && yso > -1)
                                {
                                    if (satrancKareleri[x, yso].ImageIndex > 3 && satrancKareleri[x, yso].ImageIndex < 7)
                                    {
                                        satrancKareleri[x, yso].FlatStyle = FlatStyle.Flat;
                                        satrancKareleri[x, yso].FlatAppearance.BorderColor = Color.Red;

                                    }
                                    if (satrancKareleri[x, yso].ImageIndex != 0)
                                    {
                                        ileri = satrancKareleri.GetLength(1);
                                    }
                                    if (satrancKareleri[x, yso].ImageIndex == 0)
                                    {
                                        satrancKareleri[x, yso].ImageIndex = 7;
                                        satrancKareleri[x, yso].Click += şah;
                                        hareket = 1;

                                    }
                                    if (satrancKareleri[x, yso].ImageIndex > 3 && satrancKareleri[x, yso].ImageIndex < 7)
                                    {
                                        satrancKareleri[x, yso].FlatStyle = FlatStyle.Flat;
                                        satrancKareleri[x, yso].FlatAppearance.BorderColor = Color.Red;
                                        satrancKareleri[x, yso].Click += şah;
                                        hareket = 1;
                                    }
                                }
                            }

                            //geri
                            for (int geri = 5; geri < satrancKareleri.GetLength(0); geri++)
                            {

                                xg = xg + 1;
                                if (xg < 6)
                                {
                                    if (satrancKareleri[xg, y].ImageIndex > 3 && satrancKareleri[xg, y].ImageIndex < 7)
                                    {
                                        satrancKareleri[xg, y].FlatStyle = FlatStyle.Flat;
                                        satrancKareleri[xg, y].FlatAppearance.BorderColor = Color.Red;

                                    }
                                    if (satrancKareleri[xg, y].ImageIndex != 0)
                                    {
                                        geri = satrancKareleri.GetLength(1) + 1;
                                    }
                                    if (satrancKareleri[xg, y].ImageIndex == 0)
                                    {
                                        satrancKareleri[xg, y].ImageIndex = 7;
                                        satrancKareleri[xg, y].Click += şah;
                                        hareket = 1;

                                    }
                                    if (satrancKareleri[xg, y].ImageIndex > 3 && satrancKareleri[xg, y].ImageIndex < 7)
                                    {
                                        satrancKareleri[xg, y].FlatStyle = FlatStyle.Flat;
                                        satrancKareleri[xg, y].FlatAppearance.BorderColor = Color.Red;
                                        satrancKareleri[xg, y].Click += şah;
                                        hareket = 1;
                                    }

                                }

                            }
                            //geri sağ
                            for (int geri = 5; geri < satrancKareleri.GetLength(1); geri++)
                            {
                                xgsa = xgsa + 1;
                                ygsa = ygsa + 1;
                                if (xgsa < 6)
                                {
                                    if (ygsa < 6)
                                    {
                                        if (satrancKareleri[xgsa, ygsa].ImageIndex > 3 && satrancKareleri[xgsa, ygsa].ImageIndex < 7)
                                        {
                                            if(xi<6 && xi>-1)
                                            {
                                                satrancKareleri[xgsa, ygsa].FlatStyle = FlatStyle.Flat;
                                                satrancKareleri[xi, ygsa].FlatAppearance.BorderColor = Color.Red;
                                            }
                                           

                                        }
                                        if (satrancKareleri[xgsa, ygsa].ImageIndex != 0)
                                        {
                                            geri = satrancKareleri.GetLength(1) + 1;
                                        }
                                        if (satrancKareleri[xgsa, ygsa].ImageIndex == 0)
                                        {
                                            satrancKareleri[xgsa, ygsa].ImageIndex = 7;
                                            satrancKareleri[xgsa, ygsa].Click += şah;
                                            hareket = 1;

                                        }
                                        if (satrancKareleri[xgsa, ygsa].ImageIndex > 3 && satrancKareleri[xgsa, ygsa].ImageIndex < 7)
                                        {
                                            satrancKareleri[xgsa, ygsa].FlatStyle = FlatStyle.Flat;
                                            satrancKareleri[xgsa, ygsa].FlatAppearance.BorderColor = Color.Red;
                                            satrancKareleri[xgsa, ygsa].Click += şah;
                                            hareket = 1;
                                        }
                                    }
                                }

                            }
                            //geri sol
                            for (int geri = 5; geri < satrancKareleri.GetLength(1); geri++)
                            {
                                xgso = xgso + 1;
                                ygso = ygso - 1;
                                if (ygso > -1 && ygso < 6 && xgso < 6)
                                {
                                    if (satrancKareleri[xgso, ygso].ImageIndex > 3 && satrancKareleri[xgso, ygso].ImageIndex < 7)
                                    {
                                        satrancKareleri[xgso, ygso].FlatStyle = FlatStyle.Flat;
                                        satrancKareleri[xgso, ygso].FlatAppearance.BorderColor = Color.Red;

                                    }
                                    if (satrancKareleri[xgso, ygso].ImageIndex != 0)
                                    {
                                        geri = satrancKareleri.GetLength(1) + 1;
                                    }
                                    if (satrancKareleri[xgso, ygso].ImageIndex == 0)
                                    {

                                        satrancKareleri[xgso, ygso].ImageIndex = 7;
                                        satrancKareleri[xgso, ygso].Click += şah;
                                        hareket = 1;
                                    }
                                    if (satrancKareleri[xgso, ygso].ImageIndex > 3 && satrancKareleri[xgso, ygso].ImageIndex < 7)
                                    {
                                        satrancKareleri[xgso, ygso].FlatStyle = FlatStyle.Flat;
                                        satrancKareleri[xgso, ygso].FlatAppearance.BorderColor = Color.Red;
                                        satrancKareleri[xgso, ygso].Click += şah;
                                        hareket = 1;
                                    }

                                }

                            }

                        }

                    }
                }
            }
        }       

        private void kale(object sender, EventArgs e)
        {
            Button tiklananKare = sender as Button;
            string kordinat = tiklananKare.Tag.ToString();
            int x = Convert.ToInt32(kordinat.Split(';')[0]);
            //Split dizi oluşturuyordu, 0. eleman:
            int y = Convert.ToInt32(kordinat.Split(';')[1]);
            if (satrancKareleri[adim[0], adim[1]].ImageIndex == 2)
            {

                if (satrancKareleri[x, y].ImageIndex == 7)
                {
                    satrancKareleri[x, y].ImageIndex = 2;
                    satrancKareleri[adim[0], adim[1]].ImageIndex = 0;
                    hareket = 0;
                    reset();
                    timer1.Enabled = true;
                    sıra = 0;
                    hml = hml + 1;
                }
                if (satrancKareleri[x, y].ImageIndex > 3 && satrancKareleri[x, y].ImageIndex < 7)
                {
                    satrancKareleri[x, y].ImageIndex = 2;
                    satrancKareleri[adim[0], adim[1]].ImageIndex = 0;
                    reset();
                    kazanan();
                    hareket = 0;
                    sıra = 0;
                    timer1.Enabled = true;
                    hml = hml + 1;
                }
            }
        }
        private void şah(object sender, EventArgs e)
        {
            Button tiklananKare = sender as Button;
            string kordinat = tiklananKare.Tag.ToString();
            int x = Convert.ToInt32(kordinat.Split(';')[0]);
            //Split dizi oluşturuyordu, 0. eleman:
            int y = Convert.ToInt32(kordinat.Split(';')[1]);
            if (satrancKareleri[adim[0], adim[1]].ImageIndex == 3)
            {

                if (satrancKareleri[x, y].ImageIndex == 7)
                {
                    satrancKareleri[x, y].ImageIndex = 3;
                    satrancKareleri[adim[0], adim[1]].ImageIndex = 0;
                    hareket = 0;
                    reset();
               
                    timer1.Enabled = true;
                    sıra = 0;
                    hml = hml + 1;
               
                }
                if (satrancKareleri[x, y].ImageIndex > 3 && satrancKareleri[x, y].ImageIndex < 7)
                {
                    satrancKareleri[x, y].ImageIndex = 3;
                    satrancKareleri[adim[0], adim[1]].ImageIndex = 0;
                    reset();
                    kazanan();
                    hareket = 0;
                    
                    timer1.Enabled = true;
                    sıra = 0;
                    hml = hml + 1;
                }
            }


        }
        private void piyon(object sender, EventArgs e)
        {
            if (piyonh == 1)
            {


                Button tiklananKare = sender as Button;
                string kordinat = tiklananKare.Tag.ToString();
                int x = Convert.ToInt32(kordinat.Split(';')[0]);
                //Split dizi oluşturuyordu, 0. eleman:
                int y = Convert.ToInt32(kordinat.Split(';')[1]);

                if (satrancKareleri[x, y].ImageIndex == 7)
                {
                    satrancKareleri[x, y].ImageIndex = 1;
                    satrancKareleri[adim[0], adim[1]].ImageIndex = 0;
                    hareket = 0;
                    piyonh = 0;
                    reset();

                    timer1.Enabled = true;
                    sıra = 0;
                    hml = hml + 1;
                }
                if (satrancKareleri[x, y].ImageIndex > 3 && satrancKareleri[x, y].ImageIndex < 7)
                {
                    satrancKareleri[x, y].ImageIndex = 1;
                    satrancKareleri[adim[0], adim[1]].ImageIndex = 0;
                    reset();
                    kazanan();
                    hareket = 0;
                    piyonh = 0;
                    timer1.Enabled = true;
                    sıra = 0;
                    hml = hml + 1;
                }
            }
        }

        public void reset()
        {
            for (int j = 0; j < satrancKareleri.GetLength(0); j++)
            {
                for (int k = 0; k < satrancKareleri.GetLength(1); k++)
                {
                    if (satrancKareleri[j, k].ImageIndex == 7)
                    {
                        satrancKareleri[j, k].ImageIndex = 0;

                    }
                    if (satrancKareleri[j, k].FlatAppearance.BorderColor == Color.Red)
                    {
                        satrancKareleri[j, k].FlatStyle = FlatStyle.Standard;
                    }
                }

            }
        }
        public void kazanan()
        {
            int aş=0;
            int iş=0;
            for (int j = 0; j < satrancKareleri.GetLength(0); j++)
            {
                for (int k = 0; k < satrancKareleri.GetLength(1); k++)
                {
                    if (satrancKareleri[j, k].ImageIndex == 3)
                    {
                        iş = iş + 1;
                       
                       

                    }
                    if (satrancKareleri[j, k].ImageIndex == 6)
                    {

                        aş = aş + 1;
                    }
                }

            }
            if (aş == 0)
            {
                MessageBox.Show("TEBRİKLER KAZANDINIZ");
                this.Close();
            }
            if (iş == 0)
            {
                MessageBox.Show("YAPAY ZEKA KAZANDI");
                this.Close();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if(sıra==0)
            {
                AI(adim[0], adim[1]);
            }
            

        }
    }
}









    





