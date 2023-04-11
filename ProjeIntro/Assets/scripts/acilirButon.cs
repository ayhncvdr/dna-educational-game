using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class acilirButon : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject yazi;
    public bool isYaziActive;


    void Start()
    {
        isYaziActive = false;
    }

    // Update is called once per frame
    public void fosforTask()
    {
        if (!isYaziActive)
        {
            yazi.SetActive(true);
            isYaziActive = true;
        }
        else
        {
            yazi.SetActive(false);
            isYaziActive = false;
        }
    }

}
