﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Ow.Game.Objects;
using Ow.Game.Objects.Mines;
using Ow.Game.Movements;
using Ow.Managers;
using Ow.Net.netty.commands;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ow.Utils;

namespace Ow.Game.Objects.Players.Managers
{
    public class DataBase
    {
        public int uridium { get; set; }
        public int credits { get; set; }
        public int honor { get; set; }
        public int experience { get; set; }
        public int jackpot { get; set; }
    }

    public class EquipmentBase
    {
        public int Config1Hitpoints { get; set; }
        public int Config1Damage { get; set; }
        public int Config1Shield { get; set; }
        public int Config1Speed { get; set; }
        public int Config2Hitpoints { get; set; }
        public int Config2Damage { get; set; }
        public int Config2Shield { get; set; }
        public int Config2Speed { get; set; }
    }

    class PlayerSettings
    {
        public AudioBase Audio = new AudioBase();
        public QualityBase Quality = new QualityBase();
        public ClassY2TBase ClassY2T = new ClassY2TBase();
        public DisplayBase Display = new DisplayBase();
        public GameplayBase Gameplay = new GameplayBase();
        public WindowBase Window = new WindowBase();
        public InGameSettingsBase InGameSettings = new InGameSettingsBase();
        public CurrentCooldownsBase CurrentCooldowns = new CurrentCooldownsBase();

        public List<BoundKeysBase> BoundKeys = new List<BoundKeysBase>
        {
            new BoundKeysBase(7, 0, 0, new List<int>{49}),
            new BoundKeysBase(7, 0, 1, new List<int>{50}),
            new BoundKeysBase(7, 0, 2, new List<int>{51}),
            new BoundKeysBase(7, 0, 3, new List<int>{52}),
            new BoundKeysBase(7, 0, 4, new List<int>{53}),
            new BoundKeysBase(7, 0, 5, new List<int>{54}),
            new BoundKeysBase(7, 0, 6, new List<int>{55}),
            new BoundKeysBase(7, 0, 7, new List<int>{56}),
            new BoundKeysBase(7, 0, 8, new List<int>{57}),
            new BoundKeysBase(7, 0, 9, new List<int>{48}),
            new BoundKeysBase(8, 0, 0, new List<int>{112}),
            new BoundKeysBase(8, 0, 1, new List<int>{113}),
            new BoundKeysBase(8, 0, 2, new List<int>{114}),
            new BoundKeysBase(8, 0, 3, new List<int>{115}),
            new BoundKeysBase(8, 0, 4, new List<int>{116}),
            new BoundKeysBase(8, 0, 5, new List<int>{117}),
            new BoundKeysBase(8, 0, 6, new List<int>{118}),
            new BoundKeysBase(8, 0, 7, new List<int>{119}),
            new BoundKeysBase(8, 0, 8, new List<int>{120}),
            new BoundKeysBase(8, 0, 9, new List<int>{121}),
            new BoundKeysBase(0, 0, 0, new List<int>{74}),
            new BoundKeysBase(1, 0, 0, new List<int>{67}),
            new BoundKeysBase(2, 0, 0, new List<int>{17}),
            new BoundKeysBase(3, 0, 0, new List<int>{32}),
            new BoundKeysBase(4, 0, 0, new List<int>{69}),
            new BoundKeysBase(5, 0, 0, new List<int>{82}),
            new BoundKeysBase(13, 0, 0, new List<int>{68}),
            new BoundKeysBase(6, 0, 0, new List<int>{76}),
            new BoundKeysBase(9, 0, 0, new List<int>{72}),
            new BoundKeysBase(10, 0, 0, new List<int>{70}),
            new BoundKeysBase(11, 0, 0, new List<int>{107}),
            new BoundKeysBase(12, 0, 0, new List<int>{109}),
            new BoundKeysBase(14, 0, 0, new List<int>()),
            new BoundKeysBase(15, 0, 0, new List<int>{9}),
            new BoundKeysBase(8, 0, 9, new List<int>{121}),
            new BoundKeysBase(16, 0, 0, new List<int>{81})
        };

        public Dictionary<short, string> SlotBarItems = new Dictionary<short, string>() {
            {1, AmmunitionManager.UCB_100}
        };

        public Dictionary<short, string> PremiumSlotBarItems = new Dictionary<short, string>() {
            {1, DroneManager.DEFAULT_FORMATION}
        };

        public Dictionary<short, string> ProActionBarItems = new Dictionary<short, string>();

        public class AudioBase
        {
            public bool notSet = false;
            public bool playCombatMusic = true;
            public int music = 100;
            public int sound = 100;
            public int voice = 100;
        }

        public class QualityBase
        {
            public bool notSet = false;
            public short qualityAttack = 0;
            public short qualityBackground = 3;
            public short qualityPresetting = 3;
            public bool qualityCustomized = true;
            public short qualityPoizone = 3;
            public short qualityShip = 0;
            public short qualityEngine = 0;
            public short qualityExplosion = 0;
            public short qualityCollectable = 0;
            public short qualityEffect = 0;
        }

        public class ClassY2TBase
        {
            public bool questsAvailableFilter = false;
            public bool questsUnavailableFilter = false;
            public bool questsCompletedFilter = false;
            public bool var_1151 = false;
            public bool var_2239 = false;
            public bool questsLevelOrderDescending = false;
        }

        public class DisplayBase
        {
            public bool notSet = false;
            public bool displayPlayerNames = true;
            public bool displayResources = true;
            public bool showPremiumQuickslotBar = true;
            public bool allowAutoQuality = true;
            public bool preloadUserShips = true;
            public bool displayHitpointBubbles = true;
            public bool showNotOwnedItems = true;
            public bool displayChat = true;
            public bool displayWindowsBackground = true;
            public bool displayNotFreeCargoBoxes = true;
            public bool dragWindowsAlways = true;
            public bool displayNotifications = true;
            public bool hoverShips = true;
            public bool displayDrones = true;
            public bool displayBonusBoxes = true;
            public bool displayFreeCargoBoxes = true;
            public bool var12P = true;
            public bool varb3N = false;
            public int displaySetting3DqualityAntialias = 4;
            public int varp3M = 4;
            public int displaySetting3DqualityEffects = 4;
            public int displaySetting3DqualityLights = 3;
            public int displaySetting3DqualityTextures = 3;
            public int var03r = 4;
            public int displaySetting3DsizeTextures = 3;
            public int displaySetting3DtextureFiltering = -1;
            public bool proActionBarEnabled = true;
            public bool proActionBarKeyboardInputEnabled = true;
            public bool proActionBarAutohideEnabled = true;
            public bool proActionBarOpened = false;
        }

        public class GameplayBase
        {
            public bool notSet = false;
            public bool autoRefinement = false;
            public bool quickSlotStopAttack = true;
            public bool autoBoost = false;
            public bool autoBuyBootyKeys = false;
            public bool doubleclickAttackEnabled = true;
            public bool autochangeAmmo = true;
            public bool autoStartEnabled = true;
            public bool varE3N = true;
        }

        public class WindowBase
        {
            public bool hideAllWindows = false;
            public int scale = 6;
            public string barState = "24,1|23,1|100,1|25,1|35,0|34,0|39,0|";
        }

        public class BoundKeysBase
        {
            public short actionType { get; set; }
            public short charCode { get; set; }
            public int parameter { get; set; }
            public List<int> keyCodes { get; set; }

            public BoundKeysBase(short ActionType, short CharCode, int Parameter, List<int> KeyCodes)
            {
                actionType = ActionType;
                charCode = CharCode;
                parameter = Parameter;
                keyCodes = KeyCodes;
            }
        }

        public class InGameSettingsBase
        {
            public bool inEquipZone = true;
            public bool blockedGroupInvites = false;
            public string selectedLaser = AmmunitionManager.LCB_10;
            public string selectedRocket = AmmunitionManager.R_310;
            public string selectedRocketLauncher = AmmunitionManager.HSTRM_01;
            public string selectedFormation = DroneManager.DEFAULT_FORMATION;
            public int currentConfig = 1;
            public List<string> selectedCpus = new List<string> { CpuManager.AUTO_ROCKET_CPU, CpuManager.AUTO_HELLSTROM_CPU };
        }

        public class CurrentCooldownsBase
        {
            public int smbCooldown = 0;
            public int ishCooldown = 0;
            public int empCooldown = 0;
            public int mineCooldown = 0;
            public int dcrCooldown = 0;
            public int pldCooldown = 0;
            public int energyLeechCooldown = 0;
            public int chainImpulseCooldown = 0;
            public int precisionTargeterCooldown = 0;
            public int backupShieldsCooldown = 0;
            public int battleRepairBotCooldown = 0;
            public int sentinelCooldown = 0;
            public int diminisherCooldown = 0;
            public int venomCooldown = 0;
            public int spectrumCooldown = 0;
            public int solaceCooldown = 0;
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }

    class SettingsManager
    {
        public const String STANDARD_SLOT_BAR = "standardSlotBar";
        public const String PREMIUM_SLOT_BAR  = "premiumSlotBar";
        public const String PRO_ACTION_BAR = "proActionBar";

        public Player Player { get; set; }

        public SettingsManager(Player player) { Player = player; SetCurrentItems(); }

        public void SetCurrentItems()
        {
            Player.CurrentConfig = Player.Settings.InGameSettings.currentConfig;

            if (Player.Settings.InGameSettings.selectedCpus.Contains(CpuManager.AUTO_ROCKET_CPU))
                Player.Storage.AutoRocket = true;

            if (Player.Settings.InGameSettings.selectedCpus.Contains(CpuManager.AUTO_HELLSTROM_CPU))
                Player.Storage.AutoRocketLauncher = true;

            if (Player.Settings.InGameSettings.selectedCpus.Contains(CpuManager.CLK_XL))
                Player.Invisible = true;
        }

        public static string[] LaserCategory =
        {
                "ammunition_laser_lcb-10", "ammunition_laser_mcb-25", "ammunition_laser_mcb-50",
                "ammunition_laser_ucb-100", "ammunition_laser_sab-50", //"ammunition_laser_cbo-100",
                "ammunition_laser_rsb-75" //"ammunition_laser_job-100"
        };

        public static string[] RocketsCategory =
        {
                "ammunition_rocket_r-310", "ammunition_rocket_plt-2026", "ammunition_rocket_plt-2021",
                "ammunition_rocket_plt-3030", "ammunition_specialammo_dcr-250", "ammunition_specialammo_r-ic3", "ammunition_specialammo_wiz-x"/*"ammunition_specialammo_pld-8",
                , "ammunition_rocket_bdr-1211",*/
        };

        public static string[] RocketLauncherCategory =
        {
                CpuManager.ROCKET_LAUNCHER, AmmunitionManager.HSTRM_01,
                //"ammunition_rocketlauncher_ubr-100",
                //"ammunition_rocketlauncher_eco-10", "ammunition_rocketlauncher_sar-01",
                AmmunitionManager.SAR_02
            };

        public static string[] SpecialItemsCategory =
        {
                "ammunition_mine_smb-01", "equipment_extra_cpu_ish-01", "ammunition_specialammo_emp-01"
        };

        public static string[] TechsCategory =
        {
                "tech_backup-shields", "tech_battle-repair-bot", "tech_chain-impulse",
                "tech_energy-leech", "tech_precision-targeter"
        };

