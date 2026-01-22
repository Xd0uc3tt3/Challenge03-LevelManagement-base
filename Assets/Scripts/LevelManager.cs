using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GameObject level01;
    public GameObject level02;
    public GameObject level03;
    public GameObject level04;

    private GameObject player;

    private GameObject currentActiveLevel;

    private void Awake()
    {
        player = ServiceHub.Instance.playerController.gameObject;
        currentActiveLevel = level01;
    }

    public void LevelChange(Transform spawnLocation, GameObject LevelToActivate)
    {
        currentActiveLevel.SetActive(false);
        LevelToActivate.SetActive(true);
        currentActiveLevel = LevelToActivate;

        player.transform.position = spawnLocation.position;

    }
}
