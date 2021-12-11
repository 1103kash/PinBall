using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FripperController : MonoBehaviour
{
    //HingeJoint�R���|�[�l���g������
    private HingeJoint myHingeJoint;
    //�����̌X��
    private float defaultAngle = 20;
    //�e�������̌X��
    private float flickAngle = -20;
    // Start is called before the first frame update
    void Start()
    {
        //HingeJoint�R���|�[�l���g�擾
        this.myHingeJoint = GetComponent<HingeJoint>();
        //�t���b�p�[�̌X����ݒ�
        SetAngle(this.defaultAngle);
    }
    // Update is called once per frame
    void Update()
    {
        //�����L�[/A/S/�����L�[�̂����ꂩ���������Ƃ����t���b�p�[�𓮂���
        if ((Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S)) && tag == "LeftFripperTag")
        {
            SetAngle(this.flickAngle);
        }
        //�E���L�[/D/S/�����L�[�̂����ꂩ���������Ƃ��E�t���b�p�[�𓮂���
        if ((Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S)) && tag == "RightFripperTag")
        {
            SetAngle(this.flickAngle);
        }
        //��L�̊e�Ή��L�[�������ꂽ�Ƃ��t���b�p�[�����ɖ߂�
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
        //HingeJoint�̒���JointSpring�^�ŕϐ���錾���A
        //myHingeJoint�ϐ�����spring�̒l���擾
        JointSpring jointSpr = this.myHingeJoint.spring;
        //�����ł�������p�x���t���b�p�[��HingeJoint��Spring��targetPosition�ɐݒ肷��
        jointSpr.targetPosition = angle;
        //HingeJoint�ɔ��f
        this.myHingeJoint.spring = jointSpr;
    }
}
