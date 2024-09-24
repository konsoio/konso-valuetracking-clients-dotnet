﻿namespace Konso.Clients.ValueTracking.Extensions
{
    public static class StringExtensions
    {
        public static string RemoveTailSlash(this string str)
        {
            if (str.EndsWith("/"))
            {
                str = str.Remove(str.Length - 1);
            }

            return str;
        }
    }
}
