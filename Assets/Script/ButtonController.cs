using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//��ʑJ�ڂ��s���ALoadScene���g�p���邽�߂ɓ���

public class ButtonController : MonoBehaviour
{
    //�^�C�g���{�^�������������̏���
    public void ClickTitleButton()
    {
        // " "���ɋL�q���ꂽ���O�̃V�[�������[�h����i��ʑJ�ځj
        SceneManager.LoadScene("TitleScene");
    }

}