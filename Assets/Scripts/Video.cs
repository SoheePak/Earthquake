using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Video : MonoBehaviour
{
    public GameObject rawImage;
    public GameObject video;
    private int videoPlay=0;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void play()
    {
        if(videoPlay==0)
        {
            video.SetActive(true);
            rawImage.SetActive(true);
            videoPlay = 1;
        }
        else
        {
            video.SetActive(false);
            rawImage.SetActive(false);
            videoPlay = 0;
        }

    }
}
