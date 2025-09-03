using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText1;
    public TextMeshProUGUI scoreText2;
    public GameObject portalPrefab;
    public Transform portalSpawnPoint;
    private int score = 0;
    private bool portalSpawned = false;

    public void AddPoints(int points)
    {
        score += points;
        scoreText1.text = "" + score;
        scoreText2.text = "" + score;

        if (score >= 50 && !portalSpawned)
        {
            SpawnPortal();
        }
    }

    void SpawnPortal()
    {
        Instantiate(portalPrefab, portalSpawnPoint.position, Quaternion.identity);
        portalSpawned = true;
    }
}