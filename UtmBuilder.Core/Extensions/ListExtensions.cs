namespace UtmBuilder.Core.Extensions;

public static class ListExtensions
{
     public static void AddIfNotNull(this List<string> list, string key, string? value)
     {
          if (!String.IsNullOrEmpty(value))
               list.Add($"{key}={value}");
     }
}