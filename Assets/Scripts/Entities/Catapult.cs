using System.Collections;
using UnityEngine;

[RequireComponent(typeof(SpringSwitcher))]
public class Catapult : MonoBehaviour
{
    [SerializeField] float _reloadDuration = 2.5f;
    [SerializeField] Projectile _projectilePrefab;
    [SerializeField] Transform _spawnPoint;

    private SpringSwitcher _springSwitcher;

    private void Awake()
    {
        _springSwitcher = GetComponent<SpringSwitcher>();
    }

    private void Start()
    {
        GenerateProjectile();
    }

    public void Shoot()
    {
        _springSwitcher.SetSecondValue();
    }

    public void Reload()
    {
        _springSwitcher.SetFirstValue();

        SpawnProjectileWithDelay();
    }

    private void SpawnProjectileWithDelay()
    {
        StartCoroutine(SpawnProjectile());
    }

    private IEnumerator SpawnProjectile()
    {
        yield return new WaitForSeconds(_reloadDuration);

        GenerateProjectile();
    }

    private void GenerateProjectile()
    {
        var projectile = Instantiate(_projectilePrefab);
        projectile.transform.position = _spawnPoint.position;
    }
}