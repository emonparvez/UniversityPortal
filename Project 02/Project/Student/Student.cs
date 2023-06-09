using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project
{
    public class Student
    {
        private string m_sID;
        private string m_sFirstName;
        private string m_sLastName;
        private string m_sDepartment;
        private string m_sPassword;
        private string m_sGender;
        private string m_sAddress;
        private int m_sNID;
        private double m_sCGPA;
        private string m_sTelephone;
        private string m_sEmail;
        private int[] m_sClassID;
        private string[] m_sTeacherID;
        private int m_sCredit;

        public Student(string sid, string sfn, string sln, string sd, string sp, string sg, string sa, int sn, double sc, string st, string se, int[] scl, int sCr)
        {
            m_sID=sid;
            m_sFirstName=sfn;
            m_sLastName=sln;
            m_sDepartment=sd;
            m_sPassword=sp;
            m_sGender=sg;
            m_sAddress=sa;
            m_sNID=sn;
            m_sCGPA=sc;
            m_sTelephone=st;
            m_sEmail=se;
            m_sClassID=scl;
            m_sCredit = sCr;
        }

        public int sCredit
        {
            get { return m_sCredit; }
        }

        public string[] sTeacherID
        {
            get { return m_sTeacherID; }
        }

        public string sID{
            get { return m_sID; }
        }
        public string sFirstName
        {
            get { return m_sFirstName; }
        }
        public string sLastName
        {
            get { return m_sLastName; }
        }
        public string sDepartment
        {
            get { return m_sDepartment; }
        }
        public string sPassword
        {
            get { return m_sPassword; }
        }
        public string sGender
        {
            get { return m_sGender; }
        }
        public string sAddress
        {
            get { return m_sAddress; }
        }
        public int sNID
        {
            get { return m_sNID; }
        }
        public double sCGPA
        {
            get { return m_sCGPA; }
        }
        public string sTelephone
        {
            get { return m_sTelephone; }
        }
        public string sEmail
        {
            get { return m_sEmail; }
        }
        public int[] sClassID
        {
            get { return m_sClassID; }
        }


        internal void setTeacherIDs()
        {
            m_sTeacherID= DataProvider.getTeacherIDs();
        }
    }
}
