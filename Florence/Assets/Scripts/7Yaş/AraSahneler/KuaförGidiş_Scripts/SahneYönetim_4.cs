using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SahneY�netim_4 : MonoBehaviour
{
    [SerializeField] Animator kuaf�r,kuaf�r2;
    [SerializeField] bool z1, z2;


    private void Awake()
    {
        z1 = true;
        z2 = false;

    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && z1== true)
        {
            kuaf�r.SetBool("Kayma", true);
            z1 = false;
            z2 = true;

        }
        else if(Input.GetMouseButtonDown(0) && z2 == true)
        {
            kuaf�r2.SetBool("Kayma2", true);
            z2 = false;
            StartCoroutine(SahneDelay());
        }
    }
    IEnumerator SahneDelay()
    {
        yield return new WaitForSeconds(4f);
        SceneManager.LoadScene(6);
    }
}
