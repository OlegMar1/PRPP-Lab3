using System;
using System.Collections.Generic;

namespace AnalaizerClass
{
    public class AnalaizerClass
    {
        private string expression = "";
        public string lastError { get; private set; }

        public AnalaizerClass(string expression)
        {
            this.expression = expression;
            lastError = "";
        }

        private void CheckCurrency()
        {
            lengthCheck();  //Перевірка довжини

            for (int i = 0; i < expression.Length; i++)
            {
                wrongSymbCheck(expression[i], i + 1);   //перевіряємо чи коректрий символ
            }

            symbIsLetter(); //чи коректна операція
            bracketsCheck();    //перевірка дужок
        }

        private void lengthCheck()
        {
            if (expression.Length > 65536)
            {
                lastError = "ERROR 07: Too long expression ";
                throw new Exception(lastError);
            }
        }

        private void wrongSymbCheck(char a, int position)
        {
            if (Char.IsDigit(a) ||
                Char.IsWhiteSpace(a) ||
                a == '/' ||
                a == '*' ||
                a == '-' ||
                a == '+' ||
                a == '(' ||
                a == ')' ||
                a == 'm' ||
                a == 'o' ||
                a == 'd' ||
                a == 'p')
            {
                return;
            }
            lastError = "ERROR 02 : at " + position + "  unknown operator";
            throw new Exception(lastError);
        }

        //перевірка чи правильно введений символ
        private void symbIsLetter()
        {
            for (int i = 0; i < expression.Length; i++)
            {
                if ((expression[i] == 'm') &&
                    (i < expression.Length - 2) &&
                    (expression[i + 1] == 'o') &&
                    (expression[i + 2] == 'd'))
                {
                    i += 2;
                    continue;
                }

                if (expression[i] == 'm' ||
                    expression[i] == 'p' ||
                    Char.IsDigit(expression[i]) ||
                    Char.IsWhiteSpace(expression[i]) ||
                    expression[i] == '/' ||
                    expression[i] == '*' ||
                    expression[i] == '-' ||
                    expression[i] == '+' ||
                    expression[i] == '(' ||
                    expression[i] == ')')
                {
                    continue;
                }

                lastError = "Error 02 at " + (i + 1) + " : Unknown operator";
                throw new Exception(lastError);
            }
        }

        //перевірка дужок
        private void bracketsCheck()
        {

            int openedBracketsCount = 0;

            for (int i = 0; i < expression.Length; i++)
            {
                char symb = expression[i];

                if (symb == '(')
                {
                    openedBracketsCount++;
                }
                else if (symb == ')')
                {
                    openedBracketsCount--;
                }

                if (openedBracketsCount < 0)
                {
                    lastError = "ERROE 01 : at " + (i + 1) + "  wrong brackets structure";
                    throw new Exception(lastError);
                }
                else if (openedBracketsCount > 3)
                {
                    lastError = "ERROR 01 : at " + (i + 1) + " : wrong brackets structure";
                    throw new Exception(lastError);
                }
            }

            if (openedBracketsCount != 0)
            {
                lastError = "ERROR 03: Incorrect syntax";
                throw new Exception(lastError);
            }
        }
    }
}
