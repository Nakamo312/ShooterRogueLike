using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unit
{
    public class Player : Entity
{
    private PlayerStats _stats;
    private Inventory _inventory;
    private SkillList _skills;

    public Player(PlayerStatsData playerStatsData): base(playerStatsData)
    {
        _stats = new PlayerStats(playerStatsData);
    }

    public SkillList Skills
    {
        get => _skills;
    }
    public PlayerStats Stats
    {
        get => _stats;
    }


}
}

