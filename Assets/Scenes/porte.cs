using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class porte : MonoBehaviour
{
    private bool ouvert = false;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("e"))
        {
            if (ouvert)
            {
                gameObject.GetComponent<Transform>().Rotate(-90f * Vector3.up);
            }
            else
            {
                gameObject.GetComponent<Transform>().Rotate(90f * Vector3.up);
            }
            ouvert = !ouvert;
        }

    }
}
