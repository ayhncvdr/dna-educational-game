using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dropdown2 : MonoBehaviour
{
    // Start is called before the first frame update
    public Dropdown d1;
    public GameObject positivefb;
    public GameObject negativefb;
    public GameObject fbbg;
    public GameObject devamButon;

    List<string> d1options = new List<string>() {  "solunum organýdýr", "yönetici molekülüdür" };
    bool d1true = false;
    void Start()
    {
        populateList();
        d1.onValueChanged.AddListener(delegate
        {
            dd1valuechange(d1);
        });
    }
    void populateList()
    {
        d1.AddOptions(d1options);
        
    }
    public void dd1valuechange(Dropdown sender)
    {
        // Debug.Log("You have selected this: " + sender.value);
        if (sender.value == 1)
        {
            d1true = true;
        }

    }
    public void kontrolEt()
    {
        if (d1true == true )
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
