using System.Collections;

using UnityEngine;
using UnityEditor;

public class CreateGameInventoryItem {

    [MenuItem("Tools/Create/GameInventoryItem")]
    public static void CreateInventoryItem()
    {
        GameInventoryItemTemplate item = ScriptableObject.CreateInstance<GameInventoryItemTemplate>();
        ProjectWindowUtil.CreateAsset(item, "GameInventoryItem.asset");
    }
    
}
