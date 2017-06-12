using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Chance : MonoBehaviour {

    // チャンスの画像の取得
    Image _Chance;
    float r, g, b, alpha;

    [SerializeField]
    bool _DisplayChance;

    float _foTime;
    float _fiTime;

    public float _fadeTime;

    PoseManager _pose;
	// Use this for initialization
	void Start () {
        _Chance = gameObject.GetComponent<Image>();
        r = _Chance.GetComponent<Image>().color.r;
        g = _Chance.GetComponent<Image>().color.g;
        b = _Chance.GetComponent<Image>().color.b;
        alpha = _Chance.GetComponent<Image>().color.a;

        _DisplayChance = false;

        _foTime = 0; // 初期化(フェードアウト)
        _fiTime = _fadeTime; // 初期化(フェードイン)
        _fadeTime = 1.5f;

        _pose = GameObject.Find("PoseManager").GetComponent<PoseManager>();
	}
	
	// Update is called once per frame
	void Update () {
        _Chance.GetComponent<Image>().color = new Color(r, g, b, alpha);

        if(_pose._PartCount == 0)
        {
            _DisplayChance = false;
        }
        if(_pose._PartCount == 1)
        {
            _DisplayChance = true;
        }
	}

    public void DisplayChance()
    {
        if(_DisplayChance == true)
        {
            FadeOut();
            _fiTime = _fadeTime;
        }
        if(_DisplayChance == false)
        {
            FadeIn();
            _foTime = 0;
        }

        if(_pose._RArm == true && _pose._LHip == false)
        {
            var pos = transform.position;
            pos = _pose._R_Shoulder.transform.position;
            pos.y += -4.0f;
            transform.position = pos;  
        }
        else if(_pose._RArm == false && _pose._LHip == true)
        {
            var pos = transform.position;
            pos = _pose._L_HipJoint.transform.position;
            pos.y += 4.0f;
            transform.position = pos;
        }

        if(_pose._UpperBody == true && _pose._LowerBody == false)
        {
            var pos = transform.position;
            pos = _pose._R_Shoulder.transform.position;
            pos.y += -4.0f;
            transform.position = pos;
        }
        else if (_pose._UpperBody == false && _pose._LowerBody == true)
        {
            var pos = transform.position;
            pos = _pose._L_HipJoint.transform.position;
            pos.y += 4.0f;
            transform.position = pos;
        }
    }

    void FadeOut()
    {
        _foTime += Time.deltaTime;
        float alpha = _foTime / _fadeTime;
        var color = _Chance.color;
        color.a = alpha;
        _Chance.color = color;
    }

    void FadeIn()
    {
        _fiTime -= Time.deltaTime;
        float alpha = _fiTime / _fadeTime;
        var color = _Chance.color;
        color.a = alpha;
        _Chance.color = color;
    }
}
