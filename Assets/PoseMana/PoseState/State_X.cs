using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class State_X : MonoBehaviour {
    public PoseManager _posemanager;
    /****ポーズオブジェクトの取得****/
    // ポーズオブジェクトを取得するためにCanvasを取得する
    public Canvas _PoseCanvas;
    // アルファベットXのオブジェクトを取得
    private Image _AlphaX;
    public Pose_X _alphaX;

    /*スコアオブジェクトの取得*/
    private Canvas _View;
    public ScoreView _view;

    private AudioSource _audioSource;
    // Use this for initialization
    void Start () {
        _posemanager = GameObject.FindGameObjectWithTag("Posemanager").GetComponent<PoseManager>();
        _PoseCanvas = GameObject.Find("Pose_canvas").GetComponent<Canvas>();
        _AlphaX = GameObject.Find("Pose_X").GetComponent<Image>();
        _alphaX = GameObject.Find("Pose_X").GetComponent<Pose_X>();

        _audioSource = GetComponent<AudioSource>();
        _View = GameObject.Find("ScoreCanvas").GetComponent<Canvas>();
        _view = _View.GetComponent<ScoreView>();
    }

    // Update is called once per frame
    void Update () {
        if ((_alphaX.R_arm_flag == true &&
    _alphaX.L_arm_flag == true) ||
    (_alphaX.R_leg_flag == true &&
    _alphaX.L_leg_flag == true))
        {
            _posemanager._Pose = PoseManager.PoseState.AlphaX;
        }
        /*上半身、下半身のポーズが是のとき、全身でのポーズのフラグを是に*/
        if (_alphaX.L_arm_flag == true &&
            _alphaX.R_arm_flag == true &&
            _alphaX.L_leg_flag == true &&
            _alphaX.R_leg_flag == true)
        {
            _posemanager._ScoreWhole = true;
        }

        /* 両腕の判定が是のとき、上半身ポーズのフラグを是に*/
        if (_alphaX.R_arm_flag == true &&
            _alphaX.L_arm_flag == true)
        {
            _posemanager._ScoreUpper = false;
        }

        /*両足の判定は是のとき、下半身ポーズのフラグを是に*/
        if (_alphaX.R_leg_flag == true &&
            _alphaX.L_leg_flag == true)
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
