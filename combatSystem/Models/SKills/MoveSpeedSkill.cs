using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class MoveSpeedSkill: IPassiveSkill
{
    private string _name;
    private string _description;
    private float _coeff;
    public string Name { get => _name; }
    public string Description { get => _description; }

    public IUpgradable ApplySkill(IUpgradable skill)
    {
        return default(IUpgradable);    
    }

    public PlayerStats ApplySkill(PlayerStats stats)
    {
        PlayerStats new_stats = new PlayerStats(stats);
        new_stats.moveSpeed *= _coeff;
        OnApplySkill?.Invoke();
        return new_stats;

    }

    public event Action OnApplySkill;
}

