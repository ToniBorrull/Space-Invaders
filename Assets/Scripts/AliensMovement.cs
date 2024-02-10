using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AliensMovement : MonoBehaviour
{
    public GameObject balaEnemy;
    public float speed;
    public int direccionX;
    public int direccionY;
    float contador; 
    public GameObject[] enemies;
    public int dispara;
    public float cooldown;
    public int aliensLeft;
    public float resetCooldown = 2;
    public GameObject win;
   
    
    // Update is called once per frame
    void Start()
    {
        direccionX = 1;
        aliensLeft = 50;
       
    }

    void Update()
    {
        cooldown -= Time.deltaTime;
        transform.position += new Vector3(direccionX, 0, 0) * Time.deltaTime * speed;
        contador += Time.deltaTime;
        SelectEnemy();

        if(aliensLeft <= 0)
        {
            win.SetActive(true);
            Time.timeScale = 0;
        }
    }
    public void GiroMovimiento()
    {
        if (contador >= 0.3f)
        {
            direccionX *= -1;
            direccionY = -5;
            transform.position += new Vector3(0, direccionY, 0) * Time.deltaTime * speed;
            contador = 0;
        }
    }
    public void SelectEnemy()
    {
        if(cooldown <= 0 && transform.childCount > 0)
        {
            dispara = Random.Range(0, transform.childCount);
            GameObject enemyDispara = transform.GetChild(dispara).gameObject;//PASA ALGO
            GameObject temp = Instantiate(balaEnemy, enemyDispara.transform.position, Quaternion.identity);
            Destroy(temp, 5);
            cooldown = resetCooldown;
        }
    }
        
}
