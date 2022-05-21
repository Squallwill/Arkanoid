using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverscreen : MonoBehaviour
{
    public Text fScore;
    public void Setup (float score)
    {
        gameObject.SetActive(true);
        fScore.text = score.ToString() + " POINTS";
    }
    public void Reset()
    {
        SceneManager.LoadScene("Arklvl");
        ball.life = 3;
        ball.score = 0;
    }
}
