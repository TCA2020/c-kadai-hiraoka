using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFactory : MonoBehaviour
{
    [Header("Set Enemy Prefab")]
    [SerializeField]
    private GameObject enemyPrefab;

    [Header("Set Intervar Min and Max")]
    [Range(1f,3f)]
    [SerializeField]
    private float minTime = 2f;
    [Range(5f,10f)]
    [SerializeField]
    private float maxTime = 5f;

    [Header("Set X Position")]
    [SerializeField,Range(5f,95f)]
    private float xMinPOsition = -10f;
    [SerializeField, Range(5f, 95f)]
    private float xMaxPOsition = 10f;
    [Header("Set X Position")]
    [SerializeField, Range(5f, 95f)]
    private float yMinPOsition = 0f;
    [SerializeField, Range(5f, 95f)]
    private float yMaxPOsition = 10f;
    [Header("Set X Position")]
    [SerializeField, Range(5f, 95f)]
    private float zMinPOsition = 0f;
    [SerializeField, Range(5f, 95f)]
    private float zMaxPOsition = 10f;
    
    private float interval;
    
    private float time = 0;
    // Start is called before the first frame update
    void Start()
    {
        interval = GetRandomTime();
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if (time > interval)
        {
            GameObject enemy = Instantiate(enemyPrefab);
            enemy.transform.position = GetRandomPosition();

            time = 0;

            interval = GetRandomTime();
        }
    }

    float GetRandomTime()
    {
        return Random.Range(minTime, maxTime);
    }

    Vector3 GetRandomPosition()
    {
        float x = Random.Range(xMinPOsition, xMaxPOsition);
        float y = Random.Range(yMinPOsition, yMaxPOsition);
        float z = Random.Range(zMinPOsition, zMaxPOsition);
        return new Vector3(x, y, z);
    }
}
