using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChangeControl : MonoBehaviour
{
    public Ta�� ta��1, ta��2, ta��3, ta��4, ta��5, ta��6 = new Ta��();
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
                                Invoke("SahneGe�i�iii", 1f);
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
}
