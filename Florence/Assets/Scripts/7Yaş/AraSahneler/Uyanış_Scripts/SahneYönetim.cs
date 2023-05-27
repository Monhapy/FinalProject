using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SahneY�netim : MonoBehaviour
{
    // Her resim i�in animatorlerin �ekilmesi
    
    [SerializeField] Animator resim_1_animator;
    [SerializeField] Animator resim_2_animator;
    [SerializeField] Animator resim_3_animator;
    [SerializeField] Animator resim_4_animator;

    // Hangi animasyonun neyden sonra oynayaca��n�n kontrol� i�in de�i�kenler
    [SerializeField] bool g1, g2, g3,g4 ;

    public void Awake()
    {
        //De�i�kenlerin ba�lang�� de�erleri
        g1 = true;
        g2 = false;
        g3 = false;
        g4 = false;
    }

    
    public void Update()
    {
        //1.resimin animasyon kodu
        if (Input.GetMouseButtonDown(0) && g1 == true)
        {
            resim_1_animator.SetBool("Ge�i�1",true);
            Invoke("Anim1", 0.5f);
            
            g1 = false;
            g2= true;

        
        }
        //2.resimin animasyon kodu
        else if (Input.GetMouseButtonDown(0) && g2 == true)
        {
            resim_2_animator.SetBool("Ge�i�2", true);
            Invoke("Anim2", 0.5f);
            
            g2 = false;
            g3 = true;


        }
        //3. resimin animasyon kodu 
        else if (Input.GetMouseButtonDown(0) && g3 == true)
        {
            resim_3_animator.SetBool("Ge�i�3", true);
            Invoke("Anim3", 0.5f);
            
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
    IEnumerator SonGe�i�()
    {
        //Sahne ge�i�i i�in gerekli olan delay
        yield return new WaitForSeconds(3f);

        SceneManager.LoadScene(2);
    }
    private void Anim1()
    {
        //1.resim ile 2.resim aras�ndaki gerekli olan delay i�in yaz�lm�� fonk
        resim_2_animator.SetBool("Ge�i�1", true);
    }
    private void Anim2()
    {
        //2.resim ile 3.resim aras�ndaki gerekli olan delay i�in yaz�lm�� fonk
        resim_3_animator.SetBool("Ge�i�2", true);
    }
    private void Anim3()
    {
        //3.resim ile 4.resim aras�ndaki gerekli olan delay i�in yaz�lm�� fonk
        resim_4_animator.SetBool("Ge�i�3", true);
    }


}
