using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollCube : MonoBehaviour
{

    public Rigidbody rb;
    public float force = 300;
    public float rotation = 600;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Random.Range(100, 500)
            rb.AddForce(new Vector3(0, force, 0));
            rb.AddTorque(new Vector3(Random.Range(0,rotation), Random.Range(0, rotation), Random.Range(0,rotation)));
        }
    }
}
