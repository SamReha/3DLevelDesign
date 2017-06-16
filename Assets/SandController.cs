using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SandController : MonoBehaviour {
    private GameObject player;
    private bool dissolving = false;
    private bool dissolved = false;
    private float dissolvePercent = 0f;
    private float dissolveSpeed = 0.01f;
    private MeshRenderer meshRenderer;
    private Color initialColor;

	// Use this for initialization
	void Start () {
        player = GameObject.Find("Sam");
        meshRenderer = GetComponentInChildren<MeshRenderer>();
        initialColor = meshRenderer.material.color;
    }

    void Update() {
        if (dissolved) return;

        if (dissolvePercent >= 1.0f) {
            dissolved = true;
            gameObject.SetActive(false);
        }
    }
	
	void FixedUpdate () {
        if (dissolved) return;

		if (player.GetComponent<BoxCollider>().bounds.Intersects(GetComponent<BoxCollider>().bounds)) {
            dissolving = true;
        }

        if (dissolving) {
            // Update dissolve percent
            dissolvePercent += dissolveSpeed;

            // Darken the material
            Material newMaterial = new Material(Shader.Find("Standard"));
            newMaterial.color = new Color(initialColor.r * (1 - dissolvePercent),
                                          initialColor.g * (1 - dissolvePercent),
                                          initialColor.b * (1 - dissolvePercent), 1);
            meshRenderer.material = newMaterial;
        }
	}
}
