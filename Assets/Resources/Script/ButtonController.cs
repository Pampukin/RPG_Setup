using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//��ʑJ�ڂ��s���ALoadScene���g�p���邽�߂ɓ���
using UnityEngine.UI;//Image�^���������߂ɓ���
using TMPro;

public class ButtonController : MonoBehaviour
{
    //�^�C�g���{�^�������������̏���
    public void ClickTitleButton()
    {
        // " "���ɋL�q���ꂽ���O�̃V�[�������[�h����i��ʑJ�ځj
        SceneManager.LoadScene("TitleScene");
    }

    [SerializeField] TextMeshProUGUI EnemyNameText = null;//�G�l�~�[�̖��O��\��������Text�I�u�W�F�N�g�Ƃ̘A�g�̂��߂ɓ���
    [SerializeField] TextMeshProUGUI HpText = null;//�G�l�~�[��HP��\��������Text�I�u�W�F�N�g�Ƃ̘A�g�̂��߂ɓ���
    [SerializeField] Image EnemyImage = null;//�G�l�~�[�摜��\��������Image�I�u�W�F�N�g�Ƃ̘A�g�̂��߂ɓ���
    private EnemyInformation enemyInfo;//CSV��ǂݍ���EnemyInformation�N���X���������߂ɐ錾

    private void Start()
    {
        enemyInfo = new EnemyInformation();//EnemyInformation�N���X�̎��̂Ƃ���enemyInfo����
        enemyInfo.Init();//CSV�f�[�^�̓ǂݍ��݂ƕϐ��ւ̊i�[����
    }
    //�u�X���C���v�{�^���������ꂽ���̓���BImage�I�u�W�F�N�g�ɃX���C���̉摜��\��������ƂƂ��ɁAText�I�u�W�F�N�g�ɖ��O��HP��\��������
    public void ClickSlimeButton()
    {
        EnemyNameText.text = enemyInfo.enemyName[1];//CSV�t�@�C������enemyID=1�ŕ\�����G�l�~�[�̖��O����Text�I�u�W�F�N�g�ɕ\��������
        HpText.text = "HP:" + enemyInfo.hp[1].ToString();//CSV�t�@�C������enemyID=1�ŕ\�����G�l�~�[��HP��Text�I�u�W�F�N�g�ɕ\��������(int�^���當����^�ɕϊ����邽�߂�.ToString()���g���Ă���_�ɒ��ӁB
        //CSV�t�@�C������enemyID=1�ŕ\�����G�l�~�[�̉摜�ۊǐ�(enemyInfo.imageAddress[1])�ŕ\�����t�@�C�����A�ϐ�EnemyImage�ƌ��ѕt����ꂽ�I�u�W�F�N�g�ɕ\�������鏈���B.png�Ȃǂ̊g���q�͕s�v
        EnemyImage.sprite = Resources.Load<Sprite>(enemyInfo.imageAddress[1]);
    }
    //�u�S�u�����v�{�^���������ꂽ���̓���BImage�I�u�W�F�N�g�ɃS�u�����̉摜��\��������ƂƂ��ɁAText�I�u�W�F�N�g�ɖ��O��HP��\��������
    public void ClickGoblinButton()
    {
        EnemyNameText.text = enemyInfo.enemyName[2];//CSV�t�@�C������enemyID=2�ŕ\�����G�l�~�[�̖��O����Text�I�u�W�F�N�g�ɕ\��������
        HpText.text = "HP:" + enemyInfo.hp[2].ToString();//CSV�t�@�C������enemyID=2�ŕ\�����G�l�~�[��HP��Text�I�u�W�F�N�g�ɕ\��������(int�^���當����^�ɕϊ����邽�߂�.ToString()���g���Ă���_�ɒ��ӁB
        //CSV�t�@�C������enemyID=2�ŕ\�����G�l�~�[�̉摜�ۊǐ�(enemyInfo.imageAddress[2])�ŕ\�����t�@�C�����A�ϐ�EnemyImage�ƌ��ѕt����ꂽ�I�u�W�F�N�g�ɕ\�������鏈���B.png�Ȃǂ̊g���q�͕s�v
        EnemyImage.sprite = Resources.Load<Sprite>(enemyInfo.imageAddress[2]);
    }
    //�u�h���S���v�{�^���������ꂽ���̓���BImage�I�u�W�F�N�g�Ƀh���S���̉摜��\��������ƂƂ��ɁAText�I�u�W�F�N�g�ɖ��O��HP��\��������
    public void ClickDragonButton()
    {
        EnemyNameText.text = enemyInfo.enemyName[3];//CSV�t�@�C������enemyID=3�ŕ\�����G�l�~�[�̖��O����Text�I�u�W�F�N�g�ɕ\��������
        HpText.text = "HP:" + enemyInfo.hp[3].ToString();//CSV�t�@�C������enemyID=3�ŕ\�����G�l�~�[��HP��Text�I�u�W�F�N�g�ɕ\��������(int�^���當����^�ɕϊ����邽�߂�.ToString()���g���Ă���_�ɒ��ӁB
        //CSV�t�@�C������enemyID=3�ŕ\�����G�l�~�[�̉摜�ۊǐ�(enemyInfo.imageAddress[3])�ŕ\�����t�@�C�����A�ϐ�EnemyImage�ƌ��ѕt����ꂽ�I�u�W�F�N�g�ɕ\�������鏈���B.png�Ȃǂ̊g���q�͕s�v
        EnemyImage.sprite = Resources.Load<Sprite>(enemyInfo.imageAddress[3]);
    }
    /*
//�u�X���C���v�{�^���������ꂽ���̓���BImage�I�u�W�F�N�g�ɃX���C���̉摜��\��������
public void ClickSlimeButton()
{
    //Assets������Resources�t�H���_�����ɂ���Image/pipo-enemy009�ƌ����p�X�ŕ\�����t�@�C�����A�ϐ�EnemyImage�ƌ��ѕt����ꂽ�I�u�W�F�N�g�ɕ\�������鏈���B.png�Ȃǂ̊g���q�͕s�v
    EnemyImage.sprite = Resources.Load<Sprite>("Image/Pipo-enemy009");
}
//�u�S�u�����v�{�^���������ꂽ���̓���BImage�I�u�W�F�N�g�ɃS�u�����̉摜��\��������
public void ClickGoblinButton()
{
    //Assets������Resources�t�H���_�����ɂ���Image/pipo-enemy011�ƌ����p�X�ŕ\�����t�@�C�����A�ϐ�EnemyImage�ƌ��ѕt����ꂽ�I�u�W�F�N�g�ɕ\�������鏈���B.png�Ȃǂ̊g���q�͕s�v
    EnemyImage.sprite = Resources.Load<Sprite>("Image/Pipo-enemy011");
}
//�u�h���S���v�{�^���������ꂽ���̓���BImage�I�u�W�F�N�g�Ƀh���S���̉摜��\��������
public void ClickDragonButton()
{
    //Assets������Resources�t�H���_�����ɂ���Image/pipo-enemy021�ƌ����p�X�ŕ\�����t�@�C�����A�ϐ�EnemyImage�ƌ��ѕt����ꂽ�I�u�W�F�N�g�ɕ\�������鏈���B.png�Ȃǂ̊g���q�͕s�v
    EnemyImage.sprite = Resources.Load<Sprite>("Image/Pipo-enemy021");
}
*/
}