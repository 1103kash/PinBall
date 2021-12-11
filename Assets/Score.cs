using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    //Score�I�u�W�F�N�g���擾���邽�߂̕ϐ���錾
    GameObject ScoreText;
    //�_���𒙒~���邽�߂̕ϐ���������
    int localscore = 0;
    // Start is called before the first frame update
    void Start()
    {
        ScoreText = GameObject.Find("Score");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //�Փˎ��ɏՓˑ���𔻕ʂ��ē_�������Z����f
    private void OnCollisionEnter(Collision target)
    {
        if(target.gameObject.tag == "SmallCloudTag")
        {
            localscore += 5;
        }
        else if (target.gameObject.tag == "LargeCloudTag")
        {
            localscore += 5;
        }
        else if (target.gameObject.tag == "SmallStarTag")
        {
            localscore += 1;
        }
        else if (target.gameObject.tag == "LargeStarTag")
        {
            localscore += 20;
        }
        ScoreText.GetComponent<Text>().text = localscore.ToString();
    }
}
