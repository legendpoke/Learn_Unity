using UnityEngine;

public class ScoreMethod : MonoBehaviour
{
    int count = 0;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Hit")
        {
            count++;
            Debug.Log("Player have bumped into a thing this many times:" + count);
        }
    }
}
