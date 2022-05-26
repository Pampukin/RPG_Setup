using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManagerExploreScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("ExploreScene");
        Debug.Log("プレイヤーのHP：" + PlayerManager.hp);
    }
    //ボタンを押した際にBattleSceneへ移動するメソッド
    public void ClickGoToBattleScene()
    {
        SceneManager.LoadScene("BattleScene");
    }
}