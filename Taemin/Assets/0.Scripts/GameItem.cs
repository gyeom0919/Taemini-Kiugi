using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameItem
{
    public Sprite sprite;
    public int number;
    public string name;
    public string status;
    public string discription;
    public string ItemType;
    public int status_int;
    public int useGangHwaSu;
    public int upGradeGold;
    public int persent;
    public int howhighGanghwa = 0;
    public string inosnetname;
    public int inosentStatus_int;
    public int isacesoryCnt = 0;
    public bool isequipting;
    public int dropGanghwasu=0;


    public GameItem(Sprite sprite, int num, string nam, string stat, string discrip, string temType, int _status_int, int _persent, int _useGangHwaSu, int _upGradeGold,int _dropGanghwasu)
    {
        this.sprite = sprite;
        number = num;
        name = nam;
        status = stat;
        discription = discrip;
        ItemType = temType;
        status_int = _status_int;
        useGangHwaSu = _useGangHwaSu;
        persent = _persent;
        upGradeGold = _upGradeGold;
        inosnetname = nam;
        dropGanghwasu = _dropGanghwasu;
        inosentStatus_int = _status_int;
    }

    public GameItem(Sprite sprite, int num, string nam, string discrip, string temType, int _isacessory)
    {
        this.sprite = sprite;
        number = num;
        name = nam;
        discription = discrip;
        ItemType = temType;
        inosnetname = nam;
        isacesoryCnt = _isacessory;
    }
    public GameItem(Sprite sprite, int num, string nam, string discrip, string temType)
    {
        this.sprite = sprite;
        number = num;
        name = nam;
        discription = discrip;
        ItemType = temType;
        inosnetname = nam;

    }

    public void acessory1_StatusSetting()
    {
        GameObject.Find("Taemin").GetComponent<Player>().Dex += 5 * (GameObject.Find("Taemin").GetComponent<LevelSilider>().Level);
        GameObject.Find("Taemin").GetComponent<Player>().Hp += 50 * (GameObject.Find("Taemin").GetComponent<LevelSilider>().Level);
        GameObject.Find("Taemin").GetComponent<Player>().CriticalPersent += 40;
    }
    public void acessory1_StatusOut()
    {
        GameObject.Find("Taemin").GetComponent<Player>().Dex -= 5 * (GameObject.Find("Taemin").GetComponent<LevelSilider>().Level);
        GameObject.Find("Taemin").GetComponent<Player>().Hp -= 50 * (GameObject.Find("Taemin").GetComponent<LevelSilider>().Level);
        GameObject.Find("Taemin").GetComponent<Player>().CriticalPersent -= 40;
    }

    public void acessory2_StatusSetting()
    {
        GameObject.Find("Taemin").GetComponent<Player>().GetGold *= 3;
        GameObject.Find("Taemin").GetComponent<Player>().GetExp *= 3;
    }

    public void acessory2_StatusOut()
    {
        GameObject.Find("Taemin").GetComponent<Player>().GetGold /= 3;
        GameObject.Find("Taemin").GetComponent<Player>().GetExp /= 3;
    }

    public void acessory3_StatusSetting()
    {
        GameObject.Find("Taemin").GetComponent<Player>().CriticalPersent += 50;
        GameObject.Find("Taemin").GetComponent<Player>().Str += 5 * (GameObject.Find("Taemin").GetComponent<LevelSilider>().Level);
    }

    public void acessory3_StatusOut()
    {
        GameObject.Find("Taemin").GetComponent<Player>().CriticalPersent -= 50;
        GameObject.Find("Taemin").GetComponent<Player>().Str -= 5 * (GameObject.Find("Taemin").GetComponent<LevelSilider>().Level);

    }

    public void acessory4_StatusSetting()
    {
        GameObject.Find("Taemin").GetComponent<Player>().CriticalPersent += 80;
        GameObject.Find("Taemin").GetComponent<Player>().CriticalDamage += 100;

    }
    public void acessory4_StatusOut()
    {
        GameObject.Find("Taemin").GetComponent<Player>().CriticalPersent -= 80;
        GameObject.Find("Taemin").GetComponent<Player>().CriticalDamage -= 100;

    }
}







