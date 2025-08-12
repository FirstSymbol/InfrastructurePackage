using UnityEngine;

namespace InfrastructurePackage
{
  public abstract class SEPModule : MonoBehaviour
  {
    public abstract void ExecuteAwake();
    public abstract void ExecuteStart();
  }
}