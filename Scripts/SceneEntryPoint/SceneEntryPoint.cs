using UnityEngine;

namespace InfrastructurePackage
{
  /// <summary>
  /// In the order of the queue at the Awake stage, it calls the Execute method for the modules contained in it.
  /// By default, it is called before Default Time and has a run order less than 0.
  /// </summary>
  public class SceneEntryPoint : MonoBehaviour
  {
    [field: SerializeField] public SEPModule[] PreparatorModules { get; private set; }

    private bool CheckIsEmpty() => PreparatorModules == null || PreparatorModules.Length <= 0;
    private void Awake()
    {
      if (CheckIsEmpty()) Debug.LogWarning($"[{nameof(SceneEntryPoint)}] Modules is empty!");
      
      foreach (SEPModule module in PreparatorModules)
        if (module != null) module.Execute();
    }
  }
}