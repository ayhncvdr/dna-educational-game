using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class trueAnimal : MonoBehaviour
{
    public GameObject ConfirmationPanel;
    public GameObject positiveOnay;
    public GameObject negativeOnay;
    public GameObject fbbg;
    public GameObject genetikRaporPanel;
    public GameObject hayvanImage;

    public Sprite newImg;
    private Image myImgComponent;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OnMouseDown()
    {
        myImgComponent = hayvanImage.GetComponent<Image>();
        myImgComponent.sprite = newImg;
        Debug.Log("pressed");
        genetikRaporPanel.SetActive(false);
        negativeOnay.SetActive(false);
        positiveOnay.SetActive(true);
        fbbg.SetActive(true);

        ConfirmationPanel.SetActive(true);

    }

}
