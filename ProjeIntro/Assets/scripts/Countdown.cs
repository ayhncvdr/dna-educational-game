using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    // Start is called before the first frame update

   [SerializeField] public Text textDisplay;
    public GameObject redLight;
    public GameObject cicekDeathAnim;
    public GameObject CountdownText;
    public GameObject doctorSpeech;
    public GameObject negativeFb;
    public GameObject fbBg;
    public GameObject soundOn;
   

    public Button but;
   




    public float secondsLeft = 59f;
    
    public bool takingAway = false;

    private bool isClicked;

    bool isdone = false;

    public void reset()
    {
        secondsLeft = 59f;
        cicekDeathAnim.SetActive(false);
        cicekDeathAnim.SetActive(true);
        soundOn.SetActive(true);
    }

    void Start()
    {
        Button button = but.GetComponent<Button>();
        button.onClick.AddListener(TaskToDo);
        soundOn.SetActive(true);
        


    }

   
    
    void TaskToDo()
    {
        if (this.GetComponent<AudioSource>().isPlaying)
        {
            this.GetComponent<AudioSource>().Pause();
            GameObject image1 = soundOn.transform.GetChild(0).gameObject;
            GameObject muteImage = image1.transform.GetChild(1).gameObject;
            GameObject soundUp = image1.transform.GetChild(0).gameObject;
            muteImage.SetActive(true);
            soundUp.SetActive(false);


        }
        else
        {
            this.GetComponent<AudioSource>().Play();
            GameObject image1 = soundOn.transform.GetChild(0).gameObject;
            GameObject muteImage = image1.transform.GetChild(1).gameObject;
            GameObject soundUp = image1.transform.GetChild(0).gameObject;
            muteImage.SetActive(false);
            soundUp.SetActive(true);
        }


    }
    void Update()
    {
        
        

        
        if (isdone == false)
        {
            secondsLeft -= Time.deltaTime;
            textDisplay.text = secondsLeft.ToString("00:00");
            if (secondsLeft <= 0)
            {
                secondsLeft = 0;
                Mesaj();
                

            }
            
        }

        


    }

    

    public void Mesaj()
    {
        if (secondsLeft == 0 && this.GetComponent<activity2>().isCorrectlyCompleted==false)
        {
           

            negativeFb.SetActive(true);
            fbBg.SetActive(true);
            soundOn.SetActive(false);
            
        }

    }

    


}
