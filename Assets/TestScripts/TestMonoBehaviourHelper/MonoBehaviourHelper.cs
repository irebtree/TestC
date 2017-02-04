using UnityEngine;
using System.Collections;

public static class MonoBehaviourHelper {
	/// <summary>
	/// Starts the coroutine in no MonoBehavior class.
	/// </summary>
	/// <returns>The coroutine.</returns>
	/// <param name="routine">Routine.</param>
	public static Coroutine StartCoroutine(IEnumerator routine)
	{
		MonoBehaviourInstance MonoHelper = new GameObject ("MonoHelper").AddComponent<MonoBehaviourInstance>();
		return MonoHelper.DestroyWhenComplete(routine);
	}
	
	public class MonoBehaviourInstance : MonoBehaviour
	{
		public Coroutine DestroyWhenComplete(IEnumerator routine)
		{
			return StartCoroutine(DestroyObjHandler(routine));
		}
		public IEnumerator DestroyObjHandler(IEnumerator routine)
		{
			yield return StartCoroutine(routine);
			Destroy(gameObject);
		}
	}
	
}