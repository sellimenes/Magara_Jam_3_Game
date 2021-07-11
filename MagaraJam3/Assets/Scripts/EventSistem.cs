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

        if (sonuc == "1.1")//eðer arabayý kabul ederse
        {
            Objects1_iyi[0].SetActive(true);//araba objesi aktif olsun   
            sonuc = "";//sonuc tekrar tekrar çalýþmamasý için kapatýldý.
            yield return new WaitForSeconds(0.3f);
            Objects2_kötü[0].SetActive(true);//iyi objelerden rastgele bir tanesi 2.dünyada aktif edildi.

        }
        else if (sonuc == "1.2")//araba almayý reddederse
        {
            Objects1_kötü[1].SetActive(true);//iyi objelerden rastgele bir tanesi bizim dünyamýzda aktif edildi.
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_iyi[0].SetActive(true);//kötü objelerden rastgele bir tanesi 2. dünyada aktif edildi.

        }
    }
    public IEnumerator Soru2Event()
    {

        if (sonuc == "2.1")
        {
            Objects1_kötü[0].SetActive(true);
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_iyi[1].SetActive(true);
        }
        else if (sonuc == "2.2")
        {
            Objects1_iyi[1].SetActive(true);
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_kötü[1].SetActive(true);   
        }
    }


    public IEnumerator Soru3Event()
    {

        if (sonuc == "3.1")
        {
            Objects1_kötü[1].SetActive(true);
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_iyi[0].SetActive(true);

        }
        else if (sonuc == "3.2")
        {
            Objects1_iyi[1].SetActive(true);
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_kötü[0].SetActive(true);
        }
    }

    public IEnumerator Soru4Event()
    {

        if (sonuc == "4.1")
        {
            Objects1_kötü[1].SetActive(true);
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_iyi[0].SetActive(true);

        }
        else if (sonuc == "4.2")
        {
            Objects1_iyi[1].SetActive(true);
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_kötü[0].SetActive(true);
        }
    }
    public IEnumerator Soru5Event()
    {

        if (sonuc == "5.1")
        {
            Objects1_kötü[1].SetActive(true);
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_iyi[0].SetActive(true);

        }
        else if (sonuc == "5.2")
        {
            Objects1_iyi[1].SetActive(true);
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_kötü[0].SetActive(true);
        }
    }
    public IEnumerator Soru6Event()
    {

        if (sonuc == "6.1")
        {
            Objects1_kötü[1].SetActive(true);
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_iyi[0].SetActive(true);

        }
        else if (sonuc == "6.2")
        {
            Objects1_iyi[1].SetActive(true);
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_kötü[0].SetActive(true);
        }
    }
    public IEnumerator Soru7Event()
    {

        if (sonuc == "7.1")
        {
            Objects1_kötü[1].SetActive(true);
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_iyi[0].SetActive(true);

        }
        else if (sonuc == "7.2")
        {
            Objects1_iyi[1].SetActive(true);
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_kötü[0].SetActive(true);
        }     
    }
    
    public IEnumerator Soru8Event()
    {

        if (sonuc == "8.1")
        {
            Objects1_kötü[1].SetActive(true);
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_iyi[0].SetActive(true);

        }
        else if (sonuc == "8.2")
        {
            Objects1_iyi[1].SetActive(true);
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_kötü[0].SetActive(true);
        }
    }
    public IEnumerator Soru9Event()
    {

        if (sonuc == "9.1")
        {
            Objects1_kötü[1].SetActive(true);
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_iyi[0].SetActive(true);

        }
        else if (sonuc == "9.2")
        {
            Objects1_iyi[1].SetActive(true);
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_kötü[0].SetActive(true);
        }
    }
    public IEnumerator Soru10Event()
    {

        if (sonuc == "10.1")
        {
            Objects1_kötü[1].SetActive(true);
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_iyi[0].SetActive(true);

        }
        else if (sonuc == "10.2")
        {
            Objects1_iyi[1].SetActive(true);
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_kötü[0].SetActive(true);
        }
    }
    public IEnumerator Soru11Event()
    {

        if (sonuc == "11.1")
        {
            Objects1_kötü[1].SetActive(true);
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_iyi[0].SetActive(true);

        }
        else if (sonuc == "11.2")
        {
            Objects1_iyi[1].SetActive(true);
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_kötü[0].SetActive(true);
        }
    }
    public IEnumerator Soru12Event()
    {

        if (sonuc == "12.1")
        {
            Objects1_kötü[1].SetActive(true);
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_iyi[0].SetActive(true);

        }
        else if (sonuc == "12.2")
        {
            Objects1_iyi[1].SetActive(true);
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_kötü[0].SetActive(true);
        }
    }
    public IEnumerator Soru13Event()
    {

        if (sonuc == "13.1")
        {
            Objects1_kötü[1].SetActive(true);
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_iyi[0].SetActive(true);

        }
        else if (sonuc == "13.2")
        {
            Objects1_iyi[1].SetActive(true);
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_kötü[0].SetActive(true);
        }
    }
    public IEnumerator Soru14Event()
    {

        if (sonuc == "14.1")
        {
            Objects1_kötü[1].SetActive(true);
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_iyi[0].SetActive(true);

        }
        else if (sonuc == "14.2")
        {
            Objects1_iyi[1].SetActive(true);
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_kötü[0].SetActive(true);
        }
    }
    public IEnumerator Soru15Event()
    {

        if (sonuc == "15.1")
        {
            Objects1_kötü[1].SetActive(true);
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_iyi[0].SetActive(true);

        }
        else if (sonuc == "15.2")
        {
            Objects1_iyi[1].SetActive(true);
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_kötü[0].SetActive(true);
        }
    }
    public IEnumerator Soru16Event()
    {

        if (sonuc == "16.1")
        {
            Objects1_kötü[1].SetActive(true);
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_iyi[0].SetActive(true);

        }
        else if (sonuc == "16.2")
        {
            Objects1_iyi[1].SetActive(true);
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_kötü[0].SetActive(true);
        }
    }
    public IEnumerator Soru17Event()
    {

        if (sonuc == "17.1")
        {
            Objects1_kötü[1].SetActive(true);
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_iyi[0].SetActive(true);

        }
        else if (sonuc == "17.2")
        {
            Objects1_iyi[1].SetActive(true);
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_kötü[0].SetActive(true);
        }
    }
    public IEnumerator Soru18Event()
    {

        if (sonuc == "18.1")
        {
            Objects1_kötü[1].SetActive(true);
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_iyi[0].SetActive(true);

        }
        else if (sonuc == "18.2")
        {
            Objects1_iyi[1].SetActive(true);
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_kötü[0].SetActive(true);
        }
    }
    public IEnumerator Soru19Event()
    {

        if (sonuc == "19.1")
        {
            Objects1_kötü[1].SetActive(true);
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_iyi[0].SetActive(true);

        }
        else if (sonuc == "19.2")
        {
            Objects1_iyi[1].SetActive(true);
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_kötü[0].SetActive(true);
        }
    }
    public IEnumerator Soru20Event()
    {

        if (sonuc == "20.1")
        {
            Objects1_kötü[1].SetActive(true);
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_iyi[0].SetActive(true);

        }
        else if (sonuc == "20.2")
        {
            Objects1_iyi[1].SetActive(true);
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_kötü[0].SetActive(true);
        }
    }
    public IEnumerator Soru21Event()
    {

        if (sonuc == "21.1")
        {
            Objects1_kötü[1].SetActive(true);
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_iyi[0].SetActive(true);

        }
        else if (sonuc == "21.2")
        {
            Objects1_iyi[1].SetActive(true);
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_kötü[0].SetActive(true);
        }
    }
    public IEnumerator Soru22Event()
    {

        if (sonuc == "22.1")
        {
            Objects1_kötü[1].SetActive(true);
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_iyi[0].SetActive(true);

        }
        else if (sonuc == "22.2")
        {
            Objects1_iyi[1].SetActive(true);
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_kötü[0].SetActive(true);
        }
    }
    public IEnumerator Soru23Event()
    {

        if (sonuc == "23.1")
        {
            Objects1_kötü[1].SetActive(true);
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_iyi[0].SetActive(true);

        }
        else if (sonuc == "23.2")
        {
            Objects1_iyi[1].SetActive(true);
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_kötü[0].SetActive(true);
        }
    }
    

}

