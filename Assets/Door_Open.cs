using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_Open : MonoBehaviour
{

    Animator open;
    
    // Start is called before the first frame update
    void Start()
    {
    open = GetComponent<Animator>(); 
    }

    public void Open()
    {
        bool G = open.GetBool("Station_Interacted");
        open.SetBool("Station_Interacted", !G); 
    }

    // // Update is called once per frame
    // void Update()
    // {
        
    // }
}
