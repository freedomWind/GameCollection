﻿namespace GameCollection
{
    public abstract class ProcedureBase : GameFramework.Procedure.ProcedureBase
    {
        public abstract bool UseNativeDialog
        {
            get;
        }
    }

}