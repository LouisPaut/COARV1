using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deplacement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(Z))
        {
           gameObject.GetComponent<Transform>().translate(1f * Vector3.forward);
        }
        if (Input.GetKeyDown(Q))
        {
            gameObject.GetComponent<Transform>().rotate(1f * Vector3.right);
        }
        if (Input.GetKeyDown(D))
        {
            gameObject.GetComponent<Transform>().rotate(1f * Vector3.left);
        }
        if (Input.GetKeyDown(S))
        {
            gameObject.GetComponent<Transform>().translate(1f * Vector3.backward);
        }
        
        //gameObject.GetComponent<Transform>().Translate(20f * Vector3.forward);
    }
}

