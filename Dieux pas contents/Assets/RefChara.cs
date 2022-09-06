using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RefChara : MonoBehaviour
{
    public static RefChara Instance;

    public GameObject zeusHeureux;
    public GameObject zeusColere;

    public GameObject odinHeureux;
    public GameObject odinColere;


    private void Awake()
    {
        if (Instance == null)
            Instance = this;

        else
            Destroy(this);
    }
}
