using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//画面遷移を行う、LoadSceneを使用するために導入
using UnityEngine.UI;//Image型を扱うために導入
using TMPro;

public class ButtonController : MonoBehaviour
{
    //タイトルボタンを押した時の処理
    public void ClickTitleButton()
    {
        // " "内に記述された名前のシーンをロードする（画面遷移）
        SceneManager.LoadScene("TitleScene");
    }

    [SerializeField] TextMeshProUGUI EnemyNameText = null;//エネミーの名前を表示させるTextオブジェクトとの連携のために導入
    [SerializeField] TextMeshProUGUI HpText = null;//エネミーのHPを表示させるTextオブジェクトとの連携のために導入
    [SerializeField] Image EnemyImage = null;//エネミー画像を表示させるImageオブジェクトとの連携のために導入
    private EnemyInformation enemyInfo;//CSVを読み込むEnemyInformationクラスを扱うために宣言

    private void Start()
    {
        enemyInfo = new EnemyInformation();//EnemyInformationクラスの実体としてenemyInfo生成
        enemyInfo.Init();//CSVデータの読み込みと変数への格納処理
    }
    //「スライム」ボタンが押された時の動作。Imageオブジェクトにスライムの画像を表示させるとともに、Textオブジェクトに名前とHPを表示させる
    public void ClickSlimeButton()
    {
        EnemyNameText.text = enemyInfo.enemyName[1];//CSVファイル内でenemyID=1で表されるエネミーの名前ををTextオブジェクトに表示させる
        HpText.text = "HP:" + enemyInfo.hp[1].ToString();//CSVファイル内でenemyID=1で表されるエネミーのHPをTextオブジェクトに表示させる(int型から文字列型に変換するために.ToString()を使っている点に注意。
        //CSVファイル内でenemyID=1で表されるエネミーの画像保管先(enemyInfo.imageAddress[1])で表されるファイルを、変数EnemyImageと結び付けられたオブジェクトに表示させる処理。.pngなどの拡張子は不要
        EnemyImage.sprite = Resources.Load<Sprite>(enemyInfo.imageAddress[1]);
    }
    //「ゴブリン」ボタンが押された時の動作。Imageオブジェクトにゴブリンの画像を表示させるとともに、Textオブジェクトに名前とHPを表示させる
    public void ClickGoblinButton()
    {
        EnemyNameText.text = enemyInfo.enemyName[2];//CSVファイル内でenemyID=2で表されるエネミーの名前ををTextオブジェクトに表示させる
        HpText.text = "HP:" + enemyInfo.hp[2].ToString();//CSVファイル内でenemyID=2で表されるエネミーのHPをTextオブジェクトに表示させる(int型から文字列型に変換するために.ToString()を使っている点に注意。
        //CSVファイル内でenemyID=2で表されるエネミーの画像保管先(enemyInfo.imageAddress[2])で表されるファイルを、変数EnemyImageと結び付けられたオブジェクトに表示させる処理。.pngなどの拡張子は不要
        EnemyImage.sprite = Resources.Load<Sprite>(enemyInfo.imageAddress[2]);
    }
    //「ドラゴン」ボタンが押された時の動作。Imageオブジェクトにドラゴンの画像を表示させるとともに、Textオブジェクトに名前とHPを表示させる
    public void ClickDragonButton()
    {
        EnemyNameText.text = enemyInfo.enemyName[3];//CSVファイル内でenemyID=3で表されるエネミーの名前ををTextオブジェクトに表示させる
        HpText.text = "HP:" + enemyInfo.hp[3].ToString();//CSVファイル内でenemyID=3で表されるエネミーのHPをTextオブジェクトに表示させる(int型から文字列型に変換するために.ToString()を使っている点に注意。
        //CSVファイル内でenemyID=3で表されるエネミーの画像保管先(enemyInfo.imageAddress[3])で表されるファイルを、変数EnemyImageと結び付けられたオブジェクトに表示させる処理。.pngなどの拡張子は不要
        EnemyImage.sprite = Resources.Load<Sprite>(enemyInfo.imageAddress[3]);
    }
    /*
//「スライム」ボタンが押された時の動作。Imageオブジェクトにスライムの画像を表示させる
public void ClickSlimeButton()
{
    //Assets直下のResourcesフォルダ直下にあるImage/pipo-enemy009と言うパスで表されるファイルを、変数EnemyImageと結び付けられたオブジェクトに表示させる処理。.pngなどの拡張子は不要
    EnemyImage.sprite = Resources.Load<Sprite>("Image/Pipo-enemy009");
}
//「ゴブリン」ボタンが押された時の動作。Imageオブジェクトにゴブリンの画像を表示させる
public void ClickGoblinButton()
{
    //Assets直下のResourcesフォルダ直下にあるImage/pipo-enemy011と言うパスで表されるファイルを、変数EnemyImageと結び付けられたオブジェクトに表示させる処理。.pngなどの拡張子は不要
    EnemyImage.sprite = Resources.Load<Sprite>("Image/Pipo-enemy011");
}
//「ドラゴン」ボタンが押された時の動作。Imageオブジェクトにドラゴンの画像を表示させる
public void ClickDragonButton()
{
    //Assets直下のResourcesフォルダ直下にあるImage/pipo-enemy021と言うパスで表されるファイルを、変数EnemyImageと結び付けられたオブジェクトに表示させる処理。.pngなどの拡張子は不要
    EnemyImage.sprite = Resources.Load<Sprite>("Image/Pipo-enemy021");
}
*/
}