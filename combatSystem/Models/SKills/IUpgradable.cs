using System;
using System.Collections;
using UnityEngine;


public interface IUpgradable
{
    public event Action OnUpgraded;
}