using UnityEngine;
using System.Collections;

public class comp_noSalga : MonoBehaviour 
{
	public float max_x = 6.81F;
	public float min_x = -6.81F;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (transform.position.x < min_x) 
		{ 
			transform.position= new Vector3 ( min_x , transform.position.y , transform.position.z);
		}
		if (transform.position.x > max_x) 
		{ 
			transform.position= new Vector3 ( max_x , transform.position.y , transform.position.z);
		}
	
	}
}
