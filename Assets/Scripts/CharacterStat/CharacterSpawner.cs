using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CharacterSpawner : MonoBehaviour
{
    [SerializeField]
    private List<CharacterStatData> characterDatas;     //데이터 : name, hp, attack, magic, defence, mp, speed 

    [SerializeField]
    private GameObject characterPrefab;

    public GameObject[] characters;    //캐릭터 모양(오브젝트)

    public GameObject currentCharacter;   //선택된 캐릭터

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
