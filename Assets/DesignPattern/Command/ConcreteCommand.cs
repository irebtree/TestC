using UnityEngine;
using System.Collections;

public class ConcreteCommand : ICommand {
	private Receiver receiver;
	public ConcreteCommand(Receiver receiver)
	{
		this.receiver = receiver;
	}

	public void Execute()
	{
		receiver.Action();
	}
}
