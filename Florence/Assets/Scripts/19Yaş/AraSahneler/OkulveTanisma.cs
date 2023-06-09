using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OkulveTanisma : MonoBehaviour
{
    // Her resim i�in animatorlerin �ekilmesi

    [SerializeField] Animator resim_1_animator;
    [SerializeField] Animator resim_2_animator;
    [SerializeField] Animator resim_3_animator;
    [SerializeField] Animator resim_4_animator;
    [SerializeField] Animator resim_5_animator;
    [SerializeField] Animator resim_6_animator;
    [SerializeField] Animator resim_7_animator;




    // Hangi animasyonun neyden sonra oynayaca��n�n kontrol� i�in de�i�kenler
    [SerializeField] bool z1, z2, z3, z4, z5, z6, z7;

    private void Awake()
    {
        //De�i�kenlerin ba�lang�� de�erleri
        z1 = true;
        z2 = false;
        z3 = false;
        z4 = false;
        z5 = false;
        z6 = false;
        z7 = false;
        

    }
    private void Update()
    {


        //1.resimin animasyon kodu
        if (Input.GetMouseButtonDown(0) && z1 == true)
        {
            resim_1_animator.SetBool("Ge�i�1", true);
            Invoke("Anim1", 0.5f);

            z1 = false;
            z2 = true;


        }
        //2.resimin animasyon kodu
        else if (Input.GetMouseButtonDown(0) && z2 == true)
        {
            resim_2_animator.SetBool("Ge�i�2", true);
            Invoke("Anim2", 0.5f);

            z2 = false;
            z3 = true;


        }
        else if (Input.GetMouseButtonDown(0) && z3 == true)
        {
            resim_3_animator.SetBool("Ge�i�3", true);
            Invoke("Anim3", 0.5f);

            z3 = false;
            z4 = true;


        }
        else if (Input.GetMouseButtonDown(0) && z4 == true)
        {
            resim_4_animator.SetBool("Ge�i�4", true);
            Invoke("Anim4", 0.5f);

            z4 = false;
            z5 = true;


        }
        else if (Input.GetMouseButtonDown(0) && z5 == true)
        {
            resim_5_animator.SetBool("Ge�i�5", true);
            Invoke("Anim5", 0.5f);

            z5 = false;
            z6 = true;


        }
        else if (Input.GetMouseButtonDown(0) && z6 == true)
        {
            resim_6_animator.SetBool("Ge�i�6", true);
            Invoke("Anim6", 0.5f);

            z6 = false;
            z7 = true;


        }
        else if (Input.GetMouseButtonDown(0) && z7 == true)
        {
            resim_7_animator.SetBool("Ge�i�7", true);
            
            StartCoroutine(SonGe�i�());

            z7 = false;
            


        }
        



    }
    IEnumerator SonGe�i�()
    {
        //Sahne ge�i�i i�in gerekli olan delay
        yield return new WaitForSeconds(3f);

        SceneManager.LoadScene(25);
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
        //2.resim ile 3.resim aras�ndaki gerekli olan delay i�in yaz�lm�� fonk
        resim_4_animator.SetBool("Ge�i�3", true);
    }
    private void Anim4()
    {
        //2.resim ile 3.resim aras�ndaki gerekli olan delay i�in yaz�lm�� fonk
        resim_5_animator.SetBool("Ge�i�4", true);
    }
    private void Anim5()
    {
        //2.resim ile 3.resim aras�ndaki gerekli olan delay i�in yaz�lm�� fonk
        resim_6_animator.SetBool("Ge�i�5", true);
    }
    private void Anim6()
    {
        //2.resim ile 3.resim aras�ndaki gerekli olan delay i�in yaz�lm�� fonk
        resim_7_animator.SetBool("Ge�i�6", true);
    }
    
}
