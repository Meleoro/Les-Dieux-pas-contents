using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RefChara : MonoBehaviour
{
    public static RefChara Instance;

    public GameObject zeusHeureux;
    public GameObject zeusColere;


    private void Awake()
    {
        Instance = this;
    }
}
