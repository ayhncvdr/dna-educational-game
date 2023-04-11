using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activity5 : MonoBehaviour
{
    public GameObject adenin;

    public GameObject timin;

    public GameObject sitozin;

    public GameObject guanin;

    public GameObject countdown;


    public GameObject alarm;

    public GameObject cicekAnim;

    public GameObject uyariText;

    public GameObject positiveFb;

    public GameObject negativeFb;

    public GameObject fbbg;
    public GameObject nukleotidPanel;
    public GameObject ipucu;
    public GameObject raporButon;
    public GameObject soundOn;

    // Start is called before the first frame update
    void Start()
    {
        adenin.GetComponent<nukleotid>().enabled = true;
        timin.GetComponent<nukleotid>().enabled = true;
        sitozin.GetComponent<nukleotid>().enabled = true;
        guanin.GetComponent<nukleotid>().enabled = true;
        this.GetComponent<coundownforA5>().enabled = true;

    }

    // Update is called once per frame
    public void OnayButon()
    {
        if (adenin.GetComponent<nukleotid>().correctmatch && timin.GetComponent<nukleotid>().correctmatch &&
            guanin.GetComponent<nukleotid>().correctmatch && sitozin.GetComponent<nukleotid>().correctmatch)
        {
            this.GetComponent<coundownforA5>().enabled = false;
            this.GetComponent<AudioSource>().enabled = false;
            countdown.SetActive(false);
            alarm.SetActive(false);
            cicekAnim.SetActive(false);
            uyariText.SetActive(false);
            positiveFb.SetActive(true);
            fbbg.SetActive(true);
            nukleotidPanel.SetActive(false);
            ipucu.SetActive(false);
            raporButon.SetActive(true);
            soundOn.SetActive(false);
        }
        else
        {
            negativeFb.SetActive(true);
            fbbg.SetActive(true);
            alarm.SetActive(false);
            countdown.SetActive(false);
            cicekAnim.SetActive(false);
            this.GetComponent<AudioSource>().enabled = false;

        }
    }
}
