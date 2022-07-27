using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class Spawner : IFactory
{
    private GameObject product;
    public GameObject Product { get => product; set => product = value; }

    public void Create()
    {
        GameObject.Instantiate(product as GameObject);
    }
}
