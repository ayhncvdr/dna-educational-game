using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

using UnityEngine;
using UnityEngine.UI;

public class wrongAnimal : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ConfirmationPanel;
    public GameObject fbbg;
    public GameObject genetikRaporPanel;
    public GameObject hayvanImage;

    public Sprite newImg;
    private Image myImgComponent;

    void Start()
    {
        
    }

   public void OnMouseDown()
    {
        myImgComponent = hayvanImage.GetComponent<Image>();
        myImgComponent.sprite = newImg;
        Debug.Log("pressed");
        genetikRaporPanel.SetActive(false);
        fbbg.SetActive(true);

        ConfirmationPanel.SetActive(true);
        
    }

}
