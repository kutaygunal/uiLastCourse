using UnityEngine;
using UnityEngine.UI;
using System.Collections;
[ExecuteInEditMode]
public class CoinCounter : MonoBehaviour
{
    public int coinCount = 0;
    void Update()
    {
        //Set the coin count text
        GetComponent<Text>().text =
        coinCount.ToString();
    }
}