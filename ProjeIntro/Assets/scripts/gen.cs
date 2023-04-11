using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gen : MonoBehaviour
{
    // Start is called before the first frame update
     GameObject renkGeni=null;
    public Vector3 startpos;
    bool isInsideRenk = false;
    public bool correctmatch = false;
    public bool isclick = false;
    void Start()
    {
        startpos = this.transform.position;
    }

    void OnTriggerEnter2D(Collider2D collider)
    {

        renkGeni = collider.gameObject;
        Debug.Log("Içerde");
        isInsideRenk = true;

    }
    void OnTriggerExit2D(Collider2D collider)
    {
        renkGeni = null;
        isInsideRenk = false;

    }
    void OnMouseDrag()
    {
        Vector3 newpos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
        newpos = Camera.main.ScreenToWorldPoint(newpos);
        newpos.z = 0;
        this.transform.position = newpos;
        isclick = true;
    }
    void OnMouseUp()
    {

        if (isInsideRenk == false)
        {
            this.transform.position = startpos;
        }
        else
        {
            if (renkGeni.tag == this.tag)
            {
                correctmatch = true;
                if (correctmatch)
                {
                    Vector3 truePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
                    truePos = Camera.main.ScreenToWorldPoint(truePos);
                    truePos.z = 0;

                    this.transform.position = truePos;

                }
            }
            else
            {
                correctmatch = false;
                if (!correctmatch)
                {
                    this.transform.position = startpos;
                }
            }
        }

    }
}
