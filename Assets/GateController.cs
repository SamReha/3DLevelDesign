using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateController : MonoBehaviour {
    private GameObject gate;

    public Transform endMarker;
    private Vector3 speed = new Vector3(0, 0.07f, 0);
    public AudioSource sfx;

    private float startTime;
    private float journeyLength;
    private bool active = false;

    void Start() {
        gate = GameObject.Find("Gate/gate");
    }

    void FixedUpdate() {
        if (active) {
            gate.transform.position -= speed;
            //Debug.Log(speed);

            if (gate.transform.position.y <= endMarker.position.y) {
                gate.SetActive(false);
            }
        }
    }
    
    public void trigger() {
        startTime = Time.time;
        active = true;
        sfx.Play();
    }
}
