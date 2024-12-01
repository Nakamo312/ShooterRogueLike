using UnityEditor;
using UnityEngine;
using System;


[Serializable]
public class PlayerStats : EntityStats, IUpgradable
{

    public float jumpForce;
    public float jerkForce;
    public event Action OnUpgraded;

    public PlayerStats(PlayerStatsData data): base(data)
    {
        health = data.health;
        maxHealth = data.maxHealth;
        moveSpeed = data.moveSpeed;
        jumpForce = data.jumpForce;
        jerkForce = data.jerkForce; 
    }
    public PlayerStats(PlayerStats other): base(other)
    {
        health = other.health;
        maxHealth = other.maxHealth;
        moveSpeed = other.moveSpeed;
        jumpForce = other.jumpForce;
        jerkForce = other.jerkForce;

    }

}
    