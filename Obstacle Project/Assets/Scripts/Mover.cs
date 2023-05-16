using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;
using Input = UnityEngine.Input;

public class Mover : MonoBehaviour
{
    //These Variables Change our Movement speed

    [SerializeField] float moveSpeed = 10f;
	
	 // Start is called before the first frame update
	void Start()
    {
       

        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(0.01f, 0f, 0f);


        MovePlayer();

        //PrintInstruction();


    }


    void PrintInstruction()
    {
	    Debug.Log("Welcome to the game");
	    Debug.Log("Move your player with WASD or arrow keys");
	    Debug.Log("Don't Hit the walls");
    }

    void MovePlayer()
    {
	    float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
	    float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

	    transform.Translate(xValue, 0, zValue);
	}
}
