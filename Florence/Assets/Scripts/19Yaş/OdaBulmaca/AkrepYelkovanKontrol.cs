using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AkrepYelkovanKontrol : MonoBehaviour
{
    public GameObject yelkovan, akrep,saatA��k,saat;
    void Update()
    {
        
        if (yelkovan != null && yelkovan.activeSelf)
        {
            if (akrep != null && akrep.activeSelf)
            {
                Invoke("SaatA��l��", 1f);
            }
            

        }
    }
    public void SaatA��l��()
    {
        saatA��k.SetActive(true);
        saat.SetActive(false);
    }
}
