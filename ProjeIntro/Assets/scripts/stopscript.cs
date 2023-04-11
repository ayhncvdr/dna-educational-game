using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stopscript : MonoBehaviour
{
    public GameObject character;
    public GameObject ustanim;
    public GameObject buble;
    public GameObject studentsag;

    public Sprite idle;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(stop());
        StartCoroutine(sagaDondur());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator stop()
    {
        yield return new WaitForSeconds(2.3f);
        character.GetComponent<Animator>().enabled = false;
        ustanim.GetComponent<Animator>().enabled = false;
        character.GetComponent<SpriteRenderer>().sprite = idle;
        buble.SetActive(true);
        yield return new WaitForSeconds(2);
        ustanim.SetActive(false);
    }

    IEnumerator sagaDondur()
    {
        yield return new WaitForSeconds(4.3f);
        studentsag.SetActive(true);
        studentsag.GetComponent<Animator>().enabled = true;

    }

    
}
