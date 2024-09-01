using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    [SerializeField] private Renderer rend;
    private int i = 3;

    void Update()
    {
        Debug.Log($"{gameObject.name}:{i}");
        i++;
    }
}


