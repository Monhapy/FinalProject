using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SahneY�netim : MonoBehaviour
{
    // Her resim i�in animatorlerin �ekilmesi
    public Animator resim_1_animator;
    public Animator resim_2_animator;
    public Animator resim_3_animator;
    public Animator resim_4_animator;

    // Hangi animasyonun neyden sonra oynayaca��n�n kontrol� i�in de�i�kenler
    public bool g1, g2, g3,g4 ;

    public void Awake()
    {
        //De�i�kenlerin ba�lang�� de�erleri
        g1 = true;
        g2 = false;
        g3 = false;
        g4 = false;
    }

    //Son resmin animasyonunun oynay�p sahne ge�i�i olmas� i�in gerekli olan delay fonksiyonu
    IEnumerator SonGe�i�()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene(1);
    }
    public void Update()
    {
        //1.resimin animasyon kodu
        if (Input.GetMouseButtonDown(0) && g1 == true)
        {
            resim_1_animator.SetBool("Ge�i�1",true);
            g1= false;
            g2= true;

        
        }
        //2.resimin animasyon kodu
        else if (Input.GetMouseButtonDown(0) && g2 == true)
        {
            resim_2_animator.SetBool("Ge�i�2", true);
            g2 = false;
            g3 = true;


        }
        //3. resimin animasyon kodu 
        else if (Input.GetMouseButtonDown(0) && g3 == true)
        {
            resim_3_animator.SetBool("Ge�i�3", true);
            g3 = false;
            g4 = true;


        }
        //Son resimin animasyon kodu ve sahne ge�i�i
        else if (Input.GetMouseButtonDown(0) && g4 == true)
        {
            resim_4_animator.SetBool("Ge�i�4", true);
            StartCoroutine(SonGe�i�());
            
        }
    }    
    
}
