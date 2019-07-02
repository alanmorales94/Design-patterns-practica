using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    class CalculatorCommand : Command

    {
        private char _operator;
        private int _operand;
        private Calculator _calculator;

        // Constructor

        public CalculatorCommand(Calculator calculator,
          char @operator, int operand)
        {
            this._calculator = calculator;
            this._operator = @operator;
            this._operand = operand;
        }

        // Obtiene operador

        public char Operator
        {
            set { _operator = value; }
        }

        // Tiene operador

        public int Operand
        {
            set { _operand = value; }
        }

        // Ejecuta un nuevo comando

        public override void Execute()
        {
            _calculator.Operation(_operator, _operand);
        }

        // Deja de ejecutar ulitmo comando

        public override void UnExecute()
        {
            _calculator.Operation(Undo(_operator), _operand);
        }

        // Regresa el operador opuesto

        private char Undo(char @operator)
        {
            switch (@operator)
            {
                case '+': return '-';
                case '-': return '+';
                case '*': return '/';
                case '/': return '*';
                default:
                    throw new

            ArgumentException("@operator");
            }
        }
    }
}
