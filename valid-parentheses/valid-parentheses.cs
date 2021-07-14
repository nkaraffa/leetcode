public class Solution {
    public bool IsValid(string s) {
        //Pre-screen to find values known solutions to values of 's'
            if(s.Length == 0 || s == null)
            {
                return true;
            }
            if(s.Length %2 != 0)        //If the string is odd, then it can't be valid
            {
                return false;
            }

            Stack<char> stack = new Stack<char>();      //Create a stack to store char values

            foreach (char c in s)
            {
                /* If stack contains a value 
                 * & current index is closing bracket 
                 * & the last stack value is a similar open bracket, then remove from stack
                 * 
                 * Else add value into the stack.
                 */
                if (stack.Count > 0 && c == ')' && stack.Peek() == '(')
                {
                    stack.Pop();
                }
                else if (stack.Count > 0 && c == '}' && stack.Peek() == '{')
                {
                    stack.Pop();
                }
                else if (stack.Count > 0 && c == ']' && stack.Peek() == '[')
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(c);
                }
            }

            //Returns true if stack is 0 & all brackets are valid
            return stack.Count == 0; 
    }
}