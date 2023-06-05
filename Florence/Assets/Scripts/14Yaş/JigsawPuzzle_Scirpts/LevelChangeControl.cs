using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChangeControl : MonoBehaviour
{
    public Ta�� ta��1, ta��2, ta��3, ta��4, ta��5, ta��6 ;
    public Animator camAnim,anim�,anim1,anim2,anim3,anim4,anim5,anim6;
    void Update()
    {
        if (ta��1.denemesayi2 == 1)
        {
            if (ta��2.denemesayi2 == 1)
            {
                if (ta��3.denemesayi2 == 1)
                {
                    if (ta��4.denemesayi2 == 1)
                    {
                        if (ta��5.denemesayi2 == 1)
                        {
                            if (ta��6.denemesayi2 == 1)
                            {
                                camAnim.SetBool("Zoom", true);
                                Invoke("AnimGecikme", 3f);
                                Invoke("SahneGe�i�iii", 6f);
                            }
                        }
                    }
                }
            }
        }
    }
    private void SahneGe�i�iii()
    {
        SceneManager.LoadScene(13);
    }
    private void AnimGecikme()
    {
        anim�.SetBool("Gidi��", true);
        anim1.SetBool("Gidi�1", true);
        anim2.SetBool("Gidi�2", true);
        anim3.SetBool("Gidi�3", true);
        anim4.SetBool("Gidi�4", true);
        anim5.SetBool("Gidi�5", true);
        anim6.SetBool("Gidi�6", true);
    }
}
