using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dropdownforActivity3 : MonoBehaviour
{
    // Start is called before the first frame update
    public Dropdown d1;
    public Dropdown d2;

    public GameObject positivefb;
    public GameObject negativefb;
    public GameObject fbbg;
    public GameObject devamButon;

    List<string> d1options = new List<string>() {  "tek zincirli", "çift zincirli" };
    List<string> d2options = new List<string>() { "düz", "sarmal" };

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
    void populateList()
    {
        d1.AddOptions(d1options);
        d2.AddOptions(d2options);

    }
    public void dd1valuechange(Dropdown sender1)
    {
         
        if (sender1.value == 1)
        {
            d1true = true;
        }
        Debug.Log("You have selected this: " + sender1.value);

    }
    public void dd2valuechange(Dropdown sender)
    {
         
        if (sender.value == 1)
        {
            d2true = true;
        }
        else
        {
            d2true = false;
        }
        Debug.Log("You have selected this: " + sender.value);

    }
    public void kontrolEt()
    {
        if (d1true == true && d2true==true)
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