

namespace Unit
{
    public class Entity
    {
        protected EntityStats _stats;
        protected BuffList _buffs;
        private Inventory _inventory;

        public Entity()
        {

        }
        public Entity(EntityStatsData stats)
        {
            _stats = new EntityStats(stats);
            _buffs = new BuffList();
            _inventory = new Inventory();
        }
        public float CalcDamage()
        {
            return _stats.baseDamage * _stats.DamageModifier() * _buffs.DamageModifier() * _inventory.DamageModifier();
        }

        public float CalcDamageRecieve()
        {
            return default(float);
        }
        public EntityStats Stats
        {
            get => _stats;
        }
        public BuffList Buffs
        {
            get => _buffs;
        }
    }
}


