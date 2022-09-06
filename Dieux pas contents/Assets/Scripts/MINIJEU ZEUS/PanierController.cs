using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanierController : MonoBehaviour
{
    [SerializeField] private Vector3 panierPos;
    [SerializeField] private Vector3 worldPos;
    public BoxCollider2D collider;
    public Rigidbody2D rb;
    public SpawnIngredients scoreManager;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        panierPos = Input.mousePosition;
        panierPos.z = Camera.main.nearClipPlane + 9.7f;
        worldPos = Camera.main.ScreenToWorldPoint(panierPos);

        var transformPosition = transform.position;
        transformPosition.x = worldPos.x;
        transform.position = transformPosition;
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Ingredient"))
        {
            if (col.gameObject.GetComponent<Ingredient>().objectType is >= 1 and < 4)
            {
                Destroy(col.gameObject);
                scoreManager.badScore++;
            }
            else
            {
                Destroy(col.gameObject);
                scoreManager.score++;
            }
        }
    }
}
