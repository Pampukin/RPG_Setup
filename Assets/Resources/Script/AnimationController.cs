using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class AnimationController : MonoBehaviour
{
    [SerializeField] Animator AnimationImage = null;//アニメーションを表示させるImageオブジェクトとの連携のために導入
                                                    //攻撃ボタンが押された時の処理
    public void ClickAttackButton()
    {
        //AttackTriggerをONにする処理
        AnimationImage.SetTrigger("AttackTrigger");
        //EmptyTriggerをONにする処理
        AnimationImage.SetTrigger("EmptyTrigger");
    }
}