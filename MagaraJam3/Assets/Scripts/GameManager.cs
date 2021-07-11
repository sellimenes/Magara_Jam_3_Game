using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class GameManager : MonoBehaviour
{
    public EventSistem eventsistem;
    public Eventler eventler;
    public Soru suankisoru;

    public Text Sorutxt, secenek1_txt, secenek2_txt;
    public int cevap;
    public int para;

    public int maxSaglik = 100;
    public int currentsaglik = 50;

    public int maxMutluluk = 100;
    public int currentMutluluk;

    int randomid;
    public List<bool> sorulanlar;

    public WorldConroller worldConroller;


    private void Start()
    {
        worldConroller.Para.text = para.ToString();
        worldConroller.SetMaxSaglik(maxSaglik);
        worldConroller.SetMaxMutluluk(maxMutluluk);
        currentMutluluk = maxMutluluk;
       
        for (int i = 0; i < eventler.Sorular.Count; i++)
        {
            sorulanlar.Add(false);
        }
        SoruEkle();
    }
    public void SoruEkle()
    {
        

        for (int i = 0; i < sorulanlar.Count; i++)
        {
            if (sorulanlar[i] == false)
            {
                
                int sorusayi = Random.Range(0, sorulanlar.Count);
                if (sorulanlar[sorusayi] == false)
                {
                    suankisoru = eventler.Sorular[sorusayi];
                    sorulanlar[sorusayi] = true;
                    Sorutxt.text = eventler.Sorular[sorusayi].soru;
                    secenek1_txt.text = eventler.Sorular[sorusayi].secenek1;
                    secenek2_txt.text = eventler.Sorular[sorusayi].secenek2;
                    cevap = eventler.Sorular[sorusayi].cevap;
                }
                else
                {
                    SoruEkle();
                }

                break;
                
            }
            if (i == sorulanlar.Count - 1)
            {
                Debug.Log("HOPP");
            }
        }
    }
    public void Sorular(int deger)
    {

        if (suankisoru == eventler.Sorular[0])
        {

            if (deger == cevap)
            {
                eventsistem.sonuc = "Onayla";
                DunyaSagl�g�n�Dusur(20);
                MutluluguYukselt(10);
                ParaY�kselt(10000);
            }
            else
            {
                eventsistem.sonuc = "Onaylama";
                DunyaSagl�g�n�Y�kselt(10);
                MutluluguDusur(10);
                ParaDusur(1000);
            }
            StartCoroutine(eventsistem.Soru1Event());
           
        }

        if (suankisoru == eventler.Sorular[1])
        {
            if (deger == cevap)
            {
                eventsistem.sonuc = "�zin Ver";
                DunyaSagl�g�n�Dusur(5);
                MutluluguDusur(3);
                ParaY�kselt(10000);
            }
            else
            {
                eventsistem.sonuc = "�zin Verme";
                MutluluguYukselt(3);
                ParaDusur(1000);

            }
            StartCoroutine(eventsistem.Soru2Event());
            
        }



        if (suankisoru == eventler.Sorular[2])
        {
            if (deger == cevap)
            {
                eventsistem.sonuc = "�nsanlara A��kla";
                MutluluguYukselt(10);
            }
            else
            {
                eventsistem.sonuc = "Gizle";
                MutluluguDusur(10);
            }
            StartCoroutine(eventsistem.Soru3Event());
           
        }
        if (suankisoru == eventler.Sorular[3])
        {
            if (deger == cevap)
            {
                //eventsistem.sonuc = "�zin ver";
                MutluluguYukselt(10);
                DunyaSagl�g�n�Dusur(15);
                ParaY�kselt(20);
            }
            else
            {
                // eventsistem.sonuc = "�zin verme";
                MutluluguDusur(10);
            }
            //StartCoroutine(eventsistem.Soru3Event());
            
        }
        if (suankisoru == eventler.Sorular[4])
        {
            if (deger == cevap)
            {
                //eventsistem.sonuc = "Onayla";
                MutluluguDusur(10);
                DunyaSagl�g�n�Y�kselt(10);
                ParaDusur(10);
            }
            else
            {
                // eventsistem.sonuc = "Onaylama";
                MutluluguYukselt(10);
                DunyaSagl�g�n�Dusur(10);
                ParaY�kselt(10);
            }
            //StartCoroutine(eventsistem.Soru3Event());
            
        }
        if (suankisoru == eventler.Sorular[5])
        {
            if (deger == cevap)
            {
                //eventsistem.sonuc = "Maa�lar� y�kselt";
                MutluluguYukselt(10);
                DunyaSagl�g�n�Y�kselt(10);
                ParaDusur(10);
            }
            else
            {
                // eventsistem.sonuc = "Maa�lar ayn� kals�n";
                MutluluguDusur(10);
                DunyaSagl�g�n�Dusur(10);
                ParaY�kselt(10);
            }
            //StartCoroutine(eventsistem.Soru3Event());
            
        }
        if (suankisoru == eventler.Sorular[6])
        {
            if (deger == cevap)
            {
                //eventsistem.sonuc = "�nekleri uyut";
                MutluluguDusur(10);
                DunyaSagl�g�n�Y�kselt(10);
                ParaDusur(10);
            }
            else
            {
                // eventsistem.sonuc = "Uyutma";
                MutluluguYukselt(10);
                DunyaSagl�g�n�Dusur(10);
            }
            //StartCoroutine(eventsistem.Soru3Event());
            
        }
        if (suankisoru == eventler.Sorular[7])
        {
            if (deger == cevap)
            {
                //eventsistem.sonuc = "Petrol ��kartma";
                MutluluguYukselt(10);
            }
            else
            {
                // eventsistem.sonuc = "Petrol ��kart";
                MutluluguDusur(10);
                DunyaSagl�g�n�Dusur(10);
                ParaY�kselt(10);
            }
            //StartCoroutine(eventsistem.Soru3Event());
            
        }
        if (suankisoru == eventler.Sorular[8])
        {
            if (deger == cevap)
            {
                //eventsistem.sonuc = "Denizleri temizle";
                MutluluguYukselt(10);
                DunyaSagl�g�n�Y�kselt(10);
                ParaDusur(10);
            }
            else
            {
                // eventsistem.sonuc = "Dokunma";
                MutluluguDusur(10);
                DunyaSagl�g�n�Dusur(10);
            }
            //StartCoroutine(eventsistem.Soru3Event());
            
        }
        if (suankisoru == eventler.Sorular[9])
        {
            if (deger == cevap)
            {
                //eventsistem.sonuc = "Fabrika imar�na kar�� ��k";
                MutluluguYukselt(10);
                ParaDusur(15);
            }
            else
            {
                // eventsistem.sonuc = "G�z yum";
                MutluluguDusur(10);
                DunyaSagl�g�n�Dusur(10);
                ParaY�kselt(15);
            }
            //StartCoroutine(eventsistem.Soru3Event());
            
        }
        if (suankisoru == eventler.Sorular[10])
        {
            if (deger == cevap)
            {
                //eventsistem.sonuc = "Kanser a��s� �ip takt�r";
                MutluluguDusur(15);
                DunyaSagl�g�n�Y�kselt(5);
                ParaY�kselt(15);
            }
            else
            {
                // eventsistem.sonuc = "�ip takt�rma";
                MutluluguYukselt(15);
                DunyaSagl�g�n�Dusur(5);
                ParaDusur(5);
            }
            //StartCoroutine(eventsistem.Soru3Event());
            
        }
        if (suankisoru == eventler.Sorular[11])
        {
            if (deger == cevap)
            {
                //eventsistem.sonuc = "BikBok yasakla";
                MutluluguDusur(10);
                DunyaSagl�g�n�Y�kselt(10);
                ParaDusur(10);
            }
            else
            {
                // eventsistem.sonuc = "Yasaklama";
                DunyaSagl�g�n�Dusur(10);
                ParaY�kselt(10);
                MutluluguYukselt(10);
            }
            //StartCoroutine(eventsistem.Soru3Event());
            
        }
        if (suankisoru == eventler.Sorular[12])
        {
            if (deger == cevap)
            {
                //eventsistem.sonuc = "Y�k�c� deprem ma�durlar�na yard�m et";
                DunyaSagl�g�n�Y�kselt(10);
                ParaDusur(20);
                MutluluguYukselt(10);
            }
            else
            {
                // eventsistem.sonuc = "Yard�m etme";
                DunyaSagl�g�n�Dusur(10);
                MutluluguDusur(15);
            }
            //StartCoroutine(eventsistem.Soru3Event());
            
        }
        if (suankisoru == eventler.Sorular[13])
        {
            if (deger == cevap)
            {
                //eventsistem.sonuc = "Kar�� ��k";
                MutluluguYukselt(10);
                DunyaSagl�g�n�Y�kselt(10);
                ParaDusur(10);
            }
            else
            {
                // eventsistem.sonuc = "Ter�r �rg�t�ne silah g�nder";
                DunyaSagl�g�n�Dusur(10);
                ParaY�kselt(20);
                MutluluguDusur(10);
            }
            //StartCoroutine(eventsistem.Soru3Event());
            
        }
        if (suankisoru == eventler.Sorular[14])
        {
            if (deger == cevap)
            {
                //eventsistem.sonuc = "Afrikada suya yard�m et";
                MutluluguYukselt(10);
                DunyaSagl�g�n�Y�kselt(10);
                ParaDusur(10);
            }
            else
            {
                // eventsistem.sonuc = "Yard�m etme";
                DunyaSagl�g�n�Dusur(10);
                MutluluguDusur(10);
            }
            //StartCoroutine(eventsistem.Soru3Event());
            
        }
        if (suankisoru == eventler.Sorular[15])
        {
            if (deger == cevap)
            {
                //eventsistem.sonuc = "Tsunami ma�durlar�na yard�m et";
                MutluluguYukselt(10);
                DunyaSagl�g�n�Y�kselt(10);
                ParaDusur(10);
            }
            else
            {
                // eventsistem.sonuc = "Yard�m etme";
                DunyaSagl�g�n�Dusur(10);
                MutluluguDusur(10);
            }
            //StartCoroutine(eventsistem.Soru3Event());
           
        }
        if (suankisoru == eventler.Sorular[16])
        {
            if (deger == cevap)
            {
                //eventsistem.sonuc = "Yeni konsollara vergi yapma";
                MutluluguYukselt(10);
                ParaDusur(5);
            }
            else
            {
                // eventsistem.sonuc = "Yeni oyun konsollar�n� vergilendir";
                ParaY�kselt(20);
                MutluluguDusur(10);
            }
            //StartCoroutine(eventsistem.Soru3Event());
            
        }
        if (suankisoru == eventler.Sorular[17])
        {
            if (deger == cevap)
            {
                //eventsistem.sonuc = "Gemi ticareti yasaklans�n";
                MutluluguDusur(5);
                DunyaSagl�g�n�Y�kselt(10);
                ParaDusur(20);
            }
            else
            {
                // eventsistem.sonuc = "Yasaklanmas�n";
                DunyaSagl�g�n�Dusur(10);
                ParaY�kselt(10);
                MutluluguYukselt(5);
            }
            //StartCoroutine(eventsistem.Soru3Event());
            
        }
        if (suankisoru == eventler.Sorular[18])
        {
            if (deger == cevap)
            {
                //eventsistem.sonuc = "Rehinleri kurtr";
                MutluluguYukselt(20);
            }
            else
            {
                // eventsistem.sonuc = "O�lunu kurtar";
                MutluluguDusur(20);
            }
            //StartCoroutine(eventsistem.Soru3Event());
            
        }
        if (suankisoru == eventler.Sorular[19])
        {
            if (deger == cevap)
            {
                //eventsistem.sonuc = "Te�ristlere para ver";
                MutluluguYukselt(10);
                ParaDusur(20);
            }
            else
            {
                // eventsistem.sonuc = "Verme";
                MutluluguDusur(20);
            }
            //StartCoroutine(eventsistem.Soru3Event());
           
        }
        if (suankisoru == eventler.Sorular[20])
        {
            if (deger == cevap)
            {
                //eventsistem.sonuc = "Fosil yak�t durdurulsun";
                MutluluguYukselt(10);
                DunyaSagl�g�n�Y�kselt(10);
                ParaDusur(10);
            }
            else
            {
                // eventsistem.sonuc = "Durdurulmas�n";
                DunyaSagl�g�n�Dusur(10);
                ParaY�kselt(10);
                MutluluguDusur(10);
            }
            //StartCoroutine(eventsistem.Soru3Event());
           
        }
        if (suankisoru == eventler.Sorular[21])
        {
            if (deger == cevap)
            {
                //eventsistem.sonuc = "Sigaralar yasaklans�n";
                MutluluguDusur(10);
                DunyaSagl�g�n�Y�kselt(10);
                ParaDusur(10);
            }
            else
            {
                // eventsistem.sonuc = "Yasaklanmas�n";
                DunyaSagl�g�n�Dusur(10);
                ParaY�kselt(10);
                MutluluguYukselt(10);
            }
            //StartCoroutine(eventsistem.Soru3Event());
            
        }
        if (suankisoru == eventler.Sorular[22])
        {
            if (deger == cevap)
            {
                //eventsistem.sonuc = "Baz istasyonlar� kald�r�ls�n";
                DunyaSagl�g�n�Y�kselt(20);
                ParaDusur(10);
            }
            else
            {
                // eventsistem.sonuc = "Kald�r�lmas�n";
                DunyaSagl�g�n�Dusur(10);
                ParaY�kselt(10);
            }
            //StartCoroutine(eventsistem.Soru3Event());
           
        }
        SoruEkle();
    }

    void DunyaSagl�g�n�Dusur(int dusur)
    {
        currentsaglik -= dusur;
        worldConroller.DunyaSagligi(currentsaglik);
    }
    void DunyaSagl�g�n�Y�kselt(int yukselt)
    {
        currentsaglik += yukselt;
    }

    void MutluluguDusur(int dusur)
    {
        currentMutluluk -= dusur;
        worldConroller.Mutluluk(currentMutluluk);
    }
    void MutluluguYukselt(int yukselt)
    {
        currentMutluluk += yukselt;
        worldConroller.Mutluluk(currentMutluluk);
    }

    public void ParaDusur(int dusur)
    {
        para -= dusur;
        worldConroller.Para.text = para.ToString();
    }
    public void ParaY�kselt(int y�kselt)
    {
        para += y�kselt;
        worldConroller.Para.text = para.ToString();
    }
}
