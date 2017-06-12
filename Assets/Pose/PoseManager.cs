using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PoseManager : MonoBehaviour
{

    public GameObject _L_Shoulder; //左肩を取得
    public GameObject _L_Elbow; //左ひじを取得
    public GameObject _R_Shoulder; //右手首を取得
    public GameObject _R_Elbow; //右ひじを取得
    public GameObject _L_HipJoint; //左股関節を取得
    public GameObject _L_Knee; //左ひざを取得
    public GameObject _R_HipJoint; //右股関節を取得
    public GameObject _R_Knee; //右ひざを取得

    // 上半身のポーズが取れているか
    public bool _UpperBody = false;
    // 右腕の角度が一致
    public bool _RArm;
    // 下半身のポーズが取れているか
    public bool _LowerBody = false;
    // 左股関節の角度が一致
    public bool _LHip;
    //  ポーズのパーツとどれだけそろっているか
    public int _PartCount = 0;

    // ポーズ
    public enum PoseState
    {
        None, //ポーズ無し
        Pose_of_Turbulent_hawk, // 荒ぶる鷹のポーズ
        Muay_thai, // ムエタイ
        Open_leg, // 開脚
        Chico, // 四股
        The_Eiffel_Tower, // エッフェル塔
        Banana, // バナナ
        F, // アルファベットF
        H, // アルファベットH
        J, // アルファベットJ
        K, // アルファベットK
        N, // アルファベットN
        R, // アルファベットR
        U, // アルファベットU
        X, // アルファベットX
        Yoga_1, // ヨガ1
        Yoga_2, // ヨガ2
        Yoga_3, // ヨガ3
        Bodybuilding, // ボディービル
        Frog, // カエル
        Gymnastics, // 体操
        Exit, // 出口マーク
        Sophomoric_1, // 厨二1
        Sophomoric_2, // 厨二2
        Conveni, // しゃがみ
        Yell, // 気合
        Bend_forward, // 前屈
        Sprawled, // 大の字
        Race_walking, // 競歩
        Joy, // 喜び
        Deformed // デフォルメ
    }
    [SerializeField, Tooltip("現在のポーズ")]
    public PoseState _Pose;

    private ScoreAdd _score;
    private Chance _chance;
    private Score _scores;
    private Pause_H _pause_h;
    // Use this for initialization
    void Start()
    {
        _L_Shoulder = GameObject.Find("Player_LeftHand1");
        _L_Elbow = GameObject.Find("Player_LeftHand2");
        _L_HipJoint = GameObject.Find("Player_LeftLeg1");
        _L_Knee = GameObject.Find("Player_LeftLeg2");
        _R_Shoulder = GameObject.Find("Player_RightHand1");
        _R_Elbow = GameObject.Find("Player_RightHand2");
        _R_HipJoint = GameObject.Find("Player_RightLeg1");
        _R_Knee = GameObject.Find("Player_RightLeg2");

        _Pose = PoseState.None;

        _RArm = false;
        _LHip = false;

        _score = GetComponent<ScoreAdd>();
        _chance = GameObject.Find("Chance").GetComponent<Chance>();
        _scores = GameObject.Find("Score").GetComponent<Score>();
        _pause_h = GameObject.Find("Pause_H").GetComponent<Pause_H>();
    }

    // Update is called once per frame
    void Update()
    {
        // 各関節のZ軸の参照
        float _rLs = _L_Shoulder.transform.localEulerAngles.y; // 左肩
        float _rLe = _L_Elbow.transform.localEulerAngles.y; // 左ひじ
        float _rLk = _L_Knee.transform.localEulerAngles.y; // 左ひざ
        float _rLh = _L_HipJoint.transform.localEulerAngles.y; // 左股関節
        float _rRs = _R_Shoulder.transform.localEulerAngles.y; //右肩
        float _rRe = _R_Elbow.transform.localEulerAngles.y; // 右ひじ
        float _rRk = _R_Knee.transform.localEulerAngles.y; // 右ひざ
        float _rRh = _R_HipJoint.transform.localEulerAngles.y;
        Debug.Log(_rLs);
        //// 肘、ひざのy軸の参照
        //float _rLey = _L_Elbow.transform.localEulerAngles.y;
        //float _rLky = _L_Knee.transform.localEulerAngles.y;
        //float _rRey = _R_Elbow.transform.localEulerAngles.y;
        //float _rRky = _R_Knee.transform.localEulerAngles.y;

        Pose();
        _chance.DisplayChance();
        _scores.Fade();

        if(_rLs >= 80.0f && _rLs <= 100.0f)
        {
            if(_rLe >= -10 && _rLe <= 10)
            {
                _pause_h.L_arm_flag = true;
            }
            else
            {
                _pause_h.L_arm_flag = false;
            }
        }
        else
        {
            _pause_h.L_arm_flag = false;
        }

        if (_rRs >= 260.0f && _rRs <= 280.0f)
        {
            if (_rRe >= -10 && _rRe <= 10)
            {
                _pause_h.R_arm_flag = true;
            }
            else
            {
                _pause_h.R_arm_flag = false;
            }
        }
        else
        {
            _pause_h.R_arm_flag = false;
        }

        if (_rLh >= 80.0f && _rLh <= 100.0f)
        {
            if (_rLk >= -10 && _rLk <= 10)
            {
                _pause_h.L_leg_flag = true;
            }
            else
            {
                _pause_h.L_arm_flag = false;
            }
        }
        else
        {
            _pause_h.L_leg_flag = false;
        }

        if (_rRh >= 260.0f && _rRh <= 280.0f)
        {
            if (_rRk >= -10 && _rRk <= 10)
            {
                _pause_h.R_leg_flag = true;
            }
            else
            {
                _pause_h.R_leg_flag = false;
            }
        }
        else
        {
            _pause_h.R_leg_flag = false;
        }

        if(_pause_h.L_arm_flag == true ||
            _pause_h.R_arm_flag == true ||
            _pause_h.L_leg_flag == true ||
            _pause_h.R_leg_flag == true)
        {
            _PartCount = 1;
        }
        if (_pause_h.L_arm_flag == false &&
            _pause_h.R_arm_flag == false &&
            _pause_h.L_leg_flag == false &&
            _pause_h.R_leg_flag == false)
        {
            _PartCount = 0;
            _Pose = PoseState.None;
        }
        
        if (_pause_h.L_arm_flag == true && _pause_h.R_arm_flag == true)
        {
            _UpperBody = true;
            _Pose = PoseState.H;
        }
        else
        {
            _UpperBody = false;
        }
        if(_pause_h.L_leg_flag == true && _pause_h.R_leg_flag == true)
        {
            _LowerBody = true;
            _Pose = PoseState.H;
        }
        else
        {
            _LowerBody = false;
        }

        if(_pause_h.R_arm_flag == true ||
            _pause_h.L_arm_flag == true)
        {
            _RArm = true;
        }
        else
        {
            _RArm = false;
        }
        if(_pause_h.L_leg_flag == true ||
            _pause_h.R_leg_flag == true)
        {
            _LHip = true;
        }
        else
        {
            _LHip = false;
        }

        if (_UpperBody == true)
        {
            _scores._L_Addscore = true;
        }
        else if (_UpperBody == false)
        {
            _scores._L_Addscore = false;
        }
        if (_LowerBody == true)
        {
            _scores._R_Addscore = true;
        }
        else if (_LowerBody == false)
        {
            _scores._R_Addscore = false;
        }
    }

    public void Pose()
    {
        switch (_Pose)
        {
            case PoseState.Pose_of_Turbulent_hawk:
                _score.AddScore();
                break;
            case PoseState.Muay_thai:
                _score.AddScore();
                break;
            case PoseState.Open_leg:
                _score.AddScore();
                break;
            case PoseState.Chico:
                _score.AddScore();
                break;
            case PoseState.The_Eiffel_Tower:
                _score.AddScore();
                break;
            case PoseState.Banana:
                _score.AddScore();
                break;
            case PoseState.F:
                _score.AddScore();
                break;
            case PoseState.H:
                _score.AddScore();
                break;
            case PoseState.J:
                _score.AddScore();
                break;
            case PoseState.K:
                _score.AddScore();
                break;
            case PoseState.N:
                _score.AddScore();
                break;
            case PoseState.R:
                _score.AddScore();
                break;
            case PoseState.U:
                _score.AddScore();
                break;
            case PoseState.X:
                _score.AddScore();
                break;
            case PoseState.Yoga_1:
                _score.AddScore();
                break;
            case PoseState.Yoga_2:
                _score.AddScore();
                break;
            case PoseState.Yoga_3:
                _score.AddScore();
                break;
            case PoseState.Bodybuilding:
                _score.AddScore();
                break;
            case PoseState.Frog:
                _score.AddScore();
                break;
            case PoseState.Gymnastics:
                _score.AddScore();
                break;
            case PoseState.Exit:
                _score.AddScore();
                break;
            case PoseState.Sophomoric_1:
                _score.AddScore();
                break;
            case PoseState.Sophomoric_2:
                _score.AddScore();
                break;
            case PoseState.Conveni:
                _score.AddScore();
                break;
            case PoseState.Yell:
                _score.AddScore();
                break;
            case PoseState.Bend_forward:
                _score.AddScore();
                break;
            case PoseState.Sprawled:
                _score.AddScore();
                break;
            case PoseState.Race_walking:
                _score.AddScore();
                break;
            case PoseState.Joy:
                _score.AddScore();
                break;
            case PoseState.Deformed:
                _score.AddScore();
                break;
        }
    }
}