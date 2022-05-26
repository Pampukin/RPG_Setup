using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//画面遷移を行う、LoadSceneを使用するために導入

public class ButtonController : MonoBehaviour
{
    //タイトルボタンを押した時の処理
    public void ClickTitleButton()
    {
        // " "内に記述された名前のシーンをロードする（画面遷移）
        SceneManager.LoadScene("TitleScene");
    }

}