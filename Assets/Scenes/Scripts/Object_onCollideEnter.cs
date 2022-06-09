using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_onCollideEnter : MonoBehaviour
{

    public Material newMaterial;
    public GameObject objectToChange;

    void OnTriggerEnter(Collider other)
    {
        this.GetComponent<MeshRenderer>().material = newMaterial;
    }



}
