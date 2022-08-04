using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CharacterSpawner : MonoBehaviour
{
    [SerializeField]
    private List<CharacterStatData> characterDatas;     //������ : name, hp, attack, magic, defence, mp, speed 

    [SerializeField]
    private GameObject characterPrefab;

    public GameObject[] characters;    //ĳ���� ���(������Ʈ)

    public GameObject currentCharacter;   //���õ� ĳ����

    public void Selectcharacter(CharacterType type)
    {

        for (int i = 0; i < characters.Length; i++)
        {
            characters[i].SetActive(false);
        }
        characters[(int)type].SetActive(true);

        CharacterStatManager.instance.currentCharacterType = type;
    }



}
