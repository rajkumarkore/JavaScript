﻿namespace Oops1
{
    class ClsEmployee2
    {
        int EmpId;
        string EName;
        string EAddress;
        int EAge;

        public int PEmpId
        {
            set { EmpId = value; }
            get { return EmpId; }
        }
        public string PEName
        {
            set { EName = value; }
            get { return EName; }
        }
        public string PEAddress
        {
            set { EAddress = value; }
            get { return EAddress; }
        }
        public int PEAge
        {
            set { PEAge = value; }
            get { return PEAge; }
        }
    }
}
