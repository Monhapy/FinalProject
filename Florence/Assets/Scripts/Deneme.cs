using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Deneme : MonoBehaviour
{
    public Animator arkaplan, yaz�,cam;
    private void Start()
    {
        Invoke("Yaz�", 3f);
    }
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            yaz�.SetBool("Gidi�", true);
            cam.SetBool("Cam", true);
            Invoke("Beyaz", 2.5f);
            Invoke("Sahne", 5f);

        }
    }
    private void Yaz�()
    {
        yaz�.SetBool("Yaz�", true);
    }
    private void Beyaz()
    {
        arkaplan.SetBool("Beyaz", true);
        
    }
    private void Sahne()
    {
        SceneManager.LoadScene(1);
    }
}
