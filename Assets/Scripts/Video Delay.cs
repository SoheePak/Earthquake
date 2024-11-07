using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class VideoDelay : MonoBehaviour
{
    public VideoPlayer video;
    public GameObject popup;
    public AudioClip clip;
    public AudioSource audio;
    public void delayvideo()
    {
        video.Play();
        StartCoroutine(voice());
    }

    private void Start()
    {
        popup.SetActive(false);
        Invoke("delayvideo", 4f);
    }

    IEnumerator voice()
    {
        yield return new WaitForSeconds(4f);
        audio.PlayOneShot(clip);
        yield return new WaitForSeconds(3f);
        popup.SetActive(true);
    }
}
