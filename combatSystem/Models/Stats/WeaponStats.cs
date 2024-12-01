using System.Collections;
using UnityEngine;
using System;
using Assets.Scripts.warSystem;
public class WeaponStats : IUpgradable
{
    float baseDamage;
    double damage;
    double chanceOfCrit;
    double critModifier;
    float firerate;
    float range;
    float reloadSpeed;
    float magCapacity;
    public event Action OnUpgraded;
    public WeaponStats( WeaponStatsData data)
    {
        baseDamage = data.baseDamage;
        damage = data.damage;
        chanceOfCrit = data.chanceOfCrit;
        firerate = data.firerate;
        range = data.range;
        magCapacity = data.magCapacity;
        reloadSpeed = data.reloadSpeed;
    }

}
