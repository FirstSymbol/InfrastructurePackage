using UnityEngine;

namespace InfrastructurePackage
{
  [RequireComponent(typeof(SceneScriptsPreparator))]
  public abstract class SSPModule : MonoBehaviour
  {
    public virtual void AwakeEnter() { }
    public virtual void StartEnter() { }
  }
}