using System.Collections;
using System.Collections.Generic;
using TMPro;//TextMeshProを扱うために導入
using UnityEngine;
using UnityEngine.UI;

public class AttackButtonController : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI DamageText = null;//ダメージを表示させるテキストとの連携のために導入
    //攻撃ボタンが押された時の動作。Textオブジェクトに10と表示させる
    public void ClickAttackButton()
    {
        //Text型変数DamageTextのテキスト表示内容を10に変更する
        DamageText.text = "10";
    }
}