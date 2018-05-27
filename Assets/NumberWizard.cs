using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int min, max;

    // Use this for initialization
    void Start()
    {
        min = 1;
        max = 1000;

        Debug.Log("Welcome to Number Wizard, hooman!");
        Debug.Log("Think of a number between " + min + " and " + max + ", hooman.");
        Debug.Log("But don't tell me! Now let's play...");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
