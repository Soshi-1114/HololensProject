using UnityEngine;
using UnityEngine.AI;
using TMPro;


// [RequireComponent(typeof(NavMeshAgent))]
public class CountAgent : MonoBehaviour
{
    GameObject[] tagObjects;
    public TextMeshProUGUI _debug;

    float timer = 0.0f;
    float interval = 2.0f;

    // Use this for initialization
    void Start () {

    }

    // CollisionDetector.csのonTriggerStayにセットし、衝突中に実行される。
    public void OnDetectObject(Collider collider)
    {
        // Debug.Log("OnDetectObject");
        // 検知したオブジェクトに「Player」のタグがついていれば、そのオブジェクトを追いかける
        if (collider.CompareTag("Player"))
        {
            Check("Player");
        }
    }

    
    void Check(string tagname){
        int tagObjects_Length = 0;
        tagObjects_Length = GameObject.FindGameObjectsWithTag(tagname).Length;
        Debug.Log(tagObjects_Length); //tagObjects.Lengthはオブジェクトの数
        _debug.text = "Goal:"+tagObjects_Length+"\n";
        if(tagObjects_Length == 0){
            Debug.Log(tagname + "タグがついたオブジェクトはありません");
        }
    }
}