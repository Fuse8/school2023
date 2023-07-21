using System.Text;

namespace Fuse8_ByteMinds.SummerSchool.Domain;

public static class DomainExtensions
{

    public static bool IsNullOrEmpty<T>(IEnumerable<T> collection)
    {
        return collection == null || !collection.GetEnumerator().MoveNext();
    }
    public static string JoinToString<T>(this IEnumerable<T> source, string separator)
    {
        if (source == null)
            throw new ArgumentNullException(nameof(source));

        if (separator == null)
            separator = string.Empty;

        var sb = new StringBuilder();
        bool firstItem = true;

        foreach (var item in source)
        {
            if (!firstItem)
                sb.Append(separator);

            sb.Append(item);
            firstItem = false;
        }

        return sb.ToString();

    }
        public static int DaysCountBetween(this DateTimeOffset start, DateTimeOffset end)
        {
            TimeSpan duration = end - start;
            return duration.Days;
        }
    
}











