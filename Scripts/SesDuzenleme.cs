using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SesDuzenleme : MonoBehaviour
{
    // Start is called before the first frame update
  
    private static SesDuzenleme obje = null;

    void Awake()
    {
        if (obje == null)
        {
            obje = this;
            DontDestroyOnLoad(this);
        }
        else if (this != obje)
        {
            Destroy(gameObject);
        }
    }

}
