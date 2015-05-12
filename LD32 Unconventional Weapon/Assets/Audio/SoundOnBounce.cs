using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class SoundOnBounce : MonoBehaviour {
	void OnCollisionEnter2D (Collision2D collider) {
		GetComponent<AudioSource>().Play ();
	}
}
