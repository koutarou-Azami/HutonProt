using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PoseManager : MonoBehaviour
{
    // ポーズ
    public enum PoseState
    {
        Move, //ポーズ無し
        Pose_of_Turbulent_hawk, // 荒ぶる鷹のポーズ
        Muay_thai, // ムエタイ
        Open_leg, // 開脚
        Shico, // 四股
        Eiffel_Tower, // エッフェル塔
        Banana, // バナナ
        AlphaF, // アルファベットF
        AlphaH, // アルファベットH
        AlphaJ, // アルファベットJ
        AlphaK, // アルファベットK
        AlphaN, // アルファベットN
        AlphaR, // アルファベットR
        AlphaU, // アルファベットU
        AlphaX, // アルファベットX
        Yoga_1, // ヨガ1
        Yoga_2, // ヨガ2
        Yoga_3, // ヨガ3
        Bodybuilding, // ボディービル
        Frog, // カエル
        Gymnastics, // 体操
        Exit, // 出口マーク
        Painfull1, // 厨二1
        Painfull2, // 厨二2
        Spuat, // しゃがみ
        Fight, // 気合
        Zenkutu, // 前屈
        Big, // 大の字
        Race_walking, // 競歩
        Happy, // 喜び
        Deformed // デフォルメ
    }
    [SerializeField, Tooltip("現在のポーズ")]
    public PoseState _Pose;
    private float _state_Timer;

    [SerializeField, Tooltip("全身でポーズをとれてるか")]
    public bool _ScoreWhole;
    [SerializeField, Tooltip("上半身でポーズをとれてるか")]
    public bool _ScoreUpper;
    [SerializeField, Tooltip("下半身でポーズをとれてるか")]
    public bool _ScoreLower;

    // Use this for initialization
    void Start()
    {
        _Pose = PoseState.Move;
        _state_Timer = 0.0f;
        
        _ScoreWhole = false;
        _ScoreUpper = false;
        _ScoreLower = false;
    }

    // Update is called once per frame
    void Update()
    {
        StatePose();
    }
    void StatePose()
    {
        switch (_Pose)
        {
            case PoseState.Move:
                Move();
                break;
            case PoseState.Pose_of_Turbulent_hawk:
                Pose_of_Turbulent_hawk();
                break;
            case PoseState.Open_leg:
                Open_leg();
                break;
            case PoseState.Shico:
                Shiko();
                break;
            case PoseState.Banana:
                Banana();
                break;
            case PoseState.AlphaH:
                AlphaH();
                break;
            case PoseState.AlphaK:
                AlphaK();
                break;
            case PoseState.AlphaX:
                AlphaX();
                break;
            case PoseState.Exit:
                Exit();
                break;
            case PoseState.Big:
                Big();
                break;
            case PoseState.Deformed:
                Deformed();
                break;
        };
        _state_Timer += Time.deltaTime;
    }
    public void Change_state(PoseState state)
    {
        _Pose = state;
        _state_Timer = 0.0f;
    }
    public void Move()
    {
        _ScoreLower = false;
        _ScoreUpper = false;
        _ScoreWhole = false;
        State_Banana._rogo_flag = false;
        State_Big._rogo_flag = false;
        State_Hawk._rogo_flag = false;
        State_Exit._rogo_flag = false;
        State_H._rogo_flag = false;
        State_K._rogo_flag = false;
        State_openLeg._rogo_flag = false;
        State_Shiko._rogo_flag = false;
        State_X._rogo_flag = false;
        State_Def._rogo_flag = false;
    }
    public void Pose_of_Turbulent_hawk()
    {
        if (_ScoreWhole == true)
        {
            State_Hawk.Additional_score(3000);
            State_Hawk._rogo_flag = true;
            Change_state(PoseState.Move);
        }
        else if (_ScoreUpper == true)
        {
            State_Hawk.Additional_score(40);
            State_Hawk._rogo_flag = true;
            Change_state(PoseState.Move);
        }
        else if (_ScoreLower == true)
        {
            State_Hawk.Additional_score(25);
            State_Hawk._rogo_flag = true;
            Change_state(PoseState.Move);
        }
    }
    public void Open_leg()
    {
        if (_ScoreWhole == true)
        {
            State_openLeg.Additional_score(2500);
            State_openLeg._rogo_flag = true;
            Change_state(PoseState.Move);
        }
        else if (_ScoreUpper == true)
        {
            State_openLeg.Additional_score(35);
            State_openLeg._rogo_flag = true;
            Change_state(PoseState.Move);
        }
        else if (_ScoreLower == true)
        {
            State_openLeg.Additional_score(50);
            State_openLeg._rogo_flag = true;
            Change_state(PoseState.Move);
        }
    }
    public void Shiko()
    {
        if (_ScoreWhole == true)
        {
            State_Shiko.Additional_score(3000);
            State_Shiko._rogo_flag = true;
            Change_state(PoseState.Move);
        }
        else if (_ScoreUpper == true)
        {
            State_Shiko.Additional_score(60);
            State_Shiko._rogo_flag = true;
            Change_state(PoseState.Move);
        }
        else if (_ScoreLower == true)
        {
            State_Shiko.Additional_score(40);
            State_Shiko._rogo_flag = true;
            Change_state(PoseState.Move);
        }
    }
    public void Banana()
    {
        if (_ScoreWhole == true)
        {
            State_Banana.Additional_score(1500);
            State_Banana._rogo_flag = true;
            Change_state(PoseState.Move);

        }
        else if (_ScoreUpper == true)
        {
            State_Banana.Additional_score(20);
            State_Banana._rogo_flag = true;
            Change_state(PoseState.Move);

        }
        else if (_ScoreLower == true)
        {
            State_Banana.Additional_score(25);
            State_Banana._rogo_flag = true;
            Change_state(PoseState.Move);

        }
    }
    public void AlphaH()
    {
        if (_ScoreWhole == true)
        {
            State_H.Additional_score(2500);
            State_H._rogo_flag = true;
            Change_state(PoseState.Move);
        }
        else if (_ScoreUpper == true)
        {
            State_H.Additional_score(50);
            State_H._rogo_flag = true;
            Change_state(PoseState.Move);
        }
        else if (_ScoreLower == true)
        {
            State_H.Additional_score(50);
            State_H._rogo_flag = true;
            Change_state(PoseState.Move);
        }
    }
    public void AlphaK()
    {
        if (_ScoreWhole == true)
        {
            State_K.Additional_score(2500);
            State_K._rogo_flag = true;
            Change_state(PoseState.Move);
        }
        else if (_ScoreUpper == true)
        {
            State_K.Additional_score(40);
            State_K._rogo_flag = true;
            Change_state(PoseState.Move);
        }
        else if (_ScoreLower == true)
        {
            State_K.Additional_score(40);
            State_K._rogo_flag = true;
            Change_state(PoseState.Move);
        }
    }
    public void AlphaX()
    {
        if (_ScoreWhole == true)
        {
            State_X.Additional_score(2000);
            State_X._rogo_flag = true;
            Change_state(PoseState.Move);
        }
        else if (_ScoreUpper == true)
        {
            State_X.Additional_score(40);
            State_X._rogo_flag = true;
            Change_state(PoseState.Move);
        }
        else if (_ScoreLower == true)
        {
            State_X.Additional_score(40);
            State_X._rogo_flag = true;
            Change_state(PoseState.Move);
        }
    }
    public void Exit()
    {
        if (_ScoreWhole == true)
        {
            State_Exit.Additional_score(3000);
            State_Exit._rogo_flag = true;
            Change_state(PoseState.Move);
        }
        else if (_ScoreUpper == true)
        {
            State_Exit.Additional_score(45);
            State_Exit._rogo_flag = true;
            Change_state(PoseState.Move);
        }
        else if (_ScoreLower == true)
        {
            State_Exit.Additional_score(45);
            State_Exit._rogo_flag = true;
            Change_state(PoseState.Move);
        }
    }
    public void Big()
    {
        if (_ScoreWhole == true)
        {
            State_Big.Additional_score(2500);
            State_Big._rogo_flag = true;
            Change_state(PoseState.Move);
        }
        else if (_ScoreUpper == true)
        {
            State_Big.Additional_score(50);
            State_Big._rogo_flag = true;
            Change_state(PoseState.Move);
        }
        else if (_ScoreLower == true)
        {
            State_Big.Additional_score(40);
            State_Big._rogo_flag = true;
            Change_state(PoseState.Move);
        }
    }
    public void Deformed()
    {
        if (_ScoreWhole == true)
        {
            State_Def.Additional_score(1000);
            State_Def._rogo_flag = true;
            Change_state(PoseState.Move);
        }
        else if (_ScoreUpper == true)
        {
            State_Def.Additional_score(1);
            State_Def._rogo_flag = true;
            Change_state(PoseState.Move);
        }
        else if (_ScoreLower == true)
        {
            State_Def.Additional_score(1);
            State_Def._rogo_flag = true;
            Change_state(PoseState.Move);
        }
    }
}