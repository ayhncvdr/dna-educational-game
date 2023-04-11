using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activity8 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject kahve;
    public GameObject mor;
    public GameObject yesil;
    public GameObject kirmizi;

    public GameObject positiveFb;
    public GameObject fbbg;
    public GameObject devamButon;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (kahve.GetComponent<gen>().correctmatch && mor.GetComponent<gen>().correctmatch &&
            yesil.GetComponent<gen>().correctmatch && kirmizi.GetComponent<gen>().correctmatch)
        {
            positiveFb.SetActive(true);
            fbbg.SetActive(true);
            devamButon.SetActive(true);
        }
    }
}
