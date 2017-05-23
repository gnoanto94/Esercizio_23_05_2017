using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManageLight : MonoBehaviour {

private bool interruttore;
public Light myLight;
public Image image;
public Sprite lightOn, lightOff;

	// Use this for initialization
	void Start () {
		interruttore = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void toggleLight(){
		if(!interruttore){
			myLight.enabled = true;
			interruttore = true;
			image.GetComponent<Image>().sprite = lightOn;
		} else {
			myLight.enabled = false;
			interruttore = false;
			image.GetComponent<Image>().sprite = lightOff;
		}
	}
}
