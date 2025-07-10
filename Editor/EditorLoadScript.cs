#if UNITY_EDITOR

using UnityEditor;
using UnityEngine;

namespace InfrastructurePackage.Editor
{
  [InitializeOnLoad]
  public static class EditorLoadScript
  {
    static EditorLoadScript()
    {
      SetupExecutionOrder($"{nameof(SceneEntryPoint)}", -1);
    }
    
    static void SetupExecutionOrder(string scriptName, int order)
    {
      string[] guids = AssetDatabase.FindAssets(scriptName);
      
      if (guids.Length == 0)
      {
        Debug.LogError($"The execution order cannot be set because no resources matching the \"{scriptName}\" type were found.");
        return;
      }
      
      string path = AssetDatabase.GUIDToAssetPath(guids[0]);
      MonoScript script = AssetDatabase.LoadAssetAtPath<MonoScript>(path);

      if (script == null || MonoImporter.GetExecutionOrder(script) != 0) return;
      
      MonoImporter.SetExecutionOrder(script, order);
    }

  }
}
#endif