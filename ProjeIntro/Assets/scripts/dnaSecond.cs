using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dnaSecond : MonoBehaviour
{

    GameObject cekirdek = null;
    bool isInsideCekirdek = false;
    public bool correctmatch = false;
    public Vector3 startpos;
    void Start()
    {
        startpos = this.transform.position;
    }
    void OnTriggerEnter2D(Collider2D collider)
    {

        cekirdek = collider.gameObject;
        Debug.Log("Çekirdek içerisinde");
        isInsideCekirdek = true;

    }
    void OnTriggerExit2D(Collider2D collider)
    {
        cekirdek = null;
        isInsideCekirdek = false;

    }
    void OnMouseDrag()
    {
        Vector3 newpos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
        newpos = Camera.main.ScreenToWorldPoint(newpos);
        newpos.z = 0;
        this.transform.position = newpos;
    }
    void OnMouseUp()
    {

        if (isInsideCekirdek == false)
        {
            this.transform.position = startpos;
        }
        else
        {
            if (cekirdek.tag == "cekirdek")
            {
                correctmatch = true;
            }
            else
            {
                correctmatch = false;
            }
        }

    }

}
