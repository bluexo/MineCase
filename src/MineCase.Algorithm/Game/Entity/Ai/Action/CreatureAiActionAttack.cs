﻿using System;
using System.Collections.Generic;
using System.Text;
using MineCase.Server.Game.Entities;
using Orleans;

namespace MineCase.Server.World.EntitySpawner.Ai.Action
{
    internal class CreatureAiActionAttack : CreatureAiAction
    {
        public CreatureAiActionAttack()
            : base(CreatureState.Attacking)
        {
        }

        public override void Action(IEntity creature)
        {
            throw new NotImplementedException();
        }
    }
}
