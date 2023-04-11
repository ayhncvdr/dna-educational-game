using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activity1 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject feedbackEkran;
    public GameObject blurekran;
    public GameObject hucreCekirdekanim;
    public GameObject kromozom1;
    public GameObject kromozom2;
    public GameObject kromozom3;
    GameObject[] dnalar;
    void Start()
    {
        hucreCekirdekanim.GetComponent<Animator>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void close()
    {
        feedbackEkran.SetActive(false);
        blurekran.SetActive(false);
    }

    public void playKromozomAnim()
    {
        hucreCekirdekanim.GetComponent<Animator>().enabled = true;
        
        
    }

    
    public void stopAnim()
    {
        dnalar = GameObject.FindGameObjectsWithTag("dna");
        hucreCekirdekanim.GetComponent<Animator>().enabled = false;
        foreach (GameObject o in dnalar)
        {
            o.SetActive(false);
        }

       kromozom1.SetActive(true);
       kromozom2.SetActive(true);
       kromozom3.SetActive(true);

        
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(1);
    }

    
    
}
