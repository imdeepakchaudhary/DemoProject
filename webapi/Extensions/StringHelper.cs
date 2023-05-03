using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public static class StringHelper
{
    public static string ToTitleCase(this string str)
    {
        var tokens = str.Split(new[] { " ", "-" }, StringSplitOptions.RemoveEmptyEntries);
        for (var i = 0; i < tokens.Length; i++)
        {
            var token = tokens[i];
            tokens[i] = token == token.ToUpper()
                ? token
                : token.Substring(0, 1).ToUpper() + token.Substring(1).ToLower();
        }

        return string.Join(" ", tokens);
    }

    public static Int64 ToDecode(this string str)
    {

        if (string.IsNullOrWhiteSpace(str))
            return 0;
        try
        {
            return Convert.ToInt64(webapi.Data.General.Decode(str));
        }
        catch
        {
            return 0;
        }


    }

    public static string ToEncode(this decimal? str)
    {

        if (str == null)
            return "";
        try
        {
            return webapi.Data.General.Encode(str.ToString());
        }
        catch
        {
            return "";
        }


    }
    public static string ToEncode(this int? str)
    {

        if (str == null)
            return "";
        try
        {
            return webapi.Data.General.Encode(str.ToString());
        }
        catch
        {
            return "";
        }


    }
    public static string ToEncode(this long? str)
    {

        if (str == null)
            return "";
        try
        {
            return webapi.Data.General.Encode(str.ToString());
        }
        catch
        {
            return "";
        }


    }
    public static string ToEncode(this string str)
    {

        if (str == null)
            return "";
        try
        {
            return webapi.Data.General.Encode(str.ToString());
        }
        catch
        {
            return "";
        }


    }

    public static string FormatPrice(this decimal? str)
    {
        if (str == null)
            return "0.00";
        try
        {
            return String.Format("{0:0.00}", Math.Round(str.Value, 2, MidpointRounding.AwayFromZero));
        }
        catch
        {
            return "0.00";
        }
    }

    public static DateTime? ToIST(this DateTime? utcdate)
    {
        if (utcdate == null)
            return null;
        try
        {
            return TimeZoneInfo.ConvertTimeFromUtc(utcdate.Value, TimeZoneInfo.FindSystemTimeZoneById("India Standard Time")); 
        }
        catch
        {
            return null;
        }
    }
}
