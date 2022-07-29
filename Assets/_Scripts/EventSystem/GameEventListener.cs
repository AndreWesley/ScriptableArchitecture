using UnityEngine;
using UnityEngine.Events;

namespace _Scripts.EventSystem
{
    public class GameEventListener : MonoBehaviour {
        [SerializeField] private ScriptableGameEvent gameEvent = null;
        [SerializeField] private UnityEvent response = null;

        private void OnEnable () {
            gameEvent.AddListener (this);
        }

        private void OnDisable () {
            gameEvent.RemoveListener (this);
        }

        public void OnEventCalled () {
            response.Invoke ();
        }
        
        #if UNITY_EDITOR
        public void Construct(ScriptableGameEvent incomingEvent, UnityEvent incomingResponse)
        {
            gameEvent = incomingEvent;
            response = incomingResponse;
        }
        #endif
    }
}