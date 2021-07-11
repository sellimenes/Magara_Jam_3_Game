using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class GameManager : MonoBehaviour
{
    //public EventSistem eventsistem;
    public Eventler eventler;
    public Soru suankisoru;
    int sorunumarasý;

    public GameObject[] Objects1_iyi;//kendi dünyamýzdaki iyi objeleri buraya atýyoruz.
    public GameObject[] Objects1_kötü;//kendi dünyamýzdaki kötü objeleri buraya atýyoruz
    public GameObject[] Objects2_iyi;//2. dünyadaki iyi objeleri buraya atýyoruz
    public GameObject[] Objects2_kötü;//2.dünyadaki kötü objeleri buraya atýyoruz.

    public Text Sorutxt, secenek1_txt, secenek2_txt;
    public string cevap;

    public int para;

    public int maxSaglik = 100;
    public int currentsaglik = 50;

    public int maxMutluluk = 100;
    public int currentMutluluk;

    public List<bool> sorulanlar;

    public WorldConroller worldConroller;
    string secenek;
    public int randomid;

    private void Start()
    {
        worldConroller.Para.text = para.ToString();
        worldConroller.SetMaxSaglik(maxSaglik);
        worldConroller.SetMaxMutluluk(maxMutluluk);
        currentMutluluk = maxMutluluk;
        Sorutxt.text = eventler.Sorular[0].soru;
        
        for (int i = 0; i < eventler.Sorular.Count; i++)
        {
            sorulanlar.Add(false);
        }
        //SoruVer();
    }

    private void Update()
    {
        
    }
    public void EventSorular(string secenekler)
    {
        secenekler = suankisoru.cevap;
        if (suankisoru == eventler.Sorular[0])
        {
            Soru1();
        }else if(suankisoru == eventler.Sorular[1])
        {
            Soru2();
        }else if(suankisoru == eventler.Sorular[2])
        {
            Soru3();
        }
            
    }



    public void SoruVer()
    {

        for (int i = 0; i < sorulanlar.Count; i++)
        {
            if (sorulanlar[i] == false)
            {
               
                randomid = Random.Range(0, eventler.Sorular.Count);
                suankisoru = eventler.Sorular[randomid];

                if (sorulanlar[randomid] == false)
                {
                    sorulanlar[randomid] = true;
                    Sorutxt.text = eventler.Sorular[randomid].soru;
                    secenek1_txt.text = eventler.Sorular[randomid].secenek1;
                    secenek2_txt.text = eventler.Sorular[randomid].secenek2;
                    cevap = eventler.Sorular[randomid].cevap;
                }
                else
                {
                    SoruVer();
                    
                }
                break;

            }
            if (i == sorulanlar.Count - 1)
            {
                Debug.Log("Oyun Bitti");
            }
        }
    }

    public void Soru1()
    {
        

            if (secenek == suankisoru.cevap)
            {
                //eventsistem.sonuc = "Onayla";
                DunyaSaglýgýnýDusur(20);
                MutluluguYukselt(10);
                ParaYükselt(10000);
                sorulanlar[0] = true;
                SoruVer();

            }
            else
            {
                //eventsistem.sonuc = "Onaylama";
                DunyaSaglýgýnýYükselt(10);
                MutluluguDusur(10);
                ParaDusur(1000);
                sorulanlar[0] = true;
                SoruVer();

            }
            //StartCoroutine(eventsistem.Soru1Event());

    }      
        public void Soru2() 
        {
            

                if (secenek == suankisoru.cevap)
                {
                    //eventsistem.sonuc = "Ýzin Ver";
                    DunyaSaglýgýnýDusur(5);
                    MutluluguDusur(3);
                    ParaYükselt(10000);
                    sorulanlar[1] = true;
                    SoruVer();

                }
                else
                {
                    //eventsistem.sonuc = "Ýzin Verme";
                    MutluluguYukselt(3);
                    ParaDusur(1000);
                    sorulanlar[1] = true;
                    SoruVer();
                }
                //StartCoroutine(eventsistem.Soru2Event());
             
        }
    public void Soru3()
    {
       

            if (secenek == suankisoru.cevap)
            {
                //eventsistem.sonuc = "Ýnsanlara Açýkla";
                MutluluguYukselt(10);
                sorulanlar[2] = true;
                SoruVer();

            }
            else
            {
                //eventsistem.sonuc = "Gizle";
                MutluluguDusur(10);
                sorulanlar[2] = true;
                SoruVer();
            }
            //StartCoroutine(eventsistem.Soru3Event());

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

