using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HeadTouch : MonoBehaviour
{
    public GameObject pillow;
    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Pillow")
        {
            pillow.SetActive(false);
            StartCoroutine(GameManager.instance.NextScene(2f, 3f));
            //StartCoroutine(NextScene());
        }
    }

    /*IEnumerator NextScene()
    {
        yield return new WaitForSeconds(2f);
        GameManager.instance.FadeOut();
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene(4);
    }*/
}
