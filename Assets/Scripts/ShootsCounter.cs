using UnityEngine;
using TMPro;

public class ShootsCounter : MonoBehaviour
{
    public TextMeshProUGUI Text;
    public TextMeshProUGUI Text1;

    public static int Shots;
    public static int Hits;

    private void Start()
    {
        Shots = 0;
        Hits = 0;
    }
    public void Reset()
    {
        Shots = 0;
        Hits = 0;
    }
    public void Update()
    {
        Text.text = Shots.ToString();
        Text1.text = Hits.ToString() + "    /   ";         
    }
}
