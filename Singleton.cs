using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : Component
{
    protected static T INSTANCE;

    public static T Instance
    {
        get
        {
            if (INSTANCE == null)
            {
                INSTANCE = FindObjectOfType<T>();

                if (INSTANCE == null)
                {
                    GameObject obj = new GameObject();
                    obj.name = typeof(T).Name;
                    INSTANCE = obj.AddComponent<T>();
                }
            }
            return INSTANCE;
        }
    }

    public virtual void Awake()
    {
        if (INSTANCE == null)
        {
            INSTANCE = this as T;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
