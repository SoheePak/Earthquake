using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;
using Unity.XR.CoreUtils;

public class BuildingMove: MonoBehaviour
{
    public GameObject light1;
    public GameObject tv;
    public GameObject phone;
    public Transform chair;
    public Transform chairMove;
    public Transform pot;
    public Transform potMove;
    // Start is called before the first frame update
    void Start()
    {
        Builing();

        /*for (int i = 0; i < 5; i++)
        {
            transform.DOMove(new Vector3(0, 0, 1), 0.3f);
            transform.DOMove(new Vector3(0, 0, 1.53f), 0.3f);
        }*/
        //rt.DOAnchorPosY(0, 1);
        //������������ ���ڸ� �Ű���.

    }
    public void Builing()
    {
        StartCoroutine(MoveSequence());
    }
    IEnumerator MoveSequence()
    {
        tv.GetComponent<Rigidbody>().useGravity = true;
        phone.GetComponent<Rigidbody>().isKinematic = true;
        light1.GetComponent<Rigidbody>().useGravity = true;
        for (int i = 0; i < 5; i++)
        {
            yield return new WaitForSeconds(0.5f);
            transform.DOShakePosition(4,0.3f);
            /* transform.DOMove(new Vector3(0, 0, 0.5f), 1f);  
             yield return new WaitForSeconds(0.1f);
             transform.DOMove(new Vector3(0, 0, 1.53f), 1f);*/
            if (i > 3)
            {
                chair.DOMove(chairMove.position, 2f);
            }
            else
            {
                pot.DOMove(potMove.position, 2f);
            }
        }

        StartCoroutine(GameManager.instance.NextScene(7f, 3f));

        //yield return new WaitForSeconds(7f);
        //GameManager.instance.FadeOut();
        //yield return new WaitForSeconds(3f);
        //SceneManager.LoadScene(3);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
