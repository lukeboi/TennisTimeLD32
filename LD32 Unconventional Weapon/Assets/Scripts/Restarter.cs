using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class Restarter : MonoBehaviour {
	public void USEME() {
		GetComponent<AudioSource>().Play ();
		Application.LoadLevel(Application.loadedLevel);
	}
	public void USEMEEXIT() {
		GetComponent<AudioSource>().Play ();
		Application.LoadLevel(0);
	}
}
