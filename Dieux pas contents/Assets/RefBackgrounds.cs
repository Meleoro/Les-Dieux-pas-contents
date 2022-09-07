using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RefBackgrounds : MonoBehaviour
{
    public static RefBackgrounds Instance;

    public GameObject ciel;
    public GameObject cielDark;

    public GameObject resto;
    public GameObject restoFlou;

    public GameObject valhalla;
    public GameObject valhallaFlou;

    public GameObject ilePaques;

    public GameObject champs;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;

        else
            Destroy(this);
    }
}
