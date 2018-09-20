using GameFramework;
using UnityGameFramework.Runtime;
using UnityEngine;

namespace Luna3DX
{
    /// <summary>
    /// 实体逻辑基类。
    /// </summary>
    public class BallLogic : EntityLogic
    {

        protected override void OnInit(object userData)
        {

        } 

        protected override void OnUpdate(float elapseSeconds, float realElapseSeconds)
        {
            var x=Mathf.PingPong(Time.time,3);
            GetComponent<Transform>().SetLocalPositionX(x);
        } 

    }
}
