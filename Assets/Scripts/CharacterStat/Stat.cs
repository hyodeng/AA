using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//�÷��̾� ���� ���� (���͵� �Ȱ��� �� ����....)
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
    //            status = new(type, "Warrior", 1, 12, 4, 12, 0, 5, 5, "���� ���ϰ� �� ưư\n Ŀ�ٶ� ���� ��� �ο��" );
    //            break;
    //        case CharacterType.Mage:
    //            status = new(type, "Mage", 1, 10, 8, 7, 6, 5, 10, "�������� ���� ������\n ������� �ֻ��");
    //            break;
    //        case CharacterType.Cleric:
    //            status = new(type, "Cleric", 1, 10, 8, 8, 7, 5, 11, "�ź� �������� ��ó ġ��\n ������� ���⿡�� ��Ȱ��");
    //            break;
    //        case CharacterType.Thief:
    //            status = new(type, "Thief", 1, 10, 5, 8, 3, 6, 12, "���� �����Ӱ� ����� ���� ���\n ������ �����ϰ� �����");
    //            break;
    //        case CharacterType.Popstar:
    //            status = new(type, "Popstar", 1, 15, 6, 6, 4, 4, 6, "�ŷ¿� ��ε� �� �� ����\n ������� ���� �� ����");
    //            break;
    //        case CharacterType.Chef:
    //            status = new(type, "Chef", 1, 9, 7, 8, 3, 5, 5, "�� ����� ��������\n ����! ȸ��! �ֹ��� ����");
    //            break;
    //        default:
    //            break;

    //    }

    //    return status;
    //}


}
