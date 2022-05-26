using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//Text�^���������߂ɓ���
using TMPro;

public class EncountManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI ResultText = null;//�G���J�E���g�������ʂ�\��������Text�I�u�W�F�N�g�Ƃ̘A�g�̂��߂ɓ���
    int[] resultID = new int[3];//�������ʂ�\��ID resultID[0]:�X���C���Ƃ̃G���J�E���g�@resultID[1]:�S�u�����Ƃ̃G���J�E���g�@resultID[2]:�G���J�E���g�Ȃ���\�����̂Ƃ���
    float[] resultAR = new float[3];//�eresultID�̏o����(resutAR[resultID]��resultID���������ۂ̏o���m���������j    
    //�G�l�~�[�Ƃ̃G���J�E���g�v�Z�������s�����\�b�h
    public void EncountCulc()
    {
        int result;//�G���J�E���g�v�Z���ʂ�resultID���i�[�����Ɨp�ϐ�
        int count = 0;//��Ɨp�ϐ�
        int[] encount = new int[100];//�e�m���ɉ���������resultID���i�[����ϐ�(����̏ꍇ�͏o�����͐����ł���Ƃ��ďꍇ�͔z��̑傫����100�Ƃ���)
        //�ϐ��̏���������///////////////////////////
        for (int i = 0; i < 3; i++)
        {
            resultID[i] = i;
        }
        resultAR[0] = 0.30f;//�X���C���Ƃ̃G���J�E���g����30%�ɐݒ�
        resultAR[1] = 0.20f;//�S�u�����Ƃ̃G���J�E���g����20%�ɐݒ�
        resultAR[2] = 0.50f;//�����Ƒ������Ȃ��m����50%�ɐݒ�
        //�ϐ��̏����������I��////////////////////////
        //encount�z��̒��g��0�ɏ�����
        for (int i = 0; i < encount.Length; i++)
        {
            encount[i] = 0;
        }
        //resultID�̏o�����ɏ]����resultID��z��ϐ�encount�i�[���鏈��
        for (int i = 0; i < resultID.Length; i++)
        {
            if (resultAR[i] != 0)
            {
                for (int j = 0; j < Mathf.Floor(resultAR[i] * 100); j++)//�o������float�Ȃ̂�100�{���Đ����ɂ���B�����_�ȉ��̌덷�΍�Ƃ��Đ؂�̂ď���(Mathf.Floor)���g�p����
                {
                    encount[count] = resultID[i];
                    count++;
                }
            }
        }
        //�����_���֐����g�p����̂ŁA��Ƀ����_���V�[�h�������ɂ�菉�������āA�����_�������グ��
        Random.InitState(System.DateTime.Now.Millisecond);
        //�����_���C���f�b�N�X���v�Z
        int randomIndex = Random.Range(0, encount.Length);
        //�m���ɉ������ɃG���J�E���g�v�Z���ʂ�ϐ�result
        result = encount[randomIndex];
        //�v�Z���ʂɉ����ăe�L�X�g�I�u�W�F�N�g�̕\����ύX���鏈��
        if (result == resultID[0])
        {
            ResultText.text = "Encount a Slime";
        }
        else if (result == resultID[1])
        {
            ResultText.text = "Encount a Goblin";
        }
        else
        {
            ResultText.text = "nobady";
        }
    }
}