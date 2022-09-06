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

    // Update is called once per frame
    void Update()
    {
        if(SceneManager.GetActiveScene().name == "Main")
            transf.position = RefCamera.Instance.transform.position * 10 + new Vector3(550, 256.799f, 0);
    }
}
