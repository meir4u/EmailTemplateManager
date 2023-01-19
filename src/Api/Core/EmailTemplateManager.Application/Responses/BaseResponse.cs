using System;
using System.Collections.Generic;
using System.Text;

namespace EmailTemplateManager.Application.Responses
{
    public class BaseResponse
    {
        public bool Success { get; set; } = true;
        public string Message { get; set; } = string.Empty;
        public List<string> Errors { get; set; } = null;
    }
}
