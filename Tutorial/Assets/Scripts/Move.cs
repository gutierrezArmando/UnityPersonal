using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

	public float deltaRotate = 30f;
	public float deltaMovement = 10f;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		Rotate();
		Movement();
	}

	void Rotate()
	{
		if (Input.GetKey(KeyCode.Q))
		{
			transform.Rotate(new Vector3(0f, deltaRotate, 0f) * Time.deltaTime);
		}
		else
		{
			if (Input.GetKey(KeyCode.E))
			{
				transform.Rotate(new Vector3(0f, -deltaRotate, 0f) * Time.deltaTime);
			}
		}
	}


	void Movement()
	{
		if (Input.GetKey(KeyCode.UpArrow))
		{
			transform.Translate(Vector3.up * deltaMovement * Time.deltaTime);
		}
		else
		{
			if (Input.GetKey(KeyCode.DownArrow))
			{
				transform.Translate(Vector3.down * deltaMovement * Time.deltaTime);
			}
		}
	}
}
