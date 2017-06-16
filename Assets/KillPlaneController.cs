using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillPlaneController : MonoBehaviour {
    public GameObject player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (player.GetComponent<BoxCollider>().bounds.Intersects(GetComponent<BoxCollider>().bounds)) {
            SceneManager.LoadScene(0);
        }
	}
}
