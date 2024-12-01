using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public interface IActiveSkill
{
    IUpgradable ApplySkill(IUpgradable stats);
    public event Action OnApplySkill;
}

