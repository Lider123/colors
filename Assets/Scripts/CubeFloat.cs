using UnityEngine;
using System.Collections;

public class CubeFloat : MonoBehaviour {

	public float speed, tilt;
	private Vector3 target;

	// Use this for initialization
	void Start () {
		target = new Vector3 (0, 1.3f, 0);
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Vector3.MoveTowards (transform.position, target, speed * Time.deltaTime);
		if (transform.position == target && target.y != 0) {
			target.y = 0;
		} else if (transform.position == target && target.y == 0) {
			target.y = 1.3f;
		}

		transform.Rotate (Vector3.up * Time.deltaTime * tilt);
	}
}
