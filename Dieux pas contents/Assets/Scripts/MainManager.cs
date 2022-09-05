using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainManager : MonoBehaviour
{
    public static MainManager Instance;
    public Dialogue1 dialogue1;

    public int numeroScript;
    public int partie;


    private void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(this);

        numeroScript = 1;
        partie = 1;
    }



    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SelectionDialogue();
        }
    }


    void SelectionDialogue()
    {
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

            else
            {
                dialogue1.AvancerDialogue2();
            }
        }

        else if (numeroScript == 2)
        {
            if (partie == 1)
            {
                dialogue1.AvancerDialogue1();
            }
            else
            {
                dialogue1.AvancerDialogue2();
            }
        }
    }
}
