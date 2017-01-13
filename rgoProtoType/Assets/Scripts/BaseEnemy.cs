using UnityEngine;
using System.Collections;


[System.Serializable]
public class BaseEnemy  {

    public string name;

    public enum Type
    {
            GRASS,
            FIRE,
            WATER,
            LIGHTNING,
            ICE

    }


    public enum Rarity
    {
        COMMON,
        UNCOMMON,
        RARE,
        VERYRARE

    }

    public Type EnemyType;
    public Rarity rarity;

    public float baseHP;
    public float currentHP;
    public float baseMP;
    public float currentMP;
    public float baseAttack;
    public float baseDef;
    public float currentAttack;
    public float currentDef;


}
