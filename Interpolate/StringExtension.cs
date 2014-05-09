using System;

namespace Interpolate
{
    public static class StringExtension
    {
        public static string Interpolate(this string value, object args, Formatter formatter = Formatter.Henri)
        {
            switch (formatter) {
                case Formatter.Haack:
                    return HaackFormatter.HaackFormat(value, args);
                case Formatter.Hanselman:
                    return HanselmanFormatter.HanselFormat(args, value);
                case Formatter.Henri:
                    return HenriFormatter.HenriFormat(value, args);
                case Formatter.James:
                    return JamesFormatter.JamesFormat(value, args);
                case Formatter.Oskar:
                    return OskarFormatter.OskarFormat(value, args);
                default:
                    var message = String.Format("Unknown value {0}", formatter);
                    throw new ArgumentOutOfRangeException("formatter", formatter, message);
            }
        }
    }

    public enum Formatter
    {
        Haack,
        Hanselman,
        Henri,
        James,
        Oskar,
    }
}

