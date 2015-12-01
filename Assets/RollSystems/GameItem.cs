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
        public List<GameItem> GameItems;

    }
    [Serializable]
    public class GameItem
    {
        public GameItemTypes Type = GameItemTypes.Other;
        public int HP = 100;
        public int Atack = 10;
        public int Defence = 10;
        public List<GameObject> Items;
    }

    public enum ItemCollectionTypes
    {
        Floor,
        Edge,
        SoftWall,
        Wall,
        HardWall,
        SecretPassage,
        Other
    }

    public enum GameItemTypes
    {
        Food,
        Enemy,
        Ally,
        Terrain,
        Other
    }

}