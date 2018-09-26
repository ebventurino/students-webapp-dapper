using System;

namespace Workforce.Models
{
    public class CannotDeleteModelController
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}