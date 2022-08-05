using System;

public class Functions
{
	public static bool IsEmptyOrAllSpaces(this string str)
	{
		return null != str && str.All(c => c.Equals(' '));
	}
}
