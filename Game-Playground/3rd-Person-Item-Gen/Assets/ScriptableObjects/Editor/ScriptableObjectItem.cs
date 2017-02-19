using System.Collections;
using System.Collections.Generic;
using GameStuff.ItemGen;
using UnityEngine;
using UnityEditor;

public class ScriptableObjectItem : MonoBehaviour {

    [MenuItem("Tools/Create/GameItem")]
    public static void Create()
    {
       /* ItemInit.CreateInstance();
        ProjectWindowUtil.StartNameEditingIfProjectWindowExists(
            ItemInit.GetInstanceID(),
            ScriptableObject.CreateInstance<EndNameEdit>(),
            "ItemInit.asset",
            AssetPreview.GetMiniThumbnail(asset),
            null);*/
    }
    
}
