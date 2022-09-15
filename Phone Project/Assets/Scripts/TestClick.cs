using UnityEngine;
using TMPro;

public class TestClick : MonoBehaviour
{
    TMP_Text text;
    int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = count.ToString();
    }

    public void Increment()
    {
        count++;
    }
}
