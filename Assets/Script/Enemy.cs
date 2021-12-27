using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int hp = 10;
    public int maxHp;

    Rigidbody rigid;
    BoxCollider box_collider;
    // Start is called before the first frame update
    void Awake()
    {
        rigid = GetComponent<Rigidbody>();
        box_collider = GetComponent<BoxCollider>();
    }

/*    void OnCollisionEnter(Collision other)
    {
        Debug.Log("----enemy collsion :");
        if (other.gameObject.tag == "Melee")
        {
            Debug.Log("----enemy hit by Melee!!!");
            //Weapon w = other.GetComponent<Weapon>();
            Destroy(gameObject, 3);
        }

    }*/

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Melee")
        {
            Debug.Log("----enemy hit by Melee!!!");
            Destroy(gameObject, 1);
        }

    }
    // Update is called once per frame
    void Update()
    {
        if(hp <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    public void doDamage(int damage)
    {
        hp -= damage;
        Debug.Log(hp);
    }
}
