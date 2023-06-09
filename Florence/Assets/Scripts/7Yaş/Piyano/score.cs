using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class score : MonoBehaviour
{
    public Text mytext;
    public int scorepoints;
    public GameObject yokEdilen;
    public Animator camAnim;
    public void Scoreupdate(int score)
    {
        scorepoints += score;
        mytext.text = scorepoints.ToString("0");
    }
    private void Update()
    {
        if(scorepoints==20) 
        {
            Destroy(yokEdilen);
            Invoke("CamMoveDelay", 2f);
            Invoke("SahneDeğişimDelay", 3.5f);
        }
    }
    private void SahneDeğişimDelay()
    {
        SceneManager.LoadScene(9);
    }
    private void CamMoveDelay()
    {
        camAnim.SetBool("CamMove", true);
    }
}
