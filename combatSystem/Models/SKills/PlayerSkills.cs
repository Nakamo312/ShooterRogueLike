using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SkillList 
{
    private List<IPassiveSkill> _passiveSkills;
    private List<IActiveSkill> _activeSkills;


    public SkillList()
    {
        _passiveSkills = new List<IPassiveSkill>();
        _activeSkills = new List<IActiveSkill>();
    }

    public void AddSkill(IPassiveSkill skill)
    {
        if (!_passiveSkills.Contains(skill))
        {
            _passiveSkills.Add(skill);

            
        }
        
    }

    public void AddSkill(IActiveSkill skill)
    {
        if (!_activeSkills.Contains(skill))
        {
            _activeSkills.Add(skill);

        }

    }

    public void RemoveSkill(IPassiveSkill skill)
    {
        if (_passiveSkills.Contains(skill))
        {
            _passiveSkills.Remove(skill);
        }
    }


    public void RemoveSkill(IActiveSkill skill)
    {
        if (_activeSkills.Contains(skill))
        {
            _activeSkills.Remove(skill);
        }
    }
}
