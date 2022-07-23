using UnityEngine;

public class Scorer : MonoBehaviour
{
    private int numberOfHits = 0;
    private void Start()
    {
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Wall" || other.gameObject.tag == "Obstacle")
        {
            numberOfHits++;
            Debug.Log($"You hit walls {numberOfHits} times");
        }
    }
}
