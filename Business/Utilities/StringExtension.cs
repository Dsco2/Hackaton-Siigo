using System.Globalization;
using System.Text;

namespace Business.Utilities
{
    public static class StringExtension
    {
        public static string InsensitiveConvert(this string query)
        {
            query = query?.ToLower() ?? string.Empty;
            return query.TildesReplace().Replace(' ', '-').Trim().Replace('/', '-').ToLower();
        }

        public static string TildesReplace(this string queryWithTildes)
        {
            var normalizedString = queryWithTildes.Normalize(NormalizationForm.FormD);
            var stringBuilder = new StringBuilder();

            foreach (var c in normalizedString)
            {
                var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }

            return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
        }
    }
}
