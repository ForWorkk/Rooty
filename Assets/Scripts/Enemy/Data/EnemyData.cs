using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "newEnemyData", menuName = "Data/Enemy Data/Base Data")]
public class EnemyData : ScriptableObject
{
    [Header("Combat Data")]
    [SerializeField] private float maxHealth;

    public float MaxHealth => maxHealth;

    [Header("Check Variables")]
    [SerializeField] private LayerMask whatIsGround;
    [SerializeField] private Vector2 groundCheckBox;

    public LayerMask WhatIsGround => whatIsGround;
    public Vector2 GroundCheckBox => groundCheckBox;
}
