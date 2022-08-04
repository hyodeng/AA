using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReSpawner : MonoBehaviour
{
    public GameObject[] characterprefabs;
    GameObject selectedCharacter;

    private void Start()
    {
    //    if(selectedCharacter != null)
    //    {
    //        selectedCharacter = Instantiate(characterprefabs[(int)CharacterStatManager.instance.currentCharacterType]);
    //        selectedCharacter.transform.position = transform.position;  //캐릭터 스폰 위치 바꿀 수 있음
    //    }
    //    //테스트용 _나중에 삭제
    //    selectedCharacter = Instantiate(characterprefabs[(int)CharacterType.Chef]);
    //    selectedCharacter.transform.position = transform.position;  //캐릭터 스폰 위치 바꿀 수 있음

    }

}
