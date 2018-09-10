using UnityEngine;

namespace Cocacola
{
    public class Loader
    {
        public static GameObject load_object;

        public static void Load()
        {
            load_object = new GameObject();
            load_object.AddComponent<GG>();
            UnityEngine.Object.DontDestroyOnLoad(load_object);
        }
    }
}
