using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainSceneController : MonoBehaviour
   
{


    [SerializeField] private InputField inputFieldTermA, inputFieldTermB;
    [SerializeField] private Text txtResult;
    public bool testing;



   

    // Update is called once per frame
    public int CheckAddition(int summandA, int summandB)
    {
        int result = 0;
        testing = false;

        result = summandA + summandB;
        Debug.Log(result);

        return result;
    }

    // Start is called before the first frame update
    void Start()
    {
        

        int val1 = CheckAddition(1, 2);
        int val2 = CheckAddition(100, 200);
        int val3 = CheckAddition(123, 212);

        Debug.Log("val1: " + val1 + " val2 + val3: " + (val2 + val3));
        Debug.Log("Nach Methodenaufruf sg. call");
        Debug.Log("Frohe Weihnachten");

    }


    public void GetValues()
    {
        string termA, termB;
        termA = inputFieldTermA.text;
        termB = inputFieldTermB.text;

        Debug.Log("Methode GetValues wird ausgeführt: " + CheckAddition(int.Parse(termA), int.Parse(termB)));
    }


    void Update()
    {
        if (testing)
        {
            GetValues();
        }
    }
}


