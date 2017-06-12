using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreAdd : MonoBehaviour
{
    // スコアの文字に関するスクリプトの取得
    Score _score;
    // ポーズの判定に関するスクリプトの取得
    PoseManager _pose;
    // スコア
    public static int _Score;
    [SerializeField, Tooltip("スコアに加算されたか")]
    public bool _ScoreAddition;
    bool _Wholebody;
    [SerializeField, Tooltip("スコア獲得したときにスコアをフェードを呼ぶ")]
    public bool _GetScore;

    public static int Score()
    {
        return _Score;
    }
    // Use this for initialization
    void Start()
    {
        _pose = GetComponent<PoseManager>();
        _Score = 0;
        _ScoreAddition = false;
        _Wholebody = false;
        _GetScore = false;

        _score = GameObject.Find("Score").GetComponent<Score>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(_Score);
        
        if (_ScoreAddition == false)
        {
            if (_pose._UpperBody == false && _pose._LowerBody == false)
            {
                _ScoreAddition = true;
            }
            if (_pose._Pose == PoseManager.PoseState.None)
            {
                _ScoreAddition = true;
            }
            _Wholebody = true;
        }
    }
    
    void Additional_score(int Value)
    {
        _Score += Value;
    }
    public void AddScore()
    {
        if (_pose._Pose == PoseManager.PoseState.Pose_of_Turbulent_hawk)
        {
            if (_pose._UpperBody == true)
            {
                if(_ScoreAddition == true)
                {
                    Additional_score(40);
                    _ScoreAddition = false;
                    _GetScore = true;
                    _score._Score.text = _Score.ToString() + "PointGet";
                }
            }
            if (_pose._LowerBody == true)
            {
                if(_ScoreAddition == true)
                {
                    Additional_score(25);
                    _ScoreAddition = false;
                    _GetScore = true;
                    _score._Score.text = _Score.ToString() + "PointGet";
                }
            }
            if (_pose._LowerBody == true && _pose._UpperBody == true)
            {
                Additional_score(3000);
                _pose._UpperBody = false;
                _pose._LowerBody = false;
                _pose._Pose = PoseManager.PoseState.None;
                _ScoreAddition = true;
                _GetScore = true;
                _score._Score.text = _Score.ToString() + "PointGet";
            }
        }
        else if (_pose._Pose == PoseManager.PoseState.Muay_thai)
        {
            if (_pose._UpperBody == true)
            {
                if (_ScoreAddition == true)
                {
                    Additional_score(30);
                    _ScoreAddition = false;
                    _GetScore = true;
                    _score._Score.text = _Score.ToString() + "PointGet";
                }
            }
            if (_pose._LowerBody == true)
            {
                if (_ScoreAddition == true)
                {
                    Additional_score(25);
                    _ScoreAddition = false;
                    _GetScore = true;
                    _score._Score.text = _Score.ToString() + "PointGet";
                }
            }
            if (_pose._UpperBody == true && _pose._LowerBody == true)
            {
                Additional_score(2000);
                    _pose._UpperBody = false;
                    _pose._LowerBody = false;
                    _pose._Pose = PoseManager.PoseState.None;
                _ScoreAddition = true;
                _GetScore = true;
                _score._Score.text = _Score.ToString() + "PointGet";
            }
        }
        else if (_pose._Pose == PoseManager.PoseState.Open_leg)
        {
            if (_pose._UpperBody == true)
            {
                if (_ScoreAddition == true)
                {
                    Additional_score(35);
                    _ScoreAddition = false;
                    _GetScore = true;
                    _score._Score.text = _Score.ToString() + "PointGet";
                }
            }
            if (_pose._LowerBody == true)
            {
                if (_ScoreAddition == true)
                {
                    Additional_score(50);
                    _ScoreAddition = false;
                    _GetScore = true;
                    _score._Score.text = _Score.ToString() + "PointGet";
                }
            }
            if (_pose._UpperBody == true && _pose._LowerBody == true)
            {
                Additional_score(2500);
                _pose._UpperBody = false;
                _pose._LowerBody = false;
                _GetScore = true;
                _score._Score.text = _Score.ToString() + "PointGet";
            }
        }
        else if (_pose._Pose == PoseManager.PoseState.Chico)
        {
            if (_pose._UpperBody == true)
            {
                if (_ScoreAddition == true)
                {
                    Additional_score(60);
                    _ScoreAddition = false;
                    _GetScore = true;
                    _score._Score.text = _Score.ToString() + "PointGet";
                }
            }
            if (_pose._LowerBody == true)
            {
                if (_ScoreAddition == true)
                {
                    Additional_score(40);
                    _ScoreAddition = false;
                    _GetScore = true;
                    _score._Score.text = _Score.ToString() + "PointGet";
                }
            }
            if (_pose._UpperBody == true && _pose._LowerBody == true)
            {
                Additional_score(3000);
                _pose._UpperBody = false;
                _pose._LowerBody = false;
                _GetScore = true;
                _pose._Pose = PoseManager.PoseState.None;
                _score._Score.text = _Score.ToString() + "PointGet";
            }
        }
        else if (_pose._Pose == PoseManager.PoseState.The_Eiffel_Tower)
        {
            if (_pose._UpperBody == true)
            {
                if (_ScoreAddition == true)
                {
                    Additional_score(35);
                    _ScoreAddition = false;
                    _GetScore = true;
                    _score._Score.text = _Score.ToString() + "PointGet";
                }
            }
            if (_pose._LowerBody == true)
            {
                if (_ScoreAddition == true)
                {
                    Additional_score(40);
                    _ScoreAddition = false;
                    _GetScore = true;
                    _score._Score.text = _Score.ToString() + "PointGet";
                }
            }
            if (_pose._UpperBody == true && _pose._LowerBody == true)
            {
                Additional_score(1500);
                _pose._UpperBody = false;
                _pose._LowerBody = false;
                _GetScore = true;
                _pose._Pose = PoseManager.PoseState.None;
                _score._Score.text = _Score.ToString() + "PointGet";
            }
        }
        else if (_pose._Pose == PoseManager.PoseState.Banana)
        {
            if (_pose._UpperBody == true)
            {
                if (_ScoreAddition == true)
                {
                    Additional_score(20);
                    _ScoreAddition = false;
                    _GetScore = true;
                    _score._Score.text = _Score.ToString() + "PointGet";
                }
            }
            if (_pose._LowerBody == true)
            {
                if (_ScoreAddition == true)
                {
                    Additional_score(25);
                    _ScoreAddition = false;
                    _GetScore = true;
                    _score._Score.text = _Score.ToString() + "PointGet";
                }
            }
            if (_pose._UpperBody == true && _pose._LowerBody == true)
            {
                Additional_score(1500);
                _pose._UpperBody = false;
                _pose._LowerBody = false;
                _GetScore = true;
                _pose._Pose = PoseManager.PoseState.None;
                _score._Score.text = _Score.ToString() + "PointGet";
            }
        }
        else if (_pose._Pose == PoseManager.PoseState.F)
        {
            if (_pose._UpperBody == true)
            {
                if (_ScoreAddition == true)
                {
                    Additional_score(45);
                    _ScoreAddition = false;
                    _GetScore = true;
                    _score._Score.text = _Score.ToString() + "PointGet";
                }
            }
            if (_pose._LowerBody == true)
            {
                if (_ScoreAddition == true)
                {
                    Additional_score(45);
                    _ScoreAddition = false;
                    _GetScore = true;
                    _score._Score.text = _Score.ToString() + "PointGet";
                }
            }
            if (_pose._UpperBody == true && _pose._LowerBody == true)
            {
                Additional_score(3000);
                _pose._UpperBody = false;
                _pose._LowerBody = false;
                _GetScore = true;
                _pose._Pose = PoseManager.PoseState.None;
                _score._Score.text = _Score.ToString() + "PointGet";
            }
        }
        else if (_pose._Pose == PoseManager.PoseState.H)
        {
            if (_pose._UpperBody == true)
            {
                if (_ScoreAddition == true)
                {
                    Additional_score(50);
                    _ScoreAddition = false;
                    _GetScore = true;
                    _score._Score.text = _Score.ToString() + "PointGet";
                }
            }
            if (_pose._LowerBody == true)
            {
                if(_ScoreAddition == true)
                {
                    Additional_score(50);
                    _ScoreAddition = false;
                    _GetScore = true;
                    _score._Score.text = _Score.ToString() + "PointGet";
                }
            }
            if (_pose._UpperBody == true && _pose._LowerBody == true)
            {
                if(_Wholebody == true)
                {
                    Additional_score(2500);
                    _pose._UpperBody = false;
                    _pose._LowerBody = false;
                    _GetScore = true;
                    _pose._Pose = PoseManager.PoseState.None;
                    _score._Score.text = _Score.ToString() + "PointGet";
                    _Wholebody = false;
                }
            }
        }
        else if (_pose._Pose == PoseManager.PoseState.J)
        {
            if (_pose._UpperBody == true)
            {
                if (_ScoreAddition == true)
                {
                    Additional_score(35);
                    _ScoreAddition = false;
                    _GetScore = true;
                    _score._Score.text = _Score.ToString() + "PointGet";
                }
            }
            if (_pose._LowerBody == true)
            {
                if (_ScoreAddition == true)
                {
                    Additional_score(25);
                    _ScoreAddition = false;
                    _GetScore = true;
                    _score._Score.text = _Score.ToString() + "PointGet";
                }
            }
            if (_pose._UpperBody == true && _pose._LowerBody == true)
            {
                Additional_score(2000);
                _pose._UpperBody = false;
                _pose._LowerBody = false;
                _GetScore = true;
                _pose._Pose = PoseManager.PoseState.None;
                _score._Score.text = _Score.ToString() + "PointGet";
            }
        }
        else if (_pose._Pose == PoseManager.PoseState.K)
        {
            if (_pose._UpperBody == true)
            {
                if (_ScoreAddition == true)
                {
                    Additional_score(40);
                    _ScoreAddition = false;
                    _GetScore = true;
                    _score._Score.text = _Score.ToString() + "PointGet";
                }
            }
            if (_pose._LowerBody == true)
            {
                if (_ScoreAddition == true)
                {
                    Additional_score(40);
                    _ScoreAddition = false;
                    _GetScore = true;
                    _score._Score.text = _Score.ToString() + "PointGet";
                }
            }
            if (_pose._UpperBody == true && _pose._LowerBody == true)
            {
                Additional_score(2500);
                _pose._UpperBody = false;
                _pose._LowerBody = false;
                _GetScore = true;
                _pose._Pose = PoseManager.PoseState.None;
                _score._Score.text = _Score.ToString() + "PointGet";
            }
        }
        else if (_pose._Pose == PoseManager.PoseState.N)
        {
            if (_pose._UpperBody == true)
            {
                if (_ScoreAddition == true)
                {
                    Additional_score(60);
                    _ScoreAddition = false;
                    _GetScore = true;
                    _score._Score.text = _Score.ToString() + "PointGet";
                }
            }
            if (_pose._LowerBody == true)
            {
                if (_ScoreAddition == true)
                {
                    Additional_score(60);
                    _ScoreAddition = false;
                    _GetScore = true;
                    _score._Score.text = _Score.ToString() + "PointGet";
                }
            }
            if (_pose._UpperBody == true && _pose._LowerBody == true)
            {
                Additional_score(4000);
                _pose._UpperBody = false;
                _pose._LowerBody = false;
                _GetScore = true;
                _pose._Pose = PoseManager.PoseState.None;
                _score._Score.text = _Score.ToString() + "PointGet";
            }
        }
        else if (_pose._Pose == PoseManager.PoseState.R)
        {
            if (_pose._UpperBody == true)
            {
                if (_ScoreAddition == true)
                {
                    Additional_score(40);
                    _ScoreAddition = false;
                    _GetScore = true;
                    _score._Score.text = _Score.ToString() + "PointGet";
                }
            }
            if (_pose._LowerBody == true)
            {
                if (_ScoreAddition == true)
                {
                    Additional_score(40);
                    _ScoreAddition = false;
                    _GetScore = true;
                    _score._Score.text = _Score.ToString() + "PointGet";
                }
            }
            if (_pose._UpperBody == true && _pose._LowerBody == true)
            {
                Additional_score(3500);
                _pose._UpperBody = false;
                _pose._LowerBody =false;
                _GetScore = true;
                _pose._Pose = PoseManager.PoseState.None;
                _ScoreAddition = true;
                _score._Score.text = _Score.ToString() + "PointGet";
            }
        }
        else if (_pose._Pose == PoseManager.PoseState.U)
        {
            if (_pose._UpperBody == true)
            {
                if(_ScoreAddition == true)
                {
                    Additional_score(70);
                    _ScoreAddition = false;
                    _GetScore = true;
                    _score._Score.text = _Score.ToString() + "PointGet";
                }
            }
            if (_pose._LowerBody == true)
            {
                if (_ScoreAddition == true)
                {
                    Additional_score(70);
                    _ScoreAddition = false;
                    _GetScore = true;
                    _score._Score.text = _Score.ToString() + "PointGet";
                }
            }
            if (_pose._UpperBody == true && _pose._LowerBody == true)
            {
                Additional_score(3500);
                _pose._UpperBody = false;
                _pose._LowerBody = false;
                _GetScore = true;
                _pose._Pose = PoseManager.PoseState.None;
                _score._Score.text = _Score.ToString() + "PointGet";
            }
        }
        else if (_pose._Pose == PoseManager.PoseState.X)
        {
            if (_pose._UpperBody == true)
            {
                if (_ScoreAddition == true)
                {
                    Additional_score(40);
                    _ScoreAddition = false;
                    _GetScore = true;
                    _score._Score.text = _Score.ToString() + "PointGet";
                }
            }
            if (_pose._LowerBody == true)
            {
                if (_ScoreAddition == true)
                {
                    Additional_score(40);
                    _ScoreAddition = false;
                    _GetScore = true;
                    _score._Score.text = _Score.ToString() + "PointGet";
                }
            }
            if (_pose._UpperBody == true && _pose._LowerBody == true)
            {
                Additional_score(2000);
                _pose._UpperBody = false;
                _pose._LowerBody = false;
                _GetScore = true;
                _pose._Pose = PoseManager.PoseState.None;
                _score._Score.text = _Score.ToString() + "PointGet";
            }
        }
        else if (_pose._Pose == PoseManager.PoseState.Yoga_1)
        {
            if (_pose._UpperBody == true)
            {
                if (_ScoreAddition == true)
                {
                    Additional_score(20);
                    _ScoreAddition = false;
                    _GetScore = true;
                    _score._Score.text = _Score.ToString() + "PointGet";
                }
            }
            if (_pose._LowerBody == true)
            {
                if (_ScoreAddition == true)
                {
                    Additional_score(15);
                    _ScoreAddition = false;
                    _GetScore = true;
                    _score._Score.text = _Score.ToString() + "PointGet";
                }
            }
            if (_pose._UpperBody == true && _pose._LowerBody == true)
            {
                Additional_score(5000);
                _pose._UpperBody = false;
                _pose._LowerBody = false;
                _GetScore = true;
                _pose._Pose = PoseManager.PoseState.None;
                _score._Score.text = _Score.ToString() + "PointGet";
            }
        }
        else if (_pose._Pose == PoseManager.PoseState.Yoga_2)
        {
            if (_pose._UpperBody == true)
            {
                if (_ScoreAddition == true)
                {
                    Additional_score(35);
                    _ScoreAddition = false;
                    _GetScore = true;
                    _score._Score.text = _Score.ToString() + "PointGet";
                }
            }
            if (_pose._LowerBody == true)
            {
                if (_ScoreAddition == true)
                {
                    Additional_score(40);
                    _ScoreAddition = false;
                    _GetScore = true;
                    _score._Score.text = _Score.ToString() + "PointGet";
                }
            }
            if (_pose._UpperBody == true && _pose._LowerBody == true)
            {
                Additional_score(1000);
                _pose._UpperBody = false;
                _pose._LowerBody = false;
                _GetScore = true;
                _pose._Pose = PoseManager.PoseState.None;
                _score._Score.text = _Score.ToString() + "PointGet";
            }
        }
        else if (_pose._Pose == PoseManager.PoseState.Yoga_3)
        {
            if (_pose._UpperBody == true)
            {
                if (_ScoreAddition == true)
                {
                    Additional_score(85);
                    _ScoreAddition = false;
                    _GetScore = true;
                    _score._Score.text = _Score.ToString() + "PointGet";
                }
            }
            if (_pose._LowerBody == true)
            {
                if (_ScoreAddition == true)
                {
                    Additional_score(85);
                    _ScoreAddition = false;
                    _GetScore = true;
                    _score._Score.text = _Score.ToString() + "PointGet";
                }
            }
            if (_pose._UpperBody == true && _pose._LowerBody == true)
            {
                Additional_score(8500);
                _pose._UpperBody = false;
                _pose._LowerBody = false;
                _GetScore = true;
                _pose._Pose = PoseManager.PoseState.None;
                _score._Score.text = _Score.ToString() + "PointGet";
            }
        }
        else if (_pose._Pose == PoseManager.PoseState.Bodybuilding)
        {
            if (_pose._UpperBody == true)
            {
                if (_ScoreAddition == true)
                {
                    Additional_score(20);
                    _ScoreAddition = false;
                    _GetScore = true;
                    _score._Score.text = _Score.ToString() + "PointGet";
                }
            }
            if (_pose._LowerBody == true)
            {
                if (_ScoreAddition == true)
                {
                    Additional_score(10);
                    _ScoreAddition = false;
                    _GetScore = true;
                    _score._Score.text = _Score.ToString() + "PointGet";
                }
            }
            if (_pose._UpperBody == true && _pose._LowerBody == true)
            {
                Additional_score(1500);
                _pose._UpperBody = false;
                _pose._LowerBody = false;
                _GetScore = true;
                _pose._Pose = PoseManager.PoseState.None;
                _score._Score.text = _Score.ToString() + "PointGet";
            }
        }
        else if (_pose._Pose == PoseManager.PoseState.Frog)
        {
            if (_pose._UpperBody == true)
            {
                if (_ScoreAddition == true)
                {
                    Additional_score(50);
                    _ScoreAddition = false;
                    _GetScore = true;
                    _score._Score.text = _Score.ToString() + "PointGet";
                }
            }
            if (_pose._LowerBody == true)
            {
                if (_ScoreAddition == true)
                {
                    Additional_score(50);
                    _ScoreAddition = false;
                    _GetScore = true;
                    _score._Score.text = _Score.ToString() + "PointGet";
                }
            }
            if (_pose._UpperBody == true && _pose._LowerBody == true)
            {
                Additional_score(2500);
                _pose._UpperBody = false;
                _pose._LowerBody = false;
                _GetScore = true;
                _pose._Pose = PoseManager.PoseState.None;
                _score._Score.text = _Score.ToString() + "PointGet";
            }
        }
        else if (_pose._Pose == PoseManager.PoseState.Gymnastics)
        {
            if (_pose._UpperBody == true)
            {
                if (_ScoreAddition == true)
                {
                    Additional_score(45);
                    _ScoreAddition = false;
                    _GetScore = true;
                    _score._Score.text = _Score.ToString() + "PointGet";
                }
            }
            if (_pose._LowerBody == true)
            {
                if (_ScoreAddition == true)
                {
                    Additional_score(45);
                    _ScoreAddition = false;
                    _GetScore = true;
                    _score._Score.text = _Score.ToString() + "PointGet";
                }
            }
            if (_pose._UpperBody == true && _pose._LowerBody == true)
            {
                Additional_score(2000);
                _pose._UpperBody = false;
                _pose._LowerBody = false;
                _GetScore = true;
                _pose._Pose = PoseManager.PoseState.None;
                _score._Score.text = _Score.ToString() + "PointGet";
            }
        }
        else if (_pose._Pose == PoseManager.PoseState.Exit)
        {
            if (_pose._UpperBody == true)
            {
                if (_ScoreAddition == true)
                {
                    Additional_score(45);
                    _ScoreAddition = false;
                    _GetScore = true;
                    _score._Score.text = _Score.ToString() + "PointGet";
                }
            }
            if (_pose._LowerBody == true)
            {
                if (_ScoreAddition == true)
                {
                    Additional_score(45);
                    _ScoreAddition = false;
                    _GetScore = true;
                    _score._Score.text = _Score.ToString() + "PointGet";
                }
            }
            if (_pose._UpperBody == true && _pose._LowerBody == true)
            {
                Additional_score(3000);
                _pose._UpperBody = false;
                _pose._LowerBody = false;
                _GetScore = true;
                _pose._Pose = PoseManager.PoseState.None;
                _score._Score.text = _Score.ToString() + "PointGet";
            }
        }
        else if (_pose._Pose == PoseManager.PoseState.Sophomoric_1)
        {
            if (_pose._UpperBody == true)
            {
                if (_ScoreAddition == true)
                {
                    Additional_score(30);
                    _ScoreAddition = false;
                    _GetScore = true;
                    _score._Score.text = _Score.ToString() + "PointGet";
                }
            }
            if (_pose._LowerBody == true)
            {
                if (_ScoreAddition == true)
                {
                    Additional_score(20);
                    _ScoreAddition = false;
                    _GetScore = true;
                    _score._Score.text = _Score.ToString() + "PointGet";
                }
            }
            if (_pose._UpperBody == true && _pose._LowerBody == true)
            {
                Additional_score(2000);
                _pose._UpperBody = false;
                _pose._LowerBody = false;
                _GetScore = true;
                _pose._Pose = PoseManager.PoseState.None;
                _score._Score.text = _Score.ToString() + "PointGet";
            }
        }
        else if (_pose._Pose == PoseManager.PoseState.Sophomoric_2)
        {
            if (_pose._UpperBody == true)
            {
                if (_ScoreAddition == true)
                {
                    Additional_score(45);
                    _ScoreAddition = false;
                    _GetScore = true;
                    _score._Score.text = _Score.ToString() + "PointGet";
                }
            }
            if (_pose._LowerBody == true)
            {
                if (_ScoreAddition == true)
                {
                    Additional_score(20);
                    _ScoreAddition = false;
                    _GetScore = true;
                    _score._Score.text = _Score.ToString() + "PointGet";
                }
            }
            if (_pose._UpperBody == true && _pose._LowerBody == true)
            {
                Additional_score(2500);
                _pose._UpperBody = false;
                _pose._LowerBody = false;
                _GetScore = true;
                _pose._Pose = PoseManager.PoseState.None;
                _score._Score.text = _Score.ToString() + "PointGet";
            }
        }
        else if (_pose._Pose == PoseManager.PoseState.Conveni)
        {
            if (_pose._UpperBody == true)
            {
                if (_ScoreAddition == true)
                {
                    Additional_score(30);
                    _ScoreAddition = false;
                    _GetScore = true;
                    _score._Score.text = _Score.ToString() + "PointGet";
                }
            }
            if (_pose._LowerBody == true)
            {
                if (_ScoreAddition == true)
                {
                    Additional_score(50);
                    _ScoreAddition = false;
                    _GetScore = true;
                    _score._Score.text = _Score.ToString() + "PointGet";
                }
            }
            if (_pose._UpperBody == true && _pose._LowerBody == true)
            {
                Additional_score(3500);
                _pose._UpperBody = false;
                _pose._LowerBody = false;
                _GetScore = true;
                _pose._Pose = PoseManager.PoseState.None;
                _score._Score.text = _Score.ToString() + "PointGet";
            }
        }
        else if (_pose._Pose == PoseManager.PoseState.Yell)
        {
            if (_pose._UpperBody == true)
            {
                if (_ScoreAddition == true)
                {
                    Additional_score(20);
                    _ScoreAddition = false;
                    _GetScore = true;
                    _score._Score.text = _Score.ToString() + "PointGet";
                }
            }
            if (_pose._LowerBody == true)
            {
                if (_ScoreAddition == true)
                {
                    Additional_score(40);
                    _ScoreAddition = false;
                    _GetScore = true;
                    _score._Score.text = _Score.ToString() + "PointGet";
                }
            }
            if (_pose._UpperBody == true && _pose._LowerBody == true)
            {
                Additional_score(2000);
                _pose._UpperBody = false;
                _pose._LowerBody = false;
                _GetScore = true;
                _pose._Pose = PoseManager.PoseState.None;
                _score._Score.text = _Score.ToString() + "PointGet";
            }
        }
        else if (_pose._Pose == PoseManager.PoseState.Bend_forward)
        {
            if (_pose._UpperBody == true)
            {
                if (_ScoreAddition == true)
                {
                    Additional_score(70);
                    _ScoreAddition = false;
                    _GetScore = true;
                    _score._Score.text = _Score.ToString() + "PointGet";
                }
            }
            if (_pose._LowerBody == true)
            {
                if (_ScoreAddition == true)
                {
                    Additional_score(60);
                    _ScoreAddition = false;
                    _GetScore = true;
                    _score._Score.text = _Score.ToString() + "PointGet";
                }
            }
            if (_pose._UpperBody == true && _pose._LowerBody == true)
            {
                Additional_score(5000);
                _pose._UpperBody = false;
                _pose._LowerBody = false;
                _GetScore = true;
                _pose._Pose = PoseManager.PoseState.None;
                _score._Score.text = _Score.ToString() + "PointGet";
            }
        }
        else if (_pose._Pose == PoseManager.PoseState.Sprawled)
        {
            if (_pose._UpperBody == true)
            {
                if (_ScoreAddition == true)
                {
                    Additional_score(50);
                    _ScoreAddition = false;
                    _GetScore = true;
                    _score._Score.text = _Score.ToString() + "PointGet";
                }
            }
            if (_pose._LowerBody == true)
            {
                if (_ScoreAddition == true)
                {
                    Additional_score(40);
                    _ScoreAddition = false;
                    _GetScore = true;
                    _score._Score.text = _Score.ToString() + "PointGet";
                }
            }
            if (_pose._UpperBody == true && _pose._LowerBody == true)
            {
                Additional_score(2500);
                _pose._UpperBody = false;
                _pose._LowerBody = false;
                _GetScore = true;
                _pose._Pose = PoseManager.PoseState.None;
                _score._Score.text = _Score.ToString() + "PointGet";
            }
        }
        else if (_pose._Pose == PoseManager.PoseState.Race_walking)
        {
            if (_pose._UpperBody == true)
            {
                if (_ScoreAddition == true)
                {
                    Additional_score(45);
                    _ScoreAddition = false;
                    _GetScore = true;
                    _score._Score.text = _Score.ToString() + "PointGet";
                }
            }
            if (_pose._LowerBody == true)
            {
                if (_ScoreAddition == true)
                {
                    Additional_score(20);
                    _ScoreAddition = false;
                    _GetScore = true;
                    _score._Score.text = _Score.ToString() + "PointGet";
                }
            }
            if (_pose._UpperBody == true && _pose._LowerBody == true)
            {
                Additional_score(3000);
                _pose._UpperBody = false;
                _pose._LowerBody = false;
                _GetScore = true;
                _pose._Pose = PoseManager.PoseState.None;
                _score._Score.text = _Score.ToString() + "PointGet";
            }
        }
        else if (_pose._Pose == PoseManager.PoseState.Joy)
        {
            if (_pose._UpperBody == true)
            {
                if (_ScoreAddition == true)
                {
                    Additional_score(55);
                    _ScoreAddition = false;
                    _GetScore = true;
                    _score._Score.text = _Score.ToString() + "PointGet";
                }
            }
            if (_pose._LowerBody == true)
            {
                if (_ScoreAddition == true)
                {
                    Additional_score(25);
                    _ScoreAddition = false;
                    _GetScore = true;
                    _score._Score.text = _Score.ToString() + "PointGet";
                }
            }
            if (_pose._UpperBody == true && _pose._LowerBody == true)
            {
                Additional_score(2000);
                _pose._UpperBody = false;
                _pose._LowerBody = false;
                _GetScore = true;
                _pose._Pose = PoseManager.PoseState.None;
                _score._Score.text = _Score.ToString() + "PointGet";
            }
        }
        else if (_pose._Pose == PoseManager.PoseState.Deformed)
        {
            if (_pose._UpperBody == true)
            {
                if (_ScoreAddition == true)
                {
                    Additional_score(1);
                    _ScoreAddition = false;
                    _GetScore = true;
                    _score._Score.text = _Score.ToString() + "PointGet";
                }
            }
            if (_pose._LowerBody == true)
            {
                if (_ScoreAddition == true)
                {
                    Additional_score(1);
                    _ScoreAddition = false;
                    _GetScore = true;
                    _score._Score.text = _Score.ToString() + "PointGet";
                }
            }
            if (_pose._UpperBody == true && _pose._LowerBody == true)
            {
                Additional_score(1000);
                _pose._UpperBody = false;
                _pose._LowerBody = false;
                _GetScore = true;
                _pose._Pose = PoseManager.PoseState.None;
                _score._Score.text = _Score.ToString() + "PointGet";
            }
        }
    }
}