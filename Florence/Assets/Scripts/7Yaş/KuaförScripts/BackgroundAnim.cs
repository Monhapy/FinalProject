using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackgroundAnim : MonoBehaviour
{
    public Animator animator_kuaf�r,sahneGe�i�;
    public Animator animator_sa�1, animator_sa�2;
    public bool z1, z2, z3;
    Butonlar buton;
    
    private void Start()
    {
         z1= true;
         z2= false;
         z3= false;
         
        buton = FindObjectOfType<Butonlar>();
    }

    void Update()
    {
        
        if (Input.GetMouseButtonDown(0) && z1==true)
        {
           
            animator_kuaf�r.SetBool("Ge�me3", true);
            z1= false;
            z2= true;


        }
        else if(Input.GetMouseButtonDown(0) && z2 == true)
        {
            animator_sa�1.SetBool("Sa�1", true) ;
            animator_sa�2.SetBool("Sa�2", true) ;
            z2= false;
            z3= true;

        }
        else if (Input.GetMouseButtonDown(0) && z3 == true)
        {
            
            z3 = false;
            

        }
        else if (Input.GetMouseButtonDown(0) && buton.cam == true)
        {
            sahneGe�i�.SetBool("Sahne", true);
            Invoke("SahneGe�i�", 1.5f);


        }


    }
    private void SahneGe�i�()
    {
        SceneManager.LoadScene(7);
    }
    
}
