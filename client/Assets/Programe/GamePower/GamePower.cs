using UnityEngine;

namespace RobotRevenger
{
    public class GamePower : MonoBehaviour
    {
        // Use this for initialization
        public void Start()
        {
            ActorManager.Instance.Init();
        }

        // Update is called once per frame
        public void Update()
        {
            ActorManager.Instance.Tick(Time.deltaTime);
        }
        
    }
}

