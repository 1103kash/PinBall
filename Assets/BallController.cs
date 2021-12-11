using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
    //ボールが見える可能性のあるz軸の最小値
    private float viziblePosZ = -6.5f;
    //ゲームオーバを表示するテキスト(オブジェクト)を取得するための変数を宣言
    private GameObject gameoverText;

    // Start is called before the first frame update
    void Start()
    {
        //シーン中のGameOverTextオブジェクトを取得
        this.gameoverText = GameObject.Find("GameOverText");
    }

    // Update is called once per frame
    void Update()
    {
        //ボールが画面外に出た場合、GameoverTextにゲームオーバを表示
        if (this.transform.position.z < this.viziblePosZ)
        {
            //もう変数に入れる必要がないし、オブジェクトが自分自身ではないから、直にGetComponentして入れている？
            this.gameoverText.GetComponent<Text>().text = "Game Over";
        }
    }
}
