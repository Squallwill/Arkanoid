using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ball : MonoBehaviour
{
    public float speed = 100.0f;
    public static float score = 0;
    public Text txtScore;
    public static int life = 3;
    public Text txtLife;
    public Vector2 retryPos ;
    public GameManager GameManager;

    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.down * speed;
    }
    void Update()
    {
        txtScore.text = score.ToString();
        
    }
    float hitFactor(Vector2 ballPos, Vector2 racketPos, float racketWidth)
    {
        return (ballPos.x - racketPos.x) / racketWidth;
    }
    private void OnCollisionEnter2D (Collision2D col)
    {
        if (col.gameObject.name == "racket")
        {
            float x = hitFactor(transform.position, col.transform.position, col.collider.bounds.size.x);

            Vector2 dir = new Vector2(x, 1).normalized;
            GetComponent<Rigidbody2D>().velocity = dir * speed; 

        }
      
    }
    private void OnTriggerEnter2D(Collider2D col2)
    {
        if (col2.gameObject.name == "miss")
        {
            life--;

            txtLife.text = life.ToString();

            if (life == 0) 
            {
                FindObjectOfType<GameManager>().end();

            }
            if (life > 0)
            {
                
                transform.position =  new Vector2 (0,0);
                GetComponent<Rigidbody2D>().velocity = Vector2.down * speed;

            }
        }
    }
}
