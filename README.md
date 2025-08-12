# InfrastructurePackage
## SceneEntryPoint
### Settings
By default, SceneEntryPoint is called before Default Time and has a run order less than 0 (-1 by default)
#### Execution Order
![Order](https://github.com/user-attachments/assets/3d75e9ec-341f-49be-8209-72683902a7d1)
### How to use
Create a script that will be inherited from SEPModule class and override the Execute method. After that, you should add the SceneEntryPoint script to any game object on your stage and transfer the script inherited from SEPModule to the SceneEntryPoint.
### Example
#### Script
```Csharp
public class SceneEntryPoint : MonoBehaviour
  {
    [field: SerializeField] public SEPModule[] SEPModules { get; private set; }

    private bool CheckIsEmpty() => SEPModules == null || SEPModules.Length <= 0;
    private void Awake()
    {
      if (CheckIsEmpty()) Debug.LogWarning($"[{nameof(SceneEntryPoint)}] Modules is empty!");
      
      foreach (SEPModule module in SEPModules)
        if (module != null) module.ExecuteAwake();
    }
  }
```
#### Inspector
![Inspector](https://github.com/user-attachments/assets/06bfe92e-0f22-47f1-9cfa-a4fd3772c793)
#### Console
![Console](https://github.com/user-attachments/assets/04f56a79-1594-4bc0-b6f9-3328542fa987)
