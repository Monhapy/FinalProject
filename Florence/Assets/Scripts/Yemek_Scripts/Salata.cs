using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class Salata : MonoBehaviour
{
    public GameObject dolusalata, bo�salata, yar�dolusalata,kruvasan;
    public GameObject background1,background2, background3;
    public void DoluSalata()
    {
        background1.SetActive(false);
        dolusalata.SetActive(false);
        yar�dolusalata.SetActive(true);
        background2.SetActive(true);
    }
    public void Yar�Salata()
    {
        background2.SetActive(false);
        background3.SetActive(true);
        yar�dolusalata.SetActive(false);
        bo�salata.SetActive(true);
    }
    public void Bo�Salata()
    {
        background3.SetActive(false);
        bo�salata.SetActive(false);
        kruvasan.SetActive(false);
        
        SceneManager.LoadScene(5);
    }
    
}
