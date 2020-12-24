using UnityEngine;
using UnityEngine.UI;
using System.Collections;
[ExecuteInEditMode]
public class LivesCounter : MonoBehaviour
{
    public int initialLives = 3;
    public int extraLives = 1;
    public int totalLives;
    void Start()
    {
        GetLives();
    }
    void Update()
    {
        totalLives = initialLives + extraLives;
        GetComponent<Text>().text = totalLives.ToString();
    }
    void GetLives()
    {
        totalLives = initialLives + extraLives;
    }
}
