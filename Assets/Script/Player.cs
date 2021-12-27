using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float h_axis;
    float v_axis;
    float speed = 10f;
    float rspeed = 5f;
    Vector3 move_vec;
    Animator anim;
    Rigidbody rigid;
    bool walk_down;
    bool fire_down;
    bool fire_ready;
    float fire_delay;
    Weapon equip_weapon;

    void Awake()
    {
        rigid = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetInput();
        Move();
        Attack();
    }

    void GetInput()
    {
        h_axis = Input.GetAxisRaw("Horizontal");
        v_axis = Input.GetAxisRaw("Vertical");
        walk_down = Input.GetButton("Walk");
        fire_down = Input.GetButton("Fire1");
    }

    void Move()
    {
        move_vec = new Vector3(h_axis, 0, v_axis).normalized;
        if (!(h_axis == 0 && v_axis == 0))
        {
            transform.position += move_vec * speed * (walk_down ? 0.3f : 1f) * Time.deltaTime;
            anim.SetBool("isRun", move_vec != Vector3.zero);
            anim.SetBool("isWalk", walk_down);
            transform.LookAt(transform.position + move_vec);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
/*        if (collision.gameObject.tag == "Enemy")
        {
            collision.gameObject.GetComponent<Enemy>().doDamage(5);
            Debug.Log(collision.gameObject.name);
            Debug.Log(collision.gameObject.tag);
        }*/
    }


    void Attack()
    {
/*        Collider[] cols = Physics.OverlapBoxAll(pos, boxsize, 0);
        foreach(Collider col in cols)
        {
            if(collider.tag == "Enemy")
            {
                col.GetComponent<Enemy>().TakeDamage();
            }
        }*/

        if(fire_down)
        {
          //  equip_weapon.Use();
            anim.SetTrigger("trAttack");
            //fire_delay = 0;
        }
    }
}
