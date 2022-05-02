using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaminAttak : MonoBehaviour
{
    public float timeBetweenAttacks = 0.5f;
    public int attackDamage = 10;

    private GameObject tamin;
    private Animator anim;
    private TaminHealth taminHealth;
    private MonsterHealth monsterHealth;
    public bool monsterInRange;
    private float timer;

    public int Criticalper;
    public int CriticalDmg;

    private void Awake()
    {
        tamin = GameObject.FindGameObjectWithTag("Player");
        taminHealth = GetComponent<TaminHealth>();
        anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Monster")
        {
            monsterHealth = collision.gameObject.GetComponent<MonsterHealth>();
            monsterInRange = true;
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Monster")
        {
            monsterHealth = collision.gameObject.GetComponent<MonsterHealth>();
            monsterInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Monster")
        {
            monsterInRange = false;
            timer = 0;
        }
    }

    

    private void Update()
    {
        timer += Time.deltaTime;
        if (timer >= timeBetweenAttacks && monsterInRange)
        {
            Attack();
        }

    }

    void Attack()
    {
        timer = 0f;
        if (!taminHealth.isDead)
        {
            if(Random.Range(1,101) <= Criticalper)
            {
                monsterHealth.TakeDamage(attackDamage);
            }

            else
            {
                monsterHealth.TakeDamage(attackDamage*(2+ CriticalDmg/100));
            }

        }
    }

}
