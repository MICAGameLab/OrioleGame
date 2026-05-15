using UnityEngine;
using UnityEngine.UI;

public class Arachnophobia_OptionsToggle : MonoBehaviour
{
    [SerializeField] private Toggle arachnophobiaToggle;

    private void OnEnable()
    {
        arachnophobiaToggle.isOn = Arachnophobia_GlobalSetting.IsEnabled;
    }

    public void ToggleEnabled(bool isEnabled)
    {
        Arachnophobia_GlobalSetting.SetIsEnabled(isEnabled);
    }
}
