using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    

    public AudioClip clip;
    public AudioSource audio;

    public GameObject choiceImage;      // 선택창 UI
    public GameObject GRAP;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        GRAP = GameObject.FindGameObjectWithTag("GRAP");
    }
    public GameObject image;            // 끄는 이미지
    public Image fadeImage;
    void Start()
    {
        if (SceneManager.sceneCount == 5)
        {
            choiceImage.SetActive(true);
        }


    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex > 5)
        {
            Destroy(GRAP.gameObject);
        }
    }

    public void FadeOut()               // 불끄는 이미지
    {
        image.SetActive(true);
        fadeImage.color = new Color(0, 0, 0, 0);

        fadeImage.DOFade(1.0f, 3.0f);
    }

    public void LoadScene(int index)
    {
        StartCoroutine(SceneLoad1(index));
        
    }
    public IEnumerator NextScene(float t1, float t2)
    {
        yield return new WaitForSeconds(t1);
        GameManager.instance.FadeOut();
        yield return new WaitForSeconds(t2);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    IEnumerator SceneLoad1(int index)
    {
        GameManager.instance.FadeOut();
        yield return new WaitForSeconds(1f);
        audio.PlayOneShot(clip);
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(index);
    }
}

