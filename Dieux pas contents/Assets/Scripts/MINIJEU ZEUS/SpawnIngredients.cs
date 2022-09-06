using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SpawnIngredients : MonoBehaviour
{
    public float spawnHeight = 6;

    public float spawnX;

    public float spawnDelay;

    [SerializeField] private float maxDelay = 10;

    [SerializeField] private float baseDelay = 1;

    [SerializeField] private Rigidbody2D ingredient;
    public int score;
    public int badScore;
    public MainManager manager;
    public GameOver loseCondition;

    [SerializeField] private float startDelay;

    [SerializeField] private TextMeshProUGUI text;
    [SerializeField] private TextMeshProUGUI texte;
    // Start is called before the first frame update
    void Start()
    {
        manager = GameObject.Find("GameManager").GetComponent<MainManager>();
        loseCondition = GameObject.Find("GameManager").GetComponent<GameOver>();
        startDelay = baseDelay;
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        texte.text = badScore + "/10";
        if (baseDelay >= 0)
        {
            baseDelay -= Time.deltaTime;
        }
        else
        {
            baseDelay = startDelay;
            spawnX = Random.Range(-10, 11);
            spawnDelay = Random.Range(0, maxDelay) + baseDelay;
            Instantiate(ingredient, new Vector3(spawnX,spawnHeight,0), gameObject.transform.rotation);
        }

        if (badScore == 10)
        {
            //Gameover
            Debug.Log("Cessez le tryhard!");
            loseCondition.Lost = true;
        }

        if (score == 5)
        {
            manager.partie++;
            Debug.Log("c'est perdu!");
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ingredient"))
        {
            Destroy(other.gameObject);
            score++;
            text.text = score + "/5";
        }
    }
    
}
