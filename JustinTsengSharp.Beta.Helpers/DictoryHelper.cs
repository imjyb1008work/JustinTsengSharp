using System.IO;

namespace JustinTsengSharp.Beta.Helpers
{
	public class DictoryHelper
	{
		public void IfNotExistsCreateDirectory(string path)
		{
			if (!Directory.Exists(path))
			{
				Directory.CreateDirectory(path);
			}
		}
	}
}
