using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comparsion : MonoBehaviour
{
    [SerializeField] private bool isEqual;
    [SerializeField] private bool isNotEqual;

    private void Start()
    {
        isEqual = (10 == 10); // True
        isNotEqual = (10 != 5); // True

        Debug.Log("Is Equal: " + isEqual);
        Debug.Log("Is not Equal: " + isNotEqual);
    }
}
