using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dna : MonoBehaviour
{
    GameObject circle =null;
    bool isInsideCircle= false;
     public bool correctmatch = false;
     public Vector3 startpos;
     void Start()
     {
         startpos = this.transform.position;
     }

     void OnTriggerEnter2D(Collider2D collider)
     {

         circle = collider.gameObject;
         Debug.Log("Ýçerde");
         isInsideCircle = true;

     }
     void OnTriggerExit2D(Collider2D collider)
     {
         circle = null;
         isInsideCircle = false;

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

        if (isInsideCircle == false)
        {
            this.transform.position = startpos;
        }
        else
        {
            if (circle.tag == "circle")
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
