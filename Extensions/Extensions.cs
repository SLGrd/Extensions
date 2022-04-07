namespace Extensions
{
    public static class Extensions
    {
        public static string ToCpf(this string t) => MaskFormat( t, "___.___.___-__");
        public static string ToCnpj(this string t) => MaskFormat( t, "__.___.___/____-__");

        public static string ToDigits(this string s)
        {
            return new(s[..].Where(c => char.IsDigit(c)).ToArray());
        }
        private static string MaskFormat( string t, string Mask)
        {
            int n = 0;
            char[] s = Mask.ToCharArray();     // Char array para evitar new strings in a loop
           
            for (int i = 0; i < s.Length; i++)
                if (Mask[i] == '_')
                    if (n < t.Length) s[i] = (char)t[n++]; else break;
            return new string(s);
        }

        public static string ToCep(this string t) => MaskFormat(t, "__.___-___");
        public static string ToConta(this string t) => MaskFormat(t, "AG ____ Conta _____ DV _");
    }
}