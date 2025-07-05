using ExtInspectorTools;
using UnityEngine;
using InfrastructurePackage;

namespace InfrastructurePackage
{
  [DefaultExecutionOrder(-1)]
  public class EntryPoint : MonoBehaviour
  {
    [SerializeField, RequireNotNull] public EntryPointBase _entryPoint;
    
    private void Awake()
    {
      _entryPoint.AwakeEnter();
    }

    private void Start()
    {
      _entryPoint.StartEnter();
    }
  }
}