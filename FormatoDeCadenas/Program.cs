using System;

namespace FormatoDeCadenas
{
    class Program
    {
        static void Main(string[] args)
        {
            // string message = "Find what is (inside the parentheses)";

            // int openingPosition = message.IndexOf('(');
            // int closingPosition = message.IndexOf(')');

            // Console.WriteLine(openingPosition);
            // Console.WriteLine(closingPosition);

            // openingPosition += 1;

            // int length = closingPosition - openingPosition;
            // Console.WriteLine(message.Substring(openingPosition, length));

            // string message = "What is the value <span>between the tags</span>?";

            // int openingPosition = message.IndexOf("<span>");
            // int closingPosition = message.IndexOf("</span>");

            // openingPosition += 6;
            // int length = closingPosition - openingPosition;
            // Console.WriteLine(message.Substring(openingPosition, length));

            // string message = "What is the value <span>between the tags</span>";

            // const string openSpan = "<span>";
            // const string closeSpan = "</span>";

            // int openingPosition = message.IndexOf(openSpan);
            // int closingPosition = message.IndexOf(closeSpan);

            // openingPosition += openSpan.Length;
            // int length = closingPosition - openingPosition;
            // Console.WriteLine(message.Substring(openingPosition, length));

            // string message = "(What if) I am (only interested) in the last (set of parentheses)?";
            // int openingPosition = message.LastIndexOf('(');

            // openingPosition += 1;
            // int closingPosition = message.LastIndexOf(')');
            // int length = closingPosition - openingPosition;
            // Console.WriteLine(message.Substring(openingPosition, length));

            string message = "(What if) I am (only interested) in the last (set of parentheses)?";

            while (true)
            {
                int openingPosition = message.IndexOf('(');
                if (openingPosition == -1) break;

                openingPosition += 1;
                int closingPosition = message.IndexOf(')');
                int length = closingPosition - openingPosition;
                Console.WriteLine(message.Substring(openingPosition, length));

                // Note how we use the overload of Substring to return only the remaining 
                // unprocessed message:
                message = message.Substring(closingPosition + 1);
            }


            //Ejercicio con IndexOfAny()
            //string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

            //// The IndexOfAny() helper method requires a char array of characters 
            //// we want to look for:

            //char[] openSymbols = { '[', '{', '(' };

            //// We'll use a slightly different technique for iterating through the 
            //// characters in the string.  This time, we'll use the closing position
            //// of the previous iteration as the starting index for the next open
            //// symbol.  So, we need to initialize the closingPosition variable
            //// to zero:

            //int closingPosition = 0;

            //while (true)
            //{
            //    int openingPosition = message.IndexOfAny(openSymbols, closingPosition);

            //    if (openingPosition == -1) break;

            //    string currentSymbol = message.Substring(openingPosition, 1);

            //    // Now we must find the matching closing symbol
            //    char matchingSymbol = ' ';

            //    switch (currentSymbol)
            //    {
            //        case "[":
            //            matchingSymbol = ']';
            //            break;
            //        case "{":
            //            matchingSymbol = '}';
            //            break;
            //        case "(":
            //            matchingSymbol = ')';
            //            break;
            //    }

            //    // Finally, use the techniques we've already learned to display the sub-string:
            //    openingPosition += 1;
            //    closingPosition = message.IndexOf(matchingSymbol, openingPosition);

            //    int length = closingPosition - openingPosition;
            //    Console.WriteLine(message.Substring(openingPosition, length))
            //}


            //Metodos remove y replace
            // string data = "12345John Smith          5000  3  ";
            // string updatedData = data.Remove(5, 20);
            // Console.WriteLine(updatedData);

            //string message = "This--is--ex-amp-le--da-ta";
            //message = message.Replace("--", " ");
            //message = message.Replace("-", "");
            //Console.WriteLine(message);
        }
    }
}
