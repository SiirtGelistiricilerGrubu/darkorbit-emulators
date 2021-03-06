﻿using Ow.Game.Movements;
using Ow.Game.Ticks;
using Ow.Managers;
using Ow.Net.netty;
using Ow.Net.netty.commands;
using Ow.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ow.Game.Objects.Mines
{
    abstract class Mine
    {
        public const int RANGE = 250;
        public const int EXPLODE_RANGE = 375;

        public const int ACTIVATION_TIME = 2;

        public int TickId { get; set; }
        public int MineTypeId { get; set; }
        public string Hash { get; set; }
        public Player Player { get; set; }
        public Spacemap Spacemap { get; set; }
        public Position Position { get; set; }
        public DateTime activationTime = new DateTime();
        public bool Lance { get; set; }
        public bool Pulse { get; set; }
        public bool Active = true;

        public Mine(Player player, Spacemap spacemap, Position position, int mineTypeId, bool lance = false, bool pulse = false)
        {
            Player = player;
            Spacemap = spacemap;
            Position = position;
            MineTypeId = mineTypeId;
            Lance = lance;
            Pulse = pulse;
            Hash = Randoms.GenerateHash(16);
            Spacemap.Mines.TryAdd(Hash, this);
            activationTime = DateTime.Now;
        }

        public abstract void Explode();

        public void Remove()
        {
            Active = false;
            var mine = this;

            foreach (var gameSession in GameManager.GameSessions.Values)
            {
                var player = gameSession.Player;

                if (player.Storage.InRangeMines.ContainsKey(Hash))
                    player.Storage.InRangeMines.TryRemove(Hash, out mine);
            }

            Spacemap.Mines.TryRemove(Hash, out mine);
            GameManager.SendPacketToMap(Spacemap.Id, $"0|n|MIN|{Hash}");
        }

        public string GetMineCreatePacket()
        {
            return $"0|{ServerCommands.CREATE_MINE}|{Hash}|{MineTypeId}|{Position.X}|{Position.Y}|0|0|";
        }
    }
}
