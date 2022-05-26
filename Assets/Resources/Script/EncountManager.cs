using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//Text型を扱うために導入
using TMPro;

public class EncountManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI ResultText = null;//エンカウント処理結果を表示させるTextオブジェクトとの連携のために導入
    int[] resultID = new int[3];//処理結果を表すID resultID[0]:スライムとのエンカウント　resultID[1]:ゴブリンとのエンカウント　resultID[2]:エンカウントなしを表すものとする
    float[] resultAR = new float[3];//各resultIDの出現率(resutAR[resultID]がresultIDが示す事象の出現確率を示す）    
    //エネミーとのエンカウント計算処理を行うメソッド
    public void EncountCulc()
    {
        int result;//エンカウント計算結果のresultIDを格納する作業用変数
        int count = 0;//作業用変数
        int[] encount = new int[100];//各確率に応じた数のresultIDを格納する変数(今回の場合は出現率は整数であるとして場合は配列の大きさを100とする)
        //変数の初期化処理///////////////////////////
        for (int i = 0; i < 3; i++)
        {
            resultID[i] = i;
        }
        resultAR[0] = 0.30f;//スライムとのエンカウント率を30%に設定
        resultAR[1] = 0.20f;//ゴブリンとのエンカウント率を20%に設定
        resultAR[2] = 0.50f;//魔物と遭遇しない確率を50%に設定
        //変数の初期化処理終了////////////////////////
        //encount配列の中身を0に初期化
        for (int i = 0; i < encount.Length; i++)
        {
            encount[i] = 0;
        }
        //resultIDの出現率に従ってresultIDを配列変数encount格納する処理
        for (int i = 0; i < resultID.Length; i++)
        {
            if (resultAR[i] != 0)
            {
                for (int j = 0; j < Mathf.Floor(resultAR[i] * 100); j++)//出現率がfloatなので100倍して整数にする。小数点以下の誤差対策として切り捨て処理(Mathf.Floor)を使用する
                {
                    encount[count] = resultID[i];
                    count++;
                }
            }
        }
        //ランダム関数を使用するので、先にランダムシードを時刻により初期化して、ランダム性を上げる
        Random.InitState(System.DateTime.Now.Millisecond);
        //ランダムインデックスを計算
        int randomIndex = Random.Range(0, encount.Length);
        //確率に応じたにエンカウント計算結果を変数result
        result = encount[randomIndex];
        //計算結果に応じてテキストオブジェクトの表示を変更する処理
        if (result == resultID[0])
        {
            ResultText.text = "Encount a Slime";
        }
        else if (result == resultID[1])
        {
            ResultText.text = "Encount a Goblin";
        }
        else
        {
            ResultText.text = "nobady";
        }
    }
}