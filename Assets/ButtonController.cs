using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    public Button button;
    string myNumber;
    int num;
    
    // Start is called before the first frame update
    void Start()
    {
        button= GetComponent<Button>();
        button.onClick.AddListener(Click);
        myNumber = this.tag.ToString();
        num=int.Parse(myNumber);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Click()
    {
        CalculatorController.numtext=myNumber;
        CalculatorController.on = true;
    }
}
