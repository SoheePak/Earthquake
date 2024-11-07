using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System.Xml;
using UnityEngine.SceneManagement;

public class DieScene : MonoBehaviour
{
    public Transform pos1;

    public Transform xrOrigin;

    public GameObject popup;

    public GameObject ob;

    public AudioClip clip;
    public AudioSource audio;
    public AudioClip voice;


    private void Start()
    {
        popup.SetActive(false);
    }

    public void ClickDie()
    {
        audio.PlayOneShot(clip);
        ob.SetActive(false);
        StartCoroutine(Move());
    }

    IEnumerator Move()
    {
        yield return new WaitForSeconds(2f);
        xrOrigin.DOMove(pos1.position, 3f);
        xrOrigin.DORotate(pos1.rotation.eulerAngles, 3f);
        yield return new WaitForSeconds(3.5f);
        popup.SetActive(true);
        audio.PlayOneShot(voice);
        yield return new WaitForSeconds(5f);
        
    }

    public void clickbefore()
    {
        audio.PlayOneShot(clip);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
