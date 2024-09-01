using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    [SerializeField] public Renderer rend;
    private int i = 3;

    void Update()
    {
        Debug.Log($"{gameObject.name}:{i}");
        i++;
    }
}


