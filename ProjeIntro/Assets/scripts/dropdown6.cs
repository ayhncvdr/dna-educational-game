using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dropdown6 : MonoBehaviour
{
    public Dropdown d1;
    public Dropdown d2;
    public Dropdown d3;

    public GameObject positivefb;
    public GameObject negativefb;
    public GameObject fbbg;
    public GameObject devamButon;

    List<string> d1options = new List<string>() { "flor", "fosfat", "fosfür" };
    List<string> d2options = new List<string>() { "tuz", "þeker"  };
    List<string> d3options = new List<string>() { "asit", "organik baz" };

    bool d1true = false;
    bool d2true = false;
    bool d3true = false;

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
        d3.onValueChanged.AddListener(delegate
        {
            dd3valuechange(d3);
        });
    }

    // Update is called once per frame

    void populateList()
    {
        d1.AddOptions(d1options);
        d2.AddOptions(d2options);
        d3.AddOptions(d3options);
    }
    public void dd1valuechange(Dropdown sender)
    {
        // Debug.Log("You have selected this: " + sender.value);
        if (sender.value == 1)
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
    public void dd3valuechange(Dropdown sender)
    {
        // Debug.Log("You have selected this: " + sender.value);
        if (sender.value == 1)
        {
            d3true = true;
        }

    }
    public void kontrolEt()
    {
        if (d1true && d2true&& d3true)
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
    }
}
