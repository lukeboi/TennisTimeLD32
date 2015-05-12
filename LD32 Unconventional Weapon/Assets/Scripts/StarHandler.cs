using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class StarHandler : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter2D(Collision2D collider) {
		if (collider.gameObject.tag == "Star") {
			Application.LoadLevel(0);
			GetComponent<AudioSource>().Play();
		}
	}
}
