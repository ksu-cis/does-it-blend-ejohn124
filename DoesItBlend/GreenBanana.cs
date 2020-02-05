using System;
using System.Collections.Generic;
using System.Text;

namespace DoesItBlend
{
    public class GreenBanana : Banana
    {
        /// <summary>
        /// See how we can't use override b/c banana blend is sealed, we must use new to create this method.
        /// </summary>
        /// <returns></returns>
        public new string Blend()
        {
            return "lumps";
        }
    }
}
