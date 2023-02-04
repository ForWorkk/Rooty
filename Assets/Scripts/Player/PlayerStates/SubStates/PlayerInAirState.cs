﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInAirState : PlayerState
{
    private int xInput;
    private bool isGrounded;

    public PlayerInAirState(Player player, PlayerStateMachine stateMachine, PlayerData playerData, string animBoolName) : base(player, stateMachine, playerData, animBoolName)
    {

    }

    public override void DoChecks()
    {
        base.DoChecks();

        isGrounded = player.CheckIfGrounded();
    }

    public override void Enter()
    {
        base.Enter();
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void LogicUpdate()
    {
        base.LogicUpdate();

        xInput = (int)player.InputHandler.MovementInput.x;

        player.CheckIfShouldFlip(xInput);

        player.SetVelocityX(player.CurrentVelocity.x + xInput * playerData.InAirAcceleration * Time.deltaTime);

        if (Mathf.Abs(player.CurrentVelocity.x) > playerData.MoveSpeed)
        {
            player.SetVelocityX(xInput * playerData.MoveSpeed);
        }

        player.Anim.SetFloat("yVelocity", player.CurrentVelocity.y);


        if (isGrounded && player.CurrentVelocity.y < 0.01f)
        {
            stateMachine.ChangeState(player.IdleState);
        }
    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
    }
}
