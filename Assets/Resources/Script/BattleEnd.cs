using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;//Fungus�𐧌䂷�邽�߂ɓ���
public class BattleEnd : MonoBehaviour
{

    [SerializeField] Flowchart ResultLog = null;//�퓬���ʁi�擾�o���l�j��\���������b���O�ƘA�g
                                                //�퓬�I���@�{�^���������ꂽ���ɌĂяo����郁�\�b�h
    public void ClickBattleEndButton()
    {
        //��b���O��\��������g���K�[�ƂȂ郁�b�Z�[�W��Flowchart�ɓn������
        ResultLog.SendFungusMessage("BattleEnd");
    }
}