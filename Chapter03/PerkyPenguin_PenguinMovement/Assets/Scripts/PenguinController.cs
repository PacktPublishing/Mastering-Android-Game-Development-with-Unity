using UnityEngine;
using System.Collections;

public class PenguinController : MonoBehaviour {

	public float jetpackForce = 75.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate()
	{
		bool jetpackActive = Input.GetButton ("Fire1");
		if (jetpackActive == true) {
			this.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jetpackForce));
		}
	}
}
