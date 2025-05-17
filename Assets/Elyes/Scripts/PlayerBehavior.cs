using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    public static int enemyCount=0;

    void OnTriggerEnter(Collider other)
    {
        // print("Collision detected with: " + other.gameObject.name);
        if (other.gameObject.CompareTag("Enemy"))
        {
            Animator animator = other.gameObject.GetComponent<Animator>();
            animator.SetBool("dead", true);
            enemyCount++;
            if (enemyCount ==5)
            {
                print("All enemies are dead");
                // Perform any additional actions here
                Destroy(other.gameObject);
            }
        }
    }
}
