
using System;
using System.Collections.Generic;

namespace coreSamples.Basics
{
    public class SimpleExceptionHandler
    {
        public static string GetAllInnerExceptionsString(Exception e)
        {
            if (e.InnerException != null)
                return
                    $"{e.GetType()}: {e.Message} {Environment.NewLine} --> {GetAllInnerExceptionsString(e.InnerException)}"; // recursive call
            else
                return $"{e.GetType()}: {e.Message} {Environment.NewLine}";
        }

        public static string PrintAllExceptions(Exception e)
        {
            if (e is null)
                return "";

            string text = $"Explenation:";
            var allExceptions = GetListOfAllExceptions(e);

            foreach (var exception in allExceptions)
            {
                System.Console.WriteLine(exception);
            }

            return text;
        }

        /// <summary>
        /// Puts the main exception and all inner exception in a flat list
        /// </summary>
        /// <param name="e">Exception to flatten to list</param>
        /// <returns></returns>
        private static List<Exception> GetListOfAllExceptions(Exception e)
        {
            if (e.InnerException != null)
            {
                var list = new List<Exception>{e};
                    list.AddRange(GetListOfAllExceptions(e.InnerException));; // recursive call
                return list;
            }
            else
            {
                return new List<Exception>{e};

            }


        }
        
    }
}