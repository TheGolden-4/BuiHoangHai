using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doWhileEx : MonoBehaviour
{
    [SerializeField] private int i = 0;
    private void Start()
    {
        do
        {
            Debug.Log("i: " + i);
            i++;
        } while (i < 5);
    }
}
