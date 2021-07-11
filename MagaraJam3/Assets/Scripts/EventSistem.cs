using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EventSistem : MonoBehaviour
{
    //public GameObject[] Worlds;//2 adet d�nyam�z� buraya at�yoruz
    public GameObject[] Objects1_iyi;//kendi d�nyam�zdaki iyi objeleri buraya at�yoruz.
    public GameObject[] Objects1_k�t�;//kendi d�nyam�zdaki k�t� objeleri buraya at�yoruz
    public GameObject[] Objects2_iyi;//2. d�nyadaki iyi objeleri buraya at�yoruz
    public GameObject[] Objects2_k�t�;//2.d�nyadaki k�t� objeleri buraya at�yoruz.


    public GameManager gameManager;

    public string sonuc;
    int randomObjects;
    void Start()
    {
        randomObjects = Random.Range(0, 2);
    }
    public IEnumerator Soru1Event()
    {

        if (sonuc == "Onayla")//e�er arabay� kabul ederse
        {
            Objects1_iyi[0].SetActive(true);//araba objesi aktif olsun   
            sonuc = "";//sonuc tekrar tekrar �al��mamas� i�in kapat�ld�.
            yield return new WaitForSeconds(0.3f);
            Objects2_k�t�[0].SetActive(true);//iyi objelerden rastgele bir tanesi 2.d�nyada aktif edildi.

        }
        else if (sonuc == "Onaylama")//araba almay� reddederse
        {
            Objects1_k�t�[1].SetActive(true);//iyi objelerden rastgele bir tanesi bizim d�nyam�zda aktif edildi.
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_iyi[0].SetActive(true);//k�t� objelerden rastgele bir tanesi 2. d�nyada aktif edildi.

        }
    }
    public IEnumerator Soru2Event()
    {

        if (sonuc == "�zin Ver")//e�er arabay� kabul ederse
        {
            Objects1_k�t�[0].SetActive(true);//araba objesi aktif olsun   
            sonuc = "";//sonuc tekrar tekrar �al��mamas� i�in kapat�ld�.
            yield return new WaitForSeconds(0.3f);
            Objects2_iyi[1].SetActive(true);//iyi objelerden rastgele bir tanesi 2.d�nyada aktif edildi.
        }
        else if (sonuc == "�zin Verme")//araba almay� reddederse
        {
            Objects1_iyi[1].SetActive(true);//iyi objelerden rastgele bir tanesi bizim d�nyam�zda aktif edildi.
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_k�t�[1].SetActive(true);//k�t� objelerden rastgele bir tanesi 2. d�nyada aktif edildi.    
        }
    }


    public IEnumerator Soru3Event()
    {

        if (sonuc == "�nsanlara A��kla")//e�er arabay� kabul ederse
        {
            Objects1_k�t�[1].SetActive(true);//araba objesi aktif olsun   
            sonuc = "";//sonuc tekrar tekrar �al��mamas� i�in kapat�ld�.
            yield return new WaitForSeconds(0.3f);
            Objects2_iyi[0].SetActive(true);//iyi objelerden rastgele bir tanesi 2.d�nyada aktif edildi.

        }
        else if (sonuc == "Gizle")//araba almay� reddederse
        {
            Objects1_iyi[1].SetActive(true);//iyi objelerden rastgele bir tanesi bizim d�nyam�zda aktif edildi.
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_k�t�[0].SetActive(true);//k�t� objelerden rastgele bir tanesi 2. d�nyada aktif edildi.

        }
    }
}

