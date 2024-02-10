using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balaEnemy : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    int random;
    public GameObject EnemyBala;
    public float counter;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(transform.up * speed);
        counter = 0;
    }

    void Update()
    {
       
    }

    public void Muerte()
    {
        Destroy(gameObject);
    }
}
