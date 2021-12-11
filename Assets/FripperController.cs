using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FripperController : MonoBehaviour
{
    //HingeJointコンポーネントを入れる
    private HingeJoint myHingeJoint;
    //初期の傾き
    private float defaultAngle = 20;
    //弾いた時の傾き
    private float flickAngle = -20;
    // Start is called before the first frame update
    void Start()
    {
        //HingeJointコンポーネント取得
        this.myHingeJoint = GetComponent<HingeJoint>();
        //フリッパーの傾きを設定
        SetAngle(this.defaultAngle);
    }
    // Update is called once per frame
    void Update()
    {
        //左矢印キー/A/S/下矢印キーのいずれかを押したとき左フリッパーを動かす
        if ((Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S)) && tag == "LeftFripperTag")
        {
            SetAngle(this.flickAngle);
        }
        //右矢印キー/D/S/下矢印キーのいずれかを押したとき右フリッパーを動かす
        if ((Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S)) && tag == "RightFripperTag")
        {
            SetAngle(this.flickAngle);
        }
        //上記の各対応キーが離されたときフリッパーを元に戻す
        if ((Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.DownArrow) || Input.GetKeyUp(KeyCode.S)) && tag == "LeftFripperTag")
        {
            SetAngle(this.defaultAngle);
        }
        if ((Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.DownArrow) || Input.GetKeyUp(KeyCode.S)) && tag == "RightFripperTag")
        {
            SetAngle(this.defaultAngle);
        }
        
    }
    public void SetAngle(float angle)
    {
        //HingeJointの中のJointSpring型で変数を宣言し、
        //myHingeJoint変数からspringの値を取得
        JointSpring jointSpr = this.myHingeJoint.spring;
        //引数でもらった角度をフリッパーのHingeJointのSpringのtargetPositionに設定する
        jointSpr.targetPosition = angle;
        //HingeJointに反映
        this.myHingeJoint.spring = jointSpr;
    }
}
