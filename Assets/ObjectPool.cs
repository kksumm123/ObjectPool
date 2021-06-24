using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    static ObjectPool instance;
    private void Awake()
    {
        instance = this;
    }
    new public static T instantiate<T>(T original) where T : Object
    {

    }
}
