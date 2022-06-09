using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeColourOnHover : MonoBehaviour
{

    private Renderer renderer;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void onHoverEnter()
    {
        renderer.material.color = Color.red; 
    }

    void onHoverExit()
    {
        renderer.material.color = Color.blue;
    }
}
