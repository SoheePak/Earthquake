using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DuggMove : MonoBehaviour
{
    public Transform xrOrigin;

    public Transform move;

    public GameObject dugg;

    public GameObject textUI;
    public GameObject shutdownUI;

    public AudioClip clip;
    public AudioSource audio;
    // Start is called before the first frame update
    private void Start()
    {
        textUI.SetActive(true);
        shutdownUI.SetActive(false);
    }

    public void Duggfront()
    {
        StartCoroutine(MoveDu());
    }

    public void downButton()
    {
        audio.PlayOneShot(clip);
        dugg.GetComponent<Animator>().SetTrigger("isOff");
        //StartCoroutine(WaitTime());
        shutdownUI.SetActive(false);
        StartCoroutine(GameManager.instance.NextScene(5f, 3f));

    }

    IEnumerator MoveDu()
    {
        
        audio.PlayOneShot(clip);
        textUI.SetActive(false);
        yield return new WaitForSeconds(2f);
        xrOrigin.DOMove(move.position, 1f);
        xrOrigin.DORotate(move.rotation.eulerAngles, 1f);
        yield return new WaitForSeconds(1f);
        shutdownUI.SetActive(true);
    }

    /*IEnumerator WaitTime()
    {
        shutdownUI.SetActive(false);
        yield return new WaitForSeconds(5f); 
        GameManager.instance.FadeOut();
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene(5);
    }*/
}
