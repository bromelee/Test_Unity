using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changepose : MonoBehaviour {

	int pose;
	Animator myani;
	float cont = 5f;

	// Use this for initialization
	void Start () {
		pose = 0;
		myani = this.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (cont > 0) {
			cont -= Time.deltaTime;
		} else {
			pose = Random.Range (0, 4);
            myani.SetInteger("position", pose);
			cont = 5f;
		}
	}
}
