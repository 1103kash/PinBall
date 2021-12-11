using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrightnessRegulator : MonoBehaviour
{
    //Materialを取得するための変数を宣言
    Material myMaterial;
    //Emissionの最小値
    private float minEmission = 0.2f;
    // Emissionの強度
    private float magEmission = 2.0f;
    // 衝突時に上がる変数(角度)
    private int degree = 0;
    // 発光の減衰
    private int speed = 5;
    // ターゲット色を変更するための変数を宣言
    Color defaultColor = Color.white;
    // Start is called before the first frame update
    void Start()
    {
        // タグによって光らせる色を変える※同じスクリプトでもオブジェクト毎に実行されるため結果が異なる
        if (tag == "SmallStarTag")
        {
            this.defaultColor = Color.white;
        }
        else if (tag == "LargeStarTag")
        {
            this.defaultColor = Color.yellow;
        }
        else if (tag == "SmallCloudTag" || tag == "LargeCloudTag")
        {
            this.defaultColor = Color.cyan;
        }
        //オブジェクトにアタッチしているMaterialを取得
        this.myMaterial = GetComponent<Renderer>().material;
        //オブジェクトの最初の色を設定
        myMaterial.SetColor("_EmissionColor", this.defaultColor * minEmission);
    }

    // Update is called once per frame
    void Update()
    {
        if (this.degree >= 0)
        {
            // 衝突時に上がる変数をもとに、光らせる強度を計算する
            Color emissionColor = this.defaultColor * (this.minEmission + Mathf.Sin(this.degree * Mathf.Deg2Rad) * this.magEmission);
            // 上で計算した色･光らせる強度を反映する
            myMaterial.SetColor("_EmissionColor", emissionColor);
            //現在の衝突時に上がる変数を減衰させる
            this.degree -= this.speed;
        }
    }

    //衝突時に呼ばれる関数
    void OnCollisionEnter(Collision other)
    {
        //衝突時に上がる変数(角度)を180に設定
        this.degree = 180;
    }
}
