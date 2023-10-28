using System.Collections.Generic;

namespace TestTask.Core.Extension
{
    public static class ResultMessageErrorExtension
    {
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

            var errorLine = string.Join("\n", errorsStr);
            message = string.Format("{0}\n{1}", FirstMessage, errorLine);
            return false;
        }
    }
}
