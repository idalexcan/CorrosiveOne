using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager manager;

    public GameObject hollowPrefabio, field;
    public GameObject personalCamera; 


    private void Awake()
    {
        manager = this;
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
