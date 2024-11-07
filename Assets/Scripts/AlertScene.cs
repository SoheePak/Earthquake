using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlertScene : MonoBehaviour
{
    public AudioClip clip;
    public AudioSource audio;
    public GameObject popUP;
    public AudioClip tts;

    void Start()
    {
        audio.PlayOneShot(clip);
        StartCoroutine(popin());
    }

    
    void Update()
    {
        
    }

    IEnumerator popin()
    {
        yield return new WaitForSeconds(5f);
        popUP.SetActive(true);
        yield return new WaitForSeconds(1f);
        audio.Stop();
        yield return new WaitForSeconds(1f);
        audio.PlayOneShot(tts);
        yield return new WaitForSeconds(5f);
        popUP.SetActive(false);
    }
}
