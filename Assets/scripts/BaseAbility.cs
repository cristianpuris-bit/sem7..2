using MoreMountains.Feedbacks;
using UnityEngine;

public abstract class BaseAbility : MonoBehaviour
{
    public GameObject projetilePrefab;

    public Transform firePoint;

    public MMFeedbacks castFeedback;

    public abstract void Execute();

    protected virtual void PlayFeedback()
    {
        castFeedback.PlayFeedbacks();
    }

    protected void Shoot(float speed,StatusEffect effect, float duration)
    {
        GameObject projectile = Instantiate(projetilePrefab, firePoint.position, Quaternion.identity);
    }

}
