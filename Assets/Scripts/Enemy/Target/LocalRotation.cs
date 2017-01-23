using UnityEngine;
using System.Collections;

public class LocalRotation : MonoBehaviour {
	private float zAngle = 0;
	private Vector3 Angles;

	void Update () {
		transform.eulerAngles = new Vector3(0,0,zAngle);
		zAngle++;
	}
}
