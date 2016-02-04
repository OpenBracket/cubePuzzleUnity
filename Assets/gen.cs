using UnityEngine;
using System.Collections;

public class gen : MonoBehaviour {

	public GameObject block;
	Vector3 offset;

	// Use this for initialization
	void Start () {

		offset = new Vector3 (0,0,0);

		for (int i = 0; i < 100; i++) {

			Instantiate (block, transform.position + offset, Quaternion.identity);
			offset += new Vector3 (1.25f,0,0);

		}
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
