using System.ComponentModel;

namespace MergeTools
{
    public static class Setting
    {
        public const string TEXT = "Microsoft JhengHei";
        public const string LINE = "\n";

        public enum DateFormat
        {
            [Description("yyyyMM")]
            YearMonth,
            [Description("yyyy-MM-dd HH:mm:ss.fff+08:00")]
            FullDateTime,
            [Description("yyyy-MM-dd 00:00:00.000+08:00")]
            FullDateTimeStart,
            [Description("yyyy-MM-dd 23:59:59.999+08:00")]
            FullDateTimeEnd,
            [Description("yyyy")]
            Year,
            [Description("yyyy-MM-dd HH:mm:ss.fff+08:00")]
            FullDateTimeWithT,
        }

        public static string ReplaceExtra(string data)
        {
            data = data.Replace("”", "\"");
            data = data.Replace("“", "\"");
            data = data.Replace("\t", "");
            data = data.Replace(@"[""[", "[[");
            data = data.Replace(@"]""]", "]]");
            data = data.Replace("\r\n", "");
            data = data.Replace(LINE, "");
            data = data.Replace("\\n", "");
            data = data.Replace("\r", "");
            data = data.Replace("\\r", "");
            data = data.Replace(@"\", "");
            data = data.Replace(@"""{", "{");
            data = data.Replace(@"}""", "}");
            //清掉前後"
            if (data.Length > 0 && data.Substring(0, 1) == "\"")
            {
                data = data.Remove(0, 1);
            }
            if (data.Length > 0 && data.Substring((data.Length - 1), 1) == "\"")
            {
                data = data.Remove((data.Length - 1), 1);
            }
            return data;
        }
    }

    public static class SystemMsg
    {
        public static string serializer(string msg) {
            return string.Concat("解析異常：", msg);
        }
        public static string exception(string msg)
        {
            return string.Concat("系統異常：", msg);
        }
        public static string format(string msg)
        {
            return string.Concat("格式有誤：", msg);
        }
        public static string succeed(string msg)
        {
            return string.Concat(msg, "成功");
        }
        public static string fail(string msg)
        {
            return string.Concat(msg, "失敗");
        }
        public static string fail(string msg, string detail)
        {
            return string.Concat(msg, "失敗", Setting.LINE, detail);
        }
    }
}
