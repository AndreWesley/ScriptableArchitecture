using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Tests.TestUtils
{
    public static class TestUtils
    {
        public static GameObject LoadPrefab(string prefabRelativePath)
        {
            return AssetDatabase.LoadAssetAtPath<GameObject>($"Assets/Prefabs/{prefabRelativePath}");
        }
    }
}
