# InfrastructurePackage
## SceneScriptsPreparator
### Settings
By default, SceneScriptsPreparator is called before Default Time and has a run order less than 0 (-1 by default)
#### Execution Order
![Order](https://github.com/user-attachments/assets/2799800a-bd5a-401c-8645-5546ff6d231c)
### How to use
Create a script that will be inherited from SSPModule class and override the Execute method. After that, you should add the SceneScriptsPreparator script to any game object on your stage and transfer the script inherited from SSPModule to the SceneScriptsPreparator.
### Example
#### Script
```Csharp
using InfrastructurePackage;
using UnityEngine;

namespace ProjectContent.Scripts
{
  public class TestSSPModule : SSPModule
  {
    public override void Execute()
    {
      Debug.Log($"{nameof(TestSSPModule)} - Execute");
    }
  }
}
```
#### Inspector
![Inspector](https://github.com/user-attachments/assets/575ea365-474b-44bc-bb65-6ce7037ef1c0)
#### Console
![Console](https://github.com/user-attachments/assets/c33a81ec-b398-49b3-80d5-fc39485ac914)

