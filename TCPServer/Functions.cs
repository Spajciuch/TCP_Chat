using System;
using System.Linq;
public static class Functions
{
	public static bool IsEmptyOrAllSpaces(this string str)
	{
		return null != str && str.All(c => c.Equals(' '));
	}
}