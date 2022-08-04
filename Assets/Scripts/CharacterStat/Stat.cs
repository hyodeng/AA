using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//플레이어 공통 스탯 (몬스터도 똑같이 할 수도....)
public class Stat 
{
    public CharacterType type { get ; }
    public string name { get ; set ; }
    public int level { get ; set ; }
    public int hp { get; set; }
    public int attack { get; set; }
    public int magic { get; set; }
    public int defense { get; set; }
    public int mp { get; set; }
    public float speed { get; set; }

    public string playerExplanation { get; set; }

    public Stat() { }


    public Stat(CharacterType type, string name, int level, int hp, int attack, int magic, int defense, int mp, float speed, string playerExplanation)
    {
        this.type = type;
        this.name = name;
        this.level = level;
        this.hp = hp;
        this.attack = attack;
        this.magic = magic;
        this.defense = defense;
        this.mp = mp;
        this.speed = speed;
        this.playerExplanation = playerExplanation;
    }


    //public Stat SetCharacterStatus(CharacterType type)
    //{
    //    Stat status = null;

    //    switch (type)
    //    {
    //        case CharacterType.Warrior:
    //            status = new(type, "Warrior", 1, 12, 4, 12, 0, 5, 5, "힘이 강하고 방어도 튼튼\n 커다란 검을 들고 싸운다" );
    //            break;
    //        case CharacterType.Mage:
    //            status = new(type, "Mage", 1, 10, 8, 7, 6, 5, 10, "마법으로 적을 날린다\n 대미지는 최상급");
    //            break;
    //        case CharacterType.Cleric:
    //            status = new(type, "Cleric", 1, 10, 8, 8, 7, 5, 11, "신비 마법으로 상처 치유\n 동료들의 위기에서 대활약");
    //            break;
    //        case CharacterType.Thief:
    //            status = new(type, "Thief", 1, 10, 5, 8, 3, 6, 12, "날쌘 움직임과 기술로 적을 농락\n 전투를 유리하게 만든다");
    //            break;
    //        case CharacterType.Popstar:
    //            status = new(type, "Popstar", 1, 15, 6, 6, 4, 4, 6, "매력에 모두들 폴 인 러브\n 동료들의 힘이 곧 무기");
    //            break;
    //        case CharacterType.Chef:
    //            status = new(type, "Chef", 1, 9, 7, 8, 3, 5, 5, "손 무기는 프라이팬\n 공격! 회복! 주방장 마음");
    //            break;
    //        default:
    //            break;

    //    }

    //    return status;
    //}


}
