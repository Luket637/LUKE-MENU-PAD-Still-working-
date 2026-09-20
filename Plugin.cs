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
        private GameObject menuObject;
        private bool menuOpen;

        private void Awake()
        {
            Logger.LogInfo("LR MENU PAD — UNR 1 loaded.");
        }

        private void Update()
        {
            // Y = Open / Close
            if (Input.GetKeyDown(KeyCode.Y))
            {
                ToggleMenu();
            }
        }

        private void ToggleMenu()
        {
            menuOpen = !menuOpen;

            if (menuObject != null)
                menuObject.SetActive(menuOpen);
        }
    }
}