        public static string[] MinesCategory =
        {
                "ammunition_mine_acm-01", "ammunition_mine_empm-01", "ammunition_mine_sabm-01",
                "ammunition_mine_ddm-01", "ammunition_mine_slm-01"//, "ammunition_mine_im-01"
        };

        public static string[] CpusCategory =
        {
            "equipment_extra_cpu_cl04k-xl", "equipment_extra_cpu_arol-x", "equipment_extra_cpu_rllb-x"
              /**  "equipment_extra_cpu_aim-01", "equipment_extra_cpu_aim-02", "equipment_extra_cpu_ajp-01",
                "equipment_extra_cpu_alb-x", "equipment_extra_cpu_anti-z1", "equipment_extra_cpu_anti-z1-xl",
                "equipment_extra_cpu_arol-x", "equipment_extra_cpu_cl04k-m", "equipment_extra_cpu_cl04k-xl",
                "equipment_extra_cpu_cl04k-xs", "equipment_extra_cpu_dr-01", "equipment_extra_cpu_dr-02",
                "equipment_extra_cpu_fb-x", "equipment_extra_cpu_jp-01",
                "equipment_extra_cpu_jp-02", "equipment_extra_cpu_min-t01", "equipment_extra_cpu_min-t02",
                "equipment_extra_cpu_nc-agb", "equipment_extra_cpu_nc-awb", "equipment_extra_cpu_nc-awl",
                "equipment_extra_cpu_nc-awr", "equipment_extra_cpu_nc-rrb", "equipment_extra_cpu_rb-x",
                "equipment_extra_cpu_rd-x", "equipment_extra_cpu_rllb-x", "equipment_extra_cpu_rok-t01",
                "equipment_extra_cpu_sle-01", "equipment_extra_cpu_sle-02", "equipment_extra_cpu_sle-03",
                "equipment_extra_cpu_sle-04", "equipment_extra_hmd-07", "equipment_extra_repbot_rep-1",
                "equipment_extra_repbot_rep-2", "equipment_extra_repbot_rep-3", "equipment_extra_repbot_rep-4",
                "equipment_extra_repbot_rep-s", "equipment_weapon_rocketlauncher_hst-1",
                "equipment_weapon_rocketlauncher_hst-2", "equipment_weapon_rocketlauncher_not_present", "equipment_extra_cpu_nc-rrb-x"
               */
        };

        public static string[] BuyCategory =
        {
            /*
                "ammunition_laser_lcb-10", "ammunition_laser_mcb-25", "ammunition_laser_mcb-50",
                "ammunition_laser_sab-50", "ammunition_rocket_r-310", "ammunition_rocket_plt-2026",
                "ammunition_rocket_plt-2021", "ammunition_rocket_plt-3030"
                */
        };

        public static string[] AbilitiesCategory =
        {
                SkillManager.AEGIS_HP_REPAIR,
                SkillManager.AEGIS_REPAIR_POD, SkillManager.AEGIS_SHIELD_REPAIR, SkillManager.CITADEL_DRAW_FIRE,
                SkillManager.CITADEL_FORTIFY, SkillManager.CITADEL_PROTECTION, SkillManager.CITADEL_TRAVEL, SkillManager.DIMINISHER,
                SkillManager.LIGHTNING, SkillManager.SENTINEL, SkillManager.SOLACE, SkillManager.SPEARHEAD_DOUBLE_MINIMAP,
                SkillManager.SPEARHEAD_JAM_X, SkillManager.SPEARHEAD_TARGET_MARKER, SkillManager.SPEARHEAD_ULTIMATE_CLOAK,
                SkillManager.SPECTRUM, SkillManager.VENOM
        };

        public static string[] FormationsCategory =
        {
                DroneManager.DEFAULT_FORMATION, DroneManager.TURTLE_FORMATION,
                DroneManager.ARROW_FORMATION, DroneManager.LANCE_FORMATION,
                DroneManager.STAR_FORMATION, DroneManager.PINCER_FORMATION,
                DroneManager.DOUBLE_ARROW_FORMATION, DroneManager.DIAMOND_FORMATION,
                DroneManager.CHEVRON_FORMATION, DroneManager.MOTH_FORMATION,
                DroneManager.CRAB_FORMATION, DroneManager.HEART_FORMATION/*,
                DroneManager.DRILL_FORMATION,DroneManager.RING_FORMATION,
                DroneManager.WHEEL_FORMATION*/
        };

        public void SendUserKeyBindingsUpdateCommand()
        {            
            var keyBindingsModuleCommands = new List<UserKeyBindingsModule>();
            List<PlayerSettings.BoundKeysBase> actions = Player.Settings.BoundKeys;

            foreach (var action in actions)
            {
                keyBindingsModuleCommands.Add(new UserKeyBindingsModule(
                    action.actionType, action.keyCodes, action.parameter, action.charCode));
            }
            Player.SendCommand(UserKeyBindingsUpdateCommand.write(keyBindingsModuleCommands, false));         
        }

        public void SendUserSettingsCommand()
        {
            var displaySettings = Player.Settings.Display;
            var qualitySettings = Player.Settings.Quality;
            var audioSettings = Player.Settings.Audio;
            var windowSettings = Player.Settings.Window;
            var gameplaySettings = Player.Settings.Gameplay;
            var y2tSettings = Player.Settings.ClassY2T;
            Player.SendCommand(UserSettingsCommand.write(
                new QualitySettingsModule(qualitySettings.notSet, qualitySettings.qualityAttack, qualitySettings.qualityBackground, qualitySettings.qualityPresetting, qualitySettings.qualityCustomized, qualitySettings.qualityPoizone, qualitySettings.qualityShip, qualitySettings.qualityEngine, qualitySettings.qualityExplosion, qualitySettings.qualityCollectable, qualitySettings.qualityEffect),
                new DisplaySettingsModule(displaySettings.notSet, displaySettings.displayPlayerNames, displaySettings.displayResources, displaySettings.displayBonusBoxes, displaySettings.displayHitpointBubbles, displaySettings.displayChat, displaySettings.displayDrones, displaySettings.displayFreeCargoBoxes, displaySettings.displayNotFreeCargoBoxes, displaySettings.showNotOwnedItems, displaySettings.displayWindowsBackground, displaySettings.var12P, displaySettings.displayNotifications, displaySettings.preloadUserShips, displaySettings.dragWindowsAlways, displaySettings.hoverShips, displaySettings.showPremiumQuickslotBar, displaySettings.allowAutoQuality, displaySettings.varb3N, displaySettings.displaySetting3DqualityAntialias, displaySettings.varp3M, displaySettings.displaySetting3DqualityEffects, displaySettings.displaySetting3DqualityLights, displaySettings.displaySetting3DqualityTextures, displaySettings.var03r, displaySettings.displaySetting3DsizeTextures, displaySettings.displaySetting3DtextureFiltering, displaySettings.proActionBarEnabled, displaySettings.proActionBarKeyboardInputEnabled, displaySettings.proActionBarAutohideEnabled),
                new AudioSettingsModule(audioSettings.notSet, audioSettings.sound, audioSettings.music, audioSettings.voice, audioSettings.playCombatMusic),
                new WindowSettingsModule(windowSettings.scale, windowSettings.barState, windowSettings.hideAllWindows),
                new GameplaySettingsModule(gameplaySettings.notSet, gameplaySettings.autoBoost, gameplaySettings.autoRefinement, gameplaySettings.quickSlotStopAttack, gameplaySettings.doubleclickAttackEnabled, gameplaySettings.autochangeAmmo, gameplaySettings.autoStartEnabled, gameplaySettings.autoBuyBootyKeys, false, gameplaySettings.varE3N),
                new class_y2t(y2tSettings.questsAvailableFilter, y2tSettings.questsUnavailableFilter, y2tSettings.questsCompletedFilter, y2tSettings.var_1151, y2tSettings.var_2239, y2tSettings.questsLevelOrderDescending)
            ));
        }

        public void SendMenuBarsCommand()
        {
            var menuBarsCommand = new List<ClientUIMenuBarModule>();

            var leftItems = new Dictionary<string, string>();

            leftItems.Add("user", "title_user");
            leftItems.Add("ship", "title_ship");
            //leftItems.Add("ship_warp", "ttip_shipWarp_btn");
            leftItems.Add("chat", "title_chat");
            leftItems.Add("group", "title_group");
            leftItems.Add("minimap", "title_map");
            leftItems.Add("spacemap", "title_spacemap");
            //leftItems.Add("quests", "title_quests");
            //leftItems.Add("refinement", "title_refinement");
            leftItems.Add("log", "title_log");
            if(Player.RankId == 21)
                leftItems.Add("pet", "title_pet");
            if (EventManager.Spaceball.Active)
                leftItems.Add("spaceball", "title_spaceball");
            //leftItems.Add("contacts", "title_contactlist");
            //leftItems.Add("booster", "title_booster");
            leftItems.Add("traininggrounds", "title_traininggrounds");
            //leftItems.Add("jackpot_status_ui", "title_jackpot_status_ui");

            var topLeftMenuBarItems = new List<ClientUIMenuBarItemModule>();

            foreach (var entryLeft in leftItems)
            {
                string itemID = entryLeft.Key;
                string baseKey = entryLeft.Value;

                var tf_localized =
                        new ClientUITooltipTextFormatModule(ClientUITooltipTextFormatModule.LOCALIZED);
                var tooltips = new List<ClientUITooltipModule>();
                var textReplacementModules = new List<ClientUITextReplacementModule>();
                tooltips.Add(new ClientUITooltipModule(tf_localized, ClientUITooltipModule.STANDARD, baseKey,
                                                       textReplacementModules));
                var tooltipsCommand = new ClientUITooltipsCommand(tooltips);
                var menuBarItem = new ClientUIMenuBarItemModule(true, tooltipsCommand, itemID);

                topLeftMenuBarItems.Add(menuBarItem);
            }
            var topLeftMenuBar =
                    new ClientUIMenuBarModule(ClientUIMenuBarModule.GAME_FEATURE_BAR, topLeftMenuBarItems, "0,0", "0");
            menuBarsCommand.Add(topLeftMenuBar);


            var rightItems = new Dictionary<string, string>();

            rightItems.Add("settings", "title_settings");
            rightItems.Add("help", "title_help");
            rightItems.Add("logout", "title_logout");
            rightItems.Add("fullscreen", "ttip_fullscreen_btn");

            var topRightMenuBarItems = new List<ClientUIMenuBarItemModule>();

            foreach (var entryLeft in rightItems)
            {
                string itemID = entryLeft.Key;
                string baseKey = entryLeft.Value;

                var tf_localized =
                        new ClientUITooltipTextFormatModule(ClientUITooltipTextFormatModule.LOCALIZED);
                var tooltips = new List<ClientUITooltipModule>();
                var textReplacementModules = new List<ClientUITextReplacementModule>();
                tooltips.Add(new ClientUITooltipModule(tf_localized, (short)0, baseKey, textReplacementModules));
                var tooltipsCommand = new ClientUITooltipsCommand(tooltips);
                var menuBarItem = new ClientUIMenuBarItemModule(true, tooltipsCommand, itemID);

                topRightMenuBarItems.Add(menuBarItem);
            }
            var topRightMenuBar =
                    new ClientUIMenuBarModule(ClientUIMenuBarModule.GENERIC_FEATURE_BAR, topRightMenuBarItems, "98.3,0", "0");
            menuBarsCommand.Add(topRightMenuBar);

            Player.SendCommand(ClientUIMenuBarsCommand.write(menuBarsCommand));
        }

