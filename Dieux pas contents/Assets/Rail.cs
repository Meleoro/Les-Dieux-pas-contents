using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[ExecuteInEditMode]
public class Rail : MonoBehaviour
{
    private Transform[] nodes;

    void Start()
    {
        nodes = GetComponentsInChildren<Transform>();


    }


    public Vector3 LinearPosition(int segment, int next, float ration)
    {
        Vector3 p1 = Jesus.Instance.transform.position;
        Vector3 p2 = nodes[next].position;

        Vector3 direction = p2 - p1;

        return direction;
    }


    /*private void OnDrawGizmos()
    {
        for (int i = 0; i < nodes.Length - 1; i++)
        {
            Handles.DrawDottedLine(nodes[i].position, nodes[i + 1].position, 3.0f);
        }
    }*/
}
