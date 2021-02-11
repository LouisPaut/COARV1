using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tourner : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<Transform>().Rotate(7f*Vector3.up);
        //gameObject.GetComponent<Transform>().Translate(20f * Vector3.forward);
    }
}
