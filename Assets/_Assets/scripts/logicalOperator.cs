using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class logicalOperator : MonoBehaviour
{
    [SerializeField] private bool andResult;
    [SerializeField] private bool orResult;
    [SerializeField] private bool notResult;

    private void Start()
    {
        andResult = (true && false); // false
        orResult = (true || false); // true
        notResult = !true; //false

        Debug.Log("AND result: " + andResult);
        Debug.Log("OR result: " + orResult);
        Debug.Log("NOT result: " + notResult);
    }
}
