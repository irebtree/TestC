using UnityEngine;
using System.Collections;

public class CommandClient : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Receiver receiver = new Receiver();
		ICommand command = new ConcreteCommand(receiver);

		Invoker invoker = new Invoker();
		invoker.SetCommand(command);
		invoker.ExecuteCommand();
	}
	

}
