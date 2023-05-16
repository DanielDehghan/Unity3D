using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{


	[SerializeField]  float xAngle = 0;
	[SerializeField]  float yAngle = 0.5f;
	[SerializeField]  float zAngle = 0;

	// Update is called once per frame
	void Update()
    {
        //We use Rotate Method to do the Rotation

        transform.Rotate(xAngle, yAngle, zAngle);
        
    }
}
