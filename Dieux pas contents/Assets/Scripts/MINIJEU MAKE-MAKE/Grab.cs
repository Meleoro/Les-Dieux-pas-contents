using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grab : MonoBehaviour
{
    [SerializeField] private Vector3 mousePos;

    [SerializeField] private Vector3 grabPos;
    [SerializeField] private Vector3 dir;
    [SerializeField] private Rigidbody2D grabbedRb;

    [SerializeField] private bool grabbing = false;
    [SerializeField] private float forceMultiplier = 100;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = Input.mousePosition;
        mousePos.z = Camera.main.nearClipPlane + 9.7f;
        grabPos = Camera.main.ScreenToWorldPoint(mousePos);
        transform.position = grabPos;
        

        if (grabbing)
        {
            dir = grabPos - grabbedRb.gameObject.transform.position;
            Vector3 NormalizedDir = dir.normalized;
            Debug.Log("Mouse" + grabPos);
            Debug.Log("Oeuf" + grabbedRb.position);
            grabbedRb.gravityScale = 0;
            grabbedRb.velocity *= 0.95f;
            grabbedRb.AddForce(NormalizedDir * (forceMultiplier * (Vector2.Distance(grabPos,grabbedRb.gameObject.transform.position))));
        }
        if (grabbing && Input.GetKeyUp(KeyCode.Mouse0))
        {
            grabbedRb.gravityScale = 1;
            grabbing = false;
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Ingredient"))
        {
            Debug.Log("oui!");
        }
        if (other.gameObject.CompareTag("Ingredient") && Input.GetKey(KeyCode.Mouse0))
        {
            grabbing = true;
            grabbedRb = other.gameObject.GetComponent<Rigidbody2D>();
        }
    }
}
