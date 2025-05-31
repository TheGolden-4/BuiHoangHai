using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfElse : MonoBehaviour
{
    [SerializeField] private int score = 85;
    private void Start()
    {
        if(score > 90)
        {
            Debug.Log("Grade: A");
        }
        else if(score >= 80)
        {
            Debug.Log("Grade: B");
        }
        else
        {
            Debug.Log("Grade: C");
        }
    }
}
