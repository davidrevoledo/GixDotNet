using System;
using System.Collections.Generic;

namespace GixDotnet.Infrastructure.Services
{
    public class BaseUrlParams : Dictionary<string, string>
    {
        private BaseUrlParams()
        {
        }

        public static BaseUrlParams Create()
        {
            return new BaseUrlParams();
        }

        public BaseUrlParams AddIf(bool condition, string key, string value)
        {
            if (condition) Add(key, value);

            return this;
        }

        public BaseUrlParams AddIf(Func<bool> conditionAction, string key, string value)
        {
            return AddIf(conditionAction.Invoke(), key, value);
        }

        public BaseUrlParams AddIfHasValue(string key, int? number)
        {
            AddIf(number.HasValue, key, number.ToString());
            return this;
        }

        public BaseUrlParams AddIfNotNullOrEmpty(string key, string text)
        {
            AddIf(!string.IsNullOrWhiteSpace(text), key, text);
            return this;
        }

        public BaseUrlParams AddIfHasValue(string key, DateTime? date)
        {
            AddIf(date.HasValue, key, date?.ToString("yyyyMMdd"));
            return this;
        }
    }
}