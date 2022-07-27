﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    [SerializeField] private float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, -speed * Time.deltaTime, 0);
        if (transform.position.y < -10) 
        {
            transform.position = new Vector3(0, 10, 0);
        }
    }
}
