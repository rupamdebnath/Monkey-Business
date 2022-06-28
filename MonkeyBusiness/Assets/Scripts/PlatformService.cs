using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformService : MonoBehaviour
{
    public static PlatformService instance;

    [SerializeField]

    void Awake()
    {
        if (instance == null)
            instance = this;
    }
}
