using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public float spawn_time;
    public GameObject enemy;
    public Transform[] spawnPoints;
    public int max_sub_level;
    public int[] level_enemys = int[10];//sub levels max : 10ea(by 1 stage ) 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GenerateEnemy(int level, int num_enemy)
    {
        level_enemys[level] = num_enemy;
        foreach(int i in num_enemy)
        {
            Instantiage(enemy, spawnPoints[i]);
        }
    }

}