        public void SendSlotBarCommand()
        {
            var slotBars = new List<ClientUISlotBarModule>();
            slotBars.Add(GetStandardSlotBar());
            slotBars.Add(GetPremiumSlotBar());

            if(Player.Settings.Display.proActionBarEnabled)
                slotBars.Add(GetProActionSlotBar());

            var categories = new List<ClientUISlotBarCategoryModule>();
            categories.Add(GetLasersCategory());
            categories.Add(GetRocketsCategory());
            categories.Add(GetRocketLauncherCategory());
            categories.Add(GetSpecialAmmoCategory());
            categories.Add(GetMineCategory());
            categories.Add(GetCpuCategory());
            categories.Add(GetBuyCategory());
            categories.Add(GetTechCategory());
            categories.Add(GetAbilityCategory());
            categories.Add(GetFormationCategory());

            Player.SendCommand(ClientUISlotBarsCommand.write("50,85", slotBars, categories));
        }

        public void SendHelpWindows()
        {
            var windows = new List<class_F2I>();
            windows.Add(new class_F2I(class_F2I.JUMP_GATES));
            windows.Add(new class_F2I(class_F2I.ATTACK));
            windows.Add(new class_F2I(class_F2I.EXTRA_CPU));
            windows.Add(new class_F2I(class_F2I.TRAINING_GROUNDS));
            windows.Add(new class_F2I(class_F2I.TECH_FACTORY));
            windows.Add(new class_F2I(class_F2I.THE_SHOP));
            windows.Add(new class_F2I(class_F2I.CHANGING_SHIPS));
            windows.Add(new class_F2I(class_F2I.JUMP_DEVICE));
            windows.Add(new class_F2I(class_F2I.GALAXY_GATE));
            windows.Add(new class_F2I(class_F2I.SECOND_CONFIGURATION));
            windows.Add(new class_F2I(class_F2I.AUCTION_HOUSE));
            windows.Add(new class_F2I(class_F2I.PREPARE_BATTLE));
            windows.Add(new class_F2I(class_F2I.SKYLAB));
            windows.Add(new class_F2I(class_F2I.SHIP_REPAIR));
            windows.Add(new class_F2I(class_F2I.POLICY_CHANGES));
            windows.Add(new class_F2I(class_F2I.INSTALLING_NEW_EQUIPMENT));
            windows.Add(new class_F2I(class_F2I.FULL_CARGO));
            windows.Add(new class_F2I(class_F2I.ITEM_UPGRADE));
            windows.Add(new class_F2I(class_F2I.BOOST_YOUR_EQUIP));
            windows.Add(new class_F2I(class_F2I.ORE_TRANSFER));
            windows.Add(new class_F2I(class_F2I.CLAN_BATTLE_STATION));
            windows.Add(new class_F2I(class_F2I.HOW_TO_FLY));
            windows.Add(new class_F2I(class_F2I.SELL_RESOURCE));
            windows.Add(new class_F2I(class_F2I.LOOKING_FOR_GROUPS));
            windows.Add(new class_F2I(class_F2I.SHIP_DESIGN));
            windows.Add(new class_F2I(class_F2I.CONTACT_LIST));
            windows.Add(new class_F2I(class_F2I.UNKOWN_DANGERS));
            windows.Add(new class_F2I(class_F2I.WEALTHY_FAMOUS));
            windows.Add(new class_F2I(class_F2I.GET_MORE_AMMO));
            windows.Add(new class_F2I(class_F2I.REQUEST_MISSION));
            windows.Add(new class_F2I(class_F2I.ROCKET_LAUNCHER));
            windows.Add(new class_F2I(class_F2I.WELCOME));
            windows.Add(new class_F2I(class_F2I.PALLADIUM));
            windows.Add(new class_F2I(class_F2I.EQUIP_YOUR_ROCKETS));
            windows.Add(new class_F2I(class_F2I.PVP_WARNING));
            windows.Add(new class_F2I(class_F2I.SKILL_TREE));
            windows.Add(new class_F2I(class_F2I.varC1l));
            windows.Add(new class_F2I(class_F2I.vard34));
            var c802 = class_p2k.write(windows);
            Player.SendCommand(c802);
        }

        public ClientUISlotBarModule GetStandardSlotBar()
        {
            var standartItems = new List<ClientUISlotBarItemModule>();

            foreach (var pair in Player.Settings.SlotBarItems)
            {
                ClientUISlotBarItemModule item = new ClientUISlotBarItemModule(pair.Value, pair.Key);
                standartItems.Add(item);
            }

            return new ClientUISlotBarModule("50,85|0,40", STANDARD_SLOT_BAR, "0", standartItems, true);
        }

        public ClientUISlotBarModule GetPremiumSlotBar()
        {

            var premiumItems = new List<ClientUISlotBarItemModule>();

            foreach (var pair in Player.Settings.PremiumSlotBarItems)
            {
                ClientUISlotBarItemModule item = new ClientUISlotBarItemModule(pair.Value, pair.Key);
                premiumItems.Add(item);
            }

            return new ClientUISlotBarModule("50,85|0,80", PREMIUM_SLOT_BAR, "0", premiumItems, true);
        }

        public ClientUISlotBarModule GetProActionSlotBar()
        {

            var proActionItems = new List<ClientUISlotBarItemModule>();

            foreach (var pair in Player.Settings.ProActionBarItems)
            {
                ClientUISlotBarItemModule item = new ClientUISlotBarItemModule(pair.Value, pair.Key);
                proActionItems.Add(item);
            }

            return new ClientUISlotBarModule("50,85|0,120", PRO_ACTION_BAR, "0", proActionItems, Player.Settings.Display.proActionBarOpened);
        }

        public ClientUISlotBarCategoryModule GetLasersCategory()
        {
            var lasersItems = new List<ClientUISlotBarCategoryItemModule>();
            foreach (string itemLootId in LaserCategory)
            {

                ClientUISlotBarCategoryItemTimerModule categoryTimerModule =
                        new ClientUISlotBarCategoryItemTimerModule(GetCooldownTime(itemLootId),
                                                                   new ClientUISlotBarCategoryItemTimerStateModule(ClientUISlotBarCategoryItemTimerStateModule.short_2168), 90000000, itemLootId,
                                                                   false);

                lasersItems.Add(new ClientUISlotBarCategoryItemModule(1, GetItemStatus(itemLootId, "ttip_laser", true, true),
                                                                      ClientUISlotBarCategoryItemModule.SELECTION,
                                                                      ClientUISlotBarCategoryItemModule.NONE,
                                                                      GetCooldownType(itemLootId),
                                                                      categoryTimerModule));
            }
            return new ClientUISlotBarCategoryModule("lasers", lasersItems);
        }

        public ClientUISlotBarCategoryModule GetRocketsCategory()
        {
            var rocketItems = new List<ClientUISlotBarCategoryItemModule>();
            foreach (string itemLootId in RocketsCategory)
            {

                ClientUISlotBarCategoryItemTimerModule categoryTimerModule =
                        new ClientUISlotBarCategoryItemTimerModule(GetCooldownTime(itemLootId),
                                                                   new ClientUISlotBarCategoryItemTimerStateModule(ClientUISlotBarCategoryItemTimerStateModule.short_2168), 90000000, itemLootId,
                                                                   false);

                rocketItems.Add(new ClientUISlotBarCategoryItemModule(1, GetItemStatus(itemLootId, "ttip_rocket", true, true),
                                                                      ClientUISlotBarCategoryItemModule.SELECTION,
                                                                      ClientUISlotBarCategoryItemModule.NONE,
                                                                      GetCooldownType(itemLootId),
                                                                      categoryTimerModule));
            }
            return new ClientUISlotBarCategoryModule("rockets", rocketItems);
        }

        public ClientUISlotBarCategoryModule GetRocketLauncherCategory()
        {
            var rocketLauncherItems = new List<ClientUISlotBarCategoryItemModule>();

            foreach (string itemLootId in RocketLauncherCategory)
            {

                ClientUISlotBarCategoryItemTimerModule categoryTimerModule =
                        new ClientUISlotBarCategoryItemTimerModule(GetCooldownTime(itemLootId),
                                                                   new ClientUISlotBarCategoryItemTimerStateModule(ClientUISlotBarCategoryItemTimerStateModule.short_2168), 90000000, itemLootId,
                                                                   false);

                rocketLauncherItems.Add(new ClientUISlotBarCategoryItemModule(1, itemLootId == CpuManager.ROCKET_LAUNCHER ? GetRocketLauncherItemStatus(CpuManager.ROCKET_LAUNCHER, "ttip_rocketlauncher", Player.AttackManager.RocketLauncher.CurrentLoad, false) : GetItemStatus(itemLootId, "ttip_rocket"),
                                                                      ClientUISlotBarCategoryItemModule.SELECTION,
                                                                      itemLootId == CpuManager.ROCKET_LAUNCHER ? ClientUISlotBarCategoryItemModule.DOT : ClientUISlotBarCategoryItemModule.NONE,
                                                                      GetCooldownType(itemLootId),
                                                                      categoryTimerModule));
            }
            return new ClientUISlotBarCategoryModule("rocket_launchers", rocketLauncherItems);
        }

        public ClientUISlotBarCategoryModule GetSpecialAmmoCategory()
        {
            var specialAmmoItems = new List<ClientUISlotBarCategoryItemModule>();
            foreach (string itemLootId in SpecialItemsCategory)
            {

                ClientUISlotBarCategoryItemTimerModule categoryTimerModule =
                        new ClientUISlotBarCategoryItemTimerModule(GetCooldownTime(itemLootId),
                                                                   new ClientUISlotBarCategoryItemTimerStateModule(ClientUISlotBarCategoryItemTimerStateModule.short_2168), 90000000, itemLootId,
                                                                   false);

                specialAmmoItems.Add(new ClientUISlotBarCategoryItemModule(1, GetItemStatus(itemLootId, "ttip_explosive"),
                                                                      ClientUISlotBarCategoryItemModule.SELECTION,
                                                                      ClientUISlotBarCategoryItemModule.NONE,
                                                                      GetCooldownType(itemLootId),
                                                                      categoryTimerModule));
            }
            return new ClientUISlotBarCategoryModule("special_items", specialAmmoItems);
        }

        public ClientUISlotBarCategoryModule GetMineCategory()
        {
            var mineItems = new List<ClientUISlotBarCategoryItemModule>();
            foreach (string itemLootId in MinesCategory)
            {

                ClientUISlotBarCategoryItemTimerModule categoryTimerModule =
                        new ClientUISlotBarCategoryItemTimerModule(GetCooldownTime(itemLootId),
                                                                   new ClientUISlotBarCategoryItemTimerStateModule(ClientUISlotBarCategoryItemTimerStateModule.short_2168), 90000000, itemLootId,
                                                                   false);

                mineItems.Add(new ClientUISlotBarCategoryItemModule(1, GetItemStatus(itemLootId, "ttip_explosive"),
                                                                      ClientUISlotBarCategoryItemModule.SELECTION,
                                                                      ClientUISlotBarCategoryItemModule.NONE,
                                                                      GetCooldownType(itemLootId),
                                                                      categoryTimerModule));
            }
            return new ClientUISlotBarCategoryModule("mines", mineItems);
        }

