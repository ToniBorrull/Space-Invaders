using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Edificio : MonoBehaviour
{
    public bala bala;
    public balaEnemy bala2;
    int counter;

    void Start()
    {
        counter = 0;
    }
    // Update is called once per frame
    void Update()
    {
      
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bala")
        {
            counter++;
            transform.localScale = new Vector3((transform.localScale.x - 0.07f), transform.localScale.y, 1);
            collision.gameObject.GetComponent<bala>().Muerte();
            if (counter == 15)
            {
                Destroy(gameObject);
            }
        }
        if (collision.gameObject.tag == "balaEnemy")
        {
            counter++;
            transform.localScale = new Vector3((transform.localScale.x - 0.07f), transform.localScale.y, 1);
            collision.gameObject.GetComponent<balaEnemy>().Muerte();
            if (counter == 15)
            {
                Destroy(gameObject);
            }
        }
    }
}
