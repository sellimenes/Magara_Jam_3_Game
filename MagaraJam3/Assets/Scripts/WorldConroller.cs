using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class WorldConroller : MonoBehaviour
{
    public int para;
    

    public Slider dunyaSagligi;
    public Slider MutlulukOraný;
    
    public Text Para;
    
    public void SetMaxSaglik(int saglik)
    {
        dunyaSagligi.maxValue = 100;
        dunyaSagligi.value = saglik;
    }
    public void DunyaSagligi(int saglik)
    {
        dunyaSagligi.value = saglik;
    }

    public void SetMaxMutluluk(int mutluluk)
    {
        MutlulukOraný.maxValue = 100;
        MutlulukOraný.value = mutluluk;
    }
    public void Mutluluk(int mutluluk)
    {
        MutlulukOraný.value = mutluluk;

    }

   
}
