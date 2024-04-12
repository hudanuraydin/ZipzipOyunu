using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimeControl : MonoBehaviour
{
    Rigidbody2D playerRB;
    public Text timerText;
    float time = 150;
    public float can, maxCan;
    public GameObject[] canlar;
    public GameObject gameOver;
    

    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
        can = maxCan;
    }

    // Update is called once per frame
    void Update()
    {
        SureSistemi();

        if (can <= 0 || time<=0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }

    public void OnCollisionEnter2D(Collision2D temas)
    { 
        if (temas.gameObject.tag == "Engel" || temas.gameObject.tag == "Bocek")
        {
            
            can -= 1;
            canSistemi();
            playerRB.transform.position = new Vector2(-8, -2.4f);
            
            
        }
        
    }

    public void SureSistemi()
    {
        time -= Time.deltaTime;
        timerText.text = (int)time + "";
    }
    public void canSistemi()
    {
        for(int i=0;i<maxCan;i++)
        {
            canlar[i].SetActive(false);
        }
        for (int i = 0; i < can; i++)
        {
            canlar[i].SetActive(true);
        }
    }
}
