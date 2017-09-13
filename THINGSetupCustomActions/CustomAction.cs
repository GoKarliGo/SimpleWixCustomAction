using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Deployment.WindowsInstaller;

namespace THINGSetupCustomActions
{
    public class CustomActions
    {
        [CustomAction]
        public static ActionResult SelectClientServer(Session session)
        {
            session.Log("Begin SelectClientServer");
            session["THING_INSTALL_TYPE"] = "Client";

            return ActionResult.Success;
        }
    }
}
