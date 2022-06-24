using acme.sistemas.compracoletiva.domain.Entity.Notifications;

namespace acme.sistemas.compracoletiva.core.Helpers
{
    [Serializable]
    public class EProcessosMissingParamException : EProcessosException
    {
        public EProcessosMissingParamException(string errorCode, string message, string param) : base(errorCode, message, param) { }
        public EProcessosMissingParamException(string errorCode, string message, string param, IList<Notification> notifications)
            : base(errorCode, message, param, notifications) { }

    }

    [Serializable]
    public class EProcessosUnathorizedException : EProcessosException
    {
        public EProcessosUnathorizedException(string errorCode, string message, string param = null) : base(errorCode, message, param) { }
    }

    [Serializable]
    public class EProcessosForbiddenException : EProcessosException
    {
        public EProcessosForbiddenException(string errorCode, string message, string param = null) : base(errorCode, message, param) { }
    }

    [Serializable]
    public class EProcessosInvalidFormatException : EProcessosException
    {
        public EProcessosInvalidFormatException(string errorCode, string message, string param = null) : base(errorCode, message, param) { }
    }

    [Serializable]
    public class EProcessosNotFoundException : EProcessosException
    {
        public EProcessosNotFoundException(string errorCode, string message, string param = null) : base(errorCode, message, param) { }
    }

    [Serializable]
    public class EProcessosConflictException : EProcessosException
    {
        public EProcessosConflictException(string errorCode, string message, string param = null) : base(errorCode, message, param) { }
    }

    [Serializable]
    public class EProcessosBadRequestException : EProcessosException
    {
        public EProcessosBadRequestException(string errorCode, string message, string param = null) : base(errorCode, message, param) { }
    }

    [Serializable]
    public class EProcessosException : Exception
    {
        public string ErrorCode { get; set; }
        public string Param { get; set; }
        public IList<Notification> Notifications { get; set; }

        public EProcessosException() { }

        public EProcessosException(string message) : base(message) { }

        public EProcessosException(string message, IList<Notification> notifications) : this(message)
        {
            Notifications = notifications;
        }

        public EProcessosException(string errorCode, string message, string param) : this(message)
        {
            ErrorCode = errorCode;
            Param = param;
        }

        public EProcessosException(string errorCode, string message, string param, IList<Notification> notifications)
            : this(errorCode, message, param)
        {
            Notifications = notifications;
        }
    }

    [Serializable]
    public class EProcessosAggreateException : AggregateException
    {
        public string ErrorCode { get; set; }
        public string Param { get; set; }
        public EProcessosAggreateException(string message, IList<Exception> exceptions) : base(message, exceptions)
        {
        }

        public EProcessosAggreateException(string errorCode, string message, string param, IList<Exception> exceptions)
           : base(message, exceptions)
        {
            ErrorCode = errorCode;
            Param = param;
        }
    }
}
