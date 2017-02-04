using UnityEngine;
using System.Collections;

public abstract class Element  {
	public abstract void Accept(Ivisitor visitor);
}
