using System;
using System.Collections.Generic;

namespace TestTask.Core.Extension
{
    public static class ResultMessageErrorExtension
    {
        private const int NumberErrorNotRow = 0;
        private const int MaxErrorLine = 10;
        private const string FirstMessage = "Errors when importing data:";

        public static bool IsNoErrorLine<T>(this List<Result<T>> result, out string message)
        {
            var errorsStr = new List<string>();
            message = string.Empty;

            foreach (var item in result)
            {
                if (!item.Success)
                {
                    if (item.Row == NumberErrorNotRow)
                    {
                        errorsStr.Add(item.Error);
                        continue;
                    }

                    errorsStr.Add(item.ToString());
                }

                if (errorsStr.Count >= MaxErrorLine)
                {
                    break;
                }
            }

            if (errorsStr.Count <= 0)
            {
                return true;
            }

            var errorLine = string.Join(Environment.NewLine, errorsStr);
            message = string.Format("{0}{1}{2}", FirstMessage, Environment.NewLine, errorLine);
            return false;
        }
    }
}
