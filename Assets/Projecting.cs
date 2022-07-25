using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projecting : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject lights;

    public void Sparklin()
    {
        bool g = lights.activeInHierarchy;
        lights.SetActive(!g);

    }

    // Update is called once per frame
    //void Update()
    //{
    //  
    //}
}
