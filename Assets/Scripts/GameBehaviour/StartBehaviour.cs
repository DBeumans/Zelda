using UnityEngine;

public class StartBehaviour : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space)) {
			 Application.LoadLevel(1);
		}
	}
}
