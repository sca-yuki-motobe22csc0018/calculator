using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static Unity.Collections.AllocatorManager;

public class CalculationButton : MonoBehaviour
{
    public Button button;
    string myCal;
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(Click);
        myCal = this.tag.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Click()
    {
        CalculatorController.caltext = myCal;
        CalculatorController.set = true;
    }
}
