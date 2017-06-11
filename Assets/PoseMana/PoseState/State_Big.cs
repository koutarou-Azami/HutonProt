using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class State_Big : MonoBehaviour {
    public PoseManager _posemanager;
    /****ポーズオブジェクトの取得****/
    // ポーズオブジェクトを取得するためにCanvasを取得する
    public Canvas _PoseCanvas;
    // 大の字のオブジェクトを取得
    private Image _Big;
    public Pose_big _big;
    
    /*スコアオブジェクトの取得*/
    private Canvas _View;
    public ScoreView _view;

    // Use this for initialization
    void Start ()
    {
        _posemanager = GameObject.FindGameObjectWithTag("Posemanager").GetComponent<PoseManager>();
        _PoseCanvas = GameObject.Find("Pose_canvas").GetComponent<Canvas>();
        _Big = GameObject.Find("Pose_Big").GetComponent<Image>();
        _big = GameObject.Find("Pose_Big").GetComponent<Pose_big>();

        _View = GameObject.Find("ScoreCanvas").GetComponent<Canvas>();
        _view = GameObject.Find("ScoreCanvas").GetComponent<ScoreView>();
    }
	
	// Update is called once per frame
	void Update () {
        if ((_big.R_arm_flag == true &&
            _big.L_arm_flag == true) ||
            (_big.R_leg_flag == true &&
            _big.L_leg_flag == true))
        {
            _posemanager._Pose = PoseManager.PoseState.Big;
        }
        /*上半身、下半身のポーズが是のとき、全身でのポーズのフラグを是に*/
        if (_big.L_arm_flag == true &&
            _big.R_arm_flag == true &&
            _big.L_leg_flag == true &&
            _big.R_leg_flag == true)
        {
            _posemanager._ScoreWhole = true;
        }
        /* 両腕の判定が是のとき、上半身ポーズのフラグを是に*/
        if (_big.R_arm_flag == true &&
            _big.L_arm_flag == true)
        {
            _posemanager._ScoreUpper = true;
        }
        /*両足の判定は是のとき、下半身ポーズのフラグを是に*/
        if (_big.R_leg_flag == true &&
            _big.L_leg_flag == true)
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