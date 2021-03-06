﻿using CabinIcarus.IcSkillSystem.Runtime.Buffs;
using CabinIcarus.IcSkillSystem.Runtime.Buffs.Components;
using CabinIcarus.IcSkillSystem.Runtime.Buffs.Entitys;

namespace CabinIcarus.IcSkillSystem.Runtime.Skills.Condition
{
    public abstract class ACondition<TEntity>:ICondition<TEntity> where TEntity : IIcSkSEntity
    {
        protected readonly IBuffManager<TEntity> _buffManager;

        protected ACondition(IBuffManager<TEntity> buffManager)
        {
            this._buffManager = buffManager;
        }

        public abstract bool Check(TEntity icSkSEntity);
    }
}