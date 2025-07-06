using UnityEngine;

namespace InfrastructurePackage
{
  [RequireComponent(typeof(SceneScriptsPreparator))]
  public abstract class ScenePreparatorModule : MonoBehaviour
  {
    public virtual void AwakeEnter() { }
    public virtual void StartEnter() { }
  }
}