using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Button : MonoBehaviour
{
    public GameObject settingMusic;
    public GameObject repeat, play;
    public GameObject menu;
    public int sayac = 0, sayac2 = 0;
    AudioSource backGroundMusic;

    void Start()
    {
        backGroundMusic=GetComponent<AudioSource>();
    }
    

    public static bool isPaused;
    internal object onClick;

    public void PlayButton()
    {
        SceneManager.LoadScene("Oyun1");
    }
    public void ExitButton()
    {
        Application.Quit();
    }
   
    public void SettingButton()
    {
        sayac += 1;
        if(sayac%2==1)
        {
            settingMusic.gameObject.SetActive(true);
        }
        else
        {
            settingMusic.gameObject.SetActive(false);
        }
        
    }
    
    public void SesAc()
    {
        AudioListener.volume = 1;
    }
    public void SesKapat()
    {
        AudioListener.volume = 0;
    }

    public void MusicButton()
    {
        sayac2 += 1;
        if (sayac2 % 2 == 1)
        {
            SesKapat();
        }
        else
        {
            SesAc();
        }

    }


    public void PauseButton()
    {
        if (isPaused) // Oyun durdurulmuþsa devam ettir
        {
            Time.timeScale = 1;
            isPaused = false;
            repeat.SetActive(true);
            menu.SetActive(false);
            
        }
        else // Durdurulmamýþsa durdur
        {
            Time.timeScale = 0;
            isPaused = true;
            menu.SetActive( true);
            repeat.SetActive(false);

        }
    }
    public void MenuyeGidisButonu()
    {
        SceneManager.LoadScene("Menu");
    }



}
