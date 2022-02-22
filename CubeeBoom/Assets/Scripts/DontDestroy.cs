using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroy : MonoBehaviour
{
    int _scene;
    private void Start()
    {
        _scene = SceneManager.GetActiveScene().buildIndex;
    }
    private void Awake()
    {
        if (_scene <= 1)
        {
            GameObject[] objs = GameObject.FindGameObjectsWithTag("Music");
            if (objs.Length > 1)
            {
                Destroy(this.gameObject);
            }
            DontDestroyOnLoad(this.gameObject);
        }
    }
}
