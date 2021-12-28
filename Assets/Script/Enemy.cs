using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int hp = 10;
    public int maxHp;

    Rigidbody rigid;
    BoxCollider box_collider;
    public Transform Target;

    // Start is called before the first frame update
    void Awake()
    {
        rigid = GetComponent<Rigidbody>();
        box_collider = GetComponent<BoxCollider>();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Melee")
        {
            Debug.Log("----enemy hit by Melee!!!");
            Destroy(gameObject);
        }

    }
    // Update is called once per frame
    void Update()
    {
        if(hp <= 0)
        {
            Destroy(this.gameObject);
        }
        transform.position = Vector3.MoveTowards(transform.position, Target.position, 0.01f);

    }

    public void doDamage(int damage)
    {
        hp -= damage;
        Debug.Log(hp);
    }
}
