using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SahneY�netim : MonoBehaviour
{
    public Animator resim_1_animator;
    public Animator resim_2_animator;
    public Animator resim_3_animator;
    public Animator resim_4_animator;

    public bool g1, g2, g3,g4 ;

    public void Awake()
    {
        g1 = true;
        g2 = false;
        g3 = false;
        g4 = false;
    }

    IEnumerator SonGe�i�()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(1);
    }
    public void Update()
    {
        if (Input.GetMouseButtonDown(0) && g1 == true)
        {
            resim_1_animator.SetBool("Ge�i�1",true);
            g1= false;
            g2= true;


        }
        else if (Input.GetMouseButtonDown(0) && g2 == true)
        {
            resim_2_animator.SetBool("Ge�i�2", true);
            g2 = false;
            g3 = true;


        }
        else if (Input.GetMouseButtonDown(0) && g3 == true)
        {
            resim_3_animator.SetBool("Ge�i�3", true);
            g3 = false;
            g4 = true;


        }
        else if (Input.GetMouseButtonDown(0) && g4 == true)
        {
            resim_4_animator.SetBool("Ge�i�4", true);
            StartCoroutine(SonGe�i�());
            
        }
    }    
    
}