        public ClientUISlotBarCategoryModule GetCpuCategory()
        {
            var cpuItems = new List<ClientUISlotBarCategoryItemModule>();
            foreach (string itemLootId in CpusCategory)
            {

                ClientUISlotBarCategoryItemTimerModule categoryTimerModule =
                        new ClientUISlotBarCategoryItemTimerModule(GetCooldownTime(itemLootId),
                                                                   new ClientUISlotBarCategoryItemTimerStateModule(ClientUISlotBarCategoryItemTimerStateModule.short_2168), 90000000, itemLootId,
                                                                   false);

                cpuItems.Add(new ClientUISlotBarCategoryItemModule(1, GetItemStatus(itemLootId, GetCpuTtip(itemLootId), false),
                                                                      ClientUISlotBarCategoryItemModule.SELECTION,
                                                                      ClientUISlotBarCategoryItemModule.NONE,
                                                                      GetCooldownType(itemLootId),
                                                                      categoryTimerModule));
            }
            return new ClientUISlotBarCategoryModule("cpus", cpuItems);
        }

        public string GetCpuTtip(string itemId)
        {
            switch (itemId)
            {
                case CpuManager.CLK_XL:
                    return "ttip_cloak_cpu";
                case CpuManager.AUTO_ROCKET_CPU:
                    return "ttip_arol_cpu";
                case CpuManager.AUTO_HELLSTROM_CPU:
                    return "ttip_rllb_cpu";
                default:
                    return "";
            }
        }

        public ClientUISlotBarCategoryModule GetTechCategory()
        {
            var techItems = new List<ClientUISlotBarCategoryItemModule>();
            foreach (string itemLootId in TechsCategory)
            {

                ClientUISlotBarCategoryItemTimerModule categoryTimerModule =
                        new ClientUISlotBarCategoryItemTimerModule(GetCooldownTime(itemLootId),
                                                                   new ClientUISlotBarCategoryItemTimerStateModule(ClientUISlotBarCategoryItemTimerStateModule.short_2168), 90000000, itemLootId,
                                                                   false);

                techItems.Add(new ClientUISlotBarCategoryItemModule(1, GetItemStatus(itemLootId, GetTechTtip(itemLootId), false, false, false),
                                                                      ClientUISlotBarCategoryItemModule.SELECTION,
                                                                      ClientUISlotBarCategoryItemModule.NONE,
                                                                      GetCooldownType(itemLootId),
                                                                      categoryTimerModule));
            }
            return new ClientUISlotBarCategoryModule("tech_items", techItems);
        }

        public string GetTechTtip(string itemId)
        {
            switch (itemId)
            {
                case "tech_backup-shields":
                    return "tech_SHIELD_BACKUP_name";
                case "tech_battle-repair-bot":
                    return "tech_BATTLE_REPAIR_BOT_name";
                case "tech_chain-impulse":
                    return "tech_ENERGY_CHAIN_IMPULSE_name";
                case "tech_energy-leech":
                    return "tech_ENERGY_LEECH_ARRAY_name";
                case "tech_precision-targeter":
                    return "tech_ROCKET_PROBABILITY_MAXIMIZER_name";
                default:
                    return "";
            }
        }

        public ClientUISlotBarCategoryModule GetBuyCategory()
        {
            var buyItems = new List<ClientUISlotBarCategoryItemModule>();
            foreach (string itemLootId in BuyCategory)
            {

                ClientUISlotBarCategoryItemTimerModule categoryTimerModule =
                        new ClientUISlotBarCategoryItemTimerModule(GetCooldownTime(itemLootId),
                                                                   new ClientUISlotBarCategoryItemTimerStateModule(ClientUISlotBarCategoryItemTimerStateModule.short_2168), 90000000, itemLootId,
                                                                   false);

                buyItems.Add(new ClientUISlotBarCategoryItemModule(1, GetBuyItemStatus(itemLootId),
                                                                      ClientUISlotBarCategoryItemModule.SELECTION,
                                                                      ClientUISlotBarCategoryItemModule.NONE,
                                                                      GetCooldownType(itemLootId),
                                                                      categoryTimerModule));
            }
            return new ClientUISlotBarCategoryModule("buy_now", buyItems);
        }

        public ClientUISlotBarCategoryModule GetAbilityCategory()
        {
            var abilityItems = new List<ClientUISlotBarCategoryItemModule>();

            var skills = new List<string>();

            AddSkills(skills);

            foreach (string itemLootId in skills)
            {

                ClientUISlotBarCategoryItemTimerModule categoryTimerModule =
                        new ClientUISlotBarCategoryItemTimerModule(GetCooldownTime(itemLootId),
                                                                   new ClientUISlotBarCategoryItemTimerStateModule(ClientUISlotBarCategoryItemTimerStateModule.short_2168), 90000000, itemLootId,
                                                                   false);

                abilityItems.Add(new ClientUISlotBarCategoryItemModule(1, GetAbilityItemStatus(itemLootId, GetAbilityTtip(itemLootId), GetAbilityDescriptionEnabled(itemLootId), false, false),
                                                                      ClientUISlotBarCategoryItemModule.SELECTION,
                                                                      ClientUISlotBarCategoryItemModule.NONE,
                                                                      GetCooldownType(itemLootId),
                                                                      categoryTimerModule));
            }
            return new ClientUISlotBarCategoryModule("ship_abilities", abilityItems);
        }
        
        public void AddSkills(List<string> skills)
        {
            switch(Player.Ship.Id)
            {
                case Ship.GOLIATH_SOLACE:
                    skills.Add(SkillManager.SOLACE);
                    break;
                case Ship.GOLIATH_DIMINISHER:
                    skills.Add(SkillManager.DIMINISHER);
                    break;
                case Ship.GOLIATH_SPECTRUM:
                case Ship.GOLIATH_SPECTRUM_FROST:
                case Ship.GOLIATH_SPECTRUM_LEGEND:
                    skills.Add(SkillManager.SPECTRUM);
                    break;
                case Ship.GOLIATH_SENTINEL:
                case Ship.GOLIATH_SENTINEL_FROST:
                case Ship.GOLIATH_SENTINEL_LEGEND:
                    skills.Add(SkillManager.SENTINEL);
                    break;
                case Ship.GOLIATH_VENOM:
                    skills.Add(SkillManager.VENOM);
                    break;
            }
        }

        public string GetAbilityTtip(string itemId)
        {
            switch (itemId)
            {
                case SkillManager.AEGIS_HP_REPAIR:
                    return "ttip_AEGIS_REPAIRHP_skill";
                case SkillManager.AEGIS_REPAIR_POD:
                    return "ttip_AEGIS_HEALINGPOD_skill";
                case SkillManager.AEGIS_SHIELD_REPAIR:
                    return "ttip_AEGIS_SHIELDRECHARGE_skill";
                case SkillManager.CITADEL_DRAW_FIRE:
                    return "ttip_CITADEL_DRAWFIRE_skill";
                case SkillManager.CITADEL_FORTIFY:
                    return "ttip_CITADEL_FORTIFY_skill";
                case SkillManager.CITADEL_PROTECTION:
                    return "ttip_CITADEL_PROTECTION_skill";
                case SkillManager.CITADEL_TRAVEL:
                    return "ttip_CITADEL_TRAVELMODE_skill";
                case SkillManager.DIMINISHER:
                    return "ttip_DIMINISHER_skill";
                case SkillManager.LIGHTNING:
                    return "ttip_LIGHTNING_skill";
                case SkillManager.SENTINEL:
                    return "ttip_SENTINEL_skill";
                case SkillManager.SOLACE:
                    return "ttip_SOLACE_skill";
                case SkillManager.SPEARHEAD_DOUBLE_MINIMAP:
                    return "ttip_SPEARHEAD_DOUBLEMINIMAP_skill";
                case SkillManager.SPEARHEAD_JAM_X:
                    return "ttip_SPEARHEAD_JAMX_skill";
                case SkillManager.SPEARHEAD_TARGET_MARKER:
                    return "ttip_SPEARHEAD_MARKTARGET_skill";
                case SkillManager.SPEARHEAD_ULTIMATE_CLOAK:
                    return "ttip_SPEARHEAD_ULTIMATECLOAKING_skill";
                case SkillManager.SPECTRUM:
                    return "ttip_SPECTRUM_skill";
                case SkillManager.VENOM:
                    return "ttip_VENOM_skill";
                default:
                    return "";
            }
        }

        public bool GetAbilityDescriptionEnabled(string itemId)
        {
            switch (itemId)
            {
                case SkillManager.DIMINISHER:
                    return true;
                case SkillManager.LIGHTNING:
                    return true;
                case SkillManager.SENTINEL:
                    return true;
                case SkillManager.SOLACE:
                    return true;
                case SkillManager.SPECTRUM:
                    return true;
                case SkillManager.VENOM:
                    return true;
                default:
                    return false;
            }
        }

        public bool GetAbilityItemBarStatusDescriptionEnabled(string itemId)
        {
            switch (itemId)
            {
                case SkillManager.DIMINISHER:
                    return false;
                case SkillManager.LIGHTNING:
                    return false;
                case SkillManager.SENTINEL:
                    return false;
                case SkillManager.SOLACE:
                    return false;
                case SkillManager.SPECTRUM:
                    return false;
                case SkillManager.VENOM:
                    return false;
                default:
                    return true;
            }
        }

        public ClientUISlotBarCategoryModule GetFormationCategory()
        {
            var formationItems = new List<ClientUISlotBarCategoryItemModule>();
            foreach (string itemLootId in FormationsCategory)
            {

                ClientUISlotBarCategoryItemTimerModule categoryTimerModule =
                        new ClientUISlotBarCategoryItemTimerModule(GetCooldownTime(itemLootId),
                                                                   new ClientUISlotBarCategoryItemTimerStateModule(ClientUISlotBarCategoryItemTimerStateModule.short_2168), 90000000, itemLootId,
                                                                   false);

                formationItems.Add(new ClientUISlotBarCategoryItemModule(1, GetItemStatus(itemLootId, GetFormationTtip(itemLootId), false),
                                                                      ClientUISlotBarCategoryItemModule.SELECTION,
                                                                      ClientUISlotBarCategoryItemModule.NONE,
                                                                      GetCooldownType(itemLootId),
                                                                      categoryTimerModule));
            }
            return new ClientUISlotBarCategoryModule("drone_formations", formationItems);
        }

