using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManagerBattleScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerManager.hp -= 1;//�퓬��HP��1���������Ǝ���z�肵������
        Debug.Log("BattleScene");
        Debug.Log("�v���C���[��HP�F" + PlayerManager.hp);
    }
    //�{�^�����������ۂ�ExploreScene�ֈړ����郁�\�b�h
    public void GoToExploreScene()
    {
        SceneManager.LoadScene("ExploreScene");
    }
}