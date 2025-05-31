using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Input : MonoBehaviour
{
    [SerializeField] private string playerName;
    private void Start()
    {
        Debug.Log("Player name: " + playerName);
    }
}
