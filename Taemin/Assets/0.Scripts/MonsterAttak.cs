using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterAttak : MonoBehaviour
{
    public float timeBetweenAttacks = 0.5f;
    public int attackDamage = 10;


    public Collider2D coll;
    private GameObject player;
    private TaminHealth taminHealth;
    private TaminAttak taminAttak;
    private Animator anim;
    private MonsterHealth monsterHealth;


    private bool playerInRange;
    private float timer;
   public bool playerDead;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        taminHealth = player.GetComponent<TaminHealth>();
        taminAttak = player.GetComponent<TaminAttak>();
        monsterHealth = GetComponent<MonsterHealth>();
        anim = GetComponent<Animator>();
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            playerInRange = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            playerInRange = false;
            timer = 0;
        }
    }
    private void Update()
    {
        timer += Time.deltaTime;
        if(taminHealth.isDead == true)
        {
            Destroy(gameObject);
        }
        if (timer >= timeBetweenAttacks && playerInRange)
        {
            Attack();
        }

        if (taminHealth.currentHp <= 0)
        {
            anim.SetTrigger("PlayerDead");
            playerDead = true;
        }
    }

    void Attack()
    {
        timer = 0f;
        if (!taminHealth.isDead && !monsterHealth.isDead)
        {
           
          if(attackDamage - taminHealth.Dex <= 0)
            {
                taminHealth.TakeDamage(1);
            }
            else
            {
                taminHealth.TakeDamage(attackDamage - taminHealth.Dex);
            }
              
            
        }
    }
}
