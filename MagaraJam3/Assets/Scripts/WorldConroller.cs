using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class WorldConroller : MonoBehaviour
{
    public int para;

    public Slider dunyaSagligi;
    public Slider MutlulukOran�;

    public Text Para;
    
    public void SetMaxSaglik(int saglik)
    {
        dunyaSagligi.maxValue = saglik;
        dunyaSagligi.value = 50;
    }
    public void DunyaSagligi(int saglik)
    {
        dunyaSagligi.value = saglik;

    }

    public void SetMaxMutluluk(int mutluluk)
    {
        MutlulukOran�.maxValue = mutluluk;
        MutlulukOran�.value = mutluluk;
    }
    public void Mutluluk(int mutluluk)
    {
        MutlulukOran�.value = mutluluk;

    }
}
