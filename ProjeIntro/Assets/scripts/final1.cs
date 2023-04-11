using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class final1 : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject konusmalar;
    public GameObject buton;
    void Update()
    {
        konusmalar.GetComponent<Animator>().Play("finalKonusmalar");
        StartCoroutine(waitEndSpeech());
        

    }

    IEnumerator waitEndSpeech()
    {
        yield return new WaitForSeconds(10);
        buton.SetActive(true);
    }

    // Update is called once per frame
    
}
