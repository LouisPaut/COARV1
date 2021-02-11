using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deplacement : MonoBehaviour
{
    public float speed = 1.0f;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float translation = 12.0f;
        //float translation = Input.GetAxis("Vertical") * speed;
        //translation *= Time.deltaTime;
        if (Input.GetKey("z"))
        {
 
            gameObject.GetComponent<Transform>().Translate(0.2f * Vector3.forward);
        }
        if (Input.GetKey("q"))
        {
            gameObject.GetComponent<Transform>().Rotate(1f * Vector3.down);
        }
        if (Input.GetKey("d"))
        {
            gameObject.GetComponent<Transform>().Rotate(1f * Vector3.up);
        }
        if (Input.GetKey("s"))
        {
            gameObject.GetComponent<Transform>().Translate(-0.2f * Vector3.forward);
        }
        if (Input.GetKeyDown("f"))
        {
            gameObject.transform.position = new Vector3(32, 11, -32);
            gameObject.transform.rotation = Quaternion.AngleAxis(0, Vector3.up );
        }
        if (Input.GetKeyDown("space"))
        {
            gameObject.transform.position = new Vector3(0, 5, 0) + gameObject.transform.position;
        }
        if (Input.GetKey("r"))
        {
            gameObject.transform.rotation = Quaternion.AngleAxis(0, Vector3.up);
        }
        //gameObject.GetComponent<Transform>().Translate(20f * Vector3.forward);
    }
}

