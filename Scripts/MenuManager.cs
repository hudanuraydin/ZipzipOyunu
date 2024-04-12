using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

    

    // Start is called before the first frame update
    
    public void Oyun1Button()
    {
        SceneManager.LoadScene("Level1");
        
    }
    public void Oyun2Button()
    {
        SceneManager.LoadScene("Level2");

    }
    public void Oyun3Button()
    {
        SceneManager.LoadScene("Level3");

    }
    public void Oyun4Button()
    {
        SceneManager.LoadScene("Level4");

    }
    public void Oyun5Button()
    {
        SceneManager.LoadScene("Level5");

    }
    

}
