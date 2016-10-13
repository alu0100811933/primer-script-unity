using UnityEngine;
using System.Collections;

public class RockCollider : MonoBehaviour {

	// Use this for initialization
	void Start () {

		Choque.CambiarC += Cambio;
	}

	void Cambio() {
	// Destroy (this.gameObject);
		this.gameObject.transform.Rotate(Vector3.up, 10, Space.World);

		Color newColor = new Color (Random.value, Random.value, Random.value);

		this.gameObject.GetComponent<Renderer> ().material.color = newColor;
		//GetComponent<Renderer>().material.color = Color.white;
	}
	// Update is called once per frame
	void Update () {
	}
}
