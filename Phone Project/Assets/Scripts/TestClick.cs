using UnityEngine;
using TMPro;

public class TestClick : MonoBehaviour
{
    TMP_Text text;
    int count = 0;
    int upgradeCount = 0;
    int cost = 100;

    private void Start()
    {
        text = GetComponent<TMP_Text>();
    }

    private void Update()
    {
        text.text = count.ToString();
    }

    private void CheckUpgrade()
    {
        if (count >= cost)
        {
            upgradeCount++;

        }
    }

    private void Upgrade()
    {

    }


    public void Increment()
    {
        count *= upgradeCount;
    }
}
