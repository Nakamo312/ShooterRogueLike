using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Unit;
public class CalcDamageService 
{

	private Dictionary<string, Entity> _entity;
	public CalcDamageService()
	{
        _entity = new Dictionary<string, Entity>();                               
	}

	public bool CalcDamage(string id, out float damage)
	{
        if (_entity.ContainsKey(id))
        {
            damage = _entity[id].CalcDamage();
            return true;
        }
        damage = 0;
        return false;
    }

    public bool CalcDamageReceive(string id, float damage, out float receiveDamage)
    {
        if (_entity.ContainsKey(id))
        {
            receiveDamage = _entity[id].CalcDamage();
            return true;
        }
        receiveDamage = 0;
        return false;
    }


}




