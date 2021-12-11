using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
    //�{�[����������\���̂���z���̍ŏ��l
    private float viziblePosZ = -6.5f;
    //�Q�[���I�[�o��\������e�L�X�g(�I�u�W�F�N�g)���擾���邽�߂̕ϐ���錾
    private GameObject gameoverText;

    // Start is called before the first frame update
    void Start()
    {
        //�V�[������GameOverText�I�u�W�F�N�g���擾
        this.gameoverText = GameObject.Find("GameOverText");
    }

    // Update is called once per frame
    void Update()
    {
        //�{�[������ʊO�ɏo���ꍇ�AGameoverText�ɃQ�[���I�[�o��\��
        if (this.transform.position.z < this.viziblePosZ)
        {
            //�����ϐ��ɓ����K�v���Ȃ����A�I�u�W�F�N�g���������g�ł͂Ȃ�����A����GetComponent���ē���Ă���H
            this.gameoverText.GetComponent<Text>().text = "Game Over";
        }
    }
}
