using UnityEngine;

namespace InfrastructurePackage
{
  [RequireComponent(typeof(EntryPoint))]
  public abstract class EntryPointBase : MonoBehaviour
  {
    public virtual void AwakeEnter() { }
    public virtual void StartEnter() { }
  }
}