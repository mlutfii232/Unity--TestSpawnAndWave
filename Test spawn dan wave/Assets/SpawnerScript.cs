using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
     [Header("Set Spawn Time")]
    public float textShow = 1;
    public float spawnTime = 1;
    public float spawnCounter = 1;
    public int waveCounter = 1;

    [Header("Set Prefabs Musuh")]
    [Tooltip("Ini untuk mengatur objek musuh")]
    public GameObject cubePrefab;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(cubePrefab, transform.position, Quaternion.identity);
        }
    }
}
