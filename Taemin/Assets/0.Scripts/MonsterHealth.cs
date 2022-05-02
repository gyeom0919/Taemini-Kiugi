using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Bolt;

public class MonsterHealth : MonoBehaviour
{

    public int dropGold;
    public int dropGanghwasu;
    public int monNum;
    public Item item;
    public bool isdragon = false;
    public Sprite dragonbosang;
    public NewBehaviourScript Sponer;
    public int[,,] dropItem = new int[,,] { { { 0, 5 }, { 1, 3 }, { 2, 1 } , {5 ,8} , { 6, 5} , { 7, 3},  {8, 1} , { 11,5}, { 12, 3 }, { 13, 1 } , { 17, 5 }, { 18, 3 }, { 19, 1 } },
                                            { { 1, 5 }, { 2, 3 }, { 3, 1 } , {6 ,8} , { 7, 5 } , { 8, 3 },  {9, 1} , { 12, 5 }, { 13, 3 }, { 14, 1 } , { 18, 5 }, { 19, 3 }, { 20, 1 } },
                                            { { 1, 7 }, { 2, 5 }, { 3, 3 } , {6 ,1} , { 7, 7 } , { 8, 5 },  {9, 3} , { 12, 10 }, { 13, 5 }, { 14, 2 } , { 18, 10 }, { 19, 5 }, { 20, 2 } }};

    public void Start()
    {
        Sponer=GameObject.Find("SpwonManager").GetComponent<NewBehaviourScript>();
        item = GameObject.Find("ItemManager").GetComponent<Item>();
    }

    public void Update()
    {

    }

    public GameItem boksa(GameItem gm)
    {
        GameItem gitem = new GameItem(gm.sprite, gm.number, gm.name, gm.status, gm.discription, gm.ItemType, gm.status_int, gm.persent, gm.useGangHwaSu, gm.upGradeGold, gm.dropGanghwasu);
        gitem.name = gm.inosnetname;
        gitem.status_int = gm.inosentStatus_int;
        return gitem;

    }

    public void GetReword()
    {
        if (isdragon)
        {
            item.GetItem(new GameItem(dragonbosang,50,"찔끔지린 드레곤의 오줌","통신과에 가져가면 \n무언가 선물을 줄거같다.","재료"));
        }
        Variables.Saved.Set("Jelatine", Variables.Saved.Get<int>("Jelatine") + dropGold* GameObject.Find("Taemin").GetComponent<Player>().GetGold);
        GameObject.Find("Taemin").GetComponent<Player>().GangHwaSu += dropGanghwasu;
        for(int i = 0; i < 13; i++)
        {
            
            if(Random.Range(1, 101) <= dropItem[monNum, i, 1])
            item.GetItem(   boksa(item.Itemlist[dropItem[monNum,i,0]]));
        }
        for(int i = 0; i <= 12; i++)
        {
            if (Random.Range(1, 101) <= 1)
            {
                item.GetItem(item.Itemlist[26+i]);
            }
        }
    }

    public int startingHelath = 100;
    public int currentHealth;
    Animator anim;
    public bool isDead;
    public bool isDamage;

    private void Awake()
    {
        anim = GetComponent<Animator>();
        currentHealth = startingHelath;
    }

    public void TakeDamage(int amount)
    {
        if (isDead) return;
        currentHealth -= amount;
        isDamage = true;
        anim.SetBool("isDamage", true);
        if (currentHealth <= 0)
        {
            Death();
        }
    }

    public void Death()
    {
        
        
        isDead = true;
        anim.SetTrigger("isDead");
        Destroy(gameObject, 3f);
        Sponer.monCnt += 1;
        Sponer.isClear();
        GetReword();
        
    }

    
}
