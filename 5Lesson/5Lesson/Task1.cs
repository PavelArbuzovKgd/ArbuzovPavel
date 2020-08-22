using System.Collections.Generic;

namespace _5Lesson
{
    class Task1
    {

        public bool CheckStr(string str)
        {
            string exp = "[{(]})";
            Stack<char> myStack = new Stack<char>();

            foreach (var chr in str)
            {
                int f = exp.IndexOf(chr);

                if (f >= 0 && f <= 2)
                    myStack.Push(chr);

                if (f > 2)
                {
                    if (myStack.Count == 0 || myStack.Pop() != exp[f - 3])
                        return false;
                }
            }

            if (myStack.Count != 0)
                return false;

            return true;
        }        
    }
}
