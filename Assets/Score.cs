using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    //Scoreオブジェクトを取得するための変数を宣言
    GameObject ScoreText;
    //点数を貯蓄するための変数を初期化
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

    //衝突時に衝突相手を判別して点数を加算･反映
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
