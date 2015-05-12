using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {

	public Rigidbody2D body;
	public Animator anim;
	public Rigidbody2D tennisball;
	float indata;

	int lastdir = 1;



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		indata = Mathf.Round(Input.GetAxis("Horizontal"));

		if (Input.GetKeyDown(KeyCode.Space)) {
			Rigidbody2D ball = Instantiate(tennisball) as Rigidbody2D;
			ball.position = new Vector2(body.position.x + (.4f * -lastdir), body.position.y-.1f);
			ball.AddForce(new Vector2(100 * -lastdir, 0));
		}

		if(indata == -1) {
			anim.SetInteger("DirectionID", 0);
			lastdir = 1; 
		}
		if(indata == 1) {
			anim.SetInteger("DirectionID", 4);
			lastdir = -1; 
		}

		if(indata == 0 && lastdir == 1) { 
			anim.SetInteger("DirectionID", 1); 
		}
		if (indata == 0 && lastdir == -1) {
			anim.SetInteger ("DirectionID", 2);
		}
		body.AddForce (new Vector2(Input.GetAxis ("Horizontal")*20, 0));
	
	}
}
