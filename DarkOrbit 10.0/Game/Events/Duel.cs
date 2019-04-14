﻿using Ow.Game.Objects;
using Ow.Game.Movements;
using Ow.Net.netty.commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ow.Game.Ticks;
using Ow.Managers;
using System.Collections.Concurrent;

namespace Ow.Game.Events
{
    class Duel : Tick
    {
        public int TickId { get; set; }

        public bool PeaceArea = true;

        public ConcurrentDictionary<int, Player> Players { get; set; }
        public static Spacemap Spacemap = GameManager.GetSpacemap(101);

        public Position Position1 = new Position(3700, 3200);
        public Position Position2 = new Position(6400, 3200);

        public Duel(ConcurrentDictionary<int, Player> players)
        {
            Players = players;
            if (Players.Count < 2 || Players.Count > 2) return;

            foreach (var player in Players.Values)
            {
                if (player.GameSession == null) return;

                player.AddVisualModifier(new VisualModifierCommand(player.Id, VisualModifierCommand.CAMERA, 0, "", 0, true));
                player.Storage.Duel = this;
                player.CpuManager.DisableCloak();

                foreach (var player2 in Players.Values)
                {
                    if (!player.Equals(player2))
                    {
                        player.Jump(Spacemap.Id, Position1);
                        player2.Jump(Spacemap.Id, Position2);
                    }
                }
            }

            Start();
        }

        public async void Start()
        {
            for (int i = 25; i > 0; i--)
            {
                var packet = $"0|A|STD|-={i}=-";

                foreach (var player in Players.Values)
                    if (player.GameSession != null)
                        player.SendPacket(packet);

                await Task.Delay(1000);

                if (i <= 1)
                {
                    PeaceArea = false;

                    Program.TickManager.AddTick(this, out var tickId);
                    TickId = tickId;
                }
            }
        }

        public void Tick()
        {
            if (Players.Count == 1)
            {
                var lastPlayer = Players.FirstOrDefault().Value;
                SendRewardAndStop(lastPlayer as Player);
            }
        }

        public async void SendRewardAndStop(Player winnerPlayer)
        {
            Program.TickManager.RemoveTick(this);

            winnerPlayer.SendPacket("0|n|KSMSG|label_traininggrounds_results_victory");
            await Task.Delay(5000);

            winnerPlayer.SetPosition(winnerPlayer.GetBasePosition());
            winnerPlayer.Jump(winnerPlayer.GetBaseMapId(), winnerPlayer.Position);

            foreach (var player in Players.Values)
                if (player.GameSession != null)
                {
                    var mines = Spacemap.Mines.Where(x => x.Value.Player == player);
                    foreach (var mine in mines)
                        mine.Value.Remove();

                    player.RemoveVisualModifier(VisualModifierCommand.CAMERA);
                    player.Storage.Duel = null;
                }
        }

        public static void RemovePlayer(Player player)
        {
            if (player.Storage.Duel != null)
            {
                player.Storage.Duel.Players.TryRemove(player.Id, out player);
                player.Storage.Duel = null;
            }
        }

        public Player GetOpponent(Player player)
        {
            return Players.Where(x => x.Value.Id != player.Id).FirstOrDefault().Value;
        }
    }
}