        public string GetFormationTtip(string itemId)
        {
            switch (itemId)
            {
                case DroneManager.DEFAULT_FORMATION:
                    return "ttip_btn_droneFormation_STD";
                case DroneManager.TURTLE_FORMATION:
                    return "ttip_btn_droneFormation_TURTLE";
                case DroneManager.ARROW_FORMATION:
                    return "ttip_btn_droneFormation_ARROW";
                case DroneManager.LANCE_FORMATION:
                    return "ttip_btn_droneFormation_LANCE";
                case DroneManager.STAR_FORMATION:
                    return "ttip_btn_droneFormation_STAR";
                case DroneManager.PINCER_FORMATION:
                    return "ttip_btn_droneFormation_PINCER";
                case DroneManager.DOUBLE_ARROW_FORMATION:
                    return "ttip_btn_droneFormation_DOUBLE_ARROW";
                case DroneManager.DIAMOND_FORMATION:
                    return "ttip_btn_droneFormation_DIAMOND";
                case DroneManager.CHEVRON_FORMATION:
                    return "ttip_btn_droneFormation_CHEVRON";
                case DroneManager.MOTH_FORMATION:
                    return "ttip_btn_droneFormation_MOTH";
                case DroneManager.CRAB_FORMATION:
                    return "ttip_btn_droneFormation_CRAB";
                case DroneManager.HEART_FORMATION:
                    return "ttip_btn_droneFormation_HEART";
                case DroneManager.BARRAGE_FORMATION:
                    return "ttip_btn_droneFormation_BARRAGE";
                case DroneManager.BAT_FORMATION:
                    return "ttip_btn_droneFormation_BAT";
                case DroneManager.DRILL_FORMATION:
                    return "ttip_btn_droneFormation_DRILL";
                case DroneManager.RING_FORMATION:
                    return "ttip_btn_droneFormation_RING";
                case DroneManager.WHEEL_FORMATION:
                    return "ttip_btn_droneFormation_WHEEL";
                default:
                    return "";
            }
        }

        public CooldownTypeModule GetCooldownType(string pItemId)
        {
            switch (pItemId)
            {
                case AmmunitionManager.EMP_01:
                    return new CooldownTypeModule(CooldownTypeModule.short_1048);
                case AmmunitionManager.ISH_01:
                    return new CooldownTypeModule(CooldownTypeModule.short_1085);
                case AmmunitionManager.SMB_01:
                    return new CooldownTypeModule(CooldownTypeModule.short_1124);
                case AmmunitionManager.RSB_75:
                    return new CooldownTypeModule(CooldownTypeModule.short_1220);
                case CpuManager.CLK_XL:
                    return new CooldownTypeModule(CooldownTypeModule.short_138);
                case CpuManager.AUTO_ROCKET_CPU:
                    return new CooldownTypeModule(CooldownTypeModule.short_1428);
                case TechManager.TECH_PRECISION_TARGETER:
                    return new CooldownTypeModule(CooldownTypeModule.ROCKET_PROBABILITY_MAXIMIZER);
                case TechManager.TECH_BACKUP_SHIELDS:
                    return new CooldownTypeModule(CooldownTypeModule.SHIELD_BACKUP);
                case TechManager.TECH_BATTLE_REPAIR_BOT:
                    return new CooldownTypeModule(CooldownTypeModule.BATTLE_REPAIR_BOT);
                case TechManager.TECH_ENERGY_LEECH:
                    return new CooldownTypeModule(CooldownTypeModule.ENERGY_LEECH_ARRAY);
                case TechManager.TECH_CHAIN_IMPULSE:
                    return new CooldownTypeModule(CooldownTypeModule.ENERGY_CHAIN_IMPULSE);
                case SkillManager.SENTINEL:
                    return new CooldownTypeModule(CooldownTypeModule.short_1439);
                case SkillManager.SOLACE:
                    return new CooldownTypeModule(CooldownTypeModule.short_1554);
                case SkillManager.DIMINISHER:
                    return new CooldownTypeModule(CooldownTypeModule.short_1587);
                case SkillManager.SPECTRUM:
                    return new CooldownTypeModule(CooldownTypeModule.short_1699);
                case SkillManager.VENOM:
                    return new CooldownTypeModule(CooldownTypeModule.short_1736);
                case AmmunitionManager.R_IC3:
                    return new CooldownTypeModule(CooldownTypeModule.short_1789);
                case AmmunitionManager.DCR_250:
                    return new CooldownTypeModule(CooldownTypeModule.short_1815);
                case AmmunitionManager.WIZ_X:
                    return new CooldownTypeModule(CooldownTypeModule.short_1952);
                case AmmunitionManager.PLD_8:
                    return new CooldownTypeModule(CooldownTypeModule.short_2172);

                case AmmunitionManager.SLM_01:
                    return new CooldownTypeModule(CooldownTypeModule.short_2047);
                case AmmunitionManager.EMPM_01:
                    return new CooldownTypeModule(CooldownTypeModule.short_2047);
                case AmmunitionManager.DDM_01:
                    return new CooldownTypeModule(CooldownTypeModule.short_2047);
                case AmmunitionManager.ACM_01:
                    return new CooldownTypeModule(CooldownTypeModule.short_2047);
                case AmmunitionManager.SABM_01:
                    return new CooldownTypeModule(CooldownTypeModule.short_2047);
                case AmmunitionManager.IM_01:
                    return new CooldownTypeModule(CooldownTypeModule.short_2047);

                case AmmunitionManager.R_310:
                    return new CooldownTypeModule(CooldownTypeModule.ROCKET);
                case AmmunitionManager.PLT_2026:
                    return new CooldownTypeModule(CooldownTypeModule.ROCKET);
                case AmmunitionManager.PLT_2021:
                    return new CooldownTypeModule(CooldownTypeModule.ROCKET);
                case AmmunitionManager.PLT_3030:
                    return new CooldownTypeModule(CooldownTypeModule.ROCKET);

                case DroneManager.DEFAULT_FORMATION:
                    return new CooldownTypeModule(CooldownTypeModule.short_987);
                case DroneManager.TURTLE_FORMATION:
                    return new CooldownTypeModule(CooldownTypeModule.short_987);
                case DroneManager.ARROW_FORMATION:
                    return new CooldownTypeModule(CooldownTypeModule.short_987);
                case DroneManager.LANCE_FORMATION:
                    return new CooldownTypeModule(CooldownTypeModule.short_987);
                case DroneManager.STAR_FORMATION:
                    return new CooldownTypeModule(CooldownTypeModule.short_987);
                case DroneManager.PINCER_FORMATION:
                    return new CooldownTypeModule(CooldownTypeModule.short_987);
                case DroneManager.DOUBLE_ARROW_FORMATION:
                    return new CooldownTypeModule(CooldownTypeModule.short_987);
                case DroneManager.DIAMOND_FORMATION:
                    return new CooldownTypeModule(CooldownTypeModule.short_987);
                case DroneManager.CHEVRON_FORMATION:
                    return new CooldownTypeModule(CooldownTypeModule.short_987);
                case DroneManager.MOTH_FORMATION:
                    return new CooldownTypeModule(CooldownTypeModule.short_987);
                case DroneManager.CRAB_FORMATION:
                    return new CooldownTypeModule(CooldownTypeModule.short_987);
                case DroneManager.HEART_FORMATION:
                    return new CooldownTypeModule(CooldownTypeModule.short_987);
                case DroneManager.BARRAGE_FORMATION:
                    return new CooldownTypeModule(CooldownTypeModule.short_987);
                case DroneManager.BAT_FORMATION:
                    return new CooldownTypeModule(CooldownTypeModule.short_987);
                case DroneManager.DOME_FORMATION:
                    return new CooldownTypeModule(CooldownTypeModule.short_987);
                case DroneManager.DRILL_FORMATION:
                    return new CooldownTypeModule(CooldownTypeModule.short_987);
                case DroneManager.RING_FORMATION:
                    return new CooldownTypeModule(CooldownTypeModule.short_987);
                case DroneManager.VETERAN_FORMATION:
                    return new CooldownTypeModule(CooldownTypeModule.short_987);
                case DroneManager.WHEEL_FORMATION:
                    return new CooldownTypeModule(CooldownTypeModule.short_987);
                case DroneManager.WAVE_FORMATION:
                    return new CooldownTypeModule(CooldownTypeModule.short_987);
                case DroneManager.X_FORMATION:
                    return new CooldownTypeModule(CooldownTypeModule.short_987);
                default:
                    return new CooldownTypeModule(CooldownTypeModule.NONE);
            }
        }

        private long GetCooldownTime(string pItemId)
        {
            switch (pItemId)
            {
                default:
                    return 0;
            }
        }

        public ClientUISlotBarCategoryItemStatusModule GetItemStatus(string pItemId, string pTooltipId, bool descriptionEnabled = true, bool doubleClickToFire = false, bool buyEnable = false)
        {

            ClientUITooltipsCommand itemBarStatusTootip = new ClientUITooltipsCommand(GetItemBarStatusTooltip(pItemId, pTooltipId, false, 0, descriptionEnabled, doubleClickToFire));
            ClientUITooltipsCommand slotBarStatusTooltip = new ClientUITooltipsCommand(GetSlotBarStatusTooltip(pItemId, pTooltipId, false, 0, descriptionEnabled));

            return new ClientUISlotBarCategoryItemStatusModule(itemBarStatusTootip, true, pItemId, true,
                                                               ClientUISlotBarCategoryItemStatusModule.BLUE, pItemId,
                                                               0, false, true,
                                                               slotBarStatusTooltip, buyEnable ? true : false, LaserCategory.Contains(pItemId) ? Player.Settings.InGameSettings.selectedLaser.Equals(pItemId) :
                                                                                                               RocketsCategory.Contains(pItemId) ? Player.Settings.InGameSettings.selectedRocket.Equals(pItemId) :
                                                                                                               RocketLauncherCategory.Contains(pItemId) ? Player.Settings.InGameSettings.selectedRocketLauncher.Equals(pItemId) :
                                                                                                               FormationsCategory.Contains(pItemId) ? Player.Settings.InGameSettings.selectedFormation.Equals(pItemId) :
                                                                                                               CpusCategory.Contains(pItemId) ? Player.Settings.InGameSettings.selectedCpus.Contains(pItemId) :
                                                                                                               false,
                                                               0);
        }

        public ClientUISlotBarCategoryItemStatusModule GetBuyItemStatus(string pItemId)
        {

            ClientUITooltipsCommand itemBarStatusTootip = new ClientUITooltipsCommand(GetBuyItemBarStatusTooltip(pItemId, "ttip_rocket", 1000, true, "uridium"));
            ClientUITooltipsCommand slotBarStatusTooltip = new ClientUITooltipsCommand(GetBuySlotBarStatusTooltip(pItemId, "ttip_rocket", 1000, true, "uridium"));

            return new ClientUISlotBarCategoryItemStatusModule(itemBarStatusTootip, true, pItemId, true,
                                                               ClientUISlotBarCategoryItemStatusModule.BLUE, pItemId,
                                                               0, false, true,
                                                               slotBarStatusTooltip, true, false,
                                                               0);
        }

        public ClientUISlotBarCategoryItemStatusModule GetAbilityItemStatus(string pItemId, string pTooltipId, bool descriptionEnabled = true, bool doubleClickToFire = false, bool buyEnable = false)
        {

            ClientUITooltipsCommand itemBarStatusTootip = new ClientUITooltipsCommand(GetAbilityItemBarStatusTooltip(pItemId, pTooltipId, false, 0, descriptionEnabled, doubleClickToFire));
            ClientUITooltipsCommand slotBarStatusTooltip = new ClientUITooltipsCommand(GetAbilitySlotBarStatusTooltip(pItemId, pTooltipId, false, 0, descriptionEnabled));

            return new ClientUISlotBarCategoryItemStatusModule(itemBarStatusTootip, true, pItemId, true,
                                                               ClientUISlotBarCategoryItemStatusModule.BLUE, pItemId,
                                                               0, false, true,
                                                               slotBarStatusTooltip, buyEnable ? true : false, false,
                                                               0);
        }

        public ClientUISlotBarCategoryItemStatusModule GetRocketLauncherItemStatus(string pItemId, string pTooltipId, int count = 0, bool descriptionEnabled = true, bool doubleClickToFire = false)
        {

            ClientUITooltipsCommand itemBarStatusTootip = new ClientUITooltipsCommand(GetItemBarStatusTooltip(pItemId, pTooltipId, false, 0, descriptionEnabled, doubleClickToFire));
            ClientUITooltipsCommand slotBarStatusTooltip = new ClientUITooltipsCommand(GetSlotBarStatusTooltip(pItemId, pTooltipId, false, 0, descriptionEnabled));

            var counterColor = Player.Settings.InGameSettings.selectedRocketLauncher == AmmunitionManager.ECO_10 ? ClientUISlotBarCategoryItemStatusModule.BLUE :
                               Player.Settings.InGameSettings.selectedRocketLauncher == AmmunitionManager.HSTRM_01 ? ClientUISlotBarCategoryItemStatusModule.YELLOW :
                               Player.Settings.InGameSettings.selectedRocketLauncher == AmmunitionManager.UBR_100 ? ClientUISlotBarCategoryItemStatusModule.RED :
                               Player.Settings.InGameSettings.selectedRocketLauncher == AmmunitionManager.SAR_01 ? ClientUISlotBarCategoryItemStatusModule.short_1167 :
                               Player.Settings.InGameSettings.selectedRocketLauncher == AmmunitionManager.SAR_01 || Player.Settings.InGameSettings.selectedRocketLauncher == AmmunitionManager.SAR_02 ? ClientUISlotBarCategoryItemStatusModule.short_1167 :
                               Player.Settings.InGameSettings.selectedRocketLauncher == AmmunitionManager.CBR ? ClientUISlotBarCategoryItemStatusModule.short_790 : ClientUISlotBarCategoryItemStatusModule.BLUE;

            return new ClientUISlotBarCategoryItemStatusModule(itemBarStatusTootip, true, pItemId, true,
                                                               counterColor, pItemId,
                                                               count, false, true,
                                                               slotBarStatusTooltip, false, false,
                                                               Player.AttackManager.RocketLauncher.MaxLoad);
        }

        #region Normal GetItemBarStatusTooltip()
        public List<ClientUITooltipModule> GetItemBarStatusTooltip(string pLootId, string pTooltipId, bool pCountable, long pCount, bool descriptionEnabled, bool doubleClickToFire)
        {
            var tooltipItemBars = new List<ClientUITooltipModule>();

            var vec_721_1 = new List<ClientUITextReplacementModule>();

            ClientUITooltipTextFormatModule x_521_1 =
                    new ClientUITooltipTextFormatModule(ClientUITooltipTextFormatModule.const_2514);
            ClientUITextReplacementModule x_721_1 = new ClientUITextReplacementModule("%TYPE%", x_521_1, pLootId);
            vec_721_1.Add(x_721_1);

            ClientUITooltipTextFormatModule class521_localized_1 =
                    new ClientUITooltipTextFormatModule(ClientUITooltipTextFormatModule.LOCALIZED);

            ClientUITooltipModule slotBarItemStatusTooltip_1 =
                    new ClientUITooltipModule(class521_localized_1, ClientUITooltipModule.STANDARD, pTooltipId, vec_721_1);

            tooltipItemBars.Add(slotBarItemStatusTooltip_1);

            if (pCountable)
            {
                var vec_721_2 = new List<ClientUITextReplacementModule>();

                ClientUITooltipTextFormatModule class521_plain =
                        new ClientUITooltipTextFormatModule(ClientUITooltipTextFormatModule.PLAIN);
                ClientUITextReplacementModule x_721_2 =
                        new ClientUITextReplacementModule("%COUNT%", class521_plain, pCount.ToString());
                vec_721_2.Add(x_721_2);

                ClientUITooltipTextFormatModule class521_localized_2 =
                        new ClientUITooltipTextFormatModule(ClientUITooltipTextFormatModule.LOCALIZED);

                ClientUITooltipModule slotBarItemStatusTooltip_2 =
                        new ClientUITooltipModule(class521_localized_2, ClientUITooltipModule.STANDARD, "ttip_count",
                                                  vec_721_2);

                tooltipItemBars.Add(slotBarItemStatusTooltip_2);
            }

            if (descriptionEnabled) {
                var vec_721_3 = new List<ClientUITextReplacementModule>();

                ClientUITooltipTextFormatModule x_521_3 =
                        new ClientUITooltipTextFormatModule(ClientUITooltipTextFormatModule.const_234);

                ClientUITooltipModule slotBarItemStatusTooltip_3 =
                        new ClientUITooltipModule(x_521_3, ClientUITooltipModule.STANDARD, pLootId, vec_721_3);

                tooltipItemBars.Add(slotBarItemStatusTooltip_3);
            }

            if (doubleClickToFire) {
                var vec_721_4 = new List<ClientUITextReplacementModule>();

                ClientUITooltipTextFormatModule class521_localized_4 =
                        new ClientUITooltipTextFormatModule(ClientUITooltipTextFormatModule.LOCALIZED);

                ClientUITooltipModule slotBarItemStatusTooltip_4 =
                        new ClientUITooltipModule(class521_localized_4, ClientUITooltipModule.STANDARD,
                                                  "ttip_double_click_to_fire", vec_721_4);

                tooltipItemBars.Add(slotBarItemStatusTooltip_4);
            }
            return tooltipItemBars;
        }
        #endregion Normal GetItemBarStatusTooltip()

        #region Normal GetSlotBarStatusTooltip()
        public List<ClientUITooltipModule> GetSlotBarStatusTooltip(string pLootId, string pTooltipId, bool pCountable, long pCount, bool descriptionEnabled)
        {
            var tooltipSlotBars = new List<ClientUITooltipModule>();

            var vec_721_5 = new List<ClientUITextReplacementModule>();

            ClientUITooltipTextFormatModule x_521_5 =
                    new ClientUITooltipTextFormatModule(ClientUITooltipTextFormatModule.const_2514);
            ClientUITextReplacementModule x_721_5 = new ClientUITextReplacementModule("%TYPE%", x_521_5, pLootId);
            vec_721_5.Add(x_721_5);

            ClientUITooltipTextFormatModule class521_localized_5 =
                    new ClientUITooltipTextFormatModule(ClientUITooltipTextFormatModule.LOCALIZED);

            ClientUITooltipModule slotBarItemStatusTooltip_5 =
                    new ClientUITooltipModule(class521_localized_5, ClientUITooltipModule.STANDARD, pTooltipId, vec_721_5);

            tooltipSlotBars.Add(slotBarItemStatusTooltip_5);
        
            if (pCountable)
            {
                var vec_721_6 = new List<ClientUITextReplacementModule>();

                ClientUITooltipTextFormatModule tf_plain_6 =
                        new ClientUITooltipTextFormatModule(ClientUITooltipTextFormatModule.PLAIN);
                ClientUITextReplacementModule x_721_6 =
                        new ClientUITextReplacementModule("%COUNT%", tf_plain_6, pCount.ToString());
                vec_721_6.Add(x_721_6);

                ClientUITooltipTextFormatModule tf_localized_6 =
                        new ClientUITooltipTextFormatModule(ClientUITooltipTextFormatModule.LOCALIZED);

                ClientUITooltipModule slotBarItemStatusTooltip_6 =
                        new ClientUITooltipModule(tf_localized_6, ClientUITooltipModule.STANDARD, "ttip_count", vec_721_6);

                tooltipSlotBars.Add(slotBarItemStatusTooltip_6);
            }

            if (descriptionEnabled) {
                var vec_721_7 = new List<ClientUITextReplacementModule>();

                ClientUITooltipTextFormatModule tf_234_7 =
                        new ClientUITooltipTextFormatModule(ClientUITooltipTextFormatModule.const_234);

                ClientUITooltipModule slotBarItemStatusTooltip_7 =
                        new ClientUITooltipModule(tf_234_7, ClientUITooltipModule.STANDARD, pLootId, vec_721_7);

                tooltipSlotBars.Add(slotBarItemStatusTooltip_7);
            }

            return tooltipSlotBars;
        }
        #endregion Normal GetSlotBarStatusTooltip()

        #region Buy GetBuyItemBarStatusTooltip()
        public List<ClientUITooltipModule> GetBuyItemBarStatusTooltip(string pLootId, string pTooltipId, long pAmount, bool doubleClickToBuy, string priceType)
        {
            var tooltipItemBars = new List<ClientUITooltipModule>();

            var vec_721_1 = new List<ClientUITextReplacementModule>();

            ClientUITooltipTextFormatModule x_521_1 =
                    new ClientUITooltipTextFormatModule(ClientUITooltipTextFormatModule.const_2514);
            ClientUITextReplacementModule x_721_1 = new ClientUITextReplacementModule("%TYPE%", x_521_1, pLootId);
            vec_721_1.Add(x_721_1);

            ClientUITooltipTextFormatModule class521_localized_1 =
                    new ClientUITooltipTextFormatModule(ClientUITooltipTextFormatModule.LOCALIZED);

            ClientUITooltipModule slotBarItemStatusTooltip_1 =
                    new ClientUITooltipModule(class521_localized_1, ClientUITooltipModule.STANDARD, pTooltipId, vec_721_1);

            tooltipItemBars.Add(slotBarItemStatusTooltip_1);

            var vec_721_2 = new List<ClientUITextReplacementModule>();

            ClientUITooltipTextFormatModule class521_plain =
                    new ClientUITooltipTextFormatModule(ClientUITooltipTextFormatModule.PLAIN);
            ClientUITextReplacementModule x_721_2 =
                    new ClientUITextReplacementModule("%AMOUNT%", class521_plain, pAmount.ToString());
            vec_721_2.Add(x_721_2);

            ClientUITooltipTextFormatModule class521_localized_2 =
                    new ClientUITooltipTextFormatModule(ClientUITooltipTextFormatModule.LOCALIZED);

            ClientUITooltipModule slotBarItemStatusTooltip_2 =
                    new ClientUITooltipModule(class521_localized_2, ClientUITooltipModule.STANDARD, "ttip_quick_buy_amount",
                                              vec_721_2);

            tooltipItemBars.Add(slotBarItemStatusTooltip_2);

            var vec_721_2_price = new List<ClientUITextReplacementModule>();

            ClientUITooltipTextFormatModule class521_plain_price =
                    new ClientUITooltipTextFormatModule(ClientUITooltipTextFormatModule.PLAIN);
            ClientUITextReplacementModule x_721_2_price =
                    new ClientUITextReplacementModule("%PRICE%", class521_plain_price, pAmount.ToString());
            vec_721_2_price.Add(x_721_2_price);

            ClientUITooltipTextFormatModule class521_localized_2_price =
                    new ClientUITooltipTextFormatModule(ClientUITooltipTextFormatModule.LOCALIZED);

            ClientUITooltipModule slotBarItemStatusTooltip_2_price =
                    new ClientUITooltipModule(class521_localized_2_price, ClientUITooltipModule.STANDARD, priceType == "uridium" ? "ttip_price_uridium" : "ttip_price_credits",
                                              vec_721_2_price);

            tooltipItemBars.Add(slotBarItemStatusTooltip_2_price);

            if (doubleClickToBuy)
            {
                var vec_721_4 = new List<ClientUITextReplacementModule>();

                ClientUITooltipTextFormatModule class521_localized_4 =
                        new ClientUITooltipTextFormatModule(ClientUITooltipTextFormatModule.LOCALIZED);

                ClientUITooltipModule slotBarItemStatusTooltip_4 =
                        new ClientUITooltipModule(class521_localized_4, ClientUITooltipModule.STANDARD,
                                                  "ttip_quick_buy_itembar", vec_721_4);

                tooltipItemBars.Add(slotBarItemStatusTooltip_4);
            }
            return tooltipItemBars;
        }
        #endregion Buy GetBuyItemBarStatusTooltip()

        #region Buy GetBuySlotBarStatusTooltip()
        public List<ClientUITooltipModule> GetBuySlotBarStatusTooltip(string pLootId, string pTooltipId, long pAmount, bool doubleClickToBuy, string priceType)
        {
            var tooltipSlotBars = new List<ClientUITooltipModule>();

            var vec_721_1 = new List<ClientUITextReplacementModule>();

            ClientUITooltipTextFormatModule x_521_1 =
                    new ClientUITooltipTextFormatModule(ClientUITooltipTextFormatModule.const_2514);
            ClientUITextReplacementModule x_721_1 = new ClientUITextReplacementModule("%TYPE%", x_521_1, pLootId);
            vec_721_1.Add(x_721_1);

            ClientUITooltipTextFormatModule class521_localized_1 =
                    new ClientUITooltipTextFormatModule(ClientUITooltipTextFormatModule.LOCALIZED);

            ClientUITooltipModule slotBarItemStatusTooltip_1 =
                    new ClientUITooltipModule(class521_localized_1, ClientUITooltipModule.STANDARD, pTooltipId, vec_721_1);

            tooltipSlotBars.Add(slotBarItemStatusTooltip_1);

            var vec_721_2 = new List<ClientUITextReplacementModule>();

            ClientUITooltipTextFormatModule class521_plain =
                    new ClientUITooltipTextFormatModule(ClientUITooltipTextFormatModule.PLAIN);
            ClientUITextReplacementModule x_721_2 =
                    new ClientUITextReplacementModule("%AMOUNT%", class521_plain, pAmount.ToString());
            vec_721_2.Add(x_721_2);

            ClientUITooltipTextFormatModule class521_localized_2 =
                    new ClientUITooltipTextFormatModule(ClientUITooltipTextFormatModule.LOCALIZED);

            ClientUITooltipModule slotBarItemStatusTooltip_2 =
                    new ClientUITooltipModule(class521_localized_2, ClientUITooltipModule.STANDARD, "ttip_quick_buy_amount",
                                              vec_721_2);

            tooltipSlotBars.Add(slotBarItemStatusTooltip_2);

            var vec_721_2_price = new List<ClientUITextReplacementModule>();

            ClientUITooltipTextFormatModule class521_plain_price =
                    new ClientUITooltipTextFormatModule(ClientUITooltipTextFormatModule.PLAIN);
            ClientUITextReplacementModule x_721_2_price =
                    new ClientUITextReplacementModule("%PRICE%", class521_plain_price, pAmount.ToString());
            vec_721_2_price.Add(x_721_2_price);

            ClientUITooltipTextFormatModule class521_localized_2_price =
                    new ClientUITooltipTextFormatModule(ClientUITooltipTextFormatModule.LOCALIZED);

            ClientUITooltipModule slotBarItemStatusTooltip_2_price =
                    new ClientUITooltipModule(class521_localized_2_price, ClientUITooltipModule.STANDARD, priceType == "uridium" ? "ttip_price_uridium" : "ttip_price_credits",
                                              vec_721_2_price);

            tooltipSlotBars.Add(slotBarItemStatusTooltip_2_price);

            if (doubleClickToBuy)
            {
                var vec_721_7 = new List<ClientUITextReplacementModule>();

                ClientUITooltipTextFormatModule tf_234_7 =
                        new ClientUITooltipTextFormatModule(ClientUITooltipTextFormatModule.const_234);

                ClientUITooltipModule slotBarItemStatusTooltip_7 =
                        new ClientUITooltipModule(tf_234_7, ClientUITooltipModule.STANDARD, "ttip_quick_buy_itembar", vec_721_7);

                tooltipSlotBars.Add(slotBarItemStatusTooltip_7);
            }

            return tooltipSlotBars;
        }
        #endregion Buy GetBuySlotBarStatusTooltip()

        #region Ability GetAbilityItemBarStatusTooltip()
        public List<ClientUITooltipModule> GetAbilityItemBarStatusTooltip(string pLootId, string pTooltipId, bool pCountable, long pCount, bool descriptionEnabled, bool doubleClickToFire)
        {
            var tooltipItemBars = new List<ClientUITooltipModule>();

            if (GetAbilityItemBarStatusDescriptionEnabled(pLootId)) {
                var vec_721_1 = new List<ClientUITextReplacementModule>();

                ClientUITooltipTextFormatModule x_521_1 =
                        new ClientUITooltipTextFormatModule(ClientUITooltipTextFormatModule.const_2514);
                ClientUITextReplacementModule x_721_1 = new ClientUITextReplacementModule("%TYPE%", x_521_1, pLootId);
                vec_721_1.Add(x_721_1);

                ClientUITooltipTextFormatModule class521_localized_1 =
                        new ClientUITooltipTextFormatModule(ClientUITooltipTextFormatModule.LOCALIZED);

                ClientUITooltipModule slotBarItemStatusTooltip_1 =
                        new ClientUITooltipModule(class521_localized_1, ClientUITooltipModule.STANDARD, pTooltipId, vec_721_1);

                tooltipItemBars.Add(slotBarItemStatusTooltip_1);
            }

            if (pCountable)
            {
                var vec_721_2 = new List<ClientUITextReplacementModule>();

                ClientUITooltipTextFormatModule class521_plain =
                        new ClientUITooltipTextFormatModule(ClientUITooltipTextFormatModule.PLAIN);
                ClientUITextReplacementModule x_721_2 =
                        new ClientUITextReplacementModule("%COUNT%", class521_plain, pCount.ToString());
                vec_721_2.Add(x_721_2);

                ClientUITooltipTextFormatModule class521_localized_2 =
                        new ClientUITooltipTextFormatModule(ClientUITooltipTextFormatModule.LOCALIZED);

                ClientUITooltipModule slotBarItemStatusTooltip_2 =
                        new ClientUITooltipModule(class521_localized_2, ClientUITooltipModule.STANDARD, "ttip_count",
                                                  vec_721_2);

                tooltipItemBars.Add(slotBarItemStatusTooltip_2);
            }

            if (descriptionEnabled)
            {
                var vec_721_3 = new List<ClientUITextReplacementModule>();

                ClientUITooltipTextFormatModule x_521_3 =
                        new ClientUITooltipTextFormatModule(ClientUITooltipTextFormatModule.const_234);

                ClientUITooltipModule slotBarItemStatusTooltip_3 =
                        new ClientUITooltipModule(x_521_3, ClientUITooltipModule.STANDARD, pLootId, vec_721_3);

                tooltipItemBars.Add(slotBarItemStatusTooltip_3);
            }

            if (doubleClickToFire)
            {
                var vec_721_4 = new List<ClientUITextReplacementModule>();

                ClientUITooltipTextFormatModule class521_localized_4 =
                        new ClientUITooltipTextFormatModule(ClientUITooltipTextFormatModule.LOCALIZED);

                ClientUITooltipModule slotBarItemStatusTooltip_4 =
                        new ClientUITooltipModule(class521_localized_4, ClientUITooltipModule.STANDARD,
                                                  "ttip_double_click_to_fire", vec_721_4);

                tooltipItemBars.Add(slotBarItemStatusTooltip_4);
            }
            return tooltipItemBars;
        }
        #endregion Ability GetAbilityItemBarStatusTooltip()

        #region Ability GetAbilitySlotBarStatusTooltip()
        public List<ClientUITooltipModule> GetAbilitySlotBarStatusTooltip(string pLootId, string pTooltipId, bool pCountable, long pCount, bool descriptionEnabled)
        {
            var tooltipSlotBars = new List<ClientUITooltipModule>();

            if (GetAbilityItemBarStatusDescriptionEnabled(pLootId)) {
                var vec_721_1 = new List<ClientUITextReplacementModule>();

                ClientUITooltipTextFormatModule x_521_1 =
                        new ClientUITooltipTextFormatModule(ClientUITooltipTextFormatModule.const_2514);
                ClientUITextReplacementModule x_721_1 = new ClientUITextReplacementModule("%TYPE%", x_521_1, pLootId);
                vec_721_1.Add(x_721_1);

                ClientUITooltipTextFormatModule class521_localized_1 =
                        new ClientUITooltipTextFormatModule(ClientUITooltipTextFormatModule.LOCALIZED);

                ClientUITooltipModule slotBarItemStatusTooltip_1 =
                        new ClientUITooltipModule(class521_localized_1, ClientUITooltipModule.STANDARD, pTooltipId, vec_721_1);

                tooltipSlotBars.Add(slotBarItemStatusTooltip_1);
            }

            if (pCountable)
            {
                var vec_721_6 = new List<ClientUITextReplacementModule>();

                ClientUITooltipTextFormatModule tf_plain_6 =
                        new ClientUITooltipTextFormatModule(ClientUITooltipTextFormatModule.PLAIN);
                ClientUITextReplacementModule x_721_6 =
                        new ClientUITextReplacementModule("%COUNT%", tf_plain_6, pCount.ToString());
                vec_721_6.Add(x_721_6);

                ClientUITooltipTextFormatModule tf_localized_6 =
                        new ClientUITooltipTextFormatModule(ClientUITooltipTextFormatModule.LOCALIZED);

                ClientUITooltipModule slotBarItemStatusTooltip_6 =
                        new ClientUITooltipModule(tf_localized_6, ClientUITooltipModule.STANDARD, "ttip_count", vec_721_6);

                tooltipSlotBars.Add(slotBarItemStatusTooltip_6);
            }

            if (descriptionEnabled)
            {
                var vec_721_7 = new List<ClientUITextReplacementModule>();

                ClientUITooltipTextFormatModule tf_234_7 =
                        new ClientUITooltipTextFormatModule(ClientUITooltipTextFormatModule.const_234);

                ClientUITooltipModule slotBarItemStatusTooltip_7 =
                        new ClientUITooltipModule(tf_234_7, ClientUITooltipModule.STANDARD, pLootId, vec_721_7);

                tooltipSlotBars.Add(slotBarItemStatusTooltip_7);
            }

            return tooltipSlotBars;
        }
        #endregion Ability GetAbilitySlotBarStatusTooltip()

        public void SendNewItemStatus(string itemId)
        {
            if (LaserCategory.Contains(itemId))
            {
                Player.SendCommand(GetNewItemStatus(itemId, "ttip_laser", itemId, true, true, false));
            }
            else if (RocketsCategory.Contains(itemId))
            {
                Player.SendCommand(GetNewItemStatus(itemId, "ttip_rocket", itemId, true, true, false));
            }
            else if (CpusCategory.Contains(itemId))
            {
                Player.SendCommand(GetNewItemStatus(itemId, GetCpuTtip(itemId), itemId, false, false, false));
            }
            else if (FormationsCategory.Contains(itemId))
            {
                Player.SendCommand(GetNewItemStatus(itemId, GetFormationTtip(itemId), itemId, false, false, false));
            }
            else if (RocketLauncherCategory.Contains(itemId))
            {
                Player.SendCommand(GetNewRocketLauncherItemStatus(itemId, "ttip_rocketlauncher", Player.AttackManager.RocketLauncher.CurrentLoad, false, false, false));
            }
        }

