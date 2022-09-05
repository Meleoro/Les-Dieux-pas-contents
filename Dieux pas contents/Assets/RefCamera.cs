using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class RefCamera : MonoBehaviour
{
    public static RefCamera Instance;
    public Camera camera;


    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        camera = GetComponent<Camera>();
    }

    public void CameraShake(float duration, float amplitude)
    {
        camera.DOShakePosition(duration, amplitude);
    }
}
