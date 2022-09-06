using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class RefCamera : MonoBehaviour
{
    public static RefCamera Instance;
    public Camera camera;

    public bool shaking;


    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        camera = GetComponent<Camera>();
    }

    private void Update()
    {
        /*if(!shaking)
            transform.position = new Vector3(0, 0, 0);

        else*/

    }

    public void CameraShake(float duration, float amplitude)
    {
        shaking = true;

        camera.DOShakePosition(duration, amplitude, 10, 90, true);
    }
}
