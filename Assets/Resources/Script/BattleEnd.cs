using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;//Fungusを制御するために導入
public class BattleEnd : MonoBehaviour
{

    [SerializeField] Flowchart ResultLog = null;//戦闘結果（取得経験値）を表示させる会話ログと連携
                                                //戦闘終了　ボタンが押された時に呼び出されるメソッド
    public void ClickBattleEndButton()
    {
        //会話ログを表示させるトリガーとなるメッセージをFlowchartに渡す処理
        ResultLog.SendFungusMessage("BattleEnd");
    }
}