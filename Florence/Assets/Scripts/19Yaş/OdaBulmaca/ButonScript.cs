using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButonScript : MonoBehaviour
{
    public GameObject kasaCanvas,dolap,a��kdolap,k�yafett,k���kKasa,da��n�kK�yafet;
    public GameObject kitap1, kitap2, kitap3, kitap4,da��n�k1,da��n�k2,da��n�k3,da��n�k4;
    public GameObject resim, d��m��Resim,anahtar1;
    public GameObject akrep,anahtar2;

    public void KasaGidi�()
    {
        kasaCanvas.SetActive(false);
        
    }
    public void KasaGeli�()
    {
        kasaCanvas.SetActive(true);
    }
    
    public void DolapKapak()
    {
        dolap.SetActive(false);
        a��kdolap.SetActive(true);
        k�yafett.SetActive(true);
        da��n�kK�yafet.SetActive(false);
    }
    public void K�yafet()
    {
        k�yafett.SetActive(false);
        k���kKasa.SetActive(true);
        da��n�kK�yafet.SetActive(true);
    }
    public void Kitap1()
    {
        kitap1.SetActive(false);
        da��n�k1.SetActive(true) ;
    }
    public void Kitap2()
    {
        kitap2.SetActive(false);
        da��n�k2.SetActive(true);
    }
    public void Kitap3()
    {
        kitap3.SetActive(false);
        da��n�k3.SetActive(true);
    }
    public void Kitap4()
    {
        kitap4.SetActive(false);
        da��n�k4.SetActive(true);
    }
    public void Resim()
    {
        resim.SetActive(false); 
        d��m��Resim.SetActive(true);
    }
    public void D��m��Resim()
    {
        d��m��Resim.SetActive(false);
        anahtar1.SetActive(true);
    }
    public void �ekmece()
    {
        akrep.SetActive(true);
    }
    public void Saat()
    {
        anahtar2.SetActive(true) ;
    }
}
