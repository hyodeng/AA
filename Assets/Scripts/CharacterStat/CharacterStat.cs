using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

[Serializable]
public class character
{
    public string _name, desc;
    public int maxhp, hp, maxmp, mp, attack, attackup, magic, magicup, defence, defenceup, speed, speedup;
    public string[] equipment;
}


[Serializable]
public class Character
{
    public character[] character;
}


public class CharacterStat : MonoBehaviour
{
    //
    public TextAsset textAsset;
    public Character character;

    //Max 스탯
    public float statHp = 15;
    public float statMp = 8;
    public float statAttack = 12;
    public float statMagic = 7;
    public float statDefence = 6;
    public float statSpeed = 12;
   
    public Button button_warrior;
    public Button button_mage;
    public Button button_clreic;
    public Button button_thief;
    public Button button_popstar;
    public Button button_chef;

    SliderBar hslier;

    public Slider hpSlider;
    public Slider mpSlider;
    public Slider attackSlider;
    public Slider magicSlider;
    public Slider defenceSlider;
    public Slider speedSlider;

    CharacterData data; //
    
    CharacterSpawner characterSpawner; //?사용 안함

    GameObject characterBoard;
    TextMeshProUGUI playerName;
    TextMeshProUGUI playerExplanation;

    public ParticleSystem backAura;
    private void Awake()
    {
        //Resource 폴더/Json 폴더/Character.json 파일에서 캐릭터 정보 읽어옴
        character = JsonUtility.FromJson<Character>(textAsset.text);

        playerName = GameObject.Find("PlayerName").GetComponent<TextMeshProUGUI>();
        playerExplanation = GameObject.Find("PlayerExplanation").GetComponent<TextMeshProUGUI>();

    }
    private void Start()
    {
        //data = FindObjectOfType<CharacterData>();

        characterBoard = GameObject.Find("CharacterBoard");
        characterBoard.SetActive(false);

        hpSlider = GameObject.Find("HPBar").GetComponent<Slider>();
        mpSlider = GameObject.Find("MPBar").GetComponent<Slider>();
        attackSlider = GameObject.Find("AttackBar").GetComponent<Slider>();
        magicSlider = GameObject.Find("MagicBar").GetComponent<Slider>();
        defenceSlider = GameObject.Find("DefenceBar").GetComponent<Slider>();
        speedSlider = GameObject.Find("SpeedBar").GetComponent<Slider>();

        button_warrior.onClick.AddListener(() => DataSetup(CharacterType.Warrior));
        button_mage.onClick.AddListener(() => DataSetup(CharacterType.Mage));
        button_clreic.onClick.AddListener(() => DataSetup(CharacterType.Cleric));
        button_thief.onClick.AddListener(() => DataSetup(CharacterType.Thief));
        button_popstar.onClick.AddListener(() => DataSetup(CharacterType.Popstar));
        button_chef.onClick.AddListener(() => DataSetup(CharacterType.Chef));
    }
    //statHp     statMp     statAttack   statMagic   statDefence  statSpeed
    public void DataSetup(CharacterType type)
    {
        switch (type)
        {
            case CharacterType.Warrior:

                FindObjectOfType<CharacterData>().character = character.character[(int)CharacterType.Warrior];
                //스탯바_6가지 셋팅
                hpSlider.value = (float)character.character[(int)CharacterType.Warrior].hp / statHp;
                mpSlider.value = (float)character.character[(int)CharacterType.Warrior].mp / statMp;
                attackSlider.value = (float)character.character[(int)CharacterType.Warrior].attack / statAttack;
                magicSlider.value = (float)character.character[(int)CharacterType.Warrior].magic / statMagic;
                defenceSlider.value = (float)character.character[(int)CharacterType.Warrior].defence / statDefence;
                speedSlider.value = (float)character.character[(int)CharacterType.Warrior].speed / statSpeed;
                //캐릭터 설명
                playerName.text = character.character[(int)CharacterType.Warrior]._name;
                playerExplanation.text = character.character[(int)CharacterType.Warrior].desc;
                playerExplanation.transform.parent.gameObject.SetActive(true);

                //캐릭터 배경 파티클
                if (!backAura.isPlaying) {  backAura.Play(); }

                break;
            case CharacterType.Mage:
                FindObjectOfType<CharacterData>().character = character.character[(int)CharacterType.Mage];
                hpSlider.value = (float)character.character[(int)CharacterType.Mage].hp / statHp;
                mpSlider.value = (float)character.character[(int)CharacterType.Mage].mp / statMp;
                attackSlider.value = (float)character.character[(int)CharacterType.Mage].attack / statAttack;
                magicSlider.value = (float)character.character[(int)CharacterType.Mage].magic / statMagic;
                defenceSlider.value = (float)character.character[(int)CharacterType.Mage].defence / statDefence;
                speedSlider.value = (float)character.character[(int)CharacterType.Mage].speed / statSpeed;
                playerName.text = character.character[(int)CharacterType.Mage]._name;
                playerExplanation.text = character.character[(int)CharacterType.Mage].desc;
                playerExplanation.transform.parent.gameObject.SetActive(true);
                if (!backAura.isPlaying) { backAura.Play(); }
                break;
            case CharacterType.Cleric:
                FindObjectOfType<CharacterData>().character = character.character[(int)CharacterType.Cleric];
                hpSlider.value = (float)character.character[(int)CharacterType.Cleric].hp / statHp;
                mpSlider.value = (float)character.character[(int)CharacterType.Cleric].mp / statMp;
                attackSlider.value = (float)character.character[(int)CharacterType.Cleric].attack / statAttack;
                magicSlider.value = (float)character.character[(int)CharacterType.Cleric].magic / statMagic;
                defenceSlider.value = (float)character.character[(int)CharacterType.Cleric].defence / statDefence;
                speedSlider.value = (float)character.character[(int)CharacterType.Cleric].speed / statSpeed;
                playerName.text = character.character[(int)CharacterType.Cleric]._name;
                playerExplanation.text = character.character[(int)CharacterType.Cleric].desc;
                playerExplanation.transform.parent.gameObject.SetActive(true);
                if (!backAura.isPlaying) { backAura.Play(); }
                break;
            case CharacterType.Thief:
                FindObjectOfType<CharacterData>().character = character.character[(int)CharacterType.Thief];
                hpSlider.value = (float)character.character[(int)CharacterType.Thief].hp / statHp;
                mpSlider.value = (float)character.character[(int)CharacterType.Thief].mp / statMp;
                attackSlider.value = (float)character.character[(int)CharacterType.Thief].attack / statAttack;
                magicSlider.value = (float)character.character[(int)CharacterType.Thief].magic / statMagic;
                defenceSlider.value = (float)character.character[(int)CharacterType.Thief].defence / statDefence;
                speedSlider.value = (float)character.character[(int)CharacterType.Thief].speed / statSpeed;
                playerName.text = character.character[(int)CharacterType.Thief]._name;
                playerExplanation.text = character.character[(int)CharacterType.Thief].desc;
                playerExplanation.transform.parent.gameObject.SetActive(true);
                if (!backAura.isPlaying) { backAura.Play(); }
                break;
            case CharacterType.Popstar:
                FindObjectOfType<CharacterData>().character = character.character[(int)CharacterType.Popstar];
                hpSlider.value = (float)character.character[(int)CharacterType.Popstar].hp / statHp;
                mpSlider.value = (float)character.character[(int)CharacterType.Popstar].mp / statMp;
                attackSlider.value = (float)character.character[(int)CharacterType.Popstar].attack / statAttack;
                magicSlider.value = (float)character.character[(int)CharacterType.Popstar].magic / statMagic;
                defenceSlider.value = (float)character.character[(int)CharacterType.Popstar].defence / statDefence;
                speedSlider.value = (float)character.character[(int)CharacterType.Popstar].speed / statSpeed;
                playerName.text = character.character[(int)CharacterType.Popstar]._name;
                playerExplanation.text = character.character[(int)CharacterType.Popstar].desc;
                playerExplanation.transform.parent.gameObject.SetActive(true);
                if (!backAura.isPlaying) { backAura.Play(); }
                break;
            case CharacterType.Chef:
                FindObjectOfType<CharacterData>().character = character.character[(int)CharacterType.Chef];
                hpSlider.value = (float)character.character[(int)CharacterType.Chef].hp / statHp;
                mpSlider.value = (float)character.character[(int)CharacterType.Chef].mp / statMp;
                attackSlider.value = (float)character.character[(int)CharacterType.Chef].attack / statAttack;
                magicSlider.value = (float)character.character[(int)CharacterType.Chef].magic / statMagic;
                defenceSlider.value = (float)character.character[(int)CharacterType.Chef].defence / statDefence;
                speedSlider.value = (float)character.character[(int)CharacterType.Chef].speed / statSpeed;
                playerName.text = character.character[(int)CharacterType.Chef]._name;
                playerExplanation.text = character.character[(int)CharacterType.Chef].desc;
                playerExplanation.transform.parent.gameObject.SetActive(true);
                if (!backAura.isPlaying) { backAura.Play(); }
                break;
        }
    }
    public void SelectType()
    {
        if(String.IsNullOrEmpty(FindObjectOfType<CharacterData>().character._name))
        {
            return;
        }

    }
}
