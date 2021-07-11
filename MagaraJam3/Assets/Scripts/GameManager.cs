using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public EventSistem eventsistem;
    public Eventler eventler;
    public Soru suankisoru;

    public GameObject eventPanel;

    public Text Sorutxt, secenek1_txt, secenek2_txt;
    public int cevap;
    public int para;

    public int maxSaglik = 100;
    public int currentsaglik;

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

        StartCoroutine(SoruEkle());
    }

    private void Update()
    {

    }



    public IEnumerator SoruEkle()
    {

        yield return new WaitForSeconds(5);
        eventPanel.SetActive(true);
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
                    StartCoroutine(SoruEkle());
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
        eventPanel.SetActive(false);
        //eventsistem.MapDegistir();

        //1.Soru
        if (suankisoru == eventler.Sorular[0])//Özel araçlar küresel ýsýnmayý çok etkiliyor.
                                              //Yalnýzca elektrikli araçlar kullanýlsýn.
        {

            if (deger == cevap)
            {
                eventsistem.sonuc = "1.1";//Onayla
                DunyaSaglýgýnýYükselt(20);
                MutluluguDusur(10);
                ParaYükselt(10000);
            }
            else
            {
                eventsistem.sonuc = "1.2";//Onaylama
                DunyaSaglýgýnýDusur(10);
                MutluluguYukselt(10);
                ParaDusur(1000);
            }
            StartCoroutine(eventsistem.Soru1Event());

        }
        //2.Soru
        if (suankisoru == eventler.Sorular[1])//Amazon Ormanlarý'nýn büyük bir bölümü kesilip
                                              //özel bir tatil köyü yapýlacak.
        {
            if (deger == cevap)
            {
                eventsistem.sonuc = "2.1";//Ýzin Ver
                DunyaSaglýgýnýYükselt(5);
                MutluluguDusur(3);
                ParaYükselt(10000);
            }
            else
            {
                eventsistem.sonuc = "2.2";//Ýzin Verme
                MutluluguYukselt(3);
                ParaDusur(1000);

            }
            StartCoroutine(eventsistem.Soru2Event());

        }


        //3.Soru
        if (suankisoru == eventler.Sorular[2])//Uzaylýlar bulundu.
        {
            if (deger == cevap)
            {
                eventsistem.sonuc = "3.1";//Ýnsanlara Açýkla
                MutluluguYukselt(10);
            }
            else
            {
                eventsistem.sonuc = "3.2";//Gizle
                MutluluguDusur(10);
            }
            StartCoroutine(eventsistem.Soru3Event());

        }

        //4.Soru
        if (suankisoru == eventler.Sorular[3])//Elon Musk tüm dünyaya internet saðlamak için uzaya 12 bin uydu gönderecek. Ýzin verilsin mi?
        {
            if (deger == cevap)
            {
                eventsistem.sonuc = "4.1";
                MutluluguYukselt(10);
                DunyaSaglýgýnýDusur(15);
                ParaYükselt(20);
            }
            else
            {
                eventsistem.sonuc = "4.2";
                MutluluguDusur(10);
            }
            StartCoroutine(eventsistem.Soru4Event());

        }
        if (suankisoru == eventler.Sorular[4])
        {
            if (deger == cevap)
            {
                eventsistem.sonuc = "5.1";
                MutluluguDusur(10);
                DunyaSaglýgýnýYükselt(10);
                ParaDusur(100000);
            }
            else
            {
                eventsistem.sonuc = "5.2";
                MutluluguYukselt(10);
                DunyaSaglýgýnýDusur(10);
                ParaYükselt(10000);
            }
            StartCoroutine(eventsistem.Soru5Event());

        }
        if (suankisoru == eventler.Sorular[5])
        {
            if (deger == cevap)
            {
                eventsistem.sonuc = "6.1";
                MutluluguYukselt(10);
                DunyaSaglýgýnýYükselt(10);
                ParaDusur(10000);
            }
            else
            {
                eventsistem.sonuc = "6.2";
                MutluluguDusur(10);
                DunyaSaglýgýnýDusur(10);
                ParaYükselt(10000);
            }
            StartCoroutine(eventsistem.Soru6Event());

        }
        if (suankisoru == eventler.Sorular[6])
        {
            if (deger == cevap)
            {
                eventsistem.sonuc = "7.1";
                MutluluguYukselt(10);
                DunyaSaglýgýnýDusur(10);

            }
            else
            {
                eventsistem.sonuc = "7.2";
                MutluluguDusur(10);
                DunyaSaglýgýnýYükselt(10);
                ParaYükselt(1000);
            }
            StartCoroutine(eventsistem.Soru7Event());

        }

        if (suankisoru == eventler.Sorular[7])
        {
            if (deger == cevap)
            {
                eventsistem.sonuc = "8.1";
                MutluluguYukselt(10);
            }
            else
            {
                eventsistem.sonuc = "8.2";
                MutluluguDusur(10);
                DunyaSaglýgýnýDusur(10);
                ParaYükselt(1000000);
            }
            StartCoroutine(eventsistem.Soru8Event());

        }
        if (suankisoru == eventler.Sorular[8])
        {
            if (deger == cevap)
            {
                eventsistem.sonuc = "9.1";
                MutluluguYukselt(10);
                DunyaSaglýgýnýYükselt(10);
                ParaDusur(10000);
            }
            else
            {
                eventsistem.sonuc = "9.2";
                MutluluguDusur(10);
                DunyaSaglýgýnýDusur(10);
            }
            StartCoroutine(eventsistem.Soru9Event());

        }
        if (suankisoru == eventler.Sorular[9])
        {
            if (deger == cevap)
            {
                eventsistem.sonuc = "10.1";
                MutluluguDusur(10);
                DunyaSaglýgýnýDusur(10);
                ParaDusur(150000);
            }
            else
            {
                eventsistem.sonuc = "10.2";
                MutluluguYukselt(10);
                ParaDusur(150000);
            }
            StartCoroutine(eventsistem.Soru10Event());

        }
        if (suankisoru == eventler.Sorular[10])
        {
            if (deger == cevap)
            {
                eventsistem.sonuc = "11.1";
                MutluluguDusur(15);
                DunyaSaglýgýnýYükselt(5);
                ParaYükselt(845688);
            }
            else
            {
                eventsistem.sonuc = "11.2";
                MutluluguYukselt(15);
                DunyaSaglýgýnýDusur(5);
                ParaDusur(558776);
            }
            StartCoroutine(eventsistem.Soru11Event());

        }
        if (suankisoru == eventler.Sorular[11])
        {
            if (deger == cevap)
            {
                eventsistem.sonuc = "12.1";
                MutluluguDusur(10);
                DunyaSaglýgýnýYükselt(10);
                ParaDusur(124850);
            }
            else
            {
                eventsistem.sonuc = "12.2";
                DunyaSaglýgýnýDusur(10);
                ParaYükselt(1055677);
                MutluluguYukselt(5);
            }
            StartCoroutine(eventsistem.Soru12Event());

        }
        if (suankisoru == eventler.Sorular[12])
        {
            if (deger == cevap)
            {
                eventsistem.sonuc = "13.1";
                DunyaSaglýgýnýYükselt(10);
                ParaDusur(20648);
                MutluluguYukselt(10);
            }
            else
            {
                eventsistem.sonuc = "13.2";
                DunyaSaglýgýnýDusur(10);
                MutluluguDusur(15);

            }
            StartCoroutine(eventsistem.Soru13Event());

        }
        if (suankisoru == eventler.Sorular[13])
        {
            if (deger == cevap)
            {
                eventsistem.sonuc = "14.1";
                MutluluguDusur(10);
                DunyaSaglýgýnýDusur(10);
                ParaYükselt(10000000);
            }
            else
            {
                eventsistem.sonuc = "14.2";
                DunyaSaglýgýnýYükselt(10);
                ParaDusur(2000025);
                MutluluguYukselt(7);
            }
            StartCoroutine(eventsistem.Soru14Event());

        }
        if (suankisoru == eventler.Sorular[14])//afrika
        {
            if (deger == cevap)
            {
                eventsistem.sonuc = "15.1";
                MutluluguYukselt(10);
                DunyaSaglýgýnýYükselt(10);
                ParaDusur(1054600);
            }
            else
            {
                eventsistem.sonuc = "15.2";
                DunyaSaglýgýnýDusur(10);
                MutluluguDusur(10);
            }
            StartCoroutine(eventsistem.Soru15Event());

        }
        if (suankisoru == eventler.Sorular[15])
        {
            if (deger == cevap)
            {
                eventsistem.sonuc = "16.1";

                DunyaSaglýgýnýDusur(10);
                MutluluguDusur(10);
            }
            else
            {
                eventsistem.sonuc = "16.2";
                MutluluguYukselt(10);
                DunyaSaglýgýnýYükselt(10);
                ParaDusur(1500020);
            }
            StartCoroutine(eventsistem.Soru16Event());

        }
        if (suankisoru == eventler.Sorular[16])
        {
            if (deger == cevap)
            {
                eventsistem.sonuc = "17.1";
                MutluluguYukselt(10);
                ParaDusur(5);
            }
            else
            {
                eventsistem.sonuc = "17.2";
                ParaYükselt(20);
                MutluluguDusur(10);
            }
            StartCoroutine(eventsistem.Soru17Event());

        }
        if (suankisoru == eventler.Sorular[17])
        {
            if (deger == cevap)
            {
                eventsistem.sonuc = "18.1";
                MutluluguDusur(5);
                ParaYükselt(205000);
            }
            else
            {
                eventsistem.sonuc = "18.2";
                MutluluguYukselt(15);
                ParaDusur(1236000);

            }
            StartCoroutine(eventsistem.Soru18Event());

        }
        if (suankisoru == eventler.Sorular[18])
        {
            if (deger == cevap)
            {
                eventsistem.sonuc = "19.1";
                DunyaSaglýgýnýYükselt(10);
                ParaDusur(150020);
            }
            else
            {
                eventsistem.sonuc = "19.2";
                DunyaSaglýgýnýDusur(10);
                ParaYükselt(50002500);
            }
            StartCoroutine(eventsistem.Soru19Event());

        }
        if (suankisoru == eventler.Sorular[19])
        {
            if (deger == cevap)
            {
                eventsistem.sonuc = "20.1";
                MutluluguDusur(20);

            }
            else
            {
                eventsistem.sonuc = "20.2";
                MutluluguYukselt(20);
            }
            StartCoroutine(eventsistem.Soru20Event());

        }
        if (suankisoru == eventler.Sorular[20])
        {
            if (deger == cevap)
            {
                eventsistem.sonuc = "21.1";
                MutluluguYukselt(10);

                ParaDusur(1000050);
            }
            else
            {
                eventsistem.sonuc = "21.2";
                DunyaSaglýgýnýDusur(10);

                MutluluguDusur(10);
            }
            StartCoroutine(eventsistem.Soru21Event());

        }
        if (suankisoru == eventler.Sorular[21])
        {
            if (deger == cevap)
            {
                eventsistem.sonuc = "22.1";
                MutluluguYukselt(10);
                DunyaSaglýgýnýYükselt(10);
                ParaDusur(1002000);
            }
            else
            {
                eventsistem.sonuc = "22.2";
                DunyaSaglýgýnýDusur(10);
                ParaYükselt(100250);
                MutluluguDusur(10);
            }
            StartCoroutine(eventsistem.Soru22Event());

        }
        if (suankisoru == eventler.Sorular[22])
        {
            if (deger == cevap)
            {
                eventsistem.sonuc = "23.1";
                DunyaSaglýgýnýYükselt(20);
                MutluluguDusur(10);
                ParaDusur(100200);
            }
            else
            {
                eventsistem.sonuc = "23.2";
                DunyaSaglýgýnýDusur(10);
                ParaYükselt(100500);
                MutluluguYukselt(15);
            }
            StartCoroutine(eventsistem.Soru23Event());

        }
        /*if (suankisoru == eventler.Sorular[23])
        {
            if (deger == cevap)
            {
                eventsistem.sonuc = "24.1";
                DunyaSaglýgýnýYükselt(20);

                ParaDusur(750000);
            }
            else
            {
                eventsistem.sonuc = "24.2";
                DunyaSaglýgýnýDusur(10);
                ParaYükselt(568000);
            }
            //StartCoroutine(eventsistem.Soru23Event());
        }*/

        StartCoroutine(SoruEkle());
    }

    void DunyaSaglýgýnýDusur(int dusur)
    {
        currentsaglik -= dusur;
        worldConroller.DunyaSagligi(currentsaglik);
    }
    void DunyaSaglýgýnýYükselt(int yukselt)
    {
        currentsaglik += yukselt;
        worldConroller.DunyaSagligi(currentsaglik);
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
    public void GeriCýk()
    {
        SceneManager.LoadScene(0);
    }
}
