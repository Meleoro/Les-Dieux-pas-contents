using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jesus : MonoBehaviour
{
    public Rail rail;

    private int currentSeg;
    private float transition;
    private bool isCOmpleted;

    private int nextSeg;

    public float JesusSpeed;

    private void Start()
    {
        currentSeg = 1;
    }


    private void Update()
    {
        if (currentSeg == 6)
            nextSeg = 1;

        else
            nextSeg = currentSeg + 1;

        MouvementsJesus();
    }

    public void MouvementsJesus()
    {
        transition += Time.deltaTime * JesusSpeed;

        if(transition > 1)
        {
            transition = 0;
            currentSeg++;
        }

        if (currentSeg == 7)
            currentSeg = 1;

        transform.position = rail.LinearPosition(currentSeg, nextSeg, transition);
    }
}
