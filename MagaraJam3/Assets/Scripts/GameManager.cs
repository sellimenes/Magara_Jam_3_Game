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
                DunyaSaglýgýnýDusur(20);
                MutluluguYukselt(10);
                ParaYükselt(10000);
            }
            else
            {
                eventsistem.sonuc = "Onaylama";
                DunyaSaglýgýnýYükselt(10);
                MutluluguDusur(10);
                ParaDusur(1000);
            }
            StartCoroutine(eventsistem.Soru1Event());
           
        }

        if (suankisoru == eventler.Sorular[1])
        {
            if (deger == cevap)
            {
                eventsistem.sonuc = "Ýzin Ver";
                DunyaSaglýgýnýDusur(5);
                MutluluguDusur(3);
                ParaYükselt(10000);
            }
            else
            {
                eventsistem.sonuc = "Ýzin Verme";
                MutluluguYukselt(3);
                ParaDusur(1000);

            }
            StartCoroutine(eventsistem.Soru2Event());
            
        }



        if (suankisoru == eventler.Sorular[2])
        {
            if (deger == cevap)
            {
                eventsistem.sonuc = "Ýnsanlara Açýkla";
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
                //eventsistem.sonuc = "Ýzin ver";
                MutluluguYukselt(10);
                DunyaSaglýgýnýDusur(15);
                ParaYükselt(20);
            }
            else
            {
                // eventsistem.sonuc = "Ýzin verme";
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
                DunyaSaglýgýnýYükselt(10);
                ParaDusur(10);
            }
            else
            {
                // eventsistem.sonuc = "Onaylama";
                MutluluguYukselt(10);
                DunyaSaglýgýnýDusur(10);
                ParaYükselt(10);
            }
            //StartCoroutine(eventsistem.Soru3Event());
            
        }
        if (suankisoru == eventler.Sorular[5])
        {
            if (deger == cevap)
            {
                //eventsistem.sonuc = "Maaþlarý yükselt";
                MutluluguYukselt(10);
                DunyaSaglýgýnýYükselt(10);
                ParaDusur(10);
            }
            else
            {
                // eventsistem.sonuc = "Maaþlar ayný kalsýn";
                MutluluguDusur(10);
                DunyaSaglýgýnýDusur(10);
                ParaYükselt(10);
            }
            //StartCoroutine(eventsistem.Soru3Event());
            
        }
        if (suankisoru == eventler.Sorular[6])
        {
            if (deger == cevap)
            {
                //eventsistem.sonuc = "Ýnekleri uyut";
                MutluluguDusur(10);
                DunyaSaglýgýnýYükselt(10);
                ParaDusur(10);
            }
            else
            {
                // eventsistem.sonuc = "Uyutma";
                MutluluguYukselt(10);
                DunyaSaglýgýnýDusur(10);
            }
            //StartCoroutine(eventsistem.Soru3Event());
            
        }
        if (suankisoru == eventler.Sorular[7])
        {
            if (deger == cevap)
            {
                //eventsistem.sonuc = "Petrol çýkartma";
                MutluluguYukselt(10);
            }
            else
            {
                // eventsistem.sonuc = "Petrol çýkart";
                MutluluguDusur(10);
                DunyaSaglýgýnýDusur(10);
                ParaYükselt(10);
            }
            //StartCoroutine(eventsistem.Soru3Event());
            
        }
        if (suankisoru == eventler.Sorular[8])
        {
            if (deger == cevap)
            {
                //eventsistem.sonuc = "Denizleri temizle";
                MutluluguYukselt(10);
                DunyaSaglýgýnýYükselt(10);
                ParaDusur(10);
            }
            else
            {
                // eventsistem.sonuc = "Dokunma";
                MutluluguDusur(10);
                DunyaSaglýgýnýDusur(10);
            }
            //StartCoroutine(eventsistem.Soru3Event());
            
        }
        if (suankisoru == eventler.Sorular[9])
        {
            if (deger == cevap)
            {
                //eventsistem.sonuc = "Fabrika imarýna karþý çýk";
                MutluluguYukselt(10);
                ParaDusur(15);
            }
            else
            {
                // eventsistem.sonuc = "Göz yum";
                MutluluguDusur(10);
                DunyaSaglýgýnýDusur(10);
                ParaYükselt(15);
            }
            //StartCoroutine(eventsistem.Soru3Event());
            
        }
        if (suankisoru == eventler.Sorular[10])
        {
            if (deger == cevap)
            {
                //eventsistem.sonuc = "Kanser aþýsý çip taktýr";
                MutluluguDusur(15);
                DunyaSaglýgýnýYükselt(5);
                ParaYükselt(15);
            }
            else
            {
                // eventsistem.sonuc = "Çip taktýrma";
                MutluluguYukselt(15);
                DunyaSaglýgýnýDusur(5);
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
                DunyaSaglýgýnýYükselt(10);
                ParaDusur(10);
            }
            else
            {
                // eventsistem.sonuc = "Yasaklama";
                DunyaSaglýgýnýDusur(10);
                ParaYükselt(10);
                MutluluguYukselt(10);
            }
            //StartCoroutine(eventsistem.Soru3Event());
            
        }
        if (suankisoru == eventler.Sorular[12])
        {
            if (deger == cevap)
            {
                //eventsistem.sonuc = "Yýkýcý deprem maðdurlarýna yardým et";
                DunyaSaglýgýnýYükselt(10);
                ParaDusur(20);
                MutluluguYukselt(10);
            }
            else
            {
                // eventsistem.sonuc = "Yardým etme";
                DunyaSaglýgýnýDusur(10);
                MutluluguDusur(15);
            }
            //StartCoroutine(eventsistem.Soru3Event());
            
        }
        if (suankisoru == eventler.Sorular[13])
        {
            if (deger == cevap)
            {
                //eventsistem.sonuc = "Karþý çýk";
                MutluluguYukselt(10);
                DunyaSaglýgýnýYükselt(10);
                ParaDusur(10);
            }
            else
            {
                // eventsistem.sonuc = "Terör örgütüne silah gönder";
                DunyaSaglýgýnýDusur(10);
                ParaYükselt(20);
                MutluluguDusur(10);
            }
            //StartCoroutine(eventsistem.Soru3Event());
            
        }
        if (suankisoru == eventler.Sorular[14])
        {
            if (deger == cevap)
            {
                //eventsistem.sonuc = "Afrikada suya yardým et";
                MutluluguYukselt(10);
                DunyaSaglýgýnýYükselt(10);
                ParaDusur(10);
            }
            else
            {
                // eventsistem.sonuc = "Yardým etme";
                DunyaSaglýgýnýDusur(10);
                MutluluguDusur(10);
            }
            //StartCoroutine(eventsistem.Soru3Event());
            
        }
        if (suankisoru == eventler.Sorular[15])
        {
            if (deger == cevap)
            {
                //eventsistem.sonuc = "Tsunami maðdurlarýna yardým et";
                MutluluguYukselt(10);
                DunyaSaglýgýnýYükselt(10);
                ParaDusur(10);
            }
            else
            {
                // eventsistem.sonuc = "Yardým etme";
                DunyaSaglýgýnýDusur(10);
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
                // eventsistem.sonuc = "Yeni oyun konsollarýný vergilendir";
                ParaYükselt(20);
                MutluluguDusur(10);
            }
            //StartCoroutine(eventsistem.Soru3Event());
            
        }
        if (suankisoru == eventler.Sorular[17])
        {
            if (deger == cevap)
            {
                //eventsistem.sonuc = "Gemi ticareti yasaklansýn";
                MutluluguDusur(5);
                DunyaSaglýgýnýYükselt(10);
                ParaDusur(20);
            }
            else
            {
                // eventsistem.sonuc = "Yasaklanmasýn";
                DunyaSaglýgýnýDusur(10);
                ParaYükselt(10);
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
                // eventsistem.sonuc = "Oðlunu kurtar";
                MutluluguDusur(20);
            }
            //StartCoroutine(eventsistem.Soru3Event());
            
        }
        if (suankisoru == eventler.Sorular[19])
        {
            if (deger == cevap)
            {
                //eventsistem.sonuc = "Teöristlere para ver";
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
                //eventsistem.sonuc = "Fosil yakýt durdurulsun";
                MutluluguYukselt(10);
                DunyaSaglýgýnýYükselt(10);
                ParaDusur(10);
            }
            else
            {
                // eventsistem.sonuc = "Durdurulmasýn";
                DunyaSaglýgýnýDusur(10);
                ParaYükselt(10);
                MutluluguDusur(10);
            }
            //StartCoroutine(eventsistem.Soru3Event());
           
        }
        if (suankisoru == eventler.Sorular[21])
        {
            if (deger == cevap)
            {
                //eventsistem.sonuc = "Sigaralar yasaklansýn";
                MutluluguDusur(10);
                DunyaSaglýgýnýYükselt(10);
                ParaDusur(10);
            }
            else
            {
                // eventsistem.sonuc = "Yasaklanmasýn";
                DunyaSaglýgýnýDusur(10);
                ParaYükselt(10);
                MutluluguYukselt(10);
            }
            //StartCoroutine(eventsistem.Soru3Event());
            
        }
        if (suankisoru == eventler.Sorular[22])
        {
            if (deger == cevap)
            {
                //eventsistem.sonuc = "Baz istasyonlarý kaldýrýlsýn";
                DunyaSaglýgýnýYükselt(20);
                ParaDusur(10);
            }
            else
            {
                // eventsistem.sonuc = "Kaldýrýlmasýn";
                DunyaSaglýgýnýDusur(10);
                ParaYükselt(10);
            }
            //StartCoroutine(eventsistem.Soru3Event());
           
        }
        SoruEkle();
    }

    void DunyaSaglýgýnýDusur(int dusur)
    {
        currentsaglik -= dusur;
        worldConroller.DunyaSagligi(currentsaglik);
    }
    void DunyaSaglýgýnýYükselt(int yukselt)
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
    public void ParaYükselt(int yükselt)
    {
        para += yükselt;
        worldConroller.Para.text = para.ToString();
    }
}
