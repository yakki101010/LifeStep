using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GorB : MonoBehaviour
{
    // �V���O���g���C���X�^���X
    // ���̃v���p�e�B��ʂ��āA�ǂ�����ł��Q�[���}�l�[�W���[�̃C���X�^���X�ɃA�N�Z�X�ł��܂�
    public static GorB Instance { get; private set; }

    // �V�[���Ԃŋ��L����f�[�^
    // �����̕ϐ��́A�V�[���Ԃŕێ������l���i�[���܂�

    public bool gorb;//�j������ 

    // ���̃f�[�^��ǉ��ł��܂�

    private void Awake()
    {
        // �V���O���g���p�^�[���̎���
        if (Instance == null)
        {
            // �����̃Q�[���}�l�[�W���[�C���X�^���X���Ȃ��ꍇ�A
            // ���݂̃C���X�^���X��ݒ肵�A�V�[���J�ڎ��ɔj������Ȃ��悤�ɂ��܂�
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            // �����̃Q�[���}�l�[�W���[�C���X�^���X������ꍇ�A
            // �d��������邽�߂Ɍ��݂̃C���X�^���X��j�����܂�
            Destroy(gameObject);
        }
    }
    public void BoyBottn()
    {
        gorb = true;
    }
    public void GirlBottn()
    {
        gorb = false;
    }
    public void OkBottn()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
