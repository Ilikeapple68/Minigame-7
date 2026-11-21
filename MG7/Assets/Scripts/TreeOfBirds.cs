using UnityEngine;

// Step 1: write the TreeOfBirds class in this file!

public class TreeOfBirds : MonoBehaviour
{
    [SerializeField] private GameObject[] sparrows;

    [SerializeField] private GameObject player;

    [SerializeField] private float interactionDistance = 1.0f;

    private void Update()
    {
        foreach(GameObject sparrow in sparrows)
        {
            float distance = Vector3.Distance(player.transform.position, sparrow.transform.position);
            if (distance <= interactionDistance)
            {
                sparrow.SetActive(true);
            }
        }
    }
}
