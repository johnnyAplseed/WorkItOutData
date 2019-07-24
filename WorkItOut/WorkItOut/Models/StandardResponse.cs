using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorkItOut.Models
{
    public class StandardResponse
    {
        public StandardResponse()
        {
            IsError = false;
            Message = "Success";
            Details = "";
            InnerException = "";
        }

        public StandardResponse(Exception ex)
        {
            IsError = true;
            Message = ex.Message;
            Details = ex.StackTrace;
            InnerException = ex.InnerException == null ? "" : ex.InnerException.Message;
        }

        public string Message { get; set; }
        public string Details { get; set; }
        public string InnerException { get; set; }

        public bool IsError { get; set; }
    }
}