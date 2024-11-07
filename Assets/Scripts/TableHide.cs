using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class TableHide : MonoBehaviour
{
    public Transform xrOrigin;
    public GameObject HideUI;
    public GameObject DeadUI;

    public Transform move1;
    public Transform move2;
    public Transform move3;
    public Transform move4;
    public Transform move5;

    void Start()
    {
        RunOrHide();
    }

    void RunOrHide()
    {
        HideUI.SetActive(true);
    }

    public void RunOut()
    {
        HideUI.SetActive(false);
        DeadUI.SetActive(true);

    }

    public void Hide()
    {
        HideUI.SetActive(false);

        StartCoroutine(HideOnTable());

    }

    IEnumerator HideOnTable()
    {
        yield return new WaitForSeconds(0.8f);
        xrOrigin.DOMove(move1.position, 1.0f);
        xrOrigin.DORotate(move1.rotation.eulerAngles, 1.0f);
        yield return new WaitForSeconds(0.8f);
        xrOrigin.DOMove(move2.position, 1.0f);
        xrOrigin.DORotate(move2.rotation.eulerAngles, 1.0f);
        yield return new WaitForSeconds(0.8f);
        xrOrigin.DOMove(move3.position, 1.0f);
        xrOrigin.DORotate(move3.rotation.eulerAngles, 1.0f);
        yield return new WaitForSeconds(0.8f);
        xrOrigin.DOMove(move4.position, 1.0f);
        xrOrigin.DORotate(move4.rotation.eulerAngles, 1.0f);
        yield return new WaitForSeconds(0.8f);
        xrOrigin.DOMove(move5.position, 1.0f);
        xrOrigin.DORotate(move5.rotation.eulerAngles, 1.0f);
        yield return new WaitForSeconds(0.8f);
        xrOrigin.DORotate(xrOrigin.rotation.eulerAngles + Vector3.up * 180, 1.0f);

        StartCoroutine(GameManager.instance.NextScene(2f, 3f));

    }
    
}
