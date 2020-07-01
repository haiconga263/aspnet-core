using System;
using System.Collections.Generic;
using System.Text;

namespace DEM.Project.Common
{
    public class APIResult
    {
        public object Data { get; set; }
        public UserHttpCode Result { get; set; }
        public string Code { get; set; }
        public string Message { get; set; }

        public APIResult()
        {
            Code = string.Empty;
            Message = string.Empty;
        }

        public static UserHttpCode GetResultCode(int code)
        {
            switch (code)
            {
                case -2:
                    return UserHttpCode.Error;
                case -1:
                    return UserHttpCode.ErrorWithLang;
                case 0:
                    return UserHttpCode.Success;
                case 1:
                default:
                    return UserHttpCode.Warning;
            }
        }
    }
}
