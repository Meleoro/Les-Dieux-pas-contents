using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Ingredient : MonoBehaviour
{
    public SpawnIngredients spawn;
    //[SerializeField] private SpriteRenderer sprite;
    public Sprite pates;
    public Sprite steak;
    public Sprite tomate;
    public Sprite sacDePoubelle;
    public Sprite arreteDePoisson;
    public SpriteRenderer sprite;
    public int objectType;

    public Rigidbody2D rb;

    [SerializeField] private float delay;
    // Start is called before the first frame update
    void Start()
    {
        spawn = GameObject.Find("DESPAWN").GetComponent<SpawnIngredients>();
        rb.gravityScale = 0;
        objectType = Random.Range(1, 6);
        if (objectType == 1 )
        {
            sprite.sprite = pates;
        }
        else if(objectType == 2)
        {
            sprite.sprite = steak;
        }
        else if(objectType == 3)
        {
            sprite.sprite = tomate;
        }
        else if(objectType == 4)
        {
            sprite.sprite = sacDePoubelle;
        }
        else if(objectType == 5)
        {
            sprite.sprite = arreteDePoisson;
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
