using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class OeufManager : MonoBehaviour
{
    public GameObject oeufObject;

    [SerializeField] private Vector3 oeufRespawn;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Ingredient"))
        {
            Destroy(col.gameObject);
            EggRespawn();

        }
    }

    public void EggRespawn()
    {
        Instantiate(oeufObject, new Vector3(Random.Range(2f,9f),oeufRespawn.y,oeufRespawn.z), transform.rotation);
        
    }
}
