using UnityEngine;
using UnityEngine.UI;

namespace Pexty
{
    public class ProgressBarController : MonoBehaviour
    {
        [Space, Header("Data")]
        [SerializeField] private StaminaController staminaController;
        [SerializeField] private Slider slider;
        [SerializeField] private RectTransform rectTransform;

        // Start is called before the first frame update
        void Start()
        {
            slider.maxValue = staminaController.maxValue;
        }

        // Update is called once per frame
        void Update()
        {
            slider.maxValue = staminaController.maxValue;
            slider.value = staminaController.value;

            // Show stamina progress by center
            float percent = slider.value / slider.maxValue;

            rectTransform.anchorMin = new Vector2(1f - (0.5f * percent + 0.5f), rectTransform.anchorMin.y);
            rectTransform.anchorMax = new Vector2(0.5f + 0.5f * percent, rectTransform.anchorMax.y);
        }
    }
}
