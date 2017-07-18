namespace Acme.Common
{
    /// <summary>
    /// Provides a success flag and message 
    /// useful as a method return type.
    /// </summary>
    public class OperationResult<TResult>
    {
        public OperationResult()
        {
        }

        public OperationResult(TResult result, string message) : this()
        {
            this.Result = result;
            this.Message = message;
        }

        public TResult Result { get; set; }
        public string Message { get; set; }
    }
} 

