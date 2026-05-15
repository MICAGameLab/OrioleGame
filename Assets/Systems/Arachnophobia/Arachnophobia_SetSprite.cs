using UnityEngine;

public class Arachnophobia_SetSprite : MonoBehaviour
{
    [SerializeField] private SpriteRenderer spriteRenderer;

    [SerializeField] private Sprite disabledSprite;
    [SerializeField] private float disabledSprite_Scale;

    [SerializeField] private Sprite enabledSprite;
    [SerializeField] private float enabledSprite_Scale;

    private void OnEnable()
    {
        if (Arachnophobia_GlobalSetting.IsEnabled == true)
        {
            spriteRenderer.sprite = enabledSprite;
            spriteRenderer.transform.localScale = Vector3.one * enabledSprite_Scale;
        }
        else
        {
            spriteRenderer.sprite = disabledSprite;
            spriteRenderer.transform.localScale = Vector3.one * disabledSprite_Scale;
        }
    }
}
