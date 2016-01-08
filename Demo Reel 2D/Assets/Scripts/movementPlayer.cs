using UnityEngine;
using System.Collections;

public class movementPlayer : MonoBehaviour 
{
	public Transform canon;
	public float speed;
	public float trunSpeed;
	// Use this for initialization
	void Start () 
	{
		canon = GameObject.Find ("Canon").GetComponent<Transform> ();;
	}
	
	// Update is called once per frame
	void Update () 
	{	
		if(Input.GetKey("a"))
		{
			transform.Translate (Vector2.left * speed * Time.deltaTime);
		}
		if(Input.GetKey("d"))
		{
			transform.Translate (Vector2.right * speed * Time.deltaTime);
		}
		if(Input.GetKey(KeyCode.RightArrow))
			canon.transform.Rotate(Vector3.back, trunSpeed * Time.deltaTime);
		if(Input.GetKey(KeyCode.LeftArrow))
			canon.transform.Rotate(Vector3.forward, trunSpeed * Time.deltaTime);

		if (canon.transform.rotation.z >= 0.5)
			canon.transform.rotation = new Quaternion (0, 0, 0.5f,1);

		if (canon.transform.rotation.z <= -0.5)
			canon.transform.rotation = new Quaternion (0, 0, -0.5f,1);

			
	
	}
}
