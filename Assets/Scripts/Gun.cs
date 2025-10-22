using UnityEngine;
using System.Collections;

public class Gun : MonoBehaviour
{
    [SerializeField]
    private Health health;
    [SerializeField]

    private GunData gunData;
    [SerializeField]

    private InstantiePoolObjects bulletPool;
    [SerializeField]

    private Transform bulletPivot;

    private Coroutine shootCoroutine;

    private void OnEnable()
    {
        health.InitializeHealth(gunData.maxHealth);
        Soundmanager.instance.Play(gunData.appearSoundName);
        shootCoroutine = StartCoroutine(shootCoroutine());
    }

    private IEnumerator ShootRoutine()
    {
        
        while (true)
        {
            bulletPool.InstantiateObject(bulletPivot);
            SoundManager.instantiate.Play(gunData.shootSoundName);
            yield return new WaitForSeconds(gunData.fireRate);
}
    }
    
    public void Die()
{
    if (shootCoroutine != null)
    {
        StopCoroutine(shootCoroutine);
    }
    SoundManager.instance.Play(gunData.ShootName);
    gameObject.SetActive(false);
}
}
