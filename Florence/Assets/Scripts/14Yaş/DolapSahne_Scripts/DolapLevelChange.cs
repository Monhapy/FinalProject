using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DolapLevelChange : MonoBehaviour
{
    public Ta�� ta��1, ta��2, ta��3;
    public Animator camAnim, kitapAnim,backgroundAnim;
    public GameObject kitap1,kitap2,kitap3;
    void Update()
    {
        if (ta��1.denemesayi2 == 1)
        {
            if (ta��2.denemesayi2 == 1)
            {
                if (ta��3.denemesayi2 == 1)
                {
                    kitapAnim.SetBool("KitaplarGidi�", true);
                    backgroundAnim.SetBool("Gidi�", true);
                    Invoke("SahneGe�i�iii", 3f);
                    
                }
            }
        }
    }
    private void SahneGe�i�iii()
    {
        SceneManager.LoadScene(15);
    }
    private void Start()
    {
        Invoke("KitapGecikme", 2f);
    }
    private void KitapGecikme()
    {
        kitapAnim.SetBool("KitapGeli�", true);
        kitap1.SetActive(true); 
        kitap2.SetActive(true);
        kitap3.SetActive(true);
    }
}
