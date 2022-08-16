using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CharacterStatManager : MonoBehaviour
{
    public static CharacterStatManager instance;

    public CharacterType currentCharacterType;

    Button nextScene;              //������ ���� ��ư
    int sceneIndex = 1;            //test

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
            
        }
        else if(instance != null)
        {
            Destroy(this.gameObject);
        }
    }
    private void Start()
    {
        nextScene = GameObject.Find("NextButton").GetComponent<Button>();
        nextScene.onClick.AddListener(OnStageStart); //addListener�� �̺�Ʈ �߻� �ø��� �����

    }
    void OnStageStart()
    {
        //�߰� : select ��ư�� ���� �� ĳ���͸� �������� �ʰ� next ��ư�� ������ ���� �޽����� �ߵ��� ��

        //���� : ��ü ���� ��Ƽ� �̸��̳� index ���� �ʿ�
        SceneManager.LoadScene(sceneIndex);
    }
}
