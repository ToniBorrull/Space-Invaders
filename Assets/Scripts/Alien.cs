using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alien : MonoBehaviour
{
    public AliensMovement aliensMovement;
    public int type;
    public bala bala;
    Collider2D col;
    public PlayerMovment player;
    public AliensMovement all;
    public GameObject lose;
   

    void Start()
    {
        col = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Limites"))
        {
            aliensMovement.GiroMovimiento();

        }

        if (collision.gameObject.tag == "Bala")
        {
            collision.gameObject.GetComponent<bala>().Muerte();
            
            aliensMovement.speed += 0.090f;

            if(type == 0){
               player.puntuacion += 10;
            }
            if(type == 1){
               player.puntuacion += 20;
            }
             if(type == 2){
               player.puntuacion += 30;
            }
            Destroy(gameObject);
            all.aliensLeft--;
        }
        if (collision.gameObject.CompareTag("Edificio"))
        {
            player.health = 0;
            lose.SetActive(true);
            Time.timeScale = 0;

        }
    }
}
