using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterMove : MonoBehaviour
{
    Rigidbody2D rigid;
    Vector2 die;
    Vector2 move;
    Vector2 back;
    Transform tr;
    bool isDie = false;
    float timer;
    Animator anim;
    MonsterHealth monsterHealth;
    MonsterAttak monsterAttak;
    public float speed = 1;
    private void Awake()
    {

        move = new Vector2(-speed, 0);
        die = new Vector2(0, 0);
        back = new Vector2(speed, 0);

    }

    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        monsterHealth = GetComponent<MonsterHealth>();
        tr = GetComponent<Transform>();
        monsterAttak = GetComponent<MonsterAttak>();
    }

    // Update is called once per frame
    void Update()
    {

        if (monsterHealth.isDamage)
        {
            timer += Time.deltaTime;
            Vector2 currentP = new Vector2(tr.position.x,tr.position.y);
            tr.position = Vector2.Lerp(currentP, new Vector2(currentP.x + 1, currentP.y), 0.1f);
            if (timer >= 0.05f)
            {
                monsterHealth.isDamage = false;
                timer = 0f;
                anim.SetBool("isDamage",false);
            }
        }
        else
        {
            rigid.velocity = monsterHealth.isDead||monsterAttak.playerDead ? die : move;
        }
    }

}
