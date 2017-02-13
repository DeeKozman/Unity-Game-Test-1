using System.Collections;
using System;
using GameStuff.Utility.Databases;
using UnityEngine;
using UnityEditor;

namespace GameStuff.Utility.Databases.ScriptObjDatabase
{

    public class ScriptObjDatabase<T> : AbstractDatabase<T> where T : ScriptObjDatabaseAsset
    {
        protected override void OnAddObject(T t)
        {
#if UNITY_EDITOR
            t.hideFlags = UnityEngine.HideFlags.HideInHierarchy;
            AssetDatabase.AddObjectToAsset(t, this);
            EditorUtility.SetDirty(this);
#endif
        }

        protected override void OnRemoveObject(T t)
        {
#if UNITY_EDITOR
            DestroyImmediate(t, true);
            EditorUtility.SetDirty(this);
#endif
        }
    }
}
