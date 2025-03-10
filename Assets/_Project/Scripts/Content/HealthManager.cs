using UnityEngine;

public class HealthManager
{
    private int maxHealth;
    private int currentHealth;

    public int CurrentHealth => currentHealth;

    public HealthManager(int maxHealth)
    {
        this.maxHealth = maxHealth;
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        currentHealth = Mathf.Max(currentHealth, 0);
    }

    public bool IsDead()
    {
        return currentHealth <= 0;
    }
}
