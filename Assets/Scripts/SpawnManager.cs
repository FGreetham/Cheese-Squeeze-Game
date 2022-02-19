using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class SpawnManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DestroyCheese()
    {
        //if(Input.GetMouseButtonDown())
        {
            Invoke("DestroyCheese", 0);
                }

        /*TO DO!
        Raycast code...
        if(hit.collider.gameObject.tag == "Cheese")
    { activate the loading bar UI... initiate method that clicks the loading bar... if reaches the top - destroy cheese */

        
    }
}

