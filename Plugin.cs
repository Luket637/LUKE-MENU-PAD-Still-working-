using BepInEx;
using UnityEngine;

namespace LRMenuPad
{
    [BepInPlugin(
        PluginInfo.GUID,
        PluginInfo.Name,
        PluginInfo.Version
    )]
    public class Plugin : BaseUnityPlugin
    {
        private Menu menu;

        private void Awake()
        {
            Logger.LogInfo("LR MENU PAD — UNR 1 loading...");

            GameObject menuObject = new GameObject("LR_MENU_PAD");
            DontDestroyOnLoad(menuObject);

            menu = menuObject.AddComponent<Menu>();
            menu.Create();

            Logger.LogInfo("LR MENU PAD — UNR 1 loaded.");
        }

        private void Update()
        {
            // Temporary keyboard test:
            // Press Y to open/close the menu.
            if (Input.GetKeyDown(KeyCode.Y))
            {
                menu.Toggle();
            }
        }
    }
}
