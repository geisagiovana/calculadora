using System;
using System.Runtime.Serialization;

namespace ProgramOp
{
    [Serializable]
    public class OperacaoException : Exception
    {
        public OperacaoException()
        {
        }

        public OperacaoException(string message) : base("Sinal Inválido.")
        {
           
        }

        public OperacaoException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected OperacaoException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}