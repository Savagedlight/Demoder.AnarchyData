/*
 * Demoder.AnarchyData
 *
 * Copyright (c) 2012-2016 Marie Helene Kvello-Aune 
 * 
 * This library is free software; you can redistribute it and/or
 * modify it under the terms of the GNU Lesser General Public
 * License as published by the Free Software Foundation; either 
 * version 3 of the License.
 * 
 * This library is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
 * Lesser General Public License for more details.
 * 
 * You should have received a copy of the GNU Lesser General Public 
 * License along with this library.  If not, see <http://www.gnu.org/licenses/>.
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Demoder.Common;
using Demoder.AnarchyData.Attributes;

namespace Demoder.AnarchyData
{
    [StatValue(Stat.WaitState)]
    [IncludeEnum]
    public enum WaitState
    {
        Standing = 0,
        Sitting = 2,
    }

    [IncludeEnum]
    public enum AoEntity
    {
        NanoLine = 1,
        NanoProgram = 53019
    }

    [IncludeEnum]
    public enum NpcAction
    {
        Sit = 30,
        Stand = 37,
    }

    public enum RecordState
    {
        Unmodified = 0,
        New = 1,
        Modified = 2,
        Deleted = 3,
    }

    /// <summary>
    /// Observed in the Perk RDB category.
    /// </summary>
    [Flags]
    [IncludeEnum]
    public enum ProfessionFlag : uint
    {
        None = BitFlag.None,
        Bit0 = BitFlag.Bit0,
        Soldier = BitFlag.Bit1,
        MartialArtist = BitFlag.Bit2,
        Engineer = BitFlag.Bit3,
        Fixer = BitFlag.Bit4,
        Agent = BitFlag.Bit5,
        Adventurer = BitFlag.Bit6,
        Trader = BitFlag.Bit7,
        Bureaucrat = BitFlag.Bit8,
        Enforcer = BitFlag.Bit9,
        Doctor = BitFlag.Bit10,
        NanoTechnician = BitFlag.Bit11,
        MetaPhysicist = BitFlag.Bit12,
        Bit13 = BitFlag.Bit13,
        Keeper = BitFlag.Bit14,
        Shade = BitFlag.Bit15,
        Bit16 = BitFlag.Bit16,
        Bit17 = BitFlag.Bit17,
        Bit18 = BitFlag.Bit18,
        Bit19 = BitFlag.Bit19,
        Bit20 = BitFlag.Bit20,
        Bit21 = BitFlag.Bit21,
        Bit22 = BitFlag.Bit22,
        Bit23 = BitFlag.Bit23,
        Bit24 = BitFlag.Bit24,
        Bit25 = BitFlag.Bit25,
        Bit26 = BitFlag.Bit26,
        Bit27 = BitFlag.Bit27,
        Bit28 = BitFlag.Bit28,
        Bit29 = BitFlag.Bit29,
        Bit30 = BitFlag.Bit30,
        Bit31 = BitFlag.Bit31,
    }

    [Flags]
    [StatValue(Stat.AccountFlags)]
    [IncludeEnum]
    public enum AccountFlags : uint
    {
        FreePlayer = BitFlag.Bit0,
    }

    [Flags]
    [StatValue(Stat.PlayfieldType)]
    [IncludeEnum]
    public enum PlayfieldType : uint
    {
        Indoors = BitFlag.Bit0,
        Battlestation = BitFlag.Bit1,
    }

    [StatValue(Stat.Profession)]
    [StatValue(Stat.VisualProfession)]
    [IncludeEnum]
    public enum Profession
    {
        Unknown=0,
        Soldier=1,
        MartialArtist=2,
        Engineer=3,
        Fixer=4,
        Agent=5,
        Adventurer=6,
        Trader=7,
        Bureaucrat=8,
        Enforcer=9,
        Doctor=10,
        NanoTechnician=11,
        MetaPhysicist=12,
        Monster=13,
        Keeper=14,
        Shade=15
    }

    [Flags]
    [StatValue(Stat.SelectedTargetType)]
    [IncludeEnum]
    public enum TargetTypeFlag : uint
    {
        Monster = BitFlag.Bit4,
    }

    [StatValue(Stat.AmmoType)]
    [IncludeEnum]
    public enum AmmoType
    {
        Energy = 1,
        Bullets = 2,
        FlameThrower = 3,
        ShotgunShells = 4,
        Arrows=5,
    }

    [IncludeEnum]
    public enum TextureLocation
    {
        Hands = 0,
        Body = 1,
        Feet = 2,
        Arms = 3,
        Legs = 4
    }

    [StatValue(Stat.NanoSchool)]
    [IncludeEnum]
    public enum NanoSchool
    {
        Combat = 1,
        Medical = 2,
        Protection = 3,
        Psi = 4,
        Space = 5,
    }

    [StatValue(Stat.NPCFamily)]
    [IncludeEnum]
    public enum NpcFamily
    {
        // Unsure about this one
        Human=0,

        /// <summary>
        /// For example: Slayerdroid
        /// </summary>
        RoboticPet = 95,
        // See nano 260771 18.6.2
        HealingConstruct = 96,
        // See nano 275020 18.6.2
        AttackConstruct = 97,
        // See nano 263298 18.6.2
        MesmerizingConstruct = 98,
        // See item 300751
        ControlTower = 157,
    }

    [StatValue(Stat.Faction)]
    [IncludeEnum]
    public enum Faction
    {
        Neutral=0,
        Clan = 1,
        Omni = 2
    }

    [StatValue(Stat.Gender)]
    [IncludeEnum]
    public enum Gender
    {
        Unknown = 0,
        Uni = 1,
        Male = 2,
        Female = 3,
    }

    [StatValue(Stat.Breed)]
    [IncludeEnum]
    public enum Breed
    {
        Unknown = 0,
        Solitus = 1,
        Opifex = 2,
        Nanomage = 3,
        Atrox = 4,

        HumanMonster = 7,
    }

    [IncludeEnum]
    public enum SpellParameterType
    {
        Invalid = 0,

        Int32 = 1,
        UInt32 = 2,
        String = 3,
        Hash = 4,
        Bool = 5,

        #region Flags
        BitFlag = 10,
        Enum = 11,
        #endregion

        PerkId=100,
        NanoId=101,
        ItemId=102,
        MdbText=103,
        Duration=104,
        TextStatValue=105,
        Distance=106,
        Percent = 107,
        Playfield = 108,
        BitNum = 109,
        NanoStrain = 110,
        Stat = 111,
        MdbTextBitValue = 112,

    }

    public enum RdbRecordType : uint
    {
        Unknown = 0,
        Unknown3086602 = 3086602,

        #region 1000000
        Playfield1 = 1000001,
        Playfield_UNKNOWN8 = 1000008,
        Tilemap = 1000009,       // What does that even mean?
        PlayfieldBsp = 1000012,
        CollisionData = 1000013,
        PlayfieldSpawn = 1000014,
        Playfield_UNKNOWN21 = 1000021,
        Item = 1000020,            // Parsed
        Playfield3 = 1000026,
        Playfields_UNKOWN30 = 1000030,
        /// <summary>
        /// Contains name, faction and description of playfields and areas of playfields.
        /// </summary>
        Playfield4 = 1000029,
        Perk = 1000036,
        ShadowlandsFactionDescription = 1000037,
        NanoLine = 1000038,        // Parsed
        Playfield_UNKNOWN39 = 1000039,
        #endregion
       
        #region 1010000
        Mesh = 1010001,
        CATMesh = 1010002,
        CATAnim = 1010003,
        Texture = 1010004,
        Text = 1010005,
        GroundTexture = 1010006,
        DungeonHouseMesh = 1010007,
        Icon = 1010008,
        DungeonTexture = 1010009,
        SkinTexture = 1010011,
        TideHouseDoorMesh = 1010014,
        
        Jfif5 = 1010016,
        Jfif6 = 1010017,
        
        BodyTextureMedium = 1010019,
        BodyTextureSmall = 1010020,
        GroundTextureMedium = 1010021,
        GroundTextureSmall = 1010022,
        DungeonTextureMedium = 1010023,
        DungeonTextureSmall = 1010024,
        /// <summary>
        /// Contains JFIF images, but has some prepending bytes.
        /// </summary>
        Wildlife = 1010025,
        ReducedMesh = 1010026,
        ReducedCATMesh = 1010027,
        #endregion        
        NanoProgram = 1040005,     // Parsed
        NPC = 1040023,

        MinimapMetadata = 3086620,
        MinimapTextures = 3086621,
    }

    [IncludeEnum]
    public enum MdbCategory : uint
    {
        Profession = 2004,
        NanoStrain = 2009,
    }

    [Flags]
    [StatValue(Stat.WornItem)]
    [IncludeEnum]
    public enum WornItem : uint
    {
        BasicCyberDeck = BitFlag.Bit0,
        AugmentedCyberDeck = BitFlag.Bit1,
        JobeCyberDeck = BitFlag.Bit2,
        IzgimmerCyberDeck = BitFlag.Bit3,
        GridArmor = BitFlag.Bit4,
        SocialArmor = BitFlag.Bit5,
        NanoDeck = BitFlag.Bit6,
        MpSummonedWeapon = BitFlag.Bit7,
    }

    [IncludeEnum]
    public enum TemplateEvent : int
    {
        Use = 0,
        Repair = 1,
        Wield = 2,
        TargetInVicinity = 3,
        UseItemOnTarget = 4,
        Hit = 5,

        Create = 7,
        Effects = 8,
        Run = 9,
        Activate = 10,

        StartEffect = 12,
        EndEffect = 13,
        Wear = 14,
        UseFailed = 15,
        Enter = 16,
        Open = 18,
        Close = 19,
        Terminate = 20,


        EndCollide = 23,
        FriendlyInVicinity = 24,
        EnemyInVicinity = 25,
        PersonalModifier = 26,
        Failure = 27,
        Cancellation = 28,

        Trade = 37
    }

    [IncludeEnum]
    public enum TemplateAction : int
    {
        /// <summary>
        /// Unknown if this is correct.
        /// Found in item 226270
        /// </summary>
        Any = 0,
        /// <summary>
        /// What does this do?
        /// </summary>
        Get = 1,
        Use = 3,
        /// <summary>
        /// Example item: 222954
        /// </summary>
        UseItemOnItem = 5,
        Wear = 6,
        /// <summary>
        /// Maybe 'Unwear'?
        /// </summary>
        Remove = 7,
        Wield = 8,

        /// <summary>
        /// Found in v12.0
        /// </summary>
        Idle=15,

        UseItemOnItem2 = 32,

        TriggerTargetInVicinity = 111,
        PlayshiftRequirements = 136,
    }

    [IncludeEnum]
    public enum ItemTemplateDataType : uint
    {
        Invalid = 0,
        Spells = 2,
        AtkDef = 4,
        AnimationMesh = 6,
        Animations = 14,
        Stats = 15,
        Sounds = 20,
        NameDesc = 21,
        Actions = 22,
        ShopHash = 23
    }

    [Flags]
    [StatValue(Stat.Specialization)]
    [IncludeEnum]
    public enum SpecializationFlag : uint
    {
        None= BitFlag.None,
        First=BitFlag.Bit0,
        Second = BitFlag.Bit1,
        Third = BitFlag.Bit2,
        Fourth = BitFlag.Bit3,
        Bit5 = BitFlag.Bit5,
        Bit6 = BitFlag.Bit6,
        Bit7 = BitFlag.Bit7,
        Bit8 = BitFlag.Bit8
    }


    /// <summary>
    /// Special handling in display of stat comparisons; All the stat criterions, and all spells which directly modify stats.
    /// </summary>
    [IncludeEnum]
    public enum StatOverride : uint
    {
        ClanTokens = Stat.Alignment,
        OmniTokens = Stat.NanoStrain,
    }

    [StatValue(Stat.DamageType)]
    [StatValue(Stat.DamageType2)]
    [StatValue(Stat.InitiativeType)]
    [IncludeEnum]
    public enum Stat : uint
    {
        #region 0-99
        /// <summary>
        /// Xyphos had this as Flags
        /// </summary>
        None = 0,
        MaxHealth = 1,
        Mass = 2,
        AttackSpeed = 3,
        Breed = 4,
        Organization = 5,
        Team = 6,
        State = 7,
        Duration = 8,
        MapFlags = 9,
        ProfessionLevel = 10,
        PreviousHealth = 11,
        Mesh = 12,
        Anim = 13,
        Name = 14,
        Info = 15,
        Strength = 16,
        Agility = 17,
        Stamina = 18,
        Intelligence = 19,
        Sense = 20,
        Psychic = 21,
        AMS = 22,
        StaticInstance = 23,
        MaxMass = 24,
        StaticType = 25,
        Energy = 26,
        Health = 27,
        Height = 28,
        DMS = 29,
        Can = 30,
        Face = 31,
        HairMesh = 32,
        Faction = 33,
        DeadTimer = 34,
        AccessCount = 35,
        AttackCount = 36,
        TitleLevel = 37,
        BackMesh = 38,
        ShoulderMesh = 39,
        AlienXP = 40,
        FabricType = 41,
        CATMesh = 42,
        ParentType = 43,
        ParentInstance = 44,
        BeltSlots = 45,
        BandolierSlots = 46,
        Girth = 47,
        ClanLevel = 48,
        InsuranceTime = 49,
        InventoryTimeout = 50,
        AggDef = 51,
        XP = 52,
        IP = 53,
        Level = 54,
        InventoryId = 55,
        TimeSinceCreation = 56,
        LastXP = 57,
        Age = 58,
        Gender = 59,
        Profession = 60,
        Credits = 61,
        Alignment = 62,
        Attitude = 63,
        HeadMesh = 64,
        HairTexture = 65,
        ShoulderTexture = 66,
        HairColourRGB = 67,
        NumConstructedQuest = 68,
        MaxConstructedQuest = 69,
        SpeedPenalty = 70,
        TotalMass = 71,
        ItemType = 72,
        RepairDifficulty = 73,
        Value = 74,
        NanoStrain = 75,
        /// <summary>
        /// Was EquipmentPage
        /// </summary>
        ItemClass = 76,
        RepairSkill = 77,
        CurrentMass = 78,
        Icon = 79,
        PrimaryItemType = 80,
        PrimaryItemInstance = 81,
        SecondaryItemType = 82,
        SecondaryItemInstance = 83,
        UserType = 84,
        UserInstance = 85,
        AreaType = 86,
        AreaInstance = 87,
        /// <summary>
        /// Formerly known as DefaultPos
        /// </summary>
        DefaultSlot = 88,
        Breed2 = 89,
        ProjectileAC = 90,
        MeleeAC = 91,
        EnergyAC = 92,
        ChemicalAC = 93,
        RadiationAC = 94,
        ColdAC = 95,
        PoisonAC = 96,
        FireAC = 97,
        StateAction = 98,
        ItemAnim = 99,
        #endregion


        #region 100-199
        MartialArts = 100,
        MultiMelee = 101,
        _1hBlunt = 102,
        _1hEdged = 103,
        MeleeEnergy = 104,
        _2hEdged = 105,
        Piercing = 106,
        _2hBlunt = 107,
        SharpObjects = 108,
        Grenade = 109,
        HeavyWeapons = 110,
        Bow = 111,
        Pistol = 112,
        Rifle = 113,
        MG_SMG = 114,
        Shotgun = 115,
        AssaultRifle = 116,
        VehicleWater = 117,
        MeleeInit = 118,
        RangedInit = 119,
        PhysicalInit = 120,
        BowSpecialAttack = 121,
        SensoryImprovement = 122,
        FirstAid = 123,
        Treatment = 124,
        MechanicalEngineering = 125,
        ElectricalEngineering = 126,
        MaterialMetamorphose = 127,
        BiologicalMetamorphose = 128,
        PsychologicalModification = 129,
        MaterialCreation = 130,
        SpaceTime = 131,
        NanoPool = 132,
        RangedEnergy = 133,
        MultiRanged = 134,
        TrapDisarm = 135,
        Perception = 136,
        Adventuring = 137,
        Swimming = 138,
        VehicleAir = 139,
        MapNavigation = 140,
        Tutoring = 141,
        Brawl = 142,
        Riposte = 143,
        Dimach = 144,
        Parry = 145,
        SneakAttack = 146,
        FastAttack = 147,
        Burst = 148,
        NanoInit = 149,
        FlingShot = 150,
        AimedShot = 151,
        BodyDevelopment = 152,
        DuckExplosions = 153,
        DodgeRanged = 154,
        EvadeClose = 155,
        RunSpeed = 156,
        QuantumFT = 157,
        WeaponSmithing = 158,
        Pharmaceuticals = 159,
        NanoProgramming = 160,
        ComputerLiteracy = 161,
        Psychology = 162,
        Chemistry = 163,
        Concealment = 164,
        BreakingEntry = 165,
        VehicleGround = 166,
        FullAuto = 167,
        NanoResist = 168,
        AlienLevel = 169,
        HealthChangeBest = 170,
        HealthChangeWorst = 171,
        HealthChange = 172,
        CurrentMovementMode = 173,
        PrevMovementMode = 174,
        AutoLockTimeDefault = 175,
        AutoUnlockTimeDefault = 176,
        MoreFlags = 177,
        AlienNextXP = 178,
        NPCFlags = 179,
        CurrentNCU = 180,
        MaxNCU = 181,
        Specialization = 182,
        EffectIcon = 183,
        BuildingType = 184,
        BuildingInstance = 185,
        CardOwnerType = 186,
        CardOwnerInstance = 187,
        BuildingComplexInst = 188,
        ExitInstance = 189,
        NextDoorInBuilding = 190,
        LastConcretePlayfieldInstance = 191,
        ExtenalPlayfieldInstance = 192,
        ExtenalDoorInstance = 193,
        InPlay = 194,
        AccessKey = 195,
        ConflictReputation = 196,
        OrientationMode = 197,
        SessionTime = 198,
        ResetPoints = 199,
        #endregion

        #region 200-299
        Conformity = 200,
        Aggressiveness = 201,
        Stability = 202,
        Extroverty = 203,
        Taunt = 204,
        ReflectProjectileAC = 205,
        ReflectMeleeAC = 206,
        ReflectEnergyAC = 207,
        ReflectChemicalAC = 208,
        WeaponMesh = 209,
        RechargeDelay = 210,
        EquipDelay = 211,
        MaxEnergy = 212,
        TeamFaction = 213,
        CurrentNano = 214,
        GmLevel = 215,
        ReflectRadiationAC = 216,
        ReflectColdAC = 217,
        ReflectNanoAC = 218,
        ReflectFireAC = 219,
        CurrBodyLocation = 220,
        MaxNanoEnergy = 221,
        AccumulatedDamage = 222,
        CanChangeClothes = 223,
        Features = 224,
        ReflectPoisonAC = 225,
        ShieldProjectileAC = 226,
        ShieldMeleeAC = 227,
        ShieldEnergyAC = 228,
        ShieldChemicalAC = 229,
        ShieldRadiationAC = 230,
        ShieldColdAC = 231,
        ShieldNanoAC = 232,
        ShieldFireAC = 233,
        ShieldPoisonAC = 234,
        BerserkMode = 235,
        InsurancePercentage = 236,
        ChangeSideCount = 237,
        AbsorbProjectileAC = 238,
        AbsorbMeleeAC = 239,
        AbsorbEnergyAC = 240,
        AbsorbChemicalAC = 241,
        AbsorbRadiationAC = 242,
        AbsorbColdAC = 243,
        AbsorbFireAC = 244,
        AbsorbPoisonAC = 245,
        AbsorbNanoAC = 246,
        TemporarySkillReduction = 247,
        BirthDate = 248,
        LastSaved = 249,
        SoundVolume = 250,
        CheckPetType = 251,
        MetersWalked = 252,
        QuestLevelsSolved = 253,
        MonsterLevelsKilled = 254,
        PvPLevelsKilled = 255,
        MissionBits1 = 256,
        MissionBits2 = 257,
        AccessGrant = 258,
        DoorFlags = 259,
        ClanHierarchy = 260,
        QuestStat = 261,
        ClientActivated = 262,
        PersonalResearchLevel = 263,
        GlobalResearchLevel = 264,
        PersonalResearchGoal = 265,
        GlobalResearchGoal = 266,
        TurnSpeed = 267,
        LiquidType = 268,
        GatherSound = 269,
        CastSound = 270,
        TravelSound = 271,
        HitSound = 272,
        SecondaryItemTemplate = 273,
        EquippedWeapons = 274,
        XPKillRange = 275,
        AddAllOffense = 276,
        AddAllDefense = 277,
        ProjectileDamageModifier = 278,
        MeleeDamageModifier = 279,
        EnergyDamageModifier = 280,
        ChemicalDamageModifier = 281,
        RadiationDamageModifier = 282,
        ItemHateValue = 283,
        CriticalBonus = 284,
        MaxDamage = 285,
        MinDamage = 286,
        AttackRange = 287,
        HateValueModifier = 288,
        TrapDifficulty = 289,
        StatOne = 290,
        NumAttackEffects = 291,
        DefaultAttackType = 292,
        ItemSkill = 293,
        AttackDelay = 294,
        ItemOpposedSkill = 295,
        ItemSIS = 296,
        InteractionRadius = 297,
        Slot = 298,
        LockDifficulty = 299,
        #endregion


        #region 300-399
        Members = 300,
        MinMembers = 301,
        ClanPrice = 302,
        ClanUpkeep = 303,
        ClanType = 304,
        ClanInstance = 305,
        VoteCount = 306,
        MemberType = 307,
        MemberInstance = 308,
        GlobalClanType = 309,
        GlobalClanInstance = 310,
        ColdDamageModifier = 311,
        ClanUpkeepInterval = 312,
        TimeSinceUpkeep = 313,
        ClanFinalized = 314,
        NanoDamageModifier = 315,
        FireDamageModifier = 316,
        PoisonDamageModifier = 317,
        NanoCost = 318,
        XPModifier = 319,
        BreedLimit = 320,
        GenderLimit = 321,
        LevelLimit = 322,
        PlayerKilling = 323,
        TeamAllowed = 324,
        WeaponDisallowedType = 325,
        WeaponDisallowedInstance = 326,
        Taboo = 327,
        Compulsion = 328,
        SkillDisabled = 329,
        ClanItemType = 330,
        ClanItemInstance = 331,
        DebuffFormula = 332,
        PvPRating = 333,
        SavedXP = 334,
        DoorBlockTime = 335,
        OverrideTexture = 336,
        OverrideMaterial = 337,
        DeathReason = 338,
        DamageType = 339,
        BrainType = 340,
        XPBonus = 341,
        HealInterval = 342,
        HealDelta = 343,
        MonsterTexture = 344,
        HasAlwaysLootable = 345,
        TradeLimit = 346,
        FaceTexture = 347,
        SpecialCondition = 348,
        AutoAttackFlags = 349,
        NextXP = 350,
        TeleportPauseMilliSeconds = 351,
        SISCap = 352,
        AnimSet = 353,
        AttackType = 354,
        WornItem = 355,
        NPCHash = 356,
        CollisionRadius = 357,
        OuterRadius = 358,
        ShapeShift = 359,
        Scale = 360,
        HitEffectType = 361,
        ResurrectDestination = 362,
        NanoInterval = 363,
        NanoDelta = 364,
        ReclaimItem = 365,
        GatherEffectType = 366,
        VisualBreed = 367,
        VisualProfession = 368,
        VisualGender = 369,
        RitualTargetInst = 370,
        SkillTimeOnSelectedTarget = 371,
        LastSaveXP = 372,
        ExtendedTime = 373,
        BurstRecharge = 374,
        FullAutoRecharge = 375,
        GatherAbstractAnim = 376,
        CastTargetAbstractAnim = 377,
        CastSelfAbstractAnim = 378,
        CriticalIncrease = 379,
        WeaponRange = 380,
        NanoRange = 381,
        SkillLockModifier = 382,
        NanoInterruptModifier = 383,
        EntranceStyles = 384,
        /// <summary>
        /// Was ChanceOfBreakOnNanoAttack. However, that's what *OnDebuff does.
        /// This is therefore more likely to be *OnSpellAttack.
        /// </summary>
        ChanceOfBreakOnSpellAttack = 385,
        ChanceOfBreakOnDebuff = 386,
        DieAnim = 387,
        TowerType = 388,
        Expansion = 389,
        LowresMesh = 390,
        CriticalResistance = 391,
        OldTimeExist = 392,
        ResistModifier = 393,
        ChestFlags = 394,
        PrimaryTemplateID = 395,
        NumberOfItems = 396,
        SelectedTargetType = 397,
        CorpseHash = 398,
        AmmoName = 399,
        #endregion


        #region 400-499
        Rotation = 400,
        CATAnim = 401,
        CATAnimFlags = 402,
        DisplayCATAnim = 403,
        DisplayCATMesh = 404,
        NanoSchool = 405,
        NanoSpeed = 406,
        NanoPoints = 407,
        TrainSkill = 408,
        TrainSkillCost = 409,
        InFight = 410,
        NextFormula = 411,
        MultipleCount = 412,
        EffectType = 413,
        ImpactEffectType = 414,
        CorpseType = 415,
        CorpseInstance = 416,
        CorpseAnimKey = 417,
        UnarmedTemplateInstance = 418,
        TracerEffectType = 419,
        AmmoType = 420,
        CharRadius = 421,
        /// <summary>
        /// Was 'ChanceOfUse', but according to auno (and common sense), it is ChanceOfBreakOnAttack
        /// </summary>
        ChanceOfBreakOnAttack = 422,
        CurrentState = 423,
        ArmorType = 424,
        RestModifier = 425,
        BuyModifier = 426,
        SellModifier = 427,
        CastEffectType = 428,
        NPCBrainState = 429,
        WaitState = 430,
        SelectedTarget = 431,
        ErrorCode = 432,
        OwnerInstance = 433,
        CharState = 434,
        ReadOnly = 435,
        DamageType2 = 436,
        CollideCheckInterval = 437,
        PlayfieldType = 438,
        NPCCommand = 439,
        InitiativeType = 440,
        CharTmp1 = 441,
        CharTmp2 = 442,
        CharTmp3 = 443,
        CharTmp4 = 444,
        NPCCommandArg = 445,
        NameTemplate = 446,
        DesiredTargetDistance = 447,
        VicinityRange = 448,
        NPCIsSurrendering = 449,
        StateMachine = 450,
        NPCSurrenderInstance = 451,
        NPCHasPatrolList = 452,
        NPCVicinityChars = 453,
        ProximityRangeOutdoors = 454,
        NPCFamily = 455,
        CommandRange = 456,
        NPCHatelistSize = 457,
        NPCNumPets = 458,
        ODMinSizeAdd = 459,
        EffectRed = 460,
        EffectGreen = 461,
        EffectBlue = 462,
        ODMaxSizeAdd = 463,
        DurationModifier = 464,
        NPCCryForHelpRange = 465,
        LOSHeight = 466,
        SLZoneProtection = 467,
        PetReq2 = 468,
        PetReq3 = 469,
        MapUpgrades = 470,
        MapFlags1 = 471,
        MapFlags2 = 472,
        FixtureFlags = 473,
        FallDamage = 474,
        MaxReflectedProjectileAC = 475,
        MaxReflectedMeleeAC = 476,
        MaxReflectedEnergyAC = 477,
        MaxReflectedChemicalAC = 478,
        MaxReflectedRadiationAC = 479,
        MaxReflectedColdAC = 480,
        MaxReflectedNanoAC = 481,
        MaxReflectedFireAC = 482,
        MaxReflectedPoisonAC = 483,
        ProximityRangeIndoors = 484,
        PetReqVal1 = 485,
        PetReqVal2 = 486,
        PetReqVal3 = 487,
        TargetFacing = 488,
        Backstab = 489,
        OriginatorType = 490,
        QuestInstance = 491,
        QuestIndex1 = 492,
        QuestIndex2 = 493,
        QuestIndex3 = 494,
        QuestIndex4 = 495,
        QuestIndex5 = 496,
        QTDungeonInstance = 497,
        QTNumMonsters = 498,
        QTKilledMonsters = 499,
        #endregion


        #region 500-599
        AnimPos = 500,
        AnimPlay = 501,
        AnimSpeed = 502,
        QTKillNumMonsterID1 = 503,
        QTKillNumMonsterCount1 = 504,
        QTKillNumMonsterID2 = 505,
        QTKillNumMonsterCount2 = 506,
        QTKillNumMonsterID3 = 507,
        QTKillNumMonsterCount3 = 508,
        QuestIndex0 = 509,
        QuestTimeout = 510,
        TowerNPCHash = 511,
        PetType = 512,
        OnTowerCreation = 513,
        OwnedTowers = 514,
        TowerInstance = 515,
        AttackShield = 516,
        SpecialAttackShield = 517,
        NPCVicinityPlayers = 518,
        NPCUseFightModeRegenRate = 519,
        RandomNumberRoll = 520,
        SocialStatus = 521,
        LastRnd = 522,
        AttackDelayCap = 523,
        RechargeDelayCap = 524,
        RemainingHealth = 525,
        RemainingNano = 526,
        TargetDistance = 527,
        TeamLevel = 528,
        NumberOnHateList = 529,
        ConditionState = 530,
        ExpansionPlayfield = 531,
        ShadowBreed = 532,
        NPCFovStatus = 533,
        DudChance = 534,
        HealModifier = 535,
        NanoDamage = 536,
        NanoVulnerability = 537,
        MaxBeneficialSkill = 538,
        ProcInitiative1 = 539,
        ProcInitiative2 = 540,
        ProcInitiative3 = 541,
        ProcInitiative4 = 542,
        FactionModifier = 543,
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// As of 18.5.1, this flag is only used in a single item: 285727 (Set Flag 265 Item)
        /// </remarks>
        Flag265 = 545,
        StackingLine2 = 546,
        StackingLine3 = 547,
        StackingLine4 = 548,
        StackingLine5 = 549,
        StackingLine6 = 550,
        StackingOrder = 551,
        ProcNano1 = 552,
        ProcNano2 = 553,
        ProcNano3 = 554,
        ProcNano4 = 555,
        ProcChance1 = 556,
        ProcChance2 = 557,
        ProcChance3 = 558,
        ProcChance4 = 559,
        OTArmedForces = 560,
        ClanSentinels = 561,
        OTMed = 562,
        ClanGaia = 563,
        OTTrans = 564,
        ClanVanguards = 565,
        GaurdianOfShadows = 566,
        OTFollowers = 567,
        OTOperator = 568,
        OTUnredeemed = 569,
        ClanDevoted = 570,
        ClanConserver = 571,
        ClanRedeemed = 572,
        SK = 573,
        LastSK = 574,
        NextSK = 575,
        PlayerOptions = 576,
        LastPerkResetTime = 577,
        CurrentTime = 578,
        ShadowBreedTemplate = 579,
        NPCVicinityFamily = 580,
        NPCScriptAMSScale = 581,
        ApartmentsAllowed = 582,
        ApartmentsOwned = 583,
        ApartmentAccessCard = 584,
        MapFlags3 = 585,
        MapFlags4 = 586,
        NumberOfTeamMembers = 587,
        ActionCategory = 588,
        CurrentPlayfield = 589,
        DistrictNano = 590,
        DistrictNanoInterval = 591,
        UnsavedXP = 592,
        RegainXP = 593,
        TempSaveTeamID = 594,
        TempSavePlayfield = 595,
        TempSaveX = 596,
        TempSaveY = 597,
        ExtendedFlags = 598,
        ShopPrice = 599,
        #endregion


        #region 600-699
        NewbieHP = 600,
        HPLevelUp = 601,
        HPPerSkill = 602,
        NewbieNP = 603,
        NPLevelUp = 604,
        NPPerSkill = 605,
        MaxShopItems = 606,
        PlayerID = 607,
        ShopRent = 608,
        SynergyHash = 609,
        ShopFlags = 610,
        ShopLastUsed = 611,
        ShopType = 612,
        LockDownTime = 613,
        LeaderLockDownTime = 614,
        InvadersKilled = 615,
        KilledByInvaders = 616,
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// As of 18.5.1, this skill is only used in the following items: 280731, 280749, 280751, 280753, 279250, 285727, 288068
        /// Most of thesee are mitaar hero mechanics (the pads)
        /// One item is called Set Flag 323 Item
        /// </remarks>
        Flag323 = 618,
        HouseTemplate = 620,
        FireDamage = 621,
        ColdDamage = 622,
        MeleeDamage = 623,
        ProjectileDamage = 624,
        PoisonDamage = 625,
        RadiationDamage = 626,
        EnergyDamage = 627,
        ChemicalDamage = 628,
        TotalDamage = 629,
        TrackProjectileDamage = 630,
        TrackMeleeDamage = 631,
        TrackEnergyDamage = 632,
        TrackChemicalDamage = 633,
        TrackRadiationDamage = 634,
        TrackColdDamage = 635,
        TrackPoisonDamage = 636,
        TrackFireDamage = 637,
        NPCSpellArg1 = 638,
        NPCSpellRet1 = 639,
        CityInstance = 640,
        DistanceToSpawnpoint = 641,
        CityTerminalRechargePercent = 642,
        /// <summary>
        /// Value/100 = seconds cooldown
        /// </summary>
        CooldownTime1 = 643,
        CooldownTime2 = 644,
        CooldownTime3 = 645,
        CooldownTime4 = 646,
        CooldownTime5 = 647,
        CooldownTime6 = 648,
        AdvantageHash1 = 651,
        AdvantageHash2 = 652,
        AdvantageHash3 = 653,
        AdvantageHash4 = 654,
        AdvantageHash5 = 655,
        ShopIndex = 656,
        ShopID = 657,
        IsVehicle = 658,
        DamageToNano = 659,

        AccountFlags = 660,
        DamageToNano2 = 661,
        MechData = 662,
        PointValue = 663,
        VehicleAC = 664,
        VehicleDamage = 665,
        VehicleHealth = 666,
        VehicleSpeed = 667,
        BattlestationFaction = 668,
        VictoryPoints = 669,
        BattlestationRep = 670,
        PetState = 671,
        PaidPoints = 672,

        PvpDuelKills = 674,
        PvpDuelDeaths = 675,
        PvpProfessionDuelKills = 676,
        PvpProfessionDuelDeaths = 677,
        PvpSoloScore = 682,
        PvpTeamScore = 683,
        PvpDuelScore = 684,

        MissionBits14 = 685,
        MissionBits15 = 686,
        ConfirmUseTextInstance = 687,
        ItemRarity = 688,
        HealReactivityMultiplier = 689,
        RHandWeaponType = 690,
        FullIPR = 691,
        IccCommendations = 695,
        FreelancersIncTokens = 696,
        #endregion


        ItemSeed = 700,
        ItemLevel = 701,
        ItemTemplateID = 702,
        ItemTemplateID2 = 703,
        ItemCategoryID = 704,
        HasKnubotData = 768,



        QuestBoothDifficulty = 800,
        QuestASMinimumRange = 801,
        QuestASMaximumRange = 802,
        VisualLODLevel = 888,
        TargetDistanceChange = 889,



        TideRequiredDynelID = 900,
        StreamCheckMagic = 999,



        Type = 1001,
        Instance = 1002,

        #region Invalid/errornous Stats
        /// <summary>
        /// Patch: 18.2.0, id: 270362
        /// </summary>
        Unknown649 = 649,
        /// <summary>
        /// Patch: 12.0. ID: 121304
        /// </summary>
        Unknown10207 = 10207,
        #endregion
    }

    [Flags]
    [IncludeEnum]
    public enum ActionFlag : uint
    {
        None = BitFlag.None,
        Bit0 = BitFlag.Bit0,
        Fighting = BitFlag.Bit1,
        Moving = BitFlag.Bit2,
        Falling = BitFlag.Bit3,
        ImplantAccess = BitFlag.Bit4,
        Chat = BitFlag.Bit5,
        SkillTime = BitFlag.Bit6,
        Concealment = BitFlag.Bit7,
        CryForHelp = BitFlag.Bit8,
        VicinityInfo = BitFlag.Bit9,
        Attack = BitFlag.Bit10,
        OnGrid = BitFlag.Bit11,
        BankAccess = BitFlag.Bit12,
        Zoning = BitFlag.Bit13,
        Help = BitFlag.Bit14,
        WalkOnLand = BitFlag.Bit15,
        Bit15 = BitFlag.Bit16,
        SwimInWater = BitFlag.Bit17,
        FlyInAir = BitFlag.Bit18,
        Terminate = BitFlag.Bit19,
        Bit20 = BitFlag.Bit20,
        Bit21 = BitFlag.Bit21,
        Bit22 = BitFlag.Bit22,
        Bit23 = BitFlag.Bit23,
        Anon = BitFlag.Bit24,
        Bit25 = BitFlag.Bit25,
        PvP = BitFlag.Bit26,
        Bit27 = BitFlag.Bit27,
        Bit28 = BitFlag.Bit28,
        Bit29 = BitFlag.Bit29,
        Bit30 = BitFlag.Bit30,
        Bit31 = BitFlag.Bit31,
    }


    [Flags]
    [StatValue(Stat.None, TemplateGuessedType.Nano)]
    [IncludeEnum]
    public enum NanoNoneFlag : uint
    {
        // Main source of info: Xyphos' XRDB
        None = BitFlag.None,
        Visible = BitFlag.Bit0,
        NoResistCannotFumble = BitFlag.Bit1,
        IsShapeChange = BitFlag.Bit2,
        BreakOnAttack = BitFlag.Bit3,
        TurnOnUse = BitFlag.Bit4,

        BreakOnDebuff = BitFlag.Bit5,
        BreakOnInterval = BitFlag.Bit6,
        BreakOnSpellAttack = BitFlag.Bit7,
        NoRemoveNoNCUFriendly = BitFlag.Bit8,

        TellCollision = BitFlag.Bit9,
        NoSelectionIndicator = BitFlag.Bit10,
        UseEmptyDestruct = BitFlag.Bit11, // Might be inaccurate
        /// <summary>
        /// Might indicate the client is never informed this nano executed.
        /// </summary>
        NoIIR = BitFlag.Bit12,
        NoResist = BitFlag.Bit13,

        NotRemovable = BitFlag.Bit14,
        IsHostile = BitFlag.Bit15,
        IsBuff = BitFlag.Bit16,
        IsDebuff = BitFlag.Bit17,
        PlayshiftRequirements = BitFlag.Bit18,

        NoTimerNotify = BitFlag.Bit19,
        NoTimeoutNotify = BitFlag.Bit20,
        DontRemoveOnDeath = BitFlag.Bit21,
        DontBreakOnAttack = BitFlag.Bit22,
        CannotRefresh = BitFlag.Bit23,

        IsHidden = BitFlag.Bit24, 
        ClassDebuffMMBM = BitFlag.Bit25,
        ClassDebuffMCTS = BitFlag.Bit26,
        ClassDebuffPMSI = BitFlag.Bit27,
        ClassCombatDebuff = BitFlag.Bit28,

        ClassAoE = BitFlag.Bit29, 
        ClassRootOrSnare = BitFlag.Bit30,
        WantCollision = BitFlag.Bit31,
    }

    [Flags]
    [StatValue(Stat.None)]
    [IncludeEnum]
    public enum ItemNoneFlag : uint
    {
        // Main source of info: Xyphos' XRDB
        None = BitFlag.None,
        Visible = BitFlag.Bit0,
        ModifiedDescription = BitFlag.Bit1,
        ModifiedName = BitFlag.Bit2,
        CanBeTemplateItem = BitFlag.Bit3,
        TurnOnUse = BitFlag.Bit4,
        HasMultipleCount = BitFlag.Bit5,
        Locked = BitFlag.Bit6,
        Open = BitFlag.Bit7,
        ItemSocialArmour = BitFlag.Bit8,
        TellCollision = BitFlag.Bit9,

        NoSelectionIndicator = BitFlag.Bit10,
        UseEmptyDestruct = BitFlag.Bit11,
        Stationary = BitFlag.Bit12,
        Repulsive = BitFlag.Bit13,
        DefaultTarget = BitFlag.Bit14,
        ItemTextureOverride = BitFlag.Bit15,
        Null = BitFlag.Bit16,
        HasAnimation = BitFlag.Bit17,
        HasRotation = BitFlag.Bit18,
        WantCollision = BitFlag.Bit19,

        WantSignals = BitFlag.Bit20,
        HasSentFirstIIR = BitFlag.Bit21,
        HasEnergy = BitFlag.Bit22,
        MirrorInLeftHand = BitFlag.Bit23,
        IllegalClan = BitFlag.Bit24,
        IllegalOmni = BitFlag.Bit25,
        NoDrop = BitFlag.Bit26,
        Unique = BitFlag.Bit27,
        CanBeAttacked = BitFlag.Bit28,
        DisableFalling = BitFlag.Bit29,
        HasDamage = BitFlag.Bit30,
        DisableStatelCollision = BitFlag.Bit31,
    }

    [Flags]
    [StatValue(Stat.Can)]
    [IncludeEnum]
    public enum CanFlag : uint
    {
        None = BitFlag.None,
        Carry = BitFlag.Bit0,
        Sit = BitFlag.Bit1,
        Wear = BitFlag.Bit2,
        Use = BitFlag.Bit3,
        ConfirmUse = BitFlag.Bit4,
        Consume = BitFlag.Bit5,
        TutorChip = BitFlag.Bit6,
        TutorDevice = BitFlag.Bit7,
        BreakingAndEntering = BitFlag.Bit8,
        Stackable = BitFlag.Bit9,
        NoAmmo = BitFlag.Bit10,
        Burst = BitFlag.Bit11,
        FlingShot = BitFlag.Bit12,
        FullAuto = BitFlag.Bit13,
        AimedShot = BitFlag.Bit14,
        Bow = BitFlag.Bit15,
        ThrowAttack = BitFlag.Bit16,
        SneakAttack = BitFlag.Bit17,
        FastAttack = BitFlag.Bit18,
        DisarmTraps = BitFlag.Bit19,
        AutoSelect = BitFlag.Bit20,
        ApplyOnFriendly = BitFlag.Bit21,
        ApplyOnHostile = BitFlag.Bit22,
        ApplyOnSelf = BitFlag.Bit23,
        CantSplit = BitFlag.Bit24,
        Brawl = BitFlag.Bit25,
        Dimach = BitFlag.Bit26,
        EnableHandAttractors = BitFlag.Bit27,
        CanBeWornWithSocialArmor = BitFlag.Bit28,
        CanParryRiposite = BitFlag.Bit29,
        CanBeParriedRiposited = BitFlag.Bit30,
        ApplyOnFightingTarget = BitFlag.Bit31,
    }

    [Flags]
    [StatValue(Stat.Expansion)]
    [IncludeEnum]
    public enum ExpansionFlag : uint
    {
        None = BitFlag.None,
        NotumWars = BitFlag.Bit0,
        Shadowlands = BitFlag.Bit1,
        ShadowlandsPreorder = BitFlag.Bit2,
        AlienInvasion = BitFlag.Bit3,
        AlienInvasionPreorder = BitFlag.Bit4,
        LostEden = BitFlag.Bit5,
        LostEdenPreorder = BitFlag.Bit6,
        LexacyOfXan = BitFlag.Bit7,
        LegacyOfXanPreorder = BitFlag.Bit8,
    }

    [StatValue(Stat.ExpansionPlayfield)]
    public enum ExpansionPlayfield
    {
        Rubika = 0,
        Shadowlands = 1
    }

    
    [Flags]
    [StatValue(Stat.SLZoneProtection)]
    [IncludeEnum]
    public enum SLZoneProtection : uint
    {
        Adonis = BitFlag.Bit0,
        Penumbra = BitFlag.Bit1,
        Inferno = BitFlag.Bit2,
        Pandemonium = BitFlag.Bit3,
    }

    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// Source: MDB Category 2015 in patch 18.5.4.0
    /// </remarks>
    [IncludeEnum]
    public enum Target
    {
        Self = 1,
        User = 2,
        Target = 3,
        Item = 4,
        Transfer = 5,
        Ground = 6,
        PersonSpotted = 7,
        Attacker = 8,
        Victim = 9,
        Master = 10,
        EnemyHealer = 11,
        FriendAttacker = 12,
        CommandTarget = 13,
        FightTarget = 14,
        ScaryEnemy = 15,
        FollowTarget = 16,
        LastOpponent = 17,
        PersonLeaving = 18,
        PersonLost = 19,
        Pet = 20,
        Area = 21,
        Commander = 22,
        SelectedTarget = 23,
        LastFollowTarget = 24,
    }

    [Flags]
    [StatValue(Stat.Slot, TemplateGuessedType.Weapon)]
    [StatValue(Stat.Slot, TemplateGuessedType.Utility)]
    [IncludeEnum]
    public enum WeaponSlot : uint
    {
        None = BitFlag.None,
        Bit0 = BitFlag.Bit0,
        Hud1 = BitFlag.Bit1,
        Hud3 = BitFlag.Bit2,
        Util1 = BitFlag.Bit3,
        Util2 = BitFlag.Bit4,
        Util3 = BitFlag.Bit5,
        RightHand = BitFlag.Bit6,
        Deck = BitFlag.Bit7,
        LeftHand = BitFlag.Bit8,
        Deck1 = BitFlag.Bit9,
        Deck2 = BitFlag.Bit10,
        Deck3 = BitFlag.Bit11,
        Deck4 = BitFlag.Bit12,
        Deck5 = BitFlag.Bit13,
        Deck6 = BitFlag.Bit14,
        Hud2 = BitFlag.Bit15,
    }

    [StatValue(Stat.DefaultSlot, TemplateGuessedType.Weapon)]
    [StatValue(Stat.DefaultSlot, TemplateGuessedType.Utility)]
    [IncludeEnum]
    public enum WeaponSlotPosition
    {
        None = 0,
        Hud1=1,
        Hud3=2,
        Utils1=3,
        Utils2=4,
        Utils3=5,
        RightHand=6,
        Deck=7,
        LeftHand=8,
        Deck1=9,
        Deck2=10,
        Deck3 = 11,
        Deck4 = 12,
        Deck5 = 13,
        Deck6 = 14,
        Hud2 = 15,
    }

    [Flags]
    [StatValue(Stat.Slot, TemplateGuessedType.Armor)]
    [IncludeEnum]
    public enum ArmorSlot : uint
    {
        None = BitFlag.None,
        Bit0 = BitFlag.Bit0,
        Neck = BitFlag.Bit1,
        Head = BitFlag.Bit2,
        Back = BitFlag.Bit3,
        RightShoulder = BitFlag.Bit4,
        Chest = BitFlag.Bit5,
        LeftShoulder = BitFlag.Bit6,
        RightArm = BitFlag.Bit7,
        Hands = BitFlag.Bit8,
        LeftArm = BitFlag.Bit9,
        RightWrist = BitFlag.Bit10,
        Legs = BitFlag.Bit11,
        LeftWrist = BitFlag.Bit12,
        RightFinger = BitFlag.Bit13,
        Feet = BitFlag.Bit14,
        LeftFinger = BitFlag.Bit15,

        PerkAction = BitFlag.Bit31
    }

    [StatValue(Stat.DefaultSlot, TemplateGuessedType.Armor)]
    [IncludeEnum]
    public enum ArmorSlotPosition
    {
        None=0,
        Neck=1,
        Head=2,
        Back=3,
        RightShoulder=4,
        Chest=5,
        LeftShoulder=6,
        RightArm=7,
        Hands=8,
        LeftArm=9,
        RightWrist=10,
        Legs=11,
        LeftWrist=12,
        RightFinger=13,
        Feet=14,
        LeftFinger=15
    }

    [Flags]
    [StatValue(Stat.Slot, TemplateGuessedType.Implant)]
    [StatValue(Stat.Slot, TemplateGuessedType.Spirit)]
    [IncludeEnum]
    public enum ImplantSlot : uint
    {
        None = BitFlag.None,
        Bit0 = BitFlag.Bit0,
        Eyes = BitFlag.Bit1,
        Head = BitFlag.Bit2,
        Ears = BitFlag.Bit3,
        RightArm = BitFlag.Bit4,
        Chest = BitFlag.Bit5,
        LeftArm = BitFlag.Bit6,
        RightWrist = BitFlag.Bit7,
        Waist = BitFlag.Bit8,
        LeftWrist = BitFlag.Bit9,
        RightHand = BitFlag.Bit10,
        Legs = BitFlag.Bit11,
        LeftHand = BitFlag.Bit12,
        Feet = BitFlag.Bit13,
    }

    [StatValue(Stat.DefaultSlot, TemplateGuessedType.Implant)]
    [StatValue(Stat.DefaultSlot, TemplateGuessedType.Spirit)]
    [IncludeEnum]
    public enum ImplantSlotPosition
    {
        None=0,
        Eyes=1,
        Head=2,
        Ears=3,
        RightArm=4,
        Chest=5,
        LeftArm=6,
        RightWrist=7,
        Waist=8,
        LeftWrist=9,
        RightHand=10,
        Legs=11,
        LeftHand=12,
        Feet=13
    }

    [IncludeEnum]
    public enum TowerType : uint
    {
        None = 0,
        Control = 1,
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Simple Missile Turret
        /// Massive Cannon Turret
        /// Solar Turret
        /// Fire Sprouting Turret
        /// Sentient Corrosive Turret
        /// X-11 Ejector Turret
        /// SAM Battery
        /// </remarks>
        Offensive = 2,

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// [Type=1000020 ID=201004] LC - testbuff tower: 3
        /// [Type=1000020 ID=201614] Guard - Effect Tower TEST Item: 3
        /// [Type=1000020 ID=201615] Guard - Effect Tower TEST Item: 3
        /// [Type=1000020 ID=201616] Guard - Effect Tower TEST Item: 3
        /// [Type=1000020 ID=201617] Guard - Effect Tower TEST Item: 3
        /// [Type=1000020 ID=203098] DNA-Stunning Pulse Turret: 3
        /// [Type=1000020 ID=203099] DNA-Stunning Pulse Turret: 3
        /// [Type=1000020 ID=204585] DNA-Stunning Pulse Turret: 3
        /// [Type=1000020 ID=204586] DNA-Stunning Pulse Turret: 3
        /// </remarks>
        Stun = 3,

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// [Type=1000020 ID=201537] Buff Tower TEST Item: 4
        /// [Type=1000020 ID=201609] De-Buff Tower TEST Item: 4
        /// [Type=1000020 ID=202951] Guardian Conductor of Life: 4
        /// [Type=1000020 ID=202959] Guardian Conductor of Mind: 4
        /// [Type=1000020 ID=202967] Guardian Conductor of Learning: 4
        /// [Type=1000020 ID=202975] Guardian Conductor of Will: 4
        /// [Type=1000020 ID=202983] Guardian Conductor of Speed: 4
        /// [Type=1000020 ID=202987] Guardian Conductor of Presence: 4
        /// [...]
        /// [Type=1000020 ID=204588] Depredating Pulse Turret: 4
        /// [Type=1000020 ID=230935] Chosen Spirit Tower of Illusion: 4
        /// [Type=1000020 ID=230943] Chosen Spirit Tower of Manipulation: 4
        /// [Type=1000020 ID=230959] Faithful Spirit Flower of Dreams: 4
        /// [Type=1000020 ID=230967] Faithful Spirit Flower of Conviction: 4
        /// </remarks>
        Support = 4,

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// [Type=1000020 ID=204582] Anti-Aircraft Pulse Turret: 5
        /// </remarks>
        AntiAir = 5,

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// [Type=1000020 ID=204584] Uncloak Pulse Turret: 6
        /// </remarks>
        Pulse = 6,
    }

    [StatValue(Stat.ItemClass)]
    [IncludeEnum]
    public enum ItemClass : int
    {
        None = 0,
        Weapon = 1,
        Armor = 2,
        Implant = 3,

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Seems to be (mostly?) monster weapons.
        /// 42705 (Equip Generic Innate Weapon)
        /// </remarks>
        Monster = 4,
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        Spirit = 5,
    }

    [IncludeEnum]
    public enum TemplateGuessedType : int
    {
        Misc = 0,
        Weapon = 1,
        Armor = 2,
        Implant = 3,
        Monster = 4,
        Spirit = 5,

        Utility = 10,
        Tower = 11,
        Nano = 12,
        Perk = 13,
        Shop = 14,
        PerkAction = 15,

        MonsterWeapon = 100,
    }
    
    public enum GroupingOperator
    {
        /// <summary>
        /// Test case: item 32030
        /// </summary>
        Or = 3,
        And = 4,
        /// <summary>
        /// See item 125740
        /// </summary>
        Not = 42,      
    }

    public enum FunctionOperator
    {
        #region "Functions"
        Unknown15 = 15,
        ItemWorn = 31,
        ItemNotWorn = 32,
        ItemWielded = 33,
        ItemNotWielded = 34,

        OwnsNano = 35,
        NotOwnsNano = 36,

        /// <summary>
        /// (IntegrityTester.cs:113/Log) AoItemsParser: Unknown operator: 50 (Template=[Type=1040005 ID=30090])
        /// (IntegrityTester.cs:113/Log) AoItemsParser: Unknown operator: 50 (Template=[Type=1040005 ID=222687])
        /// (IntegrityTester.cs:113/Log) AoItemsParser: Unknown operator: 50 (Template=[Type=1040005 ID=263282])
        /// (IntegrityTester.cs:113/Log) AoItemsParser: Unknown operator: 50 (Template=[Type=1040005 ID=263281])
        /// Example format from ingame: not Must target yourself (value1=1, value2=3)
        /// </summary>
        IsSameAs = 50,

        UseLocation = 88,

        /// <summary>
        /// Not sure if this is right... check item 161690.
        /// </summary>
        RunningNano = 91,
        /// <summary>
        /// item: 210702
        /// </summary>
        RunningNanoLine = 92,
        /// <summary>
        /// Test case: item 125740
        /// </summary>
        PerkTrained = 93,
        PerkLocked = 94,
        PerkNotLocked = 97,

        True = 98,
        False = 99,

        NotRunningNano = 101,
        /// <summary>
        /// See item 227768
        /// </summary>
        NotRunningNanoLine = 102,
        PerkNotTrained = 103,
        SpawnedFromHash = 104,
        /// <summary>
        /// See item 118263.
        /// </summary>
        NeedFreeInventorySlots = 106,

        OwnsItem = 108,
        /// <summary>
        /// Unsure about this one. See item 295896 (Michizure's T-Shirt Explosion). 
        /// The parameter to operator 109 is 294015 (ID of Michizure's T-shirt)
        /// </summary>
        NotOwnsItem = 109,
        HasQuestHash = 117,
        CheckNcu = 127,

        /// <summary>
        /// See item 300751
        /// </summary>
        StatSameAsSelectedTarget = 85,
        /// <summary>
        /// See item 287749
        /// </summary>
        StatEqualStat = 130,
        StatLessThanStat = 131,
        StatGreaterThanStat = 132,
        StatNotEqualStat = 133,
        #endregion
        
    }

    public enum UseOnOperator
    {
        #region Target (applies to previous operator)
        /// <summary>
        /// See item 28892
        /// </summary>
        Target = 18,
        Self = 19,
        SecondaryItem = 21,
        User = 26,
        /// <summary>
        /// Xyphos claims this is 'OnCaster'. 
        /// 223233 has:
        /// {0 0 100}
        /// {0 102 93}
        /// {0 0 42}
        /// Note: Reverse polish notation; read from the bottom.
        /// Note: {stat value operator}
        /// </summary>
        Caster = 100,

        FightingTarget = 110,
        #endregion

    }

    public enum StateOperator
    {
        #region States
        /// <summary>
        /// Not sure about this one. Item: 275692
        /// </summary>
        IsNpc = 44,
        IsFighting = 45,
        IsNotFighting = 134,
        /// <summary>
        /// Needs verification. Item example: 29319
        /// This seems to be a special comparison of stats, and not a state.
        /// param 1: 251
        /// param 2: 1
        /// </summary>
        HaveNoRegularPets = 66,

        IsFlying = 70,

        IsTowerCreateAllowed = 80,
        CanDisableDefenseShield = 83,
        IsPlayerOrPlayerControlledPet = 86,

        IsFalling = 89,
        /// <summary>
        /// See item 88068
        /// </summary>
        NotInVehicle = 111,
        /// <summary>
        /// Needs verification. Item example: 25997
        /// </summary>
        FlyingAllowed = 112,

        /// <summary>
        /// See item 263962.
        /// This might be target information.
        /// </summary>
        IsLandmineArmed = 114,

        /// <summary>
        /// See item 259882
        /// Looks like a state test.
        /// </summary>
        CanPlaceLandmine = 115,
        
        /// <summary>
        /// See item 259782
        /// </summary>
        IsInOrganization = 116,

        /// <summary>
        /// See item 267391
        /// </summary>
        IsOwnPet = 118,
        /// <summary>
        /// See item 274373
        /// </summary>
        InGracePeriod = 119,
        /// <summary>
        /// See item 274373
        /// </summary>
        InLcaLevelRange = 120,
        /// <summary>
        /// See item 281485
        /// </summary>
        IsInRaid = 121,
        IsBossNpc = 122,
        IsInDuel = 123,

        /// <summary>
        /// See item 142708 and 296265. Parameter is 2 for both of these.
        /// Other parameters may mean other things. 
        /// TODO: Investigate this!
        /// </summary>
        CanTeleport = 124,

        /// <summary>
        /// See item 296263 (Breed Change: Solitus Female)
        /// </summary>
        HasNotAnythingWorn = 125,
        AlliesInCombat = 135,
        AlliesNotInCombat = 136,
        /// <summary>
        /// (IntegrityTester.cs:113/Log) AoItemsParser: Unknown operator: 138 (Template=[Type=1000020 ID=301250])
        /// </summary>
        InTeamWith = 138,
        #endregion
    }

    public enum StatOperator
    {
        #region Test against stat
        Equal = 0,
        LessThan = 1,
        GreaterThan = 2,

        /// <summary>
        /// Xyphos: BitAnd
        /// </summary>
        BitSet = 22,

        /// <summary>
        /// Not sure if stat or state.
        /// </summary>
        NotEqual = 24,

        /// <summary>
        /// Xyphos: NotBitAnd
        /// </summary>
        BitNotSet = 107,
        #endregion        
    }

    [IncludeEnum]
    public enum Operator
    {
        #region Test against stat
        StatEqual = 0,
        StatLessThan = 1,
        StatGreaterThan = 2,
        StatBitSet = 22,
        StatNotEqual = 24,
        StatBitNotSet = 107,
        #endregion

        #region Grouping Operators
        /// <summary>
        /// Test case: item 32030
        /// </summary>
        GOr = 3,
        GAnd = 4,
        /// <summary>
        /// See item 125740
        /// </summary>
        GNot = 42,
        #endregion

        #region States
        /// <summary>
        /// Not sure about this one. Item: 275692
        /// </summary>
        StateIsNpc = 44,
        StateIsFighting = 45,
        StateIsNotFighting = 134,

        /// <summary>
        /// Needs verification. Item example: 29319
        /// This seems to be a special comparison of stats...
        /// param 1: 251
        /// param 2: 1
        /// </summary>
        StateHaveNoRegularPets = 66,

        StateIsFlying = 70,

        StateIsTowerCreateAllowed = 80,
        StateCanDisableDefenseShield = 83,
        StateIsPlayerOrPlayerControlledPet = 86,

        StateIsFalling = 89,

        /// <summary>
        /// See item 88068
        /// </summary>
        StateNotInVehicle = 111,
        /// <summary>
        /// Needs verification. Item example: 25997
        /// </summary>
        StateFlyingAllowed = 112,

        /// <summary>
        /// See item 263962.
        /// This might be target information.
        /// </summary>
        StateIsLandmineArmed = 114,

        /// <summary>
        /// See item 259882
        /// Looks like a state test.
        /// </summary>
        StateCanPlaceLandmine = 115,

        /// <summary>
        /// See item 259782
        /// </summary>
        StateIsInOrganization = 116,

        /// <summary>
        /// See item 267391
        /// </summary>
        StateIsOwnPet = 118,
        /// <summary>
        /// See item 274373
        /// </summary>
        StateInGracePeriod = 119,
        /// <summary>
        /// See item 274373
        /// </summary>
        StateInLcaLevelRange = 120,
        /// <summary>
        /// See item 281485
        /// </summary>
        StateIsInRaid = 121,
        StateIsBossNpc = 122,
        StateIsInDuel = 123,
        

        /// <summary>
        /// See item 142708 and 296265. Parameter is 2 for both of these.
        /// Other parameters may mean other things. 
        /// TODO: Investigate this!
        /// </summary>
        StateCanTeleport = 124,

        /// <summary>
        /// See item 296263 (Breed Change: Solitus Female)
        /// </summary>
        StateHasNotAnythingWorn = 125,

        Unknown135 = 135,
        /// <summary>
        /// Investigate if this should rather be a function.
        /// </summary>
        StateAlliesNotInCombat = 136,
        /// <summary>
        /// (IntegrityTester.cs:113/Log) AoItemsParser: Unknown operator: 138 (Template=[Type=1000020 ID=301250])
        /// </summary>
        StateInTeamWith = 138,
        #endregion

        #region "Functions"
        Unknown15 = 15, /* Xyphos' code claimed this was AreaZMinMax */
        ItemWorn = 31,
        ItemNotWorn = 32,
        ItemWielded = 33,
        ItemNotWielded = 34,

        OwnsNano = 35,
        NotOwnsNano = 36,

        /// <summary>
        /// (IntegrityTester.cs:113/Log) AoItemsParser: Unknown operator: 50 (Template=[Type=1040005 ID=30090])
        /// (IntegrityTester.cs:113/Log) AoItemsParser: Unknown operator: 50 (Template=[Type=1040005 ID=222687])
        /// (IntegrityTester.cs:113/Log) AoItemsParser: Unknown operator: 50 (Template=[Type=1040005 ID=263282])
        /// (IntegrityTester.cs:113/Log) AoItemsParser: Unknown operator: 50 (Template=[Type=1040005 ID=263281])
        /// Example format from ingame: not Must target yourself (value1=1, value2=3)
        /// </summary>
        IsSameAs = 50,

        UseLocation = 88,

        RunningNano = 91,
        RunningNanoLine = 92,
        /// <summary>
        /// Test case: item 125740
        /// </summary>
        PerkTrained = 93,
        PerkLocked = 94,
        PerkNotLocked = 97,

        True = 98,
        False = 99,

        NotRunningNano = 101,
        /// <summary>
        /// See item 227768
        /// </summary>
        NotRunningNanoLine = 102,
        PerkNotTrained = 103,
        SpawnedFromHash = 104,
        /// <summary>
        /// See item 118263.
        /// </summary>
        NeedFreeInventorySlots = 106,
        /// <summary>
        /// FC name: HasUnique
        /// </summary>
        OwnsItem = 108,
        /// <summary>
        /// FC name: HasNotUnique
        /// </summary>
        NotOwnsItem = 109,
        HasQuestHash = 117,
        CheckNcu = 127,
        Unknown128 = 128,


        /// <summary>
        /// See item 300751
        /// </summary>
        StatSameAsSelectedTarget = 85,
        /// <summary>
        /// See item 287749
        /// </summary>
        StatEqualStat = 130,
        StatLessThanStat = 131,
        StatGreaterThanStat = 132,
        StatNotEqualStat = 133,
        #endregion

        #region UseOn
        /// <summary>
        /// See item 28892
        /// </summary>
        OnTarget = 18,
        OnSelf = 19,
        OnSecondaryItem = 21,
        OnUser = 26,
        /// <summary>
        /// Xyphos claims this is 'OnCaster'. 
        /// 223233 has:
        /// {0 0 100}
        /// {0 102 93}
        /// {0 0 42}
        /// Note: Reverse polish notation; read from the bottom.
        /// Note: {stat value operator}
        /// </summary>
        OnCaster = 100,
        OnFightingTarget = 110,
        #endregion
    }

    public enum UnusedOperator
    {
        TimeLess = 5,
        TimeLarger = 6,
        ItemHas = 7,
        ItemHasNot = 8,
        ID = 9,
        TargetID = 10,
        TargetSignal = 11,
        TargetStat = 12,
        PrimaryItem = 13,
        SecondaryItem = 14,
        User = 16,
        ItemAnim = 17,
        Signal = 20,
        BitOr = 23,
        Illegal = 25,
        OnValidTarget = 27,
        OnInvalidTarget = 28,
        OnValidUser = 29,
        OnInvalidUser = 30,
        OnGeneralBeholder = 37,
        IsValid = 38,
        IsInvalid = 39,
        IsAlive = 40,
        IsWithinVicinity = 41,
        IsWithinWeaponRange = 43,
        IsAttacked = 46,
        IsAnyoneLooking = 47,
        IsFoe = 48,
        IsInDungeon = 49,
        DistanceTo = 51,
        IsInNoFightingArea = 52,
        Template_Compare = 53,
        Min_Max_Level_Compare = 54,
        MonsterTemplate = 57,
        HasMaster = 58,
        CanExecuteFormulaOnTarget = 59,
        Area_TargetInVicinity = 60,
        IsUnderHeavyAttack = 61,
        IsLocationOk = 62,
        IsNotTooHighLevel = 63,
        HasChangedRoomWhileFighting = 64,
        KullNumberOf = 65,
        NumberOfItems = 67,
        PrimaryTemplate = 68,
        IsTeleporting = 69,
        ScanForStat = 71,
        HasMeOnPetlist = 72,
        TrickleDownLarger = 73,
        TrickleDownLess = 74,
        IsPetOverequipped = 75,
        HasPetPendingNanoFormula = 76,
        IsPet = 77,
        CanAttackChar = 79,
        InventorySlotIsFull = 81,
        InventorySlotIsEmpty = 82,
        HasEnteredNonPvpZone = 87,
        IsOnDifferentPlayfield = 90,
        IsFactionReactionSet = 95,
        HasMoveToTarget = 96,

        Unknown128 = 128,
        
    }

    /*
    public enum Operators
    {
        EqualTo = 0,
        LessThan = 1,
        GreaterThan = 2,
        Or = 3,
        And = 4,
        OnTarget = 18,
        OnSelf = 19,
        OnSecondaryItem = 21,
        BitAnd = 22,
        NotEqual = 24,
        OnUser = 26,
        HasWornItem = 31,
        HasNotWornItem = 32,
        HasWieldedItem = 33,
        HasNotWieldedItem = 34,
        HasFormula = 35,
        HasNotFormula = 36,
        Not = 42,
        IsNPC = 44,
        IsFighting = 45,
        NotSummoned = 66,
        IsFlying = 70,
        IsTowerCreateAllowed = 80,
        CanDisableDefenseShield = 83,
        SameAsSelectedTarget = 85,
        IsPlayerOrPlayerControlledPet = 86,
        UseLocation = 88,
        IsFalling = 89,
        HasRunningNano = 91,
        HasRunningNanoLine = 92,
        HasPerk = 93,
        IsPerkLocked = 94,
        IsPerkUnlocked = 97,
        OnCaster = 100,
        HasNotRunningNano = 101,
        HasNotRunningNanoLine = 102,
        PerkNotTrained = 103,
        SpawnedFromHash = 104,
        NotBitAnd = 107,
        ObtainedItem = 108,
        FightingTarget = 110,
        IsFlyingAllowed = 112,
        HasQuestHash = 117,
        IsBoss = 122,
        Not2 = 123,
        IsInDuel = 124,
        CheckNcu = 127,
        StateEqual = 136,



        #region Unknowns
        Unknown106 = 106,
        Unknown109 = 109,
        Unknown111 = 111,
        Unknown114 = 114,
        Unknown115 = 115,
        Unknown116 = 116,
        Unknown118 = 118,
        Unknown119 = 119,
        Unknown120 = 120,
        Unknown121 = 121,
        Unknown123 = 123,
        Unknown125 = 125,
        #endregion

        #region Not found in database 18.5.3
        TimeLess = 5,
        TimeLarger = 6,
        ItemHas = 7,
        ItemHasNot = 8,
        ID = 9,
        TargetID = 10,
        TargetSignal = 11,
        TargetStat = 12,
        PrimaryItem = 13,
        SecondaryItem = 14,
        AreaZMinMax = 15,
        User = 16,
        ItemAnim = 17,
        Signal = 20,
        BitOr = 23,
        Illegal = 25,
        OnValidTarget = 27,
        OnInvalidTarget = 28,
        OnValidUser = 29,
        OnInvalidUser = 30,
        OnGeneralBeholder = 37,
        IsValid = 38,
        IsInvalid = 39,
        IsAlive = 40,
        IsWithinVicinity = 41,
        IsWithinWeaponRange = 43,
        IsAttacked = 46,
        IsAnyoneLooking = 47,
        IsFoe = 48,
        IsInDungeon = 49,
        IsSameAs = 50,
        DistanceTo = 51,
        IsInNoFightingArea = 52,
        Template_Compare = 53,
        Min_Max_Level_Compare = 54,
        MonsterTemplate = 57,
        HasMaster = 58,
        CanExecuteFormulaOnTarget = 59,
        Area_TargetInVicinity = 60,
        IsUnderHeavyAttack = 61,
        IsLocationOk = 62,
        IsNotTooHighLevel = 63,
        HasChangedRoomWhileFighting = 64,
        KullNumberOf = 65,
        NumberOfItems = 67,
        PrimaryTemplate = 68,
        IsTeleporting = 69,
        ScanForStat = 71,
        HasMeOnPetlist = 72,
        TrickleDownLarger = 73,
        TrickleDownLess = 74,
        IsPetOverequipped = 75,
        HasPetPendingNanoFormula = 76,
        IsPet = 77,
        CanAttackChar = 79,
        InventorySlotIsFull = 81,
        InventorySlotIsEmpty = 82,
        HasEnteredNonPvpZone = 87,
        IsOnDifferentPlayfield = 90,
        IsFactionReactionSet = 95,
        HasMoveToTarget = 96,
        True = 98,
        False = 99,
        #endregion
    }
    */

    [Flags]
    [IncludeEnum]
    public enum PerkType : uint
    {
        Shadowlands = BitFlag.None,
        ShadowBreed = BitFlag.Bit0,
        AlienInvasion = BitFlag.Bit1,
        BreedSolitus = BitFlag.Bit2,
        BreedOpifex = BitFlag.Bit3,
        BreedNanomage = BitFlag.Bit4,
        BreedAtrox = BitFlag.Bit5,
        PersonalResearch = BitFlag.Bit6,
        GlobalResearch1 = BitFlag.Bit7,
        GlobalResearch2 = BitFlag.Bit8,
    }

    [StatValue(Stat.MoreFlags)]
    public enum MoreFlag : uint
    {
        // See item 300697
        Autolevel = BitFlag.Bit11,
    }

    [StatValue(Stat.ShapeShift)]
    public enum MonsterShape : uint
    {
        Parrot = 30365,
        L33t = 226880,
        Wolf = 30348,
        PitLizard = 17710,
        Sabretooth = 30356,
        Totem = 227238,
        Leet = 17655,
    }

    [Flags]
    [IncludeEnum]
    public enum TrySneakModifier : uint
    {
        IgnoreSkillLock = BitFlag.Bit0,
    }

    [Flags]
    [IncludeEnum]
    public enum EndFightModifier : uint
    {
        Self = BitFlag.Bit0,
        Attackers = BitFlag.Bit1
    }

    
    [StatValue(Stat.ItemRarity)]
    [IncludeEnum]
    public enum ItemRarity
    {
        // Yellow
        Undefined=0,
        // grey
        Trash=1,
        // white
        Normal=2,
        // orange
        Exotic=3,
        // blue
        Quest=4,
        // pink!
        Social=5
    }
    

}