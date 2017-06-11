using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonBack : MonoBehaviour {

    public LevelselectManager _levelmanager;
    public Scene_manager _scenemanager;

    public GameObject _tutorial;
    public GameObject _levelselect;
	// Use this for initialization
	void Start () {
        _tutorial = GameObject.Find("Tutorial");
        _levelselect = GameObject.Find("LevelSelectUI");
	}
	
	// Update is called once per frame
	void Update () {
    }

    public void OnBack()
    {
        _levelmanager.Levelselect_state = LevelselectManager.LevelselectState.LevelSelect;
    }
}
