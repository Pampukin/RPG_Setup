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
        Debug.Log("�v���C���[��HP�F" + PlayerManager.hp);
    }
    //�{�^�����������ۂ�BattleScene�ֈړ����郁�\�b�h
    public void ClickGoToBattleScene()
    {
        SceneManager.LoadScene("BattleScene");
    }
}