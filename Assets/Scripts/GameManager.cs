using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

        bool theEnd = false;
    public GameOverscreen GameOverScreen;

    public void end ()
    {
       if (theEnd == false)
        {
            theEnd = true;
            Debug.Log("you lose");
            GameOverScreen.Setup(ball.score);
            
        }
    }
     
}
 