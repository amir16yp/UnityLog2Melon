# UnityLog2Melon
Universal MelonLoader mod to show Unity game logs on the melonloader console. Useful for debugging
## Usage
Drop the DLL into your melonloader game Mods folder, start your game and messages that were logged with the Unity `Debug` class will display on the MelonLoader console.
## Compilation
Only needs 3 DLLs:
* 0Harmony.dll
* MelonLoader.dll
* UnityEngine.CoreModule.dll

grab them from the game you have installed, use those as references and compile, or just download a prebuilt DLL from the releases page.<br/>
currently i only compile for Mono, if you want to use it on il2cpp you need to compile it yourself.
