using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    public float initDistance;

    void Start()
    {
        initDistance = player.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = ((- player.position.z + initDistance)/10).ToString("0");
    }
}
