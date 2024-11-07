using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;


public class RemoteControl : MonoBehaviour
{
    public VideoPlayer video;
    
    private void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            video.Pause();
            Invoke("SceneChange", 3f);
        }
    }

    private void SceneChange()
    {
        SceneManager.LoadScene(2);
    }

}
