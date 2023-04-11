using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dd11 : MonoBehaviour
{
    public Dropdown d1;
    public Dropdown d2;
    public Dropdown d3;
    public Dropdown d4;
    public Dropdown d5;

    public GameObject positivefb;
    public GameObject negativefb;
    public GameObject fbbg;
    public GameObject devamButon;

    List<string> d1options = new List<string>() { "çekinik", "dominant" };
    List<string> d2options = new List<string>() { "dominant", "çekinik" };
    List<string> d3options = new List<string>() { "baskýndýr", "çekiniktir" };
    List<string> d4options = new List<string>() { "küçük harf", "büyük harf" };
    List<string> d5options = new List<string>() { "büyük harf","küçük harf"};





    bool d1true = false;
    bool d2true = false;

    bool d3true = false;

    bool d4true = false;
    bool d5true = false;
    // Start is called before the first frame update
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
        d4.onValueChanged.AddListener(delegate
        {
            dd4valuechange(d4);
        });
        d5.onValueChanged.AddListener(delegate
        {
            dd5valuechange(d5);
        });
    }

   
    void populateList()
    {
        d1.AddOptions(d1options);
        d2.AddOptions(d2options);
        d3.AddOptions(d3options);
        d4.AddOptions(d4options);
        d5.AddOptions(d5options);

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
        if (sender.value == 0)
        {
            d3true = true;
        }

    }
    public void dd4valuechange(Dropdown sender)
    {
        // Debug.Log("You have selected this: " + sender.value);
        if (sender.value == 1)
        {
            d4true = true;
        }

    }
    public void dd5valuechange(Dropdown sender)
    {
        // Debug.Log("You have selected this: " + sender.value);
        if (sender.value == 1)
        {
            d5true = true;
        }

    }
    public void kontrolEt()
    {
        if (d1true && d2true && d3true && d4true && d5true)
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
