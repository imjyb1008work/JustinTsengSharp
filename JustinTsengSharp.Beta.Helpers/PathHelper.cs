using System.IO;
using System.Text;

namespace JustinTsengSharp.Beta.Helpers
{
	public class PathHelper
	{
		public static string GetRandomFileNameWithoutExtension()
		{
			return Path.GetFileNameWithoutExtension(Path.GetRandomFileName());
		}

		public static string Combine(params string[] paths)
		{
			StringBuilder sb = new StringBuilder();

			foreach (var path in paths)
			{
				sb.Append(Path.Combine(sb.ToString(), path));
			}

			return sb.ToString();
		}
	}
}
