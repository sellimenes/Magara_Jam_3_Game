using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuControl : MonoBehaviour
{
    
    public void SistemiBaslat()
    {
        SceneManager.LoadScene(1);
    }
    public void SistemiKapat()
    {
        Application.Quit();
    }

    
}
