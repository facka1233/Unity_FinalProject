using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    public string target;
    private Rigidbody2D rb;
    private ScoreState score;
    public GameObject peluru;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * speed;
    }
    
    // when bullet hit enemy
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.CompareTag("Enemy"))
        {
            HitungSkor.scoreValue +=1;
            ScoreState.instance.AddScore(1);
            Destroy(col.gameObject);
            Destroy(this.gameObject);
        }
    }
}
