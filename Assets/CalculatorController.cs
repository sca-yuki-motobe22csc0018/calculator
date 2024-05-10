using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CalculatorController : MonoBehaviour
{
    public static string numtext;
    public static string caltext;
    public Text num;
    public static bool on;
    public static bool set;
    int Count;
    // Start is called before the first frame update
    void Start()
    {
        on = false;
        set = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (on)
        {
            if (num.text == "0")
            {
                num.text = numtext;
                on = false;
            }
            else
            {
                num.text = num.text + numtext;
                on = false;
            }

            if (set)
            {
                Count = int.Parse(num.text);
                num.text = "0";
            }
        }
    }
}
