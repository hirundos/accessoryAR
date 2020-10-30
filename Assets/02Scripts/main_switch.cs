using UnityEngine;

using System.Collections;


public class main_switch : MonoBehaviour
{

    // Use this for initialization

    void Start()
    {

    }

    // Update is called once per frame

    void Update()
    {

		if (Input.GetMouseButtonDown(0))
        {
            Application.LoadLevel("second");
        }
		

        /*클릭시 main 신을 불러오라는 의미 */
    }
}
