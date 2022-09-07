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
    [SerializeField] private GameObject ange;
    
    // Start is called before the first frame update
    void Start()
    {
        MainManager.Instance = GameObject.Find("GameManager").GetComponent<MainManager>();
        ange = GameObject.Find("Ange");
        StartCoroutine(AngeDialogue(28));
        Ange.Instance.AngeApparait("Bon, ok je comprends que ca peut être déroutant d'être élu de la prophétie et sauver le monde. Les responsabilitées, le stress...",6,0,
            "Bref, oublions ce qui c'est passé avec Zeus et concentrons nous sur la nouvelle tâche a accomplir.",5,0,
            "La mission est simple, il faut mettre les oeufs dans le panier, pour se faire il faut cliquer et maintenir enfoncé le bouton gauche de la souris, puis relacher au dessus du panier",7,0,
            "CEEEPEENDAAAAAANT!",2,1,
            "Manipulez les oeufs avec êxtreme attention, car les jeter trop fort au sol va certainement les casser. Bonne chance élu de la prophétie, je crois en vous!",6,0);
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
            panier.localScale = Vector3.MoveTowards(panier.localScale,new Vector3(3, 2, 1),1*Time.unscaledDeltaTime);
            panier.position = Vector3.MoveTowards(panier.position,new Vector3(panier.position.x, -2, 0),0.5f*Time.unscaledDeltaTime);
        }
        else if (score is >= 6 and < 9)
        {
            panier.localScale = Vector3.MoveTowards(panier.localScale,new Vector3(5, 2, 1),1*Time.unscaledDeltaTime);
        }
        else if (score == 9)
        {
            panier.localScale = Vector3.MoveTowards(panier.localScale,new Vector3(11, 3, 1),1*Time.unscaledDeltaTime);
            panier.position = Vector3.MoveTowards(panier.position,new Vector3(panier.position.x, -1, 0),0.2f*Time.unscaledDeltaTime);
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

    public IEnumerator AngeDialogue(float time)
    {
        yield return new WaitForSeconds(time);
        EggRespawn();
    }
}
