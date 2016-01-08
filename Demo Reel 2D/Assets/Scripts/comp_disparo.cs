using UnityEngine;
using System.Collections;

public class comp_disparo : MonoBehaviour 
{
	public GameObject misil;
	public Transform Spawner;


	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{	
		
		//if (Input.GetKeyUp (KeyCode.Space))
		if(Input.GetKeyUp("0"))
			Instantiate (misil,Spawner.position,transform.rotation);


	
	}
}
