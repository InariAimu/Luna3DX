using GameFramework;
using GameFramework.Procedure;
using UnityGameFramework.Runtime;
using ProcedureOwner = GameFramework.Fsm.IFsm<GameFramework.Procedure.IProcedureManager>;

namespace Luna3DX
{
    public class ProcedureExample : ProcedureBase
    {
        protected override void OnEnter(ProcedureOwner procedureOwner)
        {
            base.OnEnter(procedureOwner);

            string welcomeMessage = string.Format("Hello! This is an empty project based on Game Framework {0}.", Version.GameFrameworkVersion);
            Log.Info(welcomeMessage);
            Log.Warning(welcomeMessage);
            Log.Error(welcomeMessage);

            var ec = UnityGameFramework.Runtime.GameEntry.GetComponent<EntityComponent>();
            ec.ShowEntity<Luna3DX.BallLogic>(1,"Assets/Prefabs/Sphere.prefab","xlb");
            ec.ShowEntity<Luna3DX.BallLogic>(2,"Assets/Prefabs/Sphere.prefab","xlb");
            
        }
    }
}
