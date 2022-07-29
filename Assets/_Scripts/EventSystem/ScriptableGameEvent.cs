using System;
using System.Collections.Generic;
using UnityEngine;

namespace _Scripts.EventSystem
{
	[CreateAssetMenu(fileName = "GameEvent", menuName = "SidiaTeaches/GameEvent", order = 1)]
	public class ScriptableGameEvent : ScriptableObject {
	
		[SerializeField] private List<GameEventListener> listeners = null;
	
		public int ListenersCount => listeners.Count;

		public void Call()
		{
			for (int i = listeners.Count - 1; i >= 0; i--)
			{
				listeners[i].OnEventCalled();
			}
		}

		public void AddListener(GameEventListener listener) {
			if (listeners == null)
			{
				listeners = new List<GameEventListener>();
			}
			listeners.Add(listener);
		}

		public void RemoveListener(GameEventListener listener) {
			if (listeners == null)
			{
				listeners = new List<GameEventListener>();
			}
			listeners.Remove(listener);
		}

	}
}