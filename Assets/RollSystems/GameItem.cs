using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

namespace RollSystems
{
    [Serializable]
    public class GameItemCollection
    {
        public int Min;
        public int Max;
        public ItemCollectionTypes CollectionType;
        public List<Item> GameItems;

    }

    [Serializable]
    public class Item
    {
        public List<GameObject> Items;
    }

    [Serializable]
    public class BaseItem : Item
    {
        public BaseTypes Type = BaseTypes.Other;
    }

    [Serializable]
    public class GameItem : Item
    {
        public GameItemTypes Type = GameItemTypes.Other;
        public int HP = 100;
        public int Atack = 10;
        public int Defence = 10;
    }

    [Serializable]
    public class TerrainItem : Item
    {
        public TerrainTypes Type = TerrainTypes.Other;
        public bool Breakable = false;
        public int Hp = 0;
    }


    [Serializable]
    public class NpcItem : Item
    {
        public NpcTypes Type = NpcTypes.Other;
        public int HP = 100;
        public int Atack = 10;
        public int Defence = 10;
    }


    public enum ItemCollectionTypes
    {
        Base,
        Terrain,
        Items,
        NPC,
        Other
    }

    public enum BaseTypes
    {
        Edge,
        Floor,
        Other
    }

    public enum TerrainTypes
    {
        SoftWall,
        Wall,
        HardWall,
        SecretPassage,
        Other
    }

    public enum GameItemTypes
    {
        Food,
        Trap,
        Fountain,
        Treasure,
        Other
    }

    public enum NpcTypes
    {
        Enemy,
        Ally,
        Other
    }

}