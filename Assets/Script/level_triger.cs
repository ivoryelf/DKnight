using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level_triger : MonoBehaviour
{
    SpawnManager sm;
    // Start is called before the first frame update
    void Start()
    {
        sm = GameObject.Find("spawnManger").GetComponent<SpawnManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.name == "Player")
        {
            // SpawnManager.Instance.check_trigger();
            
            sm.check_trigger();
        }
    }
}