        public void UseSlotBarItem(string pItemId)
        {
            if (LaserCategory.Contains(pItemId))
            {
                SetSelectedLaserItem(pItemId);
            }
            else if (RocketsCategory.Contains(pItemId))
            {
                SetSelectedRocketItem(pItemId);
            }
            else if (RocketLauncherCategory.Contains(pItemId))
            {
                if (pItemId == CpuManager.ROCKET_LAUNCHER)
                {
                    if (Player.AttackManager.RocketLauncher.CurrentLoad >= 1)
                        Player.AttackManager.LaunchRocketLauncher();
                    else
                        Player.AttackManager.RocketLauncher.ReloadingActive = Player.Storage.AutoRocketLauncher || Player.AttackManager.RocketLauncher.CurrentLoad == 0 ? true : false;
                }
                else
                {
                    SetSelectedRocketLauncherItem(pItemId);
                }
            }
            else if(FormationsCategory.Contains(pItemId))
            {
                Player.DroneManager.ChangeDroneFormation(pItemId);
            }
            else if (TechsCategory.Contains(pItemId))
            {
                Player.TechManager.AssembleTechCategoryRequest(pItemId);
            }
            else if (AbilitiesCategory.Contains(pItemId))
            {
                Player.SkillManager.AssembleSkillCategoryRequest(pItemId);
            }
            else
            {
                switch (pItemId)
                {
                    case AmmunitionManager.EMP_01:
                        Player.AttackManager.EMP();
                        break;
                    case AmmunitionManager.SMB_01:
                        Player.AttackManager.SMB();
                        break;
                    case AmmunitionManager.ISH_01:
                        Player.AttackManager.ISH();
                        break;
                    case CpuManager.CLK_XL:
                        Player.CpuManager.Cloak();
                        break;
                    case CpuManager.AUTO_ROCKET_CPU:
                        Player.CpuManager.ArolX();
                        break;
                    case CpuManager.AUTO_HELLSTROM_CPU:
                        Player.CpuManager.RllbX();
                        break;
                    case AmmunitionManager.SLM_01:
                    case AmmunitionManager.EMPM_01:
                    case AmmunitionManager.DDM_01:
                    case AmmunitionManager.ACM_01:
                    case AmmunitionManager.SABM_01:
                    case AmmunitionManager.IM_01:
                        SendMine(pItemId);
                        break;
                }
            }
        }

        public DateTime mineCooldown = new DateTime();
        public void SendMine(string mineLootId)
        {
            if (Player.Storage.IsInDemilitarizedZone || Player.CurrentInRangePortalId != -1) return;

            if (mineCooldown.AddMilliseconds(TimeManager.MINE_COOLDOWN) < DateTime.Now || Player.Storage.GodMode)
            {
                switch (mineLootId)
                {
                    case AmmunitionManager.SLM_01:
                        new SLM_01(Player, Player.Spacemap, new Position(Player.Position.X, Player.Position.Y), 7);
                        Player.SendCooldown(AmmunitionManager.SLM_01, TimeManager.MINE_COOLDOWN);
                        break;
                    case AmmunitionManager.EMPM_01:
                        new EMPM_01(Player, Player.Spacemap, new Position(Player.Position.X, Player.Position.Y), 2);
                        Player.SendCooldown(AmmunitionManager.EMPM_01, TimeManager.MINE_COOLDOWN);
                        break;
                    case AmmunitionManager.DDM_01:
                        new DDM_01(Player, Player.Spacemap, new Position(Player.Position.X, Player.Position.Y), 4);
                        Player.SendCooldown(AmmunitionManager.DDM_01, TimeManager.MINE_COOLDOWN);
                        break;
                    case AmmunitionManager.ACM_01:
                        new ACM_01(Player, Player.Spacemap, new Position(Player.Position.X, Player.Position.Y), 1);
                        Player.SendCooldown(AmmunitionManager.ACM_01, TimeManager.MINE_COOLDOWN);
                        break;
                    case AmmunitionManager.SABM_01:
                        new SABM_01(Player, Player.Spacemap, new Position(Player.Position.X, Player.Position.Y), 3);
                        Player.SendCooldown(AmmunitionManager.SABM_01, TimeManager.MINE_COOLDOWN);
                        break;
                    case AmmunitionManager.IM_01:
                        new IM_01(Player, Player.Spacemap, new Position(Player.Position.X, Player.Position.Y), 17);
                        Player.SendCooldown(AmmunitionManager.SABM_01, TimeManager.MINE_COOLDOWN);
                        break;
                }
                mineCooldown = DateTime.Now;
            }
        }

        public void SetSelectedLaserItem(string pSelectedLaserItem)
        {
            if (Player.Settings.InGameSettings.selectedLaser.Equals(pSelectedLaserItem))
            {
                if (Player.Settings.Gameplay.quickSlotStopAttack)
                {
                    if (Player.Selected != null)
                    {
                        if (Player.AttackManager.Attacking)
                            Player.DisableAttack(pSelectedLaserItem);
                        else
                            Player.EnableAttack(pSelectedLaserItem);
                    }
                }
            }
            else
            {
                string oldSelectedItem = Player.Settings.InGameSettings.selectedLaser;
                Player.Settings.InGameSettings.selectedLaser = pSelectedLaserItem;
                SendNewItemStatus(oldSelectedItem);
                SendNewItemStatus(pSelectedLaserItem);

                if (Player.AttackManager.Attacking)
                {
                    Player.SendCommand(RemoveMenuItemHighlightCommand.write(new class_h2P(class_h2P.ITEMS_CONTROL), oldSelectedItem, new class_K18(class_K18.ACTIVE)));
                    Player.SendCommand(AddMenuItemHighlightCommand.write(new class_h2P(class_h2P.ITEMS_CONTROL), pSelectedLaserItem, new class_K18(class_K18.ACTIVE), new class_I1W(true, 0)));
                }

                QueryManager.SavePlayer.Settings(Player);
            }
        }

        public void SetSelectedRocketItem(string pSelectedRocketItem)
        {
            if (Player.Settings.InGameSettings.selectedRocket.Equals(pSelectedRocketItem))
            {
                if (Player.Settings.Gameplay.quickSlotStopAttack)
                {
                    Player.AttackManager.RocketAttack();
                }
            }
            else
            {
                string oldSelectedItem = Player.Settings.InGameSettings.selectedRocket;
                Player.Settings.InGameSettings.selectedRocket = pSelectedRocketItem;
                SendNewItemStatus(oldSelectedItem);
                SendNewItemStatus(pSelectedRocketItem);

                QueryManager.SavePlayer.Settings(Player);
            }
        }

        public void SetSelectedRocketLauncherItem(string pSelectedRocketLauncherItem)
        {
            if (pSelectedRocketLauncherItem != CpuManager.ROCKET_LAUNCHER)
            {
                if (pSelectedRocketLauncherItem != Player.Settings.InGameSettings.selectedRocketLauncher)
                {
                    string oldSelectedItem = Player.Settings.InGameSettings.selectedRocketLauncher;
                    Player.Settings.InGameSettings.selectedRocketLauncher = pSelectedRocketLauncherItem;
                    SendNewItemStatus(oldSelectedItem);
                    SendNewItemStatus(pSelectedRocketLauncherItem);

                    Player.AttackManager.RocketLauncher.ChangeLoad(Player.Settings.InGameSettings.selectedRocketLauncher);

                    QueryManager.SavePlayer.Settings(Player);
                }
            }
        }

        public byte[] GetNewItemStatus(string pItemId, string pTooltipId, string selectedItemId, bool descriptionEnabled = true, bool doubleClickToFire = false, bool buyEnable = false)
        {

            ClientUITooltipsCommand itemBarStatusTootip = new ClientUITooltipsCommand(GetItemBarStatusTooltip(pItemId, pTooltipId, false, 0, descriptionEnabled, doubleClickToFire));
            ClientUITooltipsCommand slotBarStatusTooltip = new ClientUITooltipsCommand(GetSlotBarStatusTooltip(pItemId, pTooltipId, false, 0, descriptionEnabled));

            return new ClientUISlotBarCategoryItemStatusModule(itemBarStatusTootip, true, pItemId, true,
                                                               ClientUISlotBarCategoryItemStatusModule.BLUE, pItemId,
                                                               0, false, true,
                                                               slotBarStatusTooltip, buyEnable ? true : false, LaserCategory.Contains(selectedItemId) ? Player.Settings.InGameSettings.selectedLaser.Equals(selectedItemId) : 
                                                                                                               RocketsCategory.Contains(selectedItemId) ? Player.Settings.InGameSettings.selectedRocket.Equals(selectedItemId) : 
                                                                                                               CpusCategory.Contains(selectedItemId) ? Player.Settings.InGameSettings.selectedCpus.Contains(selectedItemId) :
                                                                                                               FormationsCategory.Contains(selectedItemId) ? Player.Settings.InGameSettings.selectedFormation.Equals(selectedItemId) :
                                                                                                               false,
                                                               0).writeCommand();
        }

        public byte[] GetNewRocketLauncherItemStatus(string pItemId, string pTooltipId, int count = 0, bool descriptionEnabled = true, bool doubleClickToFire = false, bool buyEnable = false)
        {

            ClientUITooltipsCommand itemBarStatusTootip = new ClientUITooltipsCommand(GetItemBarStatusTooltip(pItemId, pTooltipId, false, 0, descriptionEnabled, doubleClickToFire));
            ClientUITooltipsCommand slotBarStatusTooltip = new ClientUITooltipsCommand(GetSlotBarStatusTooltip(pItemId, pTooltipId, false, 0, descriptionEnabled));

            var counterColor = Player.Settings.InGameSettings.selectedRocketLauncher == AmmunitionManager.HSTRM_01 ? ClientUISlotBarCategoryItemStatusModule.YELLOW :
                              Player.Settings.InGameSettings.selectedRocketLauncher == AmmunitionManager.UBR_100 ? ClientUISlotBarCategoryItemStatusModule.RED :
                                                  ClientUISlotBarCategoryItemStatusModule.BLUE;

            return new ClientUISlotBarCategoryItemStatusModule(itemBarStatusTootip, true, pItemId, true,
                                                               counterColor, pItemId,
                                                               count, false, true,
                                                               slotBarStatusTooltip, buyEnable ? true : false, LaserCategory.Contains(pItemId) ? Player.Settings.InGameSettings.selectedLaser.Equals(pItemId) :
                                                                                                               RocketsCategory.Contains(pItemId) ? Player.Settings.InGameSettings.selectedRocket.Equals(pItemId) :
                                                                                                               RocketLauncherCategory.Contains(pItemId) ? Player.Settings.InGameSettings.selectedRocketLauncher.Equals(pItemId) :
                                                                                                               FormationsCategory.Contains(pItemId) ? Player.Settings.InGameSettings.selectedFormation.Equals(pItemId) :
                                                                                                               CpusCategory.Contains(pItemId) ? Player.Settings.InGameSettings.selectedCpus.Contains(pItemId) :
                                                                                                               false,
                                                               5).writeCommand();
        }
    }
}
