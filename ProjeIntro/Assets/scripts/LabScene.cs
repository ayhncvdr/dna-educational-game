using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LabScene : MonoBehaviour
{
    public GameObject bubleAnim;

    public GameObject microscope;

    public Button microscopeButton;

    public GameObject student;

    // Start is called before the first frame update
    void Start()
    {
        bubleAnim.SetActive(false);
        microscopeButton.enabled = false;
        microscope.GetComponent<Animator>().enabled = false;
        bubleAnim.GetComponent<Animator>().enabled = false;
        
        StartCoroutine(bubleAnimPlay());
        StartCoroutine(bubleAnimStop());
        StartCoroutine(microscopeAnimPlay());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator bubleAnimPlay()
    {
        yield return new WaitForSeconds(2);
        bubleAnim.SetActive(true);
        bubleAnim.GetComponent<Animator>().enabled = true;
    }

    IEnumerator bubleAnimStop()
    {
        yield return new WaitForSeconds(22);
        bubleAnim.SetActive(false);
    }

    IEnumerator microscopeAnimPlay()
    {
        yield return new WaitForSeconds(23);
        microscope.GetComponent<Animator>().enabled = true;
        microscopeButton.enabled = true;
    }

    public void MicroscopeGoNext()
    {
        
       // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
       StartCoroutine(goNext());

    }

    IEnumerator goNext()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    
}
