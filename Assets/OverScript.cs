using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(GameObject.Find("ScriptController").GetComponent<SleepGageScript>().sleepImage == null)
        {

        }
	}
}
