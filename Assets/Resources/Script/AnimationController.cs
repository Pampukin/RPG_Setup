using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class AnimationController : MonoBehaviour
{
    [SerializeField] Animator AnimationImage = null;//�A�j���[�V������\��������Image�I�u�W�F�N�g�Ƃ̘A�g�̂��߂ɓ���
                                                    //�U���{�^���������ꂽ���̏���
    public void ClickAttackButton()
    {
        //AttackTrigger��ON�ɂ��鏈��
        AnimationImage.SetTrigger("AttackTrigger");
        //EmptyTrigger��ON�ɂ��鏈��
        AnimationImage.SetTrigger("EmptyTrigger");
    }
}