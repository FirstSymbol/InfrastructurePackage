using UnityEngine;
using ExtInspectorTools;

namespace InfrastructurePackage
{
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