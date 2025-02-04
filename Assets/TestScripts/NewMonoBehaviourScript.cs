using UnityEngine;

namespace AE3311
{
    public class Spawner : MonoBehaviour
    {
        public class TestObject
        {
            public string name;
            public int value;

            public TestObject(string name, int value)
            {
                this.name = name;
                this.value = value;
            }
        }
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            TestObject testObject = new TestObject("Thingy", 8);
            Debug.Log("Object created: " + testObject.name + " with value " + testObject.value);
        }
    }
}
