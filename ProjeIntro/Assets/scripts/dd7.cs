using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dd7 : MonoBehaviour
{
    // Start is called before the first frame update
    public Dropdown d1;
    public Dropdown d2;
    public Dropdown d3;
    public Dropdown d4;

    public GameObject positivefb;
    public GameObject negativefb;
    public GameObject fbbg;
    public GameObject devamButon;

    List<string> doptions = new List<string>() { "Timin","Adenin", "Guanin","Sitozin" };
   

    bool d1true = false;
    bool d2true = false;
    bool d3true = false;
    bool d4true = false;
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
    }
    void populateList()
    {
       d1.AddOptions(doptions);
       d2.AddOptions(doptions);
       d3.AddOptions(doptions);
       d4.AddOptions(doptions);

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
        if (sender.value == 2)
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
        if (sender.value == 3)
        {
            d4true = true;
        }

    }
    public void kontrolEt()
    {
        if (d1true && d2true && d3true&& d4true)
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
