using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerDolap : MonoBehaviour
{
    // Her resim i�in animatorlerin �ekilmesi

    [SerializeField] Animator resim_1_animator;
    [SerializeField] Animator resim_2_animator;
    [SerializeField] Animator resim_3_animator;
    [SerializeField] Animator cam_animator;


    // Hangi animasyonun neyden sonra oynayaca��n�n kontrol� i�in de�i�kenler
    [SerializeField] bool z1, z2, z3;

    private void Awake()
    {
        //De�i�kenlerin ba�lang�� de�erleri
        z1 = true;
        z2 = false;
        z3 = false;


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
        //3. resimin animasyon kodu 
        else if (Input.GetMouseButtonDown(0) && z3 == true)
        {
            cam_animator.SetBool("CamZoom", true);
            Invoke("Anim3", 3f);
            StartCoroutine(SonGe�i�());

            z3 = false;



        }



    }
    IEnumerator SonGe�i�()
    {
        //Sahne ge�i�i i�in gerekli olan delay
        yield return new WaitForSeconds(6f);

        SceneManager.LoadScene(16);
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
        resim_3_animator.SetBool("Ge�i�3", true);
    }
}
