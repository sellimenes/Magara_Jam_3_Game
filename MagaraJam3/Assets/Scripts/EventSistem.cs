using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EventSistem : MonoBehaviour
{
    public GameObject[] Worlds1;
    public GameObject[] Worlds2;
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

        if (sonuc == "1.1")//eðer arabayý kabul ederse
        {
            Objects1_iyi[10].SetActive(true);//araba objesi aktif olsun   
            sonuc = "";//sonuc tekrar tekrar çalýþmamasý için kapatýldý.
            yield return new WaitForSeconds(0.3f);
            Objects2_kötü[3].SetActive(true);//Kötü objelerden rastgele bir tanesi 2.dünyada aktif edildi.

        }
        else if (sonuc == "1.2")//araba almayý reddederse
        {
            Objects1_kötü[3].SetActive(true);//iyi objelerden rastgele bir tanesi bizim dünyamýzda aktif edildi.
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_iyi[10].SetActive(true);//kötü objelerden rastgele bir tanesi 2. dünyada aktif edildi.

        }
    }
    public IEnumerator Soru2Event()
    {
        // Amazon ormanlarý yerine tatil köyü
        if (sonuc == "2.1") // Ýzin ver
        {
            Objects1_kötü[13].SetActive(true);
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_iyi[2].SetActive(true);
        }
        else if (sonuc == "2.2") // Ýzin verme
        {
            Objects1_iyi[1].SetActive(true);
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_kötü[13].SetActive(true);   
        }
    }


    public IEnumerator Soru3Event() // Uzaylýlar bulundu DÜZENLENECEK
    {

        if (sonuc == "3.1") // Ýsanlara açýkla
        {
            Objects1_kötü[1].SetActive(true);
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_iyi[0].SetActive(true);

        }
        else if (sonuc == "3.2") // Gizle
        {
            Objects1_iyi[1].SetActive(true);
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_kötü[0].SetActive(true);
        }
    }

    public IEnumerator Soru4Event() // Elon Musk uydu gönderecek DÜZENLENECEK
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
    public IEnumerator Soru5Event() // Pandemi baþladý. Uçuþlar durulduracak.
    {

        if (sonuc == "5.1") // Durdur
        {
            Objects1_iyi[5].SetActive(true);
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_kötü[16].SetActive(true);

        }
        else if (sonuc == "5.2") // Durdurma
        {
            Objects1_kötü[16].SetActive(true);
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_iyi[5].SetActive(true);
        }
    }
    public IEnumerator Soru6Event() // Öðretmen maaþlarýný artýr
    {

        if (sonuc == "6.1") // Maaþlarý yükselt
        {
            Objects1_iyi[12].SetActive(true);
            sonuc = "";
            yield return new WaitForSeconds(0.3f);

        }
        else if (sonuc == "6.2") // Yükseltme
        {
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
        }
    }
    public IEnumerator Soru7Event() // Ýnekleri uyut
    {

        if (sonuc == "7.1") // Onayla
        {
            Objects1_kötü[11].SetActive(true);
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_kötü[11].SetActive(true);

        }
        else if (sonuc == "7.2") // Onaylama
        {
            Objects1_kötü[11].SetActive(true);
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_kötü[11].SetActive(true);
        }     
    }
    
    public IEnumerator Soru8Event() // Petrol çýkartýlsýn mý?
    {

        if (sonuc == "8.1") // Ýzin verme
        {
            Objects1_iyi[1].SetActive(true);
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_kötü[2].SetActive(true);

        }
        else if (sonuc == "8.2") // Ýzin ver
        {
            Objects1_kötü[2].SetActive(true);
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_iyi[0].SetActive(true);
        }
    }
    public IEnumerator Soru9Event() // Denizler çok kirlendi temizlensin mi?
    {

        if (sonuc == "9.1") // Temizle
        {
            Objects1_iyi[6].SetActive(true);
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_kötü[6].SetActive(true);

        }
        else if (sonuc == "9.2") // Dokunma
        {
            Objects1_kötü[6].SetActive(true);
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_iyi[6].SetActive(true);
        }
    }
    public IEnumerator Soru10Event() // Fabrika imar izni ormanda
    {

        if (sonuc == "10.1") // Ýzin ver
        {
            Objects1_kötü[8].SetActive(true);
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_iyi[3].SetActive(true);

        }
        else if (sonuc == "10.2") // Ýzin verme
        {
            Objects1_iyi[3].SetActive(true);
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_kötü[8].SetActive(true);
        }
    }
    public IEnumerator Soru11Event() // Kanser aþýsý çip koyulsun mu
    {

        if (sonuc == "11.1") // Çip koyulsun
        {
            sonuc = "";
            yield return new WaitForSeconds(0.3f);

        }
        else if (sonuc == "11.2") // Çip koyulmasýn
        {
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
        }
    }
    public IEnumerator Soru12Event() // BikBok yasaklansýn mý
    {

        if (sonuc == "12.1") // yasakla
        {
            Objects1_kötü[1].SetActive(true);
            yield return new WaitForSeconds(0.3f);

        }
        else if (sonuc == "12.2") // yasaklama
        {
            Objects1_iyi[1].SetActive(true);
            yield return new WaitForSeconds(0.3f);
        }
    }
    public IEnumerator Soru13Event() // Yýkýcý deprem sonrasý yardým
    {

        if (sonuc == "13.1") // Yardým etme
        {
            Objects1_kötü[7].SetActive(true);
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_iyi[0].SetActive(true);

        }
        else if (sonuc == "13.2") // Yardým et
        {
            Objects1_iyi[1].SetActive(true);
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_kötü[7].SetActive(true);
        }
    }
    public IEnumerator Soru14Event() // Terör örgütü kuruldu
    {

        if (sonuc == "14.1") // Silah gönder
        {
            sonuc = "";
            yield return new WaitForSeconds(0.3f);

        }
        else if (sonuc == "14.2") // kArþý çýk
        {
            Objects1_iyi[1].SetActive(true);
            yield return new WaitForSeconds(0.3f);
        }
    }
    public IEnumerator Soru15Event() // Afrika'da su bulundu
    {

        if (sonuc == "15.1") // Yardým et
        {
            Objects1_iyi[15].SetActive(true);
            sonuc = "";
            yield return new WaitForSeconds(0.3f);

        }
        else if (sonuc == "15.2") // Yardým etme
        {
            Objects1_iyi[14].SetActive(true);
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
        }
    }
    public IEnumerator Soru16Event() // Asya'da tsunami
    {

        if (sonuc == "16.1") // Yardým etme
        {
            Objects1_kötü[15].SetActive(true);
            sonuc = "";
            yield return new WaitForSeconds(0.3f);

        }
        else if (sonuc == "16.2") // Yardým et
        {
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_kötü[15].SetActive(true);
        }
    }
    public IEnumerator Soru17Event() // Yeni oyun konsolu yayýnlandý
    {

        if (sonuc == "17.1") // Vergileri artýr
        {
            sonuc = "";
            yield return new WaitForSeconds(0.3f);

        }
        else if (sonuc == "17.2") // Bir þey yapma
        {
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
        }
    }
    public IEnumerator Soru18Event() // Yoðun gemi kullanýmýný durdur
    {

        if (sonuc == "18.1") // Durdur
        {
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_kötü[9].SetActive(true);

        }
        else if (sonuc == "18.2") // Durdurma
        {
            Objects1_kötü[9].SetActive(true);
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
        }
    }
    public IEnumerator Soru19Event() // Oðlun kaçýrýldý
    {

        if (sonuc == "19.1") // OÐlunu kurtar
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
    public IEnumerator Soru20Event() // Teröristler rehin aldý para istiyor
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
    public IEnumerator Soru21Event() // Fosil yakýt tüketimi
    {

        if (sonuc == "21.1") // Durdurulsun
        {
            Objects1_iyi[7].SetActive(true);
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_kötü[3].SetActive(true);

        }
        else if (sonuc == "21.2") // Durdurulmasýn
        {
            Objects1_kötü[3].SetActive(true);
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_iyi[7].SetActive(true);
        }
    }
    public IEnumerator Soru22Event() // sigaralar yasaklansýn mý 
    {

        if (sonuc == "22.1") // yasaklansýn
        {
            Objects1_iyi[8].SetActive(true);
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_kötü[15].SetActive(true);

        }
        else if (sonuc == "22.2") // yasaklanmasýn
        {
            Objects1_kötü[14].SetActive(true);
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_iyi[8].SetActive(true);
        }
    }
    public IEnumerator Soru23Event() // Baz istasyonlarý kaldýrýlsýn mý
    {

        if (sonuc == "23.1") // Kaldýrýlsýn
        {
            Objects1_iyi[3].SetActive(true);
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_kötü[2].SetActive(true);

        }
        else if (sonuc == "23.2") // Kaldýrýlmasýn
        {
            Objects1_kötü[2].SetActive(true);
            sonuc = "";
            yield return new WaitForSeconds(0.3f);
            Objects2_iyi[4].SetActive(true);
        }
    }
    

}

