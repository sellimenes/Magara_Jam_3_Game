using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EventSistem : MonoBehaviour
{
    //public GameObject[] Worlds;//2 adet dünyamýzý buraya atýyoruz
    public GameObject[] Objects1_iyi;//kendi dünyamýzdaki iyi objeleri buraya atýyoruz.
    public GameObject[] Objects1_kötü;//kendi dünyamýzdaki kötü objeleri buraya atýyoruz
    public GameObject[] Objects2_iyi;//2. dünyadaki iyi objeleri buraya atýyoruz
    public GameObject[] Objects2_kötü;//2.dünyadaki kötü objeleri buraya atýyoruz.


    public GameManager gameManager;

    public string sonuc;
    int randomObjects;
    void Start()
    {
        randomObjects = Random.Range(0, 2);
    }
    public IEnumerator Soru1Event()
    {

        if (sonuc == "Onayla")//eðer arabayý kabul ederse
        {
            Objects1_iyi[0].SetActive(true);//araba objesi aktif olsun   
            sonuc = "";//sonuc tekrar tekrar çalýþmamasý için kapatýldý.
            yield return new WaitForSeconds(0.3f);
            Objects2_kötü[0].SetActive(true);//iyi objelerden rastgele bir tanesi 2.dünyada aktif edildi.

        }
        else if (sonuc == "Onaylama")//araba almayý reddederse
        {
            Objects1_kötü[1].SetActive(true);//iyi objelerden rastgele bir tanesi bizim dünyamýzda aktif edildi.
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_iyi[0].SetActive(true);//kötü objelerden rastgele bir tanesi 2. dünyada aktif edildi.

        }
    }
    public IEnumerator Soru2Event()
    {

        if (sonuc == "Ýzin Ver")//eðer arabayý kabul ederse
        {
            Objects1_kötü[0].SetActive(true);//araba objesi aktif olsun   
            sonuc = "";//sonuc tekrar tekrar çalýþmamasý için kapatýldý.
            yield return new WaitForSeconds(0.3f);
            Objects2_iyi[1].SetActive(true);//iyi objelerden rastgele bir tanesi 2.dünyada aktif edildi.
        }
        else if (sonuc == "Ýzin Verme")//araba almayý reddederse
        {
            Objects1_iyi[1].SetActive(true);//iyi objelerden rastgele bir tanesi bizim dünyamýzda aktif edildi.
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_kötü[1].SetActive(true);//kötü objelerden rastgele bir tanesi 2. dünyada aktif edildi.    
        }
    }


    public IEnumerator Soru3Event()
    {

        if (sonuc == "Ýnsanlara Açýkla")//eðer arabayý kabul ederse
        {
            Objects1_kötü[1].SetActive(true);//araba objesi aktif olsun   
            sonuc = "";//sonuc tekrar tekrar çalýþmamasý için kapatýldý.
            yield return new WaitForSeconds(0.3f);
            Objects2_iyi[0].SetActive(true);//iyi objelerden rastgele bir tanesi 2.dünyada aktif edildi.

        }
        else if (sonuc == "Gizle")//araba almayý reddederse
        {
            Objects1_iyi[1].SetActive(true);//iyi objelerden rastgele bir tanesi bizim dünyamýzda aktif edildi.
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_kötü[0].SetActive(true);//kötü objelerden rastgele bir tanesi 2. dünyada aktif edildi.

        }
    }
}

