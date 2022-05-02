using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TaminHealth : MonoBehaviour
{
    public int startHp = 100;
    public int currentHp;
    public Slider HP;
    public Text hp;
    private Animator anim;
    public int Dex;
    public NewBehaviourScript mo;
    public bool isDead;
    bool damaged;

    private void Awake()
    {
        currentHp = startHp;
        anim = GetComponent<Animator>();
      
        hp.text = string.Format(startHp + "/" + startHp);
    }

    private void Update()
    {
        damaged = false;
    }

    public void setHpbar()
    {
        HP.maxValue = startHp;
        HP.value = startHp;
        hp.text = string.Format(startHp + "/" + startHp);
    }

    public void TakeDamage(int amount)
    {
        damaged = true;
        currentHp -= amount;
        HP.value = currentHp;
        hp.text = string.Format(currentHp + "/" + startHp);
        if (currentHp <= 0 && !isDead)
        {
            Death();
        }
    }

    void Death()
    {
        isDead = true;
        anim.SetTrigger("isDead");

        mo.spawner[0].spawnNum = 0;
        mo.spawner[1].spawnNum = 0;
        mo.spawner[2].spawnNum = 0;
        mo.spawner[3].spawnNum = 0;
        mo.spawner[4].spawnNum = 0;
        mo.spawner[5].spawnNum = 0;
        mo.spawner[6].spawnNum = 0;
        mo.spawner[7].spawnNum = 0;

        GameObject.Find("GameManager").GetComponent<GameManager>().Gohome();
    }
}
