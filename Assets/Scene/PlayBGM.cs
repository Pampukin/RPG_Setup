using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayBGM : MonoBehaviour
{
    [SerializeField] AudioClip BGM = null;//�Đ������鉹�y�ł���AudioClip�Ƃ̘A�g�̂��߂ɓ���
    AudioSource Audio;//���y���Đ������邽�߂�AudioSource�R���|�[�l���g��Play���\�b�h���g�����߂ɒ�`����
    void Start()
    {
        Audio = GetComponent<AudioSource>();//���̃X�N���v�g���A�^�b�`���ꂽ�I�u�W�F�N�g�ɕt�^����Ă���AudioSource�R���|�[�l���g��F��������
        Audio.PlayOneShot(BGM);//�ϐ�BGM���\�����y���Đ�����
    }
}