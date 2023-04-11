using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activity3 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject sariGen;
    public GameObject igneGen;
    public GameObject kirmiziGul;
    public GameObject sariGul;
    public GameObject kirmiziGenisYaprak;
    public GameObject kirmiziGenisYaprak2;
    public GameObject kirmizi›gneYaprak2;
    public GameObject kirmizi›gneYaprak;

    public GameObject sariGenisYaprak;
    public GameObject sariGenisYaprak2;
    public GameObject sari›gneYaprak;
    public GameObject sari›gneYaprak2;

    public GameObject yonergeText;
    public GameObject closedText;

    public GameObject sariGenText;
    public GameObject igneGenText;

    public GameObject malzemeKutusu;
    public GameObject dna;

    public GameObject positiveFb;
    public GameObject fbbg;
    public GameObject devamButon;

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()

    {
        if (sariGen.GetComponent<gen>().isclick || igneGen.GetComponent<gen>().isclick)
        {
            yonergeText.SetActive(true);
            closedText.SetActive(false);
            if (sariGen.GetComponent<gen>().isclick)
            {
                sariGenText.SetActive(false);
            }

            if (igneGen.GetComponent<gen>().isclick)
            {
                igneGenText.SetActive(false);
            }
            
        }

        if (sariGen.GetComponent<gen>().correctmatch == true)
        {
            kirmiziGul.SetActive(false);
            sariGul.SetActive(true);
        }

        if (igneGen.GetComponent<gen>().correctmatch == true)
        {
            kirmiziGenisYaprak.SetActive(false);
            kirmiziGenisYaprak2.SetActive(false);
            sariGenisYaprak.SetActive(false);
            sariGenisYaprak2.SetActive(false);

            kirmizi›gneYaprak.SetActive(true);
            kirmizi›gneYaprak2.SetActive(true);
            sari›gneYaprak.SetActive(true);
            sari›gneYaprak2.SetActive(true);
        }

        if (sariGen.GetComponent<gen>().correctmatch && igneGen.GetComponent<gen>().correctmatch)
        {
            malzemeKutusu.SetActive(false);
            this.GetComponent<activity3>().enabled = false;

            StartCoroutine(waitforfb());

            
        }
    }

    IEnumerator waitforfb()
    {
        yield return new WaitForSeconds(1f);
        positiveFb.SetActive(true);
        fbbg.SetActive(true);
        devamButon.SetActive(true);
    }
}
