using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    public float speed;
    public string inputHorizontal;
    public GameObject bala;
    public float limitePositivoX;
    public float limiteNegativoX;
    public int health;
    public int maxHealth;
    public PlayerMovment player;
    public int puntuacion;
    public GameObject lose;

    void Start()
    {
        maxHealth = 3;
    }

    void Update()
    {
        float horizontal = Input.GetAxis(inputHorizontal);
        transform.position += new Vector3(horizontal, 0, 0) * Time.deltaTime * speed;

        if (Input.GetButtonDown("Jump"))
        {
            GameObject temp = Instantiate(bala, transform.position, Quaternion.identity);

            Destroy(temp, 5);
        }

        if (transform.position.x > limitePositivoX)
        {
            transform.position = new Vector2(limitePositivoX, transform.position.y);
        }
        if (transform.position.x < limiteNegativoX)
        {
            transform.position = new Vector2(limiteNegativoX, transform.position.y);
        }
        if(health == 0)
        {
            lose.SetActive(true);
            Time.timeScale = 0;
            player.gameObject.GetComponent<SpriteRenderer>().enabled = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (health > 0)
        {
            if (collision.gameObject.CompareTag("balaEnemy"))
            {
                health = health - 1;
                transform.position = new Vector3(0, -4.65f, 0);
                collision.gameObject.GetComponent<balaEnemy>().Muerte();

            }
        }
       
    }
}
