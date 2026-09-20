using UnityEngine;
using UnityEngine.UI;

namespace LRMenuPad
{
    public class Menu : MonoBehaviour
    {
        private GameObject panel;

        public void Create()
        {
            panel = new GameObject("LR_MENU_PAD");

            // Panel
            Image background = panel.AddComponent<Image>();
            background.color = Color.blue;

            // Rounded-looking panel
            RectTransform rect = panel.GetComponent<RectTransform>();
            rect.sizeDelta = new Vector2(500f, 300f);

            // Title
            GameObject titleObject = new GameObject("Title");
            titleObject.transform.SetParent(panel.transform, false);

            Text title = titleObject.AddComponent<Text>();
            title.text = "LR MENU PAD";
            title.color = Color.black;
            title.fontSize = 32;
            title.alignment = TextAnchor.MiddleCenter;

            RectTransform titleRect = titleObject.GetComponent<RectTransform>();
            titleRect.anchorMin = new Vector2(0, 0.55f);
            titleRect.anchorMax = new Vector2(1, 0.85f);
            titleRect.offsetMin = Vector2.zero;
            titleRect.offsetMax = Vector2.zero;

            // Version
            GameObject versionObject = new GameObject("Version");
            versionObject.transform.SetParent(panel.transform, false);

            Text version = versionObject.AddComponent<Text>();
            version.text = "UNR 1";
            version.color = Color.black;
            version.fontSize = 20;
            version.alignment = TextAnchor.MiddleCenter;

            RectTransform versionRect =
                versionObject.GetComponent<RectTransform>();

            versionRect.anchorMin = new Vector2(0, 0.35f);
            versionRect.anchorMax = new Vector2(1, 0.55f);
            versionRect.offsetMin = Vector2.zero;
            versionRect.offsetMax = Vector2.zero;

            panel.SetActive(false);
        }

        public void Toggle()
        {
            if (panel != null)
                panel.SetActive(!panel.activeSelf);
        }
    }
}
