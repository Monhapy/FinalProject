using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Butonlar : MonoBehaviour
{
    public Animator sa�1_animator, cam_animator;
    public bool cam;
    
    public void Sa�1()
    {
        sa�1_animator.SetBool("Alarm", true);
    }
    public void Sa�1Deactive()
    {
       sa�1_animator.SetBool("Alarm", false);
    }
    public void Sa�2()
    {
        cam_animator.SetBool("Cam", true);
        cam = true;
        StartCoroutine(DelayScene());
    }
    IEnumerator DelayScene() 
    {
        yield return new WaitForSeconds(1.5f);
    }
}
