using System.Collections;
using System.Collections.Generic;
using TMPro;//TextMeshPro���������߂ɓ���
using UnityEngine;
using UnityEngine.UI;

public class AttackButtonController : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI DamageText = null;//�_���[�W��\��������e�L�X�g�Ƃ̘A�g�̂��߂ɓ���
    //�U���{�^���������ꂽ���̓���BText�I�u�W�F�N�g��10�ƕ\��������
    public void ClickAttackButton()
    {
        //Text�^�ϐ�DamageText�̃e�L�X�g�\�����e��10�ɕύX����
        DamageText.text = "10";
    }
}