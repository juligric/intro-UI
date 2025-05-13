using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SUMAYRESULTADO : MonoBehaviour
{
    public TMP_InputField inputNum1;
    public TMP_InputField inputNum2;
    public TextMeshProUGUI resultadoxt;

    int num1;
    int num2;
    // Start is called before the first frame update
    void Start()
    {
        resultadoxt.text = "";
    }

    public void SumaryMostrar()
    {
        num1 = int.Parse( inputNum1.text);
        num2 = int.Parse( inputNum2.text);
        resultadoxt.text = (num1 + num2) .ToString();
    }
}
