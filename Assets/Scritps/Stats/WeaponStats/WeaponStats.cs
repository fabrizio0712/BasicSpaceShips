using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Scriptable Object/Weapons/Stats")]
public class WeaponStats : ScriptableObject
{
    [SerializeField] private float bulletAmount;
    [SerializeField] private float bulletSpeed;
    [SerializeField] private float fireRate;
    [SerializeField] private Fire shotStrategy;

    public float BulletAmount { get => bulletAmount; }
    public float BulletSpeed { get => bulletSpeed; }
    public float FireRate { get => fireRate; }
    public Fire ShotStrategy { get => shotStrategy; }
}
