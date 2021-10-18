using System;
using System.Collections.Generic;
using System.Text;

namespace TestPipelineApp
{
    public class Calculator
    {
        public enum Operation
        {
            Add,
            Subtract,
            Multiply,
            Divide
        }

        private int _num1;

        private int _num2;

        private Operation _operation;

        public Operation NewOperation
        {
            set
            {
                this._operation = value;
            }
        }

        public Calculator(int num1, int num2, Operation operation)
        {
            this._num1 = num1;
            this._num2 = num2;
            this._operation = operation;
        }

        public int GetResult()
        {
            switch (this._operation)
            {
                case Operation.Add:
                    return this._num1 + this._num2;
                case Operation.Subtract:
                    return this._num1 - this._num2;
                case Operation.Multiply:
                    return this._num1 * this._num2;
                case Operation.Divide:
                    return this._num1 / this._num2;
                default:
                    throw new Exception();
            }
        }
    }
}
