using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab04
{
    class BitOperations
    {
        public bool OperationFlag { get; set; }
        public string Operation { get; set; }
        public string LeftOperand { get; set; }
        public string RightOperand { get; set; }
        public string Result { get; set; }

        public BitOperations()
        {
            Operation = null;
            LeftOperand = null;
            RightOperand = null;
            Result = null;
            OperationFlag = false;
        }

        public void AndOperation()
        {
            Result = Convert.ToString(Convert.ToInt32(LeftOperand, 2) & Convert.ToInt32(RightOperand, 2));
            Result = (Convert.ToByte(Result).ToString());
        }

        public void NotOperation()
        {
            Result = Convert.ToString(~Convert.ToInt32(LeftOperand, 2));
        }

        public void OrOperation()
        {
            Result = Convert.ToString(Convert.ToInt32(LeftOperand, 2) | Convert.ToInt32(RightOperand, 2));
        }

        public void GetResult()
        {
            if (Operation == "AND") AndOperation();
            else if (Operation == "OR") OrOperation();
        }

        public void Clear()
        {
            Operation = null;
            LeftOperand = null;
            RightOperand = null;
            Result = null;
            OperationFlag = false;
        }
    }
}
