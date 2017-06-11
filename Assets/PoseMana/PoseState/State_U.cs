﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class State_U : MonoBehaviour {
    public PoseManager _posemanager;
    /****ポーズオブジェクトの取得****/
    // ポーズオブジェクトを取得するためにCanvasを取得する
    public Canvas _PoseCanvas;
    // アルファベットUのオブジェクトを取得
    private Image _AlphaU;
    public Pose_U _alphaU;

    /*スコアオブジェクトの取得*/
    private Canvas _View;
    public ScoreView _view;

    private AudioSource _audioSource;
    // Use this for initialization
    void Start () {
        _posemanager = GameObject.FindGameObjectWithTag("Posemanager").GetComponent<PoseManager>();
        _PoseCanvas = GameObject.Find("Pose_canvas").GetComponent<Canvas>();
        _AlphaU = GameObject.Find("Pose_U").GetComponent<Image>();
        _alphaU = GameObject.Find("Pose_U").GetComponent<Pose_U>();

        _audioSource = GetComponent<AudioSource>();
        _View = GameObject.Find("ScoreCanvas").GetComponent<Canvas>();
        _view = _View.GetComponent<ScoreView>();
    }
	
	// Update is called once per frame
	void Update () {
        if ((_alphaU.R_arm_flag == true &&
            _alphaU.L_arm_flag == true) ||
            (_alphaU.R_leg_flag == true &&
            _alphaU.L_leg_flag == true))
        {
            _posemanager._Pose = PoseManager.PoseState.AlphaU;
        }
        /* 両腕の判定が是のとき、上半身ポーズのフラグを是に*/
        if (_alphaU.R_arm_flag == true &&
            _alphaU.L_arm_flag == true)
        {
            _posemanager._ScoreUpper = true;
        }
        /* 両腕の判定が是のとき、上半身ポーズのフラグを是に*/
        if (_alphaU.R_arm_flag == true &&
            _alphaU.L_arm_flag == true)
        {
            _posemanager._ScoreUpper = true;
        }
        /*両足の判定は是のとき、下半身ポーズのフラグを是に*/
        if (_alphaU.R_leg_flag == true &&
            _alphaU.L_leg_flag == true)
        {
            _posemanager._ScoreLower = true;
        }
    }
    public static void Additional_score(int Value)
    {
        var _audio = GameObject.Find("PoseState").GetComponent<AudioSource>();
        var _View = GameObject.Find("ScoreCanvas").GetComponent<Canvas>();
        var _view = _View.GetComponent<ScoreView>();

        ScoreManager._score = Value;
        ScoreManager._totalscore += Value;
        _view.View(ScoreManager._score);
        _audio.PlayOneShot(_audio.clip);
    }
}
