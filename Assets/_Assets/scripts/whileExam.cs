using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whileExam : MonoBehaviour
{
    private void Start()
    {
        int i = 0;
        while (i < 5)
        {
            Debug.Log("i: " + i);
            i++;
        }
    }
}
