using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundAnim : MonoBehaviour
{
    public Animator animator_kuaf�r;
    public Animator animator_sa�1, animator_sa�2;
    public bool z1, z2;
    private void Start()
    {
         z1= true;
         z2= false;
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
            animator_sa�1.SetBool("Sa�1", true); ;
            animator_sa�2.SetBool("Sa�2", true) ;
            z2= false;

        }
    }
    
}
