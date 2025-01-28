using UnityEngine;

public class Block : MonoBehaviour
{
    [SerializeField]
    public int health;
    public int score;
    // Update is called once per frame
    void Update()
    {
        if (health == 0)
        {
            Destroy(this);
        }
    }

    public void DealDamage(int damage)
    {
        health = Mathf.Max(health - damage, 0);
    }

    public void setHealth(int health)
    {
        this.health = health;
    }
    public int getHealth()
    {
        return health;
    }
    public void setScore(int score)
    {
        this.score = score;
    }
    public int getScore()
    {
        return score;
    }
}
