using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Bolt;

public class Player : MonoBehaviour
{
    public int GangHwaSu = 99999;
    public Text GangHwaSuText;

    public TaminAttak taminAttack;
    public TaminHealth taminHealth;
    public GameObject tamin;

    public int Str = 5;
    public int Dex = 2;
    public int Hp = 200;
    public int CriticalPersent = 0;
    public int CriticalDamage = 0;
    public int GetGold = 1;
    public int GetExp = 1;

    public int StatusPoint = 0;
    private void Update()
    {
        GangHwaSuText.text = GangHwaSu.ToString();
    }
    private void Start()
    {
        taminAttack= tamin.GetComponent<TaminAttak>();
        taminHealth= tamin.GetComponent<TaminHealth>();
    }

    public void SetStatus()
    {
        taminAttack.attackDamage = Str;
        taminHealth.startHp = Hp;
        taminAttack.Criticalper = CriticalPersent;
        taminAttack.CriticalDmg = CriticalDamage;
        taminHealth.Dex = Dex;
    }
}
