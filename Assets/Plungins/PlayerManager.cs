using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//複数のシーンで共有する情報(HP)を管理するクラス
//MonoBehaviourは継承しないことに注意
public static class PlayerManager
{
    //プレイヤーのHPを説明のため10で初期化
    public static int hp = 10;
}