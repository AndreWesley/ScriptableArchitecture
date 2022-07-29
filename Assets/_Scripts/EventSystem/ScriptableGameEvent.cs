using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GameEvent", menuName = "SidiaTeaches/GameEvent", order = 1)]
public class ScriptableGameEvent : ScriptableObject {
	
	[SerializeField] private List<GameEventListener> listeners = null;
	
	public void Call()
	{
		for (int i = listeners.Count - 1; i >= 0; i--)
		{
			listeners[i].OnEventCalled();
		}
	}

	public void AddListener(GameEventListener listener) {
		listeners.Add(listener);
	}

	public void RemoveListener(GameEventListener listener) {
		listeners.Remove(listener);
	}
}