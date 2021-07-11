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
        randomid = Random.Range(0, eventler.Sorular.Count -1);
        suankisoru = eventler.Sorular[randomid];
        for (int i = 0; i < eventler.Sorular.Count; i++)
        {
            sorulanlar.Add(false);
        }
        SoruEkle();
    }
    public void SoruEkle()
    {
        suankisoru = eventler.Sorular[randomid];

        for (int i = 0; i < sorulanlar.Count; i++)
        {
            if (sorulanlar[i] == false)
            {
                
                int sorusayi = Random.Range(0, sorulanlar.Count);
                if (sorulanlar[sorusayi] == false)
                {
                   
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
            SoruEkle();
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
            SoruEkle();
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
            SoruEkle();
        }
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
