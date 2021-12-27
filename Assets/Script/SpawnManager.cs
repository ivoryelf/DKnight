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
    // Start is called before the first frame update
    void Start()
    {
        max_cnt = spawnPoints.Length;
        e_cnt = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(e_cnt < max_cnt)
        {
            int x = Random.Range(0, spawnPoints.Length);
            Instantiate(enemy, spawnPoints[x]);
            e_cnt++;
        }
    }

    void GenerateEnemy(int level, int num_enemy)
    {
/*        level_enemys[level] = num_enemy;
        for(int i: i < num_enemy: i++)
        {
            Instantiage(enemy, spawnPoints[i]);
        }*/
    }

}
