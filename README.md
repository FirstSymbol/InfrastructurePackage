# InfrastructurePackage
## EntryPoint
### Settings
Go to the Script Execution Order and add the EntryPoint script at -1 position to it.
#### Execution Order
![image](https://github.com/user-attachments/assets/f10f14a5-040a-492f-ac54-c47cef3ffb3b)
### How to use
Create a script that will be inherited from Entry Point Base and override the Awake Enter or Start Enter methods. After that, you should add the Entry Point script to any game object on your stage and transfer the script inherited from EntryPointBase to the Entry Point.
### Example
#### Script
```Csharp
using InfrastructurePackage;
using UnityEngine;

namespace ProjectContent.Scripts
{
  public class TestEntryPoint : EntryPointBase
  {
    public override void AwakeEnter()
    {
      Debug.Log("TestEntryPoint - Awake");
    }

    public override void StartEnter()
    {
      Debug.Log("TestEntryPoint - Start");
    }
  }
}
```
#### Inspector
![image](https://github.com/user-attachments/assets/0826e734-966a-4340-9bed-07cb8610bbb3)
#### Console
![image](https://github.com/user-attachments/assets/f41549dc-37de-4f1b-bdf1-568ab25b8a86)
