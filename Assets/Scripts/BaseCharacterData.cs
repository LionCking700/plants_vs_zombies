using UnityEngine;

public class BaseCharacterData : MonoBehaviour
{
    [Header("Common Settings")]
    public float maxHealth;
    public ActionAssets[] actionAssets;

    public string GetAnimationName(ActionKey actionKey)
    {
        foreach (var actionAsset in actionAssets)
        {
            if (actionAsset.actionKey == actionKey)
            {
                return actionAsset.AnimationName;
            }
        }
        return string.Empty;
    }

    public string GetAnimationName(ActionKey actionKey)
    {
        foreach (var actionAsset in actionAssets)
        {
            if (actionAssets.actionKey == actionKey)
            {
                returnactionAsset.soundName;
            }
        }
        return string.Empty;
    }

}
