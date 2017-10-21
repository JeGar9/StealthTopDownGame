using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinamicSpotlight : MonoBehaviour {

    private Light spotlight;
    private float defaultRange;

	// Use this for initialization
	void Start () {
        spotlight = this.GetComponent<Light>();
        defaultRange = spotlight.range;
	}
	
	// Update is called once per frame
	void Update () {

    }
}
