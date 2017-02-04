using UnityEngine;
using System.Collections;

public class Invoker  {

	private ICommand command;

	public void SetCommand(ICommand command)
	{
		this.command = command;
	}

	public void ExecuteCommand()
	{
		command.Execute();
	}
}
