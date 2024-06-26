public class WalkingState : State
{
    public WalkingState(NPC _npc, StateMachine _stateMachine) : base(_npc, _stateMachine) { }
    public override void Enter()
    {
        base.Enter();
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void HandleInput()
    {

        base.HandleInput();
    }

    public override void LogicUpdate()
    {
        base.LogicUpdate();
        npc.Destination();
        if (npc.Arrived()) { stateMachine.ChangeState(npc.thinking); }

    }
    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
    }
}