using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class strongestBlock : MonoBehaviour
{
    public float blockHP = 3;
    void OnCollisionEnter2D(Collision2D collisioninfo)
    {
        blockHP--;
        if (blockHP == 0)
        {
            Destroy(gameObject);
        }
    }
   }
