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
    //Vector3 dir;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        h_axis = Input.GetAxisRaw("Horizontal");
        v_axis = Input.GetAxisRaw("Vertical");
        move_vec = new Vector3(h_axis, 0, v_axis).normalized;
        if(!(h_axis==0 && v_axis == 0))
        {
            transform.position += move_vec * speed * Time.deltaTime;
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(move_vec), Time.deltaTime * rspeed);

        }
    }
}
