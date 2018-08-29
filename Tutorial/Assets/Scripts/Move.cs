using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

	public float deltaRotate = 30;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		Rotate();
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
	
}
