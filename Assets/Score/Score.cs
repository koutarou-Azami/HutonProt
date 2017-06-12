using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {
    // スコアの画像を取得
    //public Image _Score;
    public Text _Score;
    float r, g, b, alpha;

    // スコアの加算のスクリプトを取得
    ScoreAdd _score;
    // パーツの判定のスクリプトを取得
    PoseManager _pose;
    public int _Additional;
    public bool _L_Addscore;
    public bool _R_Addscore;
    bool _Fadeflag;
    bool _Fade;

    float _fiTime;
    float _foTime;

    public float _fadeTime;
    public float _timer;
	// Use this for initialization
	void Start () {
        _score = GameObject.Find("PoseManager").GetComponent<ScoreAdd>();
        _pose = GameObject.Find("PoseManager").GetComponent<PoseManager> ();

        _Additional = 0;
        _L_Addscore = false;
        _R_Addscore = false;
        _Fadeflag = false;
        _Fade = false;

        //_Score = gameObject.GetComponent<Image>();
        _Score = gameObject.GetComponent<Text>();
        r = _Score.GetComponent<Text>().color.r;
        g = _Score.GetComponent<Text>().color.g;
        b = _Score.GetComponent<Text>().color.b;
        alpha = _Score.GetComponent<Text>().color.a;

        _Score.text = "PointGet";

        _fadeTime = 1.5f;
        _fiTime = _fadeTime;
        _foTime = 0.0f;

        _timer = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
        if(_score._GetScore == true)
        {
            FadeOut();
            _timer += Time.deltaTime;
            if(_timer >= 2.5f)
            {
                FadeIn();
            }
            if(_timer >= 5.0f)
            {
                _score._GetScore = false;
            }
        }
        else if(_score._GetScore == false)
        {
            _foTime = 0.0f;
            _fiTime = _fadeTime;
            _timer = 0.0f;
        }
    }

    public void Fade()
    {
        if(_Fadeflag == true)
        {
            FadeOut();
            _timer += Time.deltaTime;
            if(_timer >= 3.0f)
            {
                FadeIn();
            }
        }

        if (_L_Addscore == true)
        {
            var pos = transform.position;
            pos = _pose._L_Shoulder.transform.position;
            pos.y += 4.0f;
            transform.position = pos;
        }
        if (_R_Addscore == true)
        {
            var pos = transform.position;
            pos = _pose._R_HipJoint.transform.position;
            pos.y += -4.0f;
            transform.position = pos;
        }
    }

    public void FadeIn()
    {
        _fiTime -= Time.deltaTime;
        float alpha = _fiTime / _fadeTime;
        var color = _Score.color;
        color.a = alpha;
        _Score.color = color;
    }

    public void FadeOut()
    {
        _foTime += Time.deltaTime;
        float alpha = _foTime / _fadeTime;
        var color = _Score.color;
        color.a = alpha;
        _Score.color = color;
    }
}
