using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMissile : MonoBehaviour
{
    [SerializeField] GameObject prefab1;
    [SerializeField] GameObject prefab2;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            ObjectPool.Instantiate(prefab1);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            ObjectPool.Instantiate(prefab2);
        }
    }
}
