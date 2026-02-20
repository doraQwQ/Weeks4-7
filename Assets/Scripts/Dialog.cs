using TMPro;
using UnityEngine;

public class Dialog : MonoBehaviour
{
    public TMP_Text text;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TextAppear()
    {
        int num = (int)Random.Range(0, 5);//0-4
        if (num == 0)
        {
            text.text = "Eat! eat !eat! if I win this. I don't need to work anymore!";
        }
        else if (num == 1)
        {
            text.text = "Ugh, I am full... No..No, I need to eat more";
        }
        else if (num == 2)
        {
            text.text = "The other contestant seems to be behind me, I mustn't give up";
        }
        else if (num == 3)
        {
            text.text = "I wish my stomach can share with someone else, then I can keep eating!";
        }
        else if (num == 4)
        {
            text.text = "This food is really yummy.";
        }
    }
}
