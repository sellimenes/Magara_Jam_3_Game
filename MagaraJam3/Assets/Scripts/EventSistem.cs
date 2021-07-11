using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EventSistem : MonoBehaviour
{
    public GameObject[] Worlds1;
    public GameObject[] Worlds2;
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

   /* public void MapDegistir()
    {
        if (gameManager.currentsaglik <= 75)
        {
            Worlds1[0].SetActive(false);
            Worlds1[1].SetActive(true);
        }
        else if (gameManager.currentsaglik <= 50)
        {
            Worlds1[1].SetActive(false);
            Worlds1[2].SetActive(true);
        }else if (gameManager.currentsaglik <= 25)
        {
            Worlds1[2].SetActive(false);
            Worlds1[3].SetActive(true);
        }
    }*/

    public IEnumerator Soru1Event()
    {

        if (sonuc == "1.1")//e�er arabay� kabul ederse
        {
            Objects1_iyi[10].SetActive(true);//araba objesi aktif olsun   
            sonuc = "";//sonuc tekrar tekrar �al��mamas� i�in kapat�ld�.
            yield return new WaitForSeconds(0.3f);
            Objects2_k�t�[3].SetActive(true);//K�t� objelerden rastgele bir tanesi 2.d�nyada aktif edildi.

        }
        else if (sonuc == "1.2")//araba almay� reddederse
        {
            Objects1_k�t�[3].SetActive(true);//iyi objelerden rastgele bir tanesi bizim d�nyam�zda aktif edildi.
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_iyi[10].SetActive(true);//k�t� objelerden rastgele bir tanesi 2. d�nyada aktif edildi.

        }
    }
    public IEnumerator Soru2Event()
    {
        // Amazon ormanlar� yerine tatil k�y�
        if (sonuc == "2.1") // �zin ver
        {
            Objects1_k�t�[13].SetActive(true);
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_iyi[2].SetActive(true);
        }
        else if (sonuc == "2.2") // �zin verme
        {
            Objects1_iyi[1].SetActive(true);
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_k�t�[13].SetActive(true);   
        }
    }


    public IEnumerator Soru3Event() // Uzayl�lar bulundu D�ZENLENECEK
    {

        if (sonuc == "3.1") // �sanlara a��kla
        {
            Objects1_k�t�[1].SetActive(true);
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_iyi[0].SetActive(true);

        }
        else if (sonuc == "3.2") // Gizle
        {
            Objects1_iyi[1].SetActive(true);
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_k�t�[0].SetActive(true);
        }
    }

    public IEnumerator Soru4Event() // Elon Musk uydu g�nderecek D�ZENLENECEK
    {

        if (sonuc == "4.1")
        {
            Objects1_k�t�[1].SetActive(true);
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_iyi[0].SetActive(true);

        }
        else if (sonuc == "4.2")
        {
            Objects1_iyi[1].SetActive(true);
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_k�t�[0].SetActive(true);
        }
    }
    public IEnumerator Soru5Event() // Pandemi ba�lad�. U�u�lar durulduracak.
    {

        if (sonuc == "5.1") // Durdur
        {
            Objects1_iyi[5].SetActive(true);
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_k�t�[16].SetActive(true);

        }
        else if (sonuc == "5.2") // Durdurma
        {
            Objects1_k�t�[16].SetActive(true);
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_iyi[5].SetActive(true);
        }
    }
    public IEnumerator Soru6Event() // ��retmen maa�lar�n� art�r
    {

        if (sonuc == "6.1") // Maa�lar� y�kselt
        {
            Objects1_iyi[12].SetActive(true);
            sonuc = "";
            yield return new WaitForSeconds(0.3f);

        }
        else if (sonuc == "6.2") // Y�kseltme
        {
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
        }
    }
    public IEnumerator Soru7Event() // �nekleri uyut
    {

        if (sonuc == "7.1") // Onayla
        {
            Objects1_k�t�[11].SetActive(true);
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_k�t�[11].SetActive(true);

        }
        else if (sonuc == "7.2") // Onaylama
        {
            Objects1_k�t�[11].SetActive(true);
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_k�t�[11].SetActive(true);
        }     
    }
    
    public IEnumerator Soru8Event() // Petrol ��kart�ls�n m�?
    {

        if (sonuc == "8.1") // �zin verme
        {
            Objects1_iyi[1].SetActive(true);
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_k�t�[2].SetActive(true);

        }
        else if (sonuc == "8.2") // �zin ver
        {
            Objects1_k�t�[2].SetActive(true);
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_iyi[0].SetActive(true);
        }
    }
    public IEnumerator Soru9Event() // Denizler �ok kirlendi temizlensin mi?
    {

        if (sonuc == "9.1") // Temizle
        {
            Objects1_iyi[6].SetActive(true);
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_k�t�[6].SetActive(true);

        }
        else if (sonuc == "9.2") // Dokunma
        {
            Objects1_k�t�[6].SetActive(true);
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_iyi[6].SetActive(true);
        }
    }
    public IEnumerator Soru10Event() // Fabrika imar izni ormanda
    {

        if (sonuc == "10.1") // �zin ver
        {
            Objects1_k�t�[8].SetActive(true);
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_iyi[3].SetActive(true);

        }
        else if (sonuc == "10.2") // �zin verme
        {
            Objects1_iyi[3].SetActive(true);
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_k�t�[8].SetActive(true);
        }
    }
    public IEnumerator Soru11Event() // Kanser a��s� �ip koyulsun mu
    {

        if (sonuc == "11.1") // �ip koyulsun
        {
            sonuc = "";
            yield return new WaitForSeconds(0.3f);

        }
        else if (sonuc == "11.2") // �ip koyulmas�n
        {
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
        }
    }
    public IEnumerator Soru12Event() // BikBok yasaklans�n m�
    {

        if (sonuc == "12.1") // yasakla
        {
            Objects1_k�t�[1].SetActive(true);
            yield return new WaitForSeconds(0.3f);

        }
        else if (sonuc == "12.2") // yasaklama
        {
            Objects1_iyi[1].SetActive(true);
            yield return new WaitForSeconds(0.3f);
        }
    }
    public IEnumerator Soru13Event() // Y�k�c� deprem sonras� yard�m
    {

        if (sonuc == "13.1") // Yard�m etme
        {
            Objects1_k�t�[7].SetActive(true);
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_iyi[0].SetActive(true);

        }
        else if (sonuc == "13.2") // Yard�m et
        {
            Objects1_iyi[1].SetActive(true);
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_k�t�[7].SetActive(true);
        }
    }
    public IEnumerator Soru14Event() // Ter�r �rg�t� kuruldu
    {

        if (sonuc == "14.1") // Silah g�nder
        {
            sonuc = "";
            yield return new WaitForSeconds(0.3f);

        }
        else if (sonuc == "14.2") // kAr�� ��k
        {
            Objects1_iyi[1].SetActive(true);
            yield return new WaitForSeconds(0.3f);
        }
    }
    public IEnumerator Soru15Event() // Afrika'da su bulundu
    {

        if (sonuc == "15.1") // Yard�m et
        {
            Objects1_iyi[15].SetActive(true);
            sonuc = "";
            yield return new WaitForSeconds(0.3f);

        }
        else if (sonuc == "15.2") // Yard�m etme
        {
            Objects1_iyi[14].SetActive(true);
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
        }
    }
    public IEnumerator Soru16Event() // Asya'da tsunami
    {

        if (sonuc == "16.1") // Yard�m etme
        {
            Objects1_k�t�[15].SetActive(true);
            sonuc = "";
            yield return new WaitForSeconds(0.3f);

        }
        else if (sonuc == "16.2") // Yard�m et
        {
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_k�t�[15].SetActive(true);
        }
    }
    public IEnumerator Soru17Event() // Yeni oyun konsolu yay�nland�
    {

        if (sonuc == "17.1") // Vergileri art�r
        {
            sonuc = "";
            yield return new WaitForSeconds(0.3f);

        }
        else if (sonuc == "17.2") // Bir �ey yapma
        {
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
        }
    }
    public IEnumerator Soru18Event() // Yo�un gemi kullan�m�n� durdur
    {

        if (sonuc == "18.1") // Durdur
        {
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_k�t�[9].SetActive(true);

        }
        else if (sonuc == "18.2") // Durdurma
        {
            Objects1_k�t�[9].SetActive(true);
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
        }
    }
    public IEnumerator Soru19Event() // O�lun ka��r�ld�
    {

        if (sonuc == "19.1") // O�lunu kurtar
        {
            sonuc = "";
            yield return new WaitForSeconds(0.3f);

        }
        else if (sonuc == "19.2") // Rehinleri kurtar
        {
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
        }
    }
    public IEnumerator Soru20Event() // Ter�ristler rehin ald� para istiyor
    {

        if (sonuc == "20.1") // Para ver
        {
            sonuc = "";
            yield return new WaitForSeconds(0.3f);

        }
        else if (sonuc == "20.2") // Para verme
        {
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
        }
    }
    public IEnumerator Soru21Event() // Fosil yak�t t�ketimi
    {

        if (sonuc == "21.1") // Durdurulsun
        {
            Objects1_iyi[7].SetActive(true);
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_k�t�[3].SetActive(true);

        }
        else if (sonuc == "21.2") // Durdurulmas�n
        {
            Objects1_k�t�[3].SetActive(true);
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_iyi[7].SetActive(true);
        }
    }
    public IEnumerator Soru22Event() // sigaralar yasaklans�n m� 
    {

        if (sonuc == "22.1") // yasaklans�n
        {
            Objects1_iyi[8].SetActive(true);
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_k�t�[15].SetActive(true);

        }
        else if (sonuc == "22.2") // yasaklanmas�n
        {
            Objects1_k�t�[14].SetActive(true);
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_iyi[8].SetActive(true);
        }
    }
    public IEnumerator Soru23Event() // Baz istasyonlar� kald�r�ls�n m�
    {

        if (sonuc == "23.1") // Kald�r�ls�n
        {
            Objects1_iyi[3].SetActive(true);
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_k�t�[2].SetActive(true);

        }
        else if (sonuc == "23.2") // Kald�r�lmas�n
        {
            Objects1_k�t�[2].SetActive(true);
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_iyi[4].SetActive(true);
        }
    }
    

}

