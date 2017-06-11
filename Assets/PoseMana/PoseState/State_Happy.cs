using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class State_Happy : MonoBehaviour {
    public PoseManager _posemanager;
    /****ポーズオブジェクトの取得****/
    // ポーズオブジェクトを取得するためにCanvasを取得する
    public Canvas _PoseCanvas;
    // 喜びのオブジェクトを取得
    private Image _Happy;
    public Pose_Happy _happy;

    /*スコアオブジェクトの取得*/
    private Canvas _View;
    public ScoreView _view;

    private AudioSource _audioSource;
    // Use this for initialization
    void Start () {
        _posemanager = GameObject.FindGameObjectWithTag("Posemanager").GetComponent<PoseManager>();
        _PoseCanvas = GameObject.Find("Pose_canvas").GetComponent<Canvas>();
        _Happy = GameObject.Find("Pose_Happy").GetComponent<Image>();
        _happy = GameObject.Find("Pose_Happy").GetComponent<Pose_Happy>();

        _audioSource = GetComponent<AudioSource>();
        _View = GameObject.Find("ScoreCanvas").GetComponent<Canvas>();
        _view = _View.GetComponent<ScoreView>();
    }

    // Update is called once per frame
    void Update () {
        if ((_happy.R_arm_flag == true &&
    _happy.L_arm_flag == true) ||
    (_happy.R_leg_flag == true &&
    _happy.L_leg_flag == true))
        {
            _posemanager._Pose = PoseManager.PoseState.Happy;
        }
        if (_happy.L_arm_flag == true &&
            _happy.R_arm_flag == true &&
            _happy.L_leg_flag == true &&
            _happy.R_leg_flag == true)
        {
            _posemanager._ScoreWhole = true;
        }

        if (_happy.R_arm_flag == true &&
            _happy.L_arm_flag == true)
        {
            _posemanager._ScoreUpper = true;
        }
        if (_happy.R_leg_flag == true &&
            _happy.L_leg_flag == true)
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
