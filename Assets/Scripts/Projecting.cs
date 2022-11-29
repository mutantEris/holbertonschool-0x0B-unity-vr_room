using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projecting : MonoBehaviour
{
    public GameObject lights;

    public void Sparklin()
    {
        bool g = lights.activeInHierarchy;
        lights.SetActive(!g);
    }
}
