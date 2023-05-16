using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{

	private void OnCollisionEnter(Collision other)
	{
		//  who collided with walls
		//if(transform.gameObject.name == "Player")

		Debug.Log("Bumped into a wall");
		// Saying if it is the player that hits the obstacles
		if (other.gameObject.tag == "Player")
		{
		//Accessing MeshRender Component and then material and color in i and make it equal to red 
		GetComponent<MeshRenderer>().material.color = Color.red;

			// Changing the obstacles tag to Hit while hitting them 
		      gameObject.tag = "Hit";
		}



	}
}
