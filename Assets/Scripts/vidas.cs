using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class vidas : MonoBehaviour
{
    public PlayerMovment player;
    public TMP_Text playerText;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        playerText.text = (player.health).ToString();
    }
}