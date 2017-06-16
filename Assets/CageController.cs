using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CageController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void trigger() {
        gameObject.SetActive(false);
    }
}
