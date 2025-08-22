using UnityEngine;

namespace InfrastructurePackage
{
  /// <summary>
  /// In the order of the queue at the Awake stage, it calls the Execute method for the modules contained in it.
  /// By default, it is called before Default Time and has a run order less than 0.
  /// </summary>
  public class SceneEntryPoint : MonoBehaviour
  {
    [field: SerializeField] public SEPModule[] SEPModules { get; private set; }

    private bool CheckIsEmpty() => SEPModules == null || SEPModules.Length <= 0;
    private void Awake()
    {
      if (CheckIsEmpty())
      {
        Debug.LogWarning($"[{nameof(SceneEntryPoint)}] Modules is empty!"); return;
      }
      
      foreach (SEPModule module in SEPModules)
        if (module != null) module.ExecuteAwake();
    }

    private void Start()
    {
      foreach (SEPModule module in SEPModules)
        if (module != null) module.ExecuteStart();
    }
  }
}