using System.Collections;
using UnityEngine;

public class Enemy_Atteck : MonoBehaviour {

	private bool _atteck = false;

	private IEnumerator coroutine;
	private float _attecking;

	public bool atteck { get { return _atteck; } }
	
	void Start() {
		coroutine = RandomNum(3.0f);
		StartCoroutine(coroutine);
	}

	void Update() {
		if (_attecking < 5) {
			_atteck = true;
		} else {
			_atteck = false;
		}
	}

	private IEnumerator RandomNum(float waitTime) {
		while(true) {
			_attecking = Random.Range(0, 10);
			yield return new WaitForSeconds(3);
		}
	}
}
