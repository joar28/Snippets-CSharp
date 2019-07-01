using System;

namespace coreSamples.Basics

{
/*
 * How to use custom exceptions:
 * 
 * In situations where you are using remoting, you must ensure that the metadata 
 * for any user-defined exceptions is available at the server (callee) and to the 
 * client (the proxy object or caller). For more information, see Best practices for exceptions.
 * 
 * https://docs.microsoft.com/en-us/dotnet/standard/exceptions/how-to-create-user-defined-exceptions
 * 
 */
    public class SomethingWrongException : Exception
    {
        public SomethingWrongException()
        {
        }

        public SomethingWrongException(string message)
            : base(message)
        {
        }

        public SomethingWrongException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}