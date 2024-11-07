using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dontdestroy : MonoBehaviour
{
    GameObject[] objects;
    void Awake()
    {
        objects = GameObject.FindGameObjectsWithTag("GRAP");

        if(objects.Length > 1)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);
    }
}
