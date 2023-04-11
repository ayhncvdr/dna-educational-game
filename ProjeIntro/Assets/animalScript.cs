using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animalScript : MonoBehaviour
{
    // Start is called before the first frame update
    void OnMouseDown()
    {
        Destroy(this.gameObject);
    }
}
