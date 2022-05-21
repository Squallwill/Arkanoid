using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class strongBlock : MonoBehaviour
{
    public float blockHP = 2;
    void OnCollisionEnter2D(Collision2D collisioninfo)
    {
        blockHP -- ;
        if (blockHP == 0)
        {
            Destroy(gameObject);
            ball.score = ball.score + 2;
        }
    }

}
