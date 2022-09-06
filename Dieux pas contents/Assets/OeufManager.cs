using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
using TMPro;

public class OeufManager : MonoBehaviour
{
    public GameObject oeufObject;

    [SerializeField] private Vector3 oeufRespawn;
    
    [SerializeField] private TextMeshProUGUI text;
    [SerializeField] private TextMeshProUGUI texte;
    public Transform panier;
    
    public int score;
    [SerializeField] private int badScore;
    public GameOver loseCondition;
    private bool newScene;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        texte.text = badScore + "/3";
        text.text = score + "/10";
        if (badScore == 3)
        {
            loseCondition.Lost = true;
        }

        if (score is >= 3 and < 6)
        {
            panier.localScale = new Vector3()
        }
        else if (score is >= 6 and < 9)
        {
            
        }
        else if (score == 9)
        {
            
        }
        else if (score == 10 && !newScene)
        {
            newScene = true;
            MainManager.Instance.partie++;
            MainManager.Instance.SelectionDialogue();
            Debug.Log(MainManager.Instance.partie);
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Ingredient"))
        {
            Destroy(col.gameObject);
            EggRespawn();
            badScore++;
        }
    }

    public void EggRespawn()
    {
        Instantiate(oeufObject, new Vector3(Random.Range(2f,9f),oeufRespawn.y,oeufRespawn.z), transform.rotation);
        
    }
}
