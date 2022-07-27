using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CharacterInput : MonoBehaviour
{
    [SerializeField] private KeyCode forwardKey = KeyCode.W;
    [SerializeField] private KeyCode backwardKey = KeyCode.S;
    [SerializeField] private KeyCode leftKey = KeyCode.A;
    [SerializeField] private KeyCode rightKey = KeyCode.W;
    [SerializeField] private KeyCode shootKey = KeyCode.K;

    private bool isPressingForward = false;
    private bool isPressingBackward = false;
    private bool isPressingLeft = false;
    private bool isPressingRight = false;
    private bool isPressingShoot = false;

    public bool IsPressingForward { get => isPressingForward; }
    public bool IsPressingBackward { get => isPressingBackward; }
    public bool IsPressingLeft { get => isPressingLeft; }
    public bool IsPressingRight { get => isPressingRight; }
    public bool IsPressingShoot { get => isPressingShoot; }

    void Update()
    {
        if (Input.GetKey(forwardKey)) isPressingForward = true;
        else isPressingForward = false; 
        if (Input.GetKey(backwardKey)) isPressingBackward = true;
        else isPressingBackward = false; 
        if (Input.GetKey(leftKey)) isPressingLeft = true;
        else isPressingLeft = false; 
        if (Input.GetKey(rightKey)) isPressingRight = true;
        else isPressingRight = false;
        if (Input.GetKey(shootKey)) isPressingShoot = true;
        else isPressingShoot = false;
    }
}
