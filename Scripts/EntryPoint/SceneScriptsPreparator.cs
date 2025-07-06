using UnityEngine;

namespace InfrastructurePackage
{
  public class SceneScriptsPreparator : MonoBehaviour
  {
    [SerializeField] public ScenePreparatorModule[] PreparatorModules;

    private bool CheckIsEmpty() => PreparatorModules == null || PreparatorModules.Length <= 0;
    private void Awake()
    {
      if (CheckIsEmpty()) Debug.LogWarning($"[{nameof(SceneScriptsPreparator)}] Modules is empty.");
      
      foreach (ScenePreparatorModule module in PreparatorModules)
        module.AwakeEnter();
    }

    private void Start()
    {
      foreach (ScenePreparatorModule module in PreparatorModules)
        module.AwakeEnter();
    }
  }
}