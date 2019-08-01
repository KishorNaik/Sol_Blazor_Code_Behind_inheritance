using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol_Code_Behind.Base
{
    public class CodeBehindDemoBase : ComponentBase
    {
        #region Property
        public String Message { get; set; } = "Hello Blazor";
        #endregion

        #region Protected Method
        protected void FromCodeBeind()
        {
            Message = "Hello from Code Behind";
        }
        #endregion 
    }
}
