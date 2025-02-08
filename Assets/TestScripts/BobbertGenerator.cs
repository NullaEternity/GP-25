using UnityEngine;

namespace AE3311
{
    public class ClassObjectRelationship : MonoBehaviour
    {
        public class TestObject
        {
            public string name = "Bobbert";

        }
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            TestObject obj = new TestObject();
            Debug.Log(obj.name + "LIVES! HE HAS BEEN CREATED");
        }
    } 
}
