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

    float time;
    private void Start()
    {
        currentsaglik = maxSaglik;
        currentMutluluk = maxMutluluk;
        worldConroller.SetMaxSaglik(maxSaglik);
        time = 0.3f * Time.deltaTime;
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
        
        OyunuBitir();
    }



    public IEnumerator SoruEkle()
    {

        yield return new WaitForSeconds(time);
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
                DunyaSaglýgýKontrol(5);
                MutlulukKontrol(-20);
                ParaKontrol(10000);
            }
            else
            {
                eventsistem.sonuc = "1.2";//Onaylama
                DunyaSaglýgýKontrol(-35);
                MutlulukKontrol(7);
                ParaKontrol(-1000);
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
                DunyaSaglýgýKontrol(-5);
                MutlulukKontrol(-3);
                ParaKontrol(10000);
            }
            else
            {
                eventsistem.sonuc = "2.2";//Ýzin Verme
                MutlulukKontrol(3);
                ParaKontrol(-10000);

            }
            StartCoroutine(eventsistem.Soru2Event());

        }


        //3.Soru
        if (suankisoru == eventler.Sorular[2])//Uzaylýlar bulundu.
        {
            if (deger == cevap)
            {
                eventsistem.sonuc = "3.1";//Ýnsanlara Açýkla
                MutlulukKontrol(10);
            }
            else
            {
                eventsistem.sonuc = "3.2";//Gizle
                MutlulukKontrol(-10);
            }
            StartCoroutine(eventsistem.Soru3Event());

        }

        //4.Soru
        if (suankisoru == eventler.Sorular[3])//Elon Musk tüm dünyaya internet saðlamak için uzaya 12 bin uydu gönderecek. Ýzin verilsin mi?
        {
            if (deger == cevap)
            {
                eventsistem.sonuc = "4.1";
                MutlulukKontrol(10);
                DunyaSaglýgýKontrol(-15);
                ParaKontrol(20000);
            }
            else
            {
                eventsistem.sonuc = "4.2";
                MutlulukKontrol(-10);
            }
            StartCoroutine(eventsistem.Soru4Event());

        }
        if (suankisoru == eventler.Sorular[4])
        {
            if (deger == cevap)
            {
                eventsistem.sonuc = "5.1";
                MutlulukKontrol(-15);
                DunyaSaglýgýKontrol(10);
                ParaKontrol(-100000);
            }
            else
            {
                eventsistem.sonuc = "5.2";
                MutlulukKontrol(10);
                DunyaSaglýgýKontrol(-25);
                ParaKontrol(10000);
            }
            StartCoroutine(eventsistem.Soru5Event());

        }
        if (suankisoru == eventler.Sorular[5])
        {
            if (deger == cevap)
            {
                eventsistem.sonuc = "6.1";
                MutlulukKontrol(5);
                DunyaSaglýgýKontrol(10);
                ParaKontrol(-10000);
            }
            else
            {
                eventsistem.sonuc = "6.2";
                MutlulukKontrol(-15);
                DunyaSaglýgýKontrol(-15);
                ParaKontrol(10000);
            }
            StartCoroutine(eventsistem.Soru6Event());

        }
        if (suankisoru == eventler.Sorular[6])
        {
            if (deger == cevap)
            {
                eventsistem.sonuc = "7.1";
                MutlulukKontrol(10);
                DunyaSaglýgýKontrol(-10);

            }
            else
            {
                eventsistem.sonuc = "7.2";
                MutlulukKontrol(-22);
                DunyaSaglýgýKontrol(6);
                ParaKontrol(-10000);
            }
            StartCoroutine(eventsistem.Soru7Event());

        }

        if (suankisoru == eventler.Sorular[7])
        {
            if (deger == cevap)
            {
                eventsistem.sonuc = "8.1";
                MutlulukKontrol(10);
            }
            else
            {
                eventsistem.sonuc = "8.2";
                MutlulukKontrol(-10);
                DunyaSaglýgýKontrol(-21);
                ParaKontrol(10000);
            }
            StartCoroutine(eventsistem.Soru8Event());

        }
        if (suankisoru == eventler.Sorular[8])
        {
            if (deger == cevap)
            {
                eventsistem.sonuc = "9.1";
                MutlulukKontrol(8);
                DunyaSaglýgýKontrol(10);
                ParaKontrol(-100000);
            }
            else
            {
                eventsistem.sonuc = "9.2";
                MutlulukKontrol(-20);
                DunyaSaglýgýKontrol(-16);
            }
            StartCoroutine(eventsistem.Soru9Event());

        }
        if (suankisoru == eventler.Sorular[9])
        {
            if (deger == cevap)
            {
                eventsistem.sonuc = "10.1";
                MutlulukKontrol(-10);
                DunyaSaglýgýKontrol(-10);
                ParaKontrol(150000);
            }
            else
            {
                eventsistem.sonuc = "10.2";
                MutlulukKontrol(10);
                ParaKontrol(-150000);
            }
            StartCoroutine(eventsistem.Soru10Event());

        }
        if (suankisoru == eventler.Sorular[10])
        {
            if (deger == cevap)
            {
                eventsistem.sonuc = "11.1";
                MutlulukKontrol(-15);
                DunyaSaglýgýKontrol(5);
                ParaKontrol(10688);
            }
            else
            {
                eventsistem.sonuc = "11.2";
                MutlulukKontrol(15);
                DunyaSaglýgýKontrol(-5);
                ParaKontrol(-105776);
            }
            StartCoroutine(eventsistem.Soru11Event());

        }
        if (suankisoru == eventler.Sorular[11])
        {
            if (deger == cevap)
            {
                eventsistem.sonuc = "12.1";
                MutlulukKontrol(-10);
                DunyaSaglýgýKontrol(10);
                ParaKontrol(-124850);
            }
            else
            {
                eventsistem.sonuc = "12.2";
                DunyaSaglýgýKontrol(-10);
                ParaKontrol(105677);
                MutlulukKontrol(5);
            }
            StartCoroutine(eventsistem.Soru12Event());

        }
        if (suankisoru == eventler.Sorular[12])
        {
            if (deger == cevap)
            {
                eventsistem.sonuc = "13.1";
                DunyaSaglýgýKontrol(-10);                
                MutlulukKontrol(-10);
            }
            else
            {
                eventsistem.sonuc = "13.2";
                DunyaSaglýgýKontrol(10);
                MutlulukKontrol(15);
                ParaKontrol(-100500);
            }
            StartCoroutine(eventsistem.Soru13Event());
        }
        if (suankisoru == eventler.Sorular[13])
        {
            if (deger == cevap)
            {
                eventsistem.sonuc = "14.1";
                MutlulukKontrol(-28);
                DunyaSaglýgýKontrol(-10);
                ParaKontrol(100000);
            }
            else
            {
                eventsistem.sonuc = "14.2";
                DunyaSaglýgýKontrol(10);
                ParaKontrol(-200000);
                MutlulukKontrol(7);
            }
            StartCoroutine(eventsistem.Soru14Event());

        }
        if (suankisoru == eventler.Sorular[14])//afrika
        {
            if (deger == cevap)
            {
                eventsistem.sonuc = "15.1";
                MutlulukKontrol(10);
                DunyaSaglýgýKontrol(10);
                ParaKontrol(-104600);
            }
            else
            {
                eventsistem.sonuc = "15.2";
                DunyaSaglýgýKontrol(-10);
                MutlulukKontrol(-10);
            }
            StartCoroutine(eventsistem.Soru15Event());

        }
        if (suankisoru == eventler.Sorular[15])
        {
            if (deger == cevap)
            {
                eventsistem.sonuc = "16.1";

                DunyaSaglýgýKontrol(-10);
                MutlulukKontrol(-10);
            }
            else
            {
                eventsistem.sonuc = "16.2";
                MutlulukKontrol(10);
                DunyaSaglýgýKontrol(10);
                ParaKontrol(-150020);
            }
            StartCoroutine(eventsistem.Soru16Event());

        }
        if (suankisoru == eventler.Sorular[16])
        {
            if (deger == cevap)
            {
                eventsistem.sonuc = "17.1";
                MutlulukKontrol(-25);
                ParaKontrol(50000);
            }
            else
            {
                eventsistem.sonuc = "17.2";
                ParaKontrol(-20000);
                MutlulukKontrol(10);
            }
            StartCoroutine(eventsistem.Soru17Event());

        }
        if (suankisoru == eventler.Sorular[17])
        {
            if (deger == cevap)
            {
                eventsistem.sonuc = "18.1";
                DunyaSaglýgýKontrol(5);
                
                ParaKontrol(-205000);
            }
            else
            {
                eventsistem.sonuc = "18.2";
                DunyaSaglýgýKontrol(5);
                ParaKontrol(123000);

            }
            StartCoroutine(eventsistem.Soru18Event());

        }
        if (suankisoru == eventler.Sorular[18])
        {
            if (deger == cevap)
            {
                eventsistem.sonuc = "19.1";

                DunyaSaglýgýKontrol(-10);
            }
            else
            {
                eventsistem.sonuc = "19.2";
                DunyaSaglýgýKontrol(-10);
                
            }
            StartCoroutine(eventsistem.Soru19Event());

        }
        if (suankisoru == eventler.Sorular[19])
        {
            if (deger == cevap)
            {
                eventsistem.sonuc = "20.1";
                MutlulukKontrol(-20);
                ParaKontrol(-350000);

            }
            else
            {
                eventsistem.sonuc = "20.2";
                DunyaSaglýgýKontrol(-20);
                MutlulukKontrol(-20);
                ParaKontrol(200000);
            }
            StartCoroutine(eventsistem.Soru20Event());

        }
        if (suankisoru == eventler.Sorular[20])
        {
            if (deger == cevap)
            {
                eventsistem.sonuc = "21.1";
                MutlulukKontrol(10);
                DunyaSaglýgýKontrol(10);
                ParaKontrol(-100050);
            }
            else
            {
                eventsistem.sonuc = "21.2";
                DunyaSaglýgýKontrol(-19);
                ParaKontrol(100050);
                MutlulukKontrol(-15);
            }
            StartCoroutine(eventsistem.Soru21Event());

        }
        if (suankisoru == eventler.Sorular[21])
        {
            if (deger == cevap)
            {
                eventsistem.sonuc = "22.1";
                MutlulukKontrol(-20);
                DunyaSaglýgýKontrol(10);
                ParaKontrol(-102000);
            }
            else
            {
                eventsistem.sonuc = "22.2";
                DunyaSaglýgýKontrol(-23);
                ParaKontrol(100250);
                MutlulukKontrol(24);
            }
            StartCoroutine(eventsistem.Soru22Event());

        }
        if (suankisoru == eventler.Sorular[22])
        {
            if (deger == cevap)
            {
                eventsistem.sonuc = "23.1";
                DunyaSaglýgýKontrol(20);
                
                ParaKontrol(-100200);
            }
            else
            {
                eventsistem.sonuc = "23.2";
                DunyaSaglýgýKontrol(-14);
                ParaKontrol(100500);
                
            }
            StartCoroutine(eventsistem.Soru23Event());

        }
        

        StartCoroutine(SoruEkle());
    }

   
    public void DunyaSaglýgýKontrol(int saglik)
    {
        currentsaglik += saglik;
        worldConroller.DunyaSagligi(currentsaglik);
        if (currentsaglik >= 100)
        {
            currentsaglik = 100;
        }
    }


    public void MutlulukKontrol(int mutluluk)
    {
        currentMutluluk += mutluluk;
       worldConroller.Mutluluk(currentMutluluk);
        if (currentMutluluk >= 100)
        {
            currentMutluluk = 100;
        }
    }
   
    public void ParaKontrol(int para)
    {
        para += para;
        worldConroller.Para.text = para.ToString();
    }
    public void GeriCýk()
    {
        SceneManager.LoadScene(0);
    }

    public void OyunuBitir()
    {
        if (currentMutluluk <= 0||para<=-500000||currentsaglik<=0)
        {
            SceneManager.LoadScene(3);
        }
    }

}
