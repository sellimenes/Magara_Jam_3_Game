using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Soru 
{
    public string soru;
    public string secenek1;
    public string secenek2;
    public string cevap;


    void sorular(string Soru, string Secenek1, string Secenek2,string Cevap)
    {
        soru = Soru;
        secenek1 = Secenek1;
        secenek2 = Secenek2;
        cevap = Cevap;
    }
   
}
