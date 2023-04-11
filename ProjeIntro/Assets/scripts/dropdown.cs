using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dropdown : MonoBehaviour
{
    // Start is called before the first frame update

    public Dropdown d1;
    public Dropdown d2;
    public Dropdown d3;

    public GameObject positivefb;
    public GameObject negativefb;
    public GameObject fbbg;
    public GameObject devamButon;

    List<string> d1options = new List<string>() { "DNA", "gen", "kromozom" };
    List<string> d2options = new List<string>() { "DNA", "Kromozomlar", "Genler" };
    List<string> d3options = new List<string>() { "büyük", "küçük" };

     bool d1true = false;
    bool d2true=false;
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
        d2.onValueChanged.AddListener(delegate
        {
            dd3valuechange(d3);
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void populateList()
    {
        d1.AddOptions(d1options);
        d2.AddOptions(d2options);
        d3.AddOptions(d3options);
    }
    public void dd1valuechange(Dropdown sender)
    {
        // Debug.Log("You have selected this: " + sender.value);
        if (sender.value == 2) {
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

    public void kontrolEt()
    {
        if(d1true==true && d2true == true && d3true==true)
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
