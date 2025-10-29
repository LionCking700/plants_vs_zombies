using UnityEngine;
using System.Collections;

public class Gun : MonoBehaviour
{
    [SerializeField]
    private Health health;
    [SerializeField]

    private GunData gunData;
    [SerializeField]

    private InstantiatePoolObjects bulletPool;
    [SerializeField]

    private Transform bulletPivot;
    [SerializeField]

    private LayerMask enemiesLayer;
    [SerializeField]

    private float raycastOffset = 2f;
    [SerializeField]

    private Animator animator;

    private bool _isActive = false;

    private bool isShooting = false;

    private Health enemyHealth;

    private Coroutine shootCoroutine;

    public bool isActive
    {
        set { _isActive = value;  }
    }

    private void OnEnable()
    {
        enemyHealth = null;
        isShooting = false;
        health.InitializeHealth(gunData.maxHealth);
        animator.Play(gunData.idleanimationName, 0, 0f);
        //SoundManager.instance.Play(gunData.appearSoundName);
    }

    private void Update()
    {
        if (!isActive && !isShooting && health.CurrentHealth> 0)
        {
            Vector3 right = tranform.TransformDirection(Vector3.right);
            if (Physics.Raycast(transform.position + Vector3.up * right, out RaycastHit hit, gunData.range,enemiesLayer))
            {
                isShooting = true;
                currentEnemy = hit.collider.GetComponent<Health>();
                shootCoroutine = StartCoroutine(ShootRoutine());
            }
            Debug.DrawRay(tranform.position, right * gunData.range, Color.blue);
        }
    }

    private IEnumerator ShootRoutine()
    {

        while (enemyHealth && enemyHealth.CurrentHelath > 0)
        {
            yield return new WaitForSeconds(gunData.fireRate);
            bulletPool.InstantiateObject(bulletPivot);
            SoundManager.instance.Play(gunData.shootSoundName);

        }
        isShooting = false;
        enemyHealth = null;
    }
    
    public void Die()
{
        if (shootCoroutine != null)
        {
            StopCoroutine(shootCoroutine);
        }
        animator.Play(gunData.dieAnimationName, 0, 0f);
        isShooting = false;
        enemyHealth = null;
        SoundManager.instance.Play(gunData.dieShootName);
        StartCoroutine(DieRoutine());
}
}
}
