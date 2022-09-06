using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Ingredient : MonoBehaviour
{
    public SpawnIngredients spawn;
    //[SerializeField] private SpriteRenderer sprite;
    public Sprite objectBien;
    public Sprite objectPasBien;
    public int objectType;

    public Rigidbody2D rb;

    [SerializeField] private float delay;
    // Start is called before the first frame update
    void Start()
    {
        spawn = GameObject.Find("DESPAWN").GetComponent<SpawnIngredients>();
        rb.gravityScale = 0;
        objectType = Random.Range(1, 6);
        if (objectType is >= 1 and < 4)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = objectBien;
        }
        else if(objectType >= 4)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = objectPasBien;
        }
        delay = spawn.spawnDelay;
    }

    // Update is called once per frame
    void Update()
    {
        if(delay >= 0)
        {
            delay -= Time.deltaTime;
        }
        else
        {
            rb.gravityScale = 0.5f;
        }
    }
}
