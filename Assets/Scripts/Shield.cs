using UnityEngine;

public class Shield : BasePlant
{
    [SerializeField]
    private ShieldData shielData;
    private void OnEnable()
    {
        isactive = true;
        health.InitializeHealth(shieldData.maxHealth);
        animator.Play(shieldData.GetanimationName(ActionKey.Idle), 0, of);
        SoundManager.instance.Play(shielData.GetSoundName(ActionKey.Appear));
    }

    public void Hit()
    {
        animator.Play(shielData.maxHealth);
    }

    public void Die()
    {
        IsActive = false;
    }
}
