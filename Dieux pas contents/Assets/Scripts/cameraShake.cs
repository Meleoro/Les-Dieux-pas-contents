using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cameraShake : MonoBehaviour
{
    public RectTransform transf;

    public static cameraShake Instance;


    void Start()
    {
        transf = GetComponent<RectTransform>();

        Instance = this;
    }


    void Update()
    {
        if(SceneManager.GetActiveScene().name == "Main")
            transf.localPosition = RefCamera.Instance.transform.position * 8;
    }
}
