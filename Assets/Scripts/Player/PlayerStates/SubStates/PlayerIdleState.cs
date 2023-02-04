using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIdleState : PlayerGroundedState
{
    public PlayerIdleState(Player player, PlayerStateMachine stateMachine, PlayerData playerData, string animBoolName) : base(player, stateMachine, playerData, animBoolName)
    {
    }

    public override void DoChecks()
    {
        base.DoChecks();
    }

    public override void Enter()
    {
        base.Enter();

        player.SetVelocityX(0f);
        player.SetVelocityY(0f);
        player.RB.isKinematic = true;
    }

    public override void Exit()
    {
        base.Exit();
        player.RB.isKinematic = false;
    }

    public override void LogicUpdate()
    {
        base.LogicUpdate();

        if (input.x != 0f)
        {
            stateMachine.ChangeState(player.MoveState);
        }
        /*
        if (input.y < 0f)
        {
            stateMachine.ChangeState(player.CrouchState);
        }
        */
    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
    }
}
