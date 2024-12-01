using System.Collections;
using UnityEngine;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;

public interface IPassiveSkill
{
    public string Name { get; }
    public string Description { get; }
    public IUpgradable ApplySkill(IUpgradable stats);
    public event Action OnApplySkill;
}



