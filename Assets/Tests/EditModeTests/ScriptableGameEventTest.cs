using _Scripts.EventSystem;
using NUnit.Framework;
using UnityEngine;

namespace Tests.EditModeTests
{
    public class ScriptableGameEventTest
    {
        [Test]
        public void When_AddListener_Expects_IncreaseListenersList()
        {
            //arrange
            GameObject obj = new GameObject();
            ScriptableGameEvent gameEvent = ScriptableObject.CreateInstance<ScriptableGameEvent>();
            GameEventListener eventListener = obj.AddComponent<GameEventListener>();

            // //act
            gameEvent.AddListener(eventListener);

            // //assert
            Assert.AreEqual(1, gameEvent.ListenersCount);
        }
        
        [Test]
        public void When_RemoveListener_Expects_ReduceListenersList()
        {
            //arrange
            GameObject obj = new GameObject();
            GameEventListener eventListener = obj.AddComponent<GameEventListener>();
            ScriptableGameEvent gameEvent = ScriptableObject.CreateInstance<ScriptableGameEvent>();
            
            //act
            gameEvent.AddListener(eventListener);
            Assert.AreEqual(1, gameEvent.ListenersCount);
            gameEvent.RemoveListener(eventListener);
            
            //assert
            Assert.AreEqual(0, gameEvent.ListenersCount);
        }
    }
}
