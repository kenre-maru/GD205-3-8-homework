using UnityEngine;
using System.Collections;

public class BasicConditionals : MonoBehaviour {

	public GameObject freeweed;
	public GameObject winner;
	bool iGotTheKeys;
	bool won;

	// Use this for initialization
	void Start () {
	
		iGotTheKeys = false;
		won = false;
		winner.transform.position = new Vector3 (2, 1, 100);
	
	}
	
	// Update is called once per frame
	void Update () {

		//Controls
		if (Input.GetKeyDown (KeyCode.W)){
            freeweed.transform.position += new Vector3 (0, 0, 1);
			Debug.Log ("lol you good bro keep going");
	    }	

		if (Input.GetKeyDown (KeyCode.A)){
			freeweed.transform.position += new Vector3 (-1, 0, 0);
			Debug.Log ("lol you good bro keep going");
		}	

		if (Input.GetKeyDown (KeyCode.S)){
			freeweed.transform.position += new Vector3 (0, 0, -1);
			Debug.Log ("lol you good bro keep going");
		}	
			
		if (Input.GetKeyDown (KeyCode.D)){
			freeweed.transform.position += new Vector3 (1, 0, 0);
			Debug.Log ("lol you good bro keep going");
		}

		// Out Of Bounds Coords
		if (freeweed.transform.position.z == -1) {
			freeweed.transform.position = new Vector3 (-1, 1, 0);
		}

		if  (freeweed.transform.position.z == 8) {
			freeweed.transform.position = new Vector3 (-1, 1, 0);
		}

		if (freeweed.transform.position.x == -2) {
			freeweed.transform.position = new Vector3 (-1, 1, 0);
		}

		if (freeweed.transform.position.x == 7) {
			freeweed.transform.position = new Vector3 (-1, 1, 0);
		}

		//Hazard Coll.
		if (freeweed.transform.position == new Vector3 (6, 1, 4)) {
			freeweed.transform.position = new Vector3 (-1, 1, 0);
		}

		if (freeweed.transform.position == new Vector3 (5, 1, 4)) {
			freeweed.transform.position = new Vector3 (-1, 1, 0);
		}

		if (freeweed.transform.position == new Vector3 (5, 1, 5)) {
			freeweed.transform.position = new Vector3 (-1, 1, 0);
		}

		if (freeweed.transform.position == new Vector3 (4, 1, 1)) {
			freeweed.transform.position = new Vector3 (-1, 1, 0);
		}

		if (freeweed.transform.position == new Vector3 (3, 1, 0)) {
			freeweed.transform.position = new Vector3 (-1, 1, 0);
		}

		if (freeweed.transform.position == new Vector3 (3, 1, 1)) {
			freeweed.transform.position = new Vector3 (-1, 1, 0);
		}

		if (freeweed.transform.position == new Vector3 (1, 1, 2)) {
			freeweed.transform.position = new Vector3 (-1, 1, 0);
		}

		if (freeweed.transform.position == new Vector3 (1, 1, 4)) {
			freeweed.transform.position = new Vector3 (-1, 1, 0);
		}

		if (freeweed.transform.position == new Vector3 (0, 1, 6)) {
			freeweed.transform.position = new Vector3 (-1, 1, 0);
		}

		if (freeweed.transform.position == new Vector3 (3, 1, 6)) {
			freeweed.transform.position = new Vector3 (-1, 1, 0);
		}

		if (freeweed.transform.position == new Vector3 (3, 1, 5)) {
			freeweed.transform.position = new Vector3 (-1, 1, 0);
		}

		//Conditional Item (Key)
		if (freeweed.transform.position == new Vector3 (6, 1, 5)) {
			iGotTheKeys = true;
		}

		//Winning Condition
		if (freeweed.transform.position == new Vector3 (4, 1, 0)) {
			winner.transform.position = new Vector3 (5, 1, 3);
			Debug.Log ("DAMNN SON WERE U FIND DIS!!!!! WINNER!!!!!!!!");
		}
  }
}
