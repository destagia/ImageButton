using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace Test
{
    public class Tester : MonoBehaviour
    {
        [SerializeField] Button button;

        void Start()
        {
            button.onClick.AddListener(() => Debug.Log("button!"));
        }
    }
}