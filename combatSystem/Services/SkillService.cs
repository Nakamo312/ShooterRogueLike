using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit;

public class SkillService
{
    private Dictionary<string, Player> _entity;
    public SkillService()
    {
        _entity = new Dictionary<string, Player>();

    }

    public void ApplySkill(string id, IPassiveSkill passiveSkill)
    {
        if (_entity.ContainsKey(id))
        {
            _entity[id].Skills.AddSkill(passiveSkill);
            passiveSkill.ApplySkill(_entity[id].Stats);
        }
    }

    public void ApplySkill(string id, IActiveSkill activeSkilll)
    {
        if (_entity.ContainsKey(id))
        {
            _entity[id].Skills.AddSkill(activeSkilll);
            activeSkilll.ApplySkill(_entity[id].Stats);
        }
    }
}

