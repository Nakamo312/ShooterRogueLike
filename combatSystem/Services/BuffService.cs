using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit;

public  class BuffService
{
    private Dictionary<string, Entity> _entity;
    public BuffService()
    {
        _entity = new Dictionary<string, Entity>();

    }

    public void ApplyBuff(string id, IBuff buff)
    {
        if (_entity.ContainsKey(id))
        {
            _entity[id].Buffs.AddBuff(buff);
            buff.ApplyBuff(_entity[id].Stats);
        }
    }

}

