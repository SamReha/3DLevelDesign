using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherButtonController : MonoBehaviour {
    //public GameObject[] targets;
    public GameObject target;
    public GameObject[] interactors;

    private bool up = true;
    private BoxCollider triggerVolume;
    private GameObject button_up;

    // Use this for initialization
    void Start() {
        triggerVolume = GameObject.Find("Button (1)/triggerVolume").GetComponent<BoxCollider>();
        button_up = GameObject.Find("Button (1)/switch_up");
    }

    // Update is called once per frame
    void Update() {
        if (!up) return; // If we're in the down state, don't bother checking

        foreach (GameObject interactor in interactors) {
            if (interactor.GetComponent<BoxCollider>().bounds.Intersects(triggerVolume.bounds)) {
                target.GetComponent<CageController>().trigger();
                button_up.SetActive(false);
                up = false;
            }
        }
    }
}
