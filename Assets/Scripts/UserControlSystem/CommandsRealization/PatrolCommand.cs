using Abstractions.Commands;
using Abstractions.Commands.CommandsInterfaces;
using UnityEngine;

public class PatrolCommand : CommandExecutorBase<IPatrolCommand>
{
    public override void ExecuteSpecificCommand(IPatrolCommand command)
    {
        Debug.Log("Patrol");
    }
}
