using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dropdown5 : MonoBehaviour
{
    // Start is called before the first frame update
    public Dropdown d1;
    public Dropdown d2;
    public GameObject positivefb;
    public GameObject negativefb;
    public GameObject fbbg;
    public GameObject devamButon;
    public GameObject uyari;

    List<string> d1options = new List<string>() { "kromozom", "DNA", "nükleotid" };
    List<string> d2options = new List<string>() { "DNA", "Nükleotidler", "Kromozomlar" };

    bool d1true = false;
    bool d2true = false;

    void Start()
    {
        populateList();

        d1.onValueChanged.AddListener(delegate
        {
            dd1valuechange(d1);
        });
        d2.onValueChanged.AddListener(delegate
        {
            dd2valuechange(d2);
        });

    }

    // Update is called once per frame
    
    void populateList()
    {
        d1.AddOptions(d1options);
        d2.AddOptions(d2options);
    }
    public void dd1valuechange(Dropdown sender)
    {
        // Debug.Log("You have selected this: " + sender.value);
        if (sender.value == 2)
        {
            d1true = true;
        }

    }
    public void dd2valuechange(Dropdown sender)
    {
        // Debug.Log("You have selected this: " + sender.value);
        if (sender.value == 1)
        {
            d2true = true;
        }

    }
    public void kontrolEt()
    {
        if (d1true && d2true)
        {
            positivefb.SetActive(true);
            fbbg.SetActive(true);
            devamButon.SetActive(true);
        }
        else
        {
            negativefb.SetActive(true);
            fbbg.SetActive(true);
        }
        uyari.SetActive(false);
    }
}
