using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodeBlock_AnswerTrigger : MonoBehaviour
{

    Vector3 blockTransform;

    private void OnTriggerEnter(Collider other)
    {
        // attempts to get the position of the other object on collider intersect
        other.transform.position = blockTransform;
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
