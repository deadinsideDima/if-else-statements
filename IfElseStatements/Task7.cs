namespace IfStatements
{
    public static class Task7
    {
        public static int DoSomething(bool b, int i)
        {
            if (b)
            {
                if (i < -5 || i >= 5)
                {
                    return i + 10;
                }
                else
                {
                    return 10 - (i * i);
                }
            }
            else
            {
                if (i <= -7 || i > 4)
                {
                    return i - 100;
                }
                else
                {
                    return 10 - i;
                }
            }
        }
    }
}
