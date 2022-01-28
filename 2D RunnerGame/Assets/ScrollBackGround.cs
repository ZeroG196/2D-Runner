using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollBackGround : MonoBehaviour
{
    public float speed;
    public Transform[] backgrounds;

    float leftPosX = 0f;
    float rightPosX = 0f;
    float xScreenHalfSize;
    float yScreenHalfSize;

    void Start()
    {
        xScreenHalfSize = Camera.main.orthographicSize;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
