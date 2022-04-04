using Abstractions.Commands;
using Abstractions.Commands.CommandsInterfaces;
using UnityEngine;

public class MoveCommand : CommandExecutorBase<IMoveCommand>
{
    public override void ExecuteSpecificCommand(IMoveCommand command)
    {
        Debug.Log("Move");
    }
}
