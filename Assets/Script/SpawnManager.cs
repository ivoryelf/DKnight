using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public float spawn_time;
    public GameObject enemy;
    public Transform[] spawnPoints;
    public int max_sub_level;
    public int[] level_enemys;
    public int e_cnt, max_cnt;

    protected static SpawnManager instance = null;
    public static SpawnManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = System.Activator.CreateInstance(typeof(SpawnManager)) as SpawnManager;
            }
            return instance;
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        max_cnt = spawnPoints.Length;
        e_cnt = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public bool check_trigger()
    {
        if(e_cnt < max_cnt)
        {
            for (int i = 0; i < max_cnt; i++)
            {
                //int x = Random.Range(0, spawnPoints.Length);
                enemy.SetActive(true);
                Instantiate(enemy, spawnPoints[i]);
                e_cnt++;
                Debug.Log("check trigger!!");
            }
        }

        return true;
    }

}
