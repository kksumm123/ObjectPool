using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLocal : MonoBehaviour
{
    public Vector3 moveAxis = new Vector3(0, 1, 0);
    public float speed = 3;
    [SerializeField] float destroyTime = 5;
    private void Awake()
    {
        Destroy(gameObject, destroyTime);
    }
    void Update()
    {
        transform.Translate(moveAxis * speed * Time.deltaTime, Space.Self);
    }
}