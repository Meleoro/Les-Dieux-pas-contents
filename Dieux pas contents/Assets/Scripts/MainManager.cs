using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class MainManager : MonoBehaviour
{
    public static MainManager Instance;
    public Dialogue1 dialogue1;
    public Dialogue2 dialogue2;

    public int numeroScript;
    public int partie;


    private void Awake()
    {
        DontDestroyOnLoad(this);

        if (Instance == null)
            Instance = this;

        else
            Destroy(gameObject);

        numeroScript = 1;
        partie = 1;
    }



    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SelectionDialogue();
        }

        if (Input.GetKeyDown(KeyCode.AltGr))
        {
            partie += 1;

            SelectionDialogue();
        }
    }


    public void SelectionDialogue()
    {
        // ZEUS
        if (numeroScript == 1)
        {
            if(partie == 1)
            {
                dialogue1.AvancerDialogue1();
            }

            else if(partie == 2)
            {
                SceneManager.LoadScene("Oscar");
            } 

            else if(partie == 3)
            {
                SceneManager.LoadScene("Main");
                partie += 1;
            }

            else
            {
                dialogue1.AvancerDialogue2();
            }
        }


        // ODIN
        else if (numeroScript == 2)
        {
            if (partie == 1)
            {
                dialogue2.AvancerDialogue1();
            }

            else if (partie == 2)
            {
                SceneManager.LoadScene("Oscar");
            }

            else if (partie == 3)
            {
                SceneManager.LoadScene("Main");
                partie += 1;
            }

            else
            {
                dialogue2.AvancerDialogue2();
            }
        }
    }


    public void OuvertureScene()
    {
        ReferencesUI.Instance.fondu.
    }
}
