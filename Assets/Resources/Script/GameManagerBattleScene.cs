using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManagerBattleScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerManager.hp -= 1;//戦闘でHPが1減ったこと事を想定した処理
        Debug.Log("BattleScene");
        Debug.Log("プレイヤーのHP：" + PlayerManager.hp);
    }
    //ボタンを押した際にExploreSceneへ移動するメソッド
    public void GoToExploreScene()
    {
        SceneManager.LoadScene("ExploreScene");
    }
}