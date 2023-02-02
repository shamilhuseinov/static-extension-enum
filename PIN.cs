using System;

namespace test
{
	public static class Extention
	{
        public static bool ChechkPIN(this string PIN)
        {
            if (PIN.Length == 7 && PIN == PIN.ToUpper())
            {
                return true;
            }
            throw new Exception();
        }
    }
}

