using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


[Serializable]
public  class EntityStats: IBuffable
{
    public float health;
    public float regenhealth;
    public float maxHealth;
    public float moveSpeed;
    public event Action OnBuffed;
    public event Action OnDebuffed;
    public float baseDamage;

    public EntityStats(EntityStatsData data)
    {
        health = data.maxHealth;
        maxHealth = data.maxHealth;
        moveSpeed = data.moveSpeed;
        regenhealth = data.regenHealth;
    }
    public EntityStats(EntityStats stats)
    {
        health = stats.health;
        maxHealth = stats.maxHealth;
        moveSpeed = stats.moveSpeed;
        /*regenhealth = stats.regenhealth;
        baseDamage = stats.baseDamage;*/
    }

    public float DamageModifier()
    {
        return default(float);
    }
}

