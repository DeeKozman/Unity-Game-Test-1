using System.Collections;

using UnityEngine;
using UnityEditor;

public class CreateGameInventoryItem {

    [MenuItem("Tools/Create/GameInventoryItem")]
    public static void CreateInventoryItem()
    {
        GameInventoryItem item = ScriptableObject.CreateInstance<GameInventoryItem>();
        ProjectWindowUtil.CreateAsset(item, "GameInventoryItem.asset");
    }
    
}
