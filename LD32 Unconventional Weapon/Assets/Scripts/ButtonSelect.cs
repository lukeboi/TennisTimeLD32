using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class ButtonSelect : MonoBehaviour {
	public int levelToLoad;

	public void USEME() {
		GetComponent<AudioSource>().Play ();
		Application.LoadLevel (levelToLoad);
	}
}
