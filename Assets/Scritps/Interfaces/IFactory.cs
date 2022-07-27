using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IFactory 
{
    GameObject Product { get; set; }
    void Create();
}
