using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Music : MonoBehaviour
{
    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);

        if (SceneManager.GetActiveScene().name == "7to14Ya�")
        {
            Destroy(GameObject.FindWithTag("Music"));
        }


    }


}
