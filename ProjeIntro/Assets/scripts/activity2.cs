using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class activity2 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject dna;
    public GameObject disabledText;
    public GameObject showedText;
    public GameObject circle;
    public GameObject circle2;
    public GameObject redLight;
    public GameObject cicekDeathAnim;
    public GameObject CountdownText;
    public GameObject doctorSpeech;
    public GameObject positiveFeedback;
    public GameObject negativeFb;
    public Button devambuton;
    public GameObject devam;
    

    public GameObject hucreCekirdek;
    public GameObject fbBg;
    private bool isDone = false;
    public bool isCorrectlyCompleted = false;
    public GameObject error;

    
    

    



    void Start()
    {
        dna.GetComponent<dnaSecond>().enabled = false;
        this.GetComponent<Countdown>().enabled = false;
        this.GetComponent<AudioSource>().enabled = false;
        error.SetActive(false);
    }

    void Update()
    {
        if (dna.GetComponent<dna>().correctmatch == true ) 
        {
            disabledText.SetActive(false);
            showedText.SetActive(true);
            circle.SetActive(false);
            foreach (Collider2D col in circle.GetComponents<Collider2D>())
            {
                col.enabled = false;
            }
            circle2.SetActive(true);

            dna.GetComponent<dna>().enabled = false;
            hucreCekirdek.GetComponent<Collider2D>().enabled = true;
            StartCoroutine(waitaBit());
            
            // dna.GetComponent<dnaSecond>().enabled = true;
        }
        else if (dna.GetComponent<dnaSecond>().correctmatch == true && isDone==false)
        {
            redLight.SetActive(false);
            
            cicekDeathAnim.SetActive(false);
            CountdownText.SetActive(false);
            doctorSpeech.SetActive(false);
            this.GetComponent<AudioSource>().enabled = false;
            error.SetActive(false);
            this.GetComponent<Countdown>().enabled = false;

            //positiveFeedback.SetActive(true);
            StartCoroutine(waitForFb());
            isDone = true;




        }
      /* else if(this.gameObject.GetComponent<Countdown>().secondsLeft==0)
        {
            redLight.SetActive(false);
            cicekDeathAnim.SetActive(false);
            CountdownText.SetActive(false);
            doctorSpeech.SetActive(false);
            this.GetComponent<Countdown>().enabled = false;

            negativeFb.SetActive(true);
            fbBg.SetActive(true);
        }*/
    }

    IEnumerator waitaBit()
    {
        yield return new WaitForSeconds(2);
        redLight.SetActive(true);
        
        error.SetActive(true);
        this.GetComponent<AudioSource>().enabled = true;
        cicekDeathAnim.SetActive(true);
        CountdownText.SetActive(true);
        
        this.GetComponent<Countdown>().enabled = true;
        dna.GetComponent<dnaSecond>().enabled = true;

    }

    IEnumerator waitForFb()
    {
        yield return new WaitForSeconds(2);
        positiveFeedback.SetActive(true);
        isCorrectlyCompleted = true;
        fbBg.SetActive(true);
        redLight.SetActive(false);
        
        this.GetComponent<AudioSource>().enabled = false;
        error.SetActive(false);
        this.GetComponent<Countdown>().soundOn.SetActive(false);
        CountdownText.SetActive(false);
        negativeFb.SetActive(false);
        cicekDeathAnim.SetActive(false);

    }

    
    
}
