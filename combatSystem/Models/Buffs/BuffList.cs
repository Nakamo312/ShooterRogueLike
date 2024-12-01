using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class BuffList
{
    private List<IBuff> _buffs;
    public BuffList()
    {
        _buffs = new List<IBuff>();
    }

    public bool AddBuff(IBuff buff)
    {
        if (_buffs.Contains(buff))
        {
            return false;
        }

        _buffs.Add(buff);
        return true;
    }

    public bool RemoveBuff(IBuff buff)
    {
        if (_buffs.Contains(buff))
        {
            return false;
        }

        _buffs.Remove(buff);
        return true;
    }
    public float DamageModifier()
    {
        return default(float);
    }
}

