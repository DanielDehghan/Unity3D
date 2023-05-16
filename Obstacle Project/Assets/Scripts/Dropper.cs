using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    // Making a variable of type renderer
    // because we are going to use and access it frequently
	 MeshRenderer renderer;
	 Rigidbody rigidbody;
	[SerializeField]  float timeToWait = 2f;
    // Start is called before the first frame update
    void Start()
    {

        renderer = GetComponent<MeshRenderer>();
        rigidbody = GetComponent<Rigidbody>();

        renderer.enabled = false;
        rigidbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {

        //saying after 3 seconds do this
	    if (Time.time > timeToWait)
	    {
            renderer.enabled = true;
            rigidbody.useGravity = true;
		}

	}
}
