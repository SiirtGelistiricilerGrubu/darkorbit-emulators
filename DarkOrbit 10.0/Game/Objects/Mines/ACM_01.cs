﻿using Ow.Game.Movements;
using Ow.Game.Objects.Players.Managers;
using Ow.Managers;
using Ow.Net.netty.commands;
using Ow.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ow.Game.Objects.Mines
{
    class ACM_01 : Mine
    {
        public ACM_01(Player player, Spacemap spacemap, Position position, int mineTypeId) : base(player, spacemap, position, mineTypeId, player.Settings.InGameSettings.selectedFormation == DroneManager.LANCE_FORMATION) { }

        public override void Explode()
        {
            foreach (var character in Spacemap.Characters.Values)
            {
                if (character is Player player && player.Position.DistanceTo(Position) < EXPLODE_RANGE)
                {
                    if (Player == player || player.Storage.Duel == null || (player.Storage.Duel != null && Player == player.Storage.Duel?.GetOpponent(player)))
                    {
                        var damage = Maths.GetPercentage(player.CurrentHitPoints, 20);

                        if (Lance)
                            damage *= 2;

                        Player.AttackManager.Damage(Player, player, DamageType.MINE, damage, 0, false);
                    }
                }
            }
        }
    }
}
