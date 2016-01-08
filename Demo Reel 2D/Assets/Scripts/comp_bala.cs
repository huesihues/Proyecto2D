using UnityEngine;
using System.Collections;

public class comp_bala : MonoBehaviour 
{
	public float balaSpeed;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.Translate (Vector2.up * balaSpeed * Time.deltaTime);
		Destroy (gameObject, 2f);

	}
}
