using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Project
{
    class DataProvider
    {
        static string myConnection = "datasource=localhost;port=3306;username=root;password=root";
        public static bool checkValidity(string id, string password, string type)
        {
            try
            {                
                MySqlConnection myConn = new MySqlConnection(myConnection);
                myConn.Open();
                MySqlCommand SelectCommand = new MySqlCommand("select * from myuniversity.student where StudentId = '" + id + "' and Password = '" + password + "';", myConn); ;
                if(type=="Student"){
                     SelectCommand = new MySqlCommand("select * from myuniversity.student where StudentId = '" + id + "' and Password = '" + password + "';", myConn);
                }
                else if (type == "Teacher")
                {
                     SelectCommand = new MySqlCommand("select * from myuniversity.teacher where TeacherID = '" + id + "' and Password = '" + password + "';", myConn);
                }
                else if (type == "Admin")
                {
                    int i = Convert.ToInt32(id);
                     SelectCommand = new MySqlCommand("select * from myuniversity.admin where ID = " + i + " and Password = '" + password + "';", myConn);
                }
                else if (type == "Librarian")
                {
                     SelectCommand = new MySqlCommand("select * from myuniversity.librarian where LibrarianID = '" + id + "' and Password = '" + password + "';", myConn);
                }
                
                MySqlDataReader myReader;
                

                myReader = SelectCommand.ExecuteReader();

                if (myReader.Read())
                {
                    myConn.Close();
                    return true;                   
                }
                else
                {
                    myConn.Close();
                    return false;                
                }   
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }﻿
        }




        internal static int[] getClassIDs()
        {
            int[] cids = new int[8];
            try
            {
                
                MySqlConnection myConn = new MySqlConnection(myConnection);
                myConn.Open();
                MySqlCommand SelectCommand = new MySqlCommand("select * from myuniversity.student where StudentId = '" + StudentHome.sid + "';", myConn); 

                MySqlDataReader myReader;

                myReader = SelectCommand.ExecuteReader();
               
                if (myReader.Read())
                {
                    cids[0] = myReader.GetInt32(11);
                    cids[1] = myReader.GetInt32(12);
                    cids[2] = myReader.GetInt32(13);
                    cids[3] = myReader.GetInt32(14);
                    cids[4] = myReader.GetInt32(15);
                    cids[5] = myReader.GetInt32(16);
                    cids[6] = myReader.GetInt32(17);
                    cids[7] = myReader.GetInt32(18);
                }
                myConn.Close();
                return cids;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }﻿
        }

        internal static bool checkSunday(int p)
        {
            try
            {
                
                MySqlConnection myConn = new MySqlConnection(myConnection);
                myConn.Open();
                MySqlCommand SelectCommand = new MySqlCommand("select * from myuniversity.class where classId = '" + p + "' and Sunday = 1;", myConn);

                MySqlDataReader myReader;

                myReader = SelectCommand.ExecuteReader();

                if (myReader.Read())
                {
                    myConn.Close();
                    return true;
                }
                else
                {
                    return false;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }﻿
            
            
        }

        internal static bool checkMonday(int p)
        {
            try
            {
                
                MySqlConnection myConn = new MySqlConnection(myConnection);
                myConn.Open();
                MySqlCommand SelectCommand = new MySqlCommand("select * from myuniversity.class where classId = '" + p + "' and Monday = 1;", myConn);

                MySqlDataReader myReader;

                myReader = SelectCommand.ExecuteReader();

                if (myReader.Read())
                {
                    myConn.Close();
                    return true;
                }
                else
                {
                    myConn.Close();
                    return false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }﻿
            
            
        }

        internal static bool checkTuesday(int p)
        {
            try
            {
                
                MySqlConnection myConn = new MySqlConnection(myConnection);
                myConn.Open();
                MySqlCommand SelectCommand = new MySqlCommand("select * from myuniversity.class where classId = '" + p + "' and Tuesday = 1;", myConn);

                MySqlDataReader myReader;

                myReader = SelectCommand.ExecuteReader();

                if (myReader.Read())
                {
                    myConn.Close();
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }﻿
            
            
        }

        internal static bool checkWednesday(int p)
        {
            try
            {
                
                MySqlConnection myConn = new MySqlConnection(myConnection);
                myConn.Open();
                MySqlCommand SelectCommand = new MySqlCommand("select * from myuniversity.class where classId = '" + p + "' and Wednesday = 1;", myConn);

                MySqlDataReader myReader;

                myReader = SelectCommand.ExecuteReader();

                if (myReader.Read())
                {
                    myConn.Close();
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }﻿
            
            
        }

        internal static bool checkThursday(int p)
        {
            try
            {
                
                MySqlConnection myConn = new MySqlConnection(myConnection);
                myConn.Open();
                MySqlCommand SelectCommand = new MySqlCommand("select * from myuniversity.class where classId = '" + p + "' and Thursday = 1;", myConn);

                MySqlDataReader myReader;

                myReader = SelectCommand.ExecuteReader();

                if (myReader.Read())
                {
                    myConn.Close();
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }﻿
            
            
        }

        internal static string getTimeAndCourseName(int p)
        {
            try
            {
                
                MySqlConnection myConn = new MySqlConnection(myConnection);
                myConn.Open();
                MySqlCommand SelectCommand = new MySqlCommand("select * from myuniversity.class where classId = '" + p + "';", myConn);

                MySqlDataReader myReader;

                myReader = SelectCommand.ExecuteReader();

                string time = "";
                string courseIDstr="";
                if (myReader.Read())
                {
                     time = myReader.GetString("Time");
                     courseIDstr = myReader.GetString("CourseID");
                }
                myConn.Close();
                myConn.Open();
                MySqlCommand SelectCommand1 = new MySqlCommand("select * from myuniversity.course where courseID = '" + courseIDstr + "';", myConn);
                MySqlDataReader myReader1;

                myReader1 = SelectCommand1.ExecuteReader();
                string courseName = "";

                if (myReader1.Read())
                {
                    courseName = myReader1.GetString(1);
                }
                myConn.Close();

                return "**  " + courseName + " ---> " + time;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }﻿
        }

        internal static string getMailAddress(string p)
        {
            string mailAddress="";
            try
            {
                
                MySqlConnection myConn = new MySqlConnection(myConnection);
                myConn.Open();
                MySqlCommand SelectCommand = new MySqlCommand("select * from myuniversity.student where StudentId = '" + p + "';", myConn);

                MySqlDataReader myReader;

                myReader = SelectCommand.ExecuteReader();

                if (myReader.Read())
                {
                    mailAddress = myReader.GetString("email");
                }
                myConn.Close();
                return mailAddress;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }﻿
        }

        internal static string getNID(string p)
        {
            string nid="";
            try
            {
                
                MySqlConnection myConn = new MySqlConnection(myConnection);
                myConn.Open();
                MySqlCommand SelectCommand = new MySqlCommand("select * from myuniversity.student where StudentId = '" + p + "';", myConn);

                MySqlDataReader myReader;

                myReader = SelectCommand.ExecuteReader();

                if (myReader.Read())
                {
                    nid = myReader.GetString("NID");
                }
                myConn.Close();
                return nid;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }﻿
        }

        internal static string getPassword(string p)
        {
            string pass="";
            try
            {
                
                MySqlConnection myConn = new MySqlConnection(myConnection);
                myConn.Open();
                MySqlCommand SelectCommand = new MySqlCommand("select * from myuniversity.student where StudentId = '" + p + "';", myConn);

                MySqlDataReader myReader;

                myReader = SelectCommand.ExecuteReader();

                if (myReader.Read())
                {
                    pass = myReader.GetString("password");
                }
                myConn.Close();
                return pass;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }﻿
        }

        internal static bool changeStudentPassword(string sid,string p)
        {
            try
            {
                
                MySqlConnection myConn = new MySqlConnection(myConnection);
                myConn.Open();
                MySqlCommand SelectCommand = new MySqlCommand("update myuniversity.student set password= '"+p+"' where StudentId = '" + sid + "';", myConn);

                MySqlDataReader myReader;

                myReader = SelectCommand.ExecuteReader();
                myConn.Close();
                return true;
                
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }﻿
        }

       

        internal static string getSAddress()
        {
            string sadd = "";
            try
            {
                
                MySqlConnection myConn = new MySqlConnection(myConnection);
                myConn.Open();
                MySqlCommand SelectCommand = new MySqlCommand("select * from myuniversity.student where StudentId = '" + StudentHome.sid + "';", myConn);

                MySqlDataReader myReader;

                myReader = SelectCommand.ExecuteReader();

                if (myReader.Read())
                {
                    sadd = myReader.GetString("Address");
                }
                myConn.Close();
                return sadd;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }﻿
        }

        internal static string getSGender()
        {
            string sg = "";
            try
            {
                
                MySqlConnection myConn = new MySqlConnection(myConnection);
                myConn.Open();
                MySqlCommand SelectCommand = new MySqlCommand("select * from myuniversity.student where StudentId = '" + StudentHome.sid + "';", myConn);

                MySqlDataReader myReader;

                myReader = SelectCommand.ExecuteReader();

                if (myReader.Read())
                {
                    sg = myReader.GetString("Gender");
                }
                myConn.Close();
                return sg;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }﻿
        }

        internal static string getSTelephone()
        {
            string st = "";
            try
            {
                
                MySqlConnection myConn = new MySqlConnection(myConnection);
                myConn.Open();
                MySqlCommand SelectCommand = new MySqlCommand("select * from myuniversity.student where StudentId = '" + StudentHome.sid + "';", myConn);

                MySqlDataReader myReader;

                myReader = SelectCommand.ExecuteReader();

                if (myReader.Read())
                {
                    st = myReader.GetString("Telephone");
                }
                myConn.Close();
                return st;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }﻿
        }

        internal static string getSEmail()
        {
            string se = "";
            try
            {
                
                MySqlConnection myConn = new MySqlConnection(myConnection);
                myConn.Open();
                MySqlCommand SelectCommand = new MySqlCommand("select * from myuniversity.student where StudentId = '" + StudentHome.sid + "';", myConn);

                MySqlDataReader myReader;

                myReader = SelectCommand.ExecuteReader();

                if (myReader.Read())
                {
                    se = myReader.GetString("email");
                }
                myConn.Close();
                return se;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }﻿
        }

        internal static double getCGPA()
        {
            double cg =0.0;
            try
            {
                
                MySqlConnection myConn = new MySqlConnection(myConnection);
                myConn.Open();
                MySqlCommand SelectCommand = new MySqlCommand("select * from myuniversity.student where StudentId = '" + StudentHome.sid + "';", myConn);

                MySqlDataReader myReader;

                myReader = SelectCommand.ExecuteReader();

                if (myReader.Read())
                {
                    cg = Convert.ToDouble(myReader.GetString("cgpa"));
                }
                myConn.Close();
                return cg;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0.0;
            }﻿
        }

        internal static int getSCredit()
        {
            int credit = 0;
            try
            {
                
                MySqlConnection myConn = new MySqlConnection(myConnection);
                myConn.Open();
                MySqlCommand SelectCommand = new MySqlCommand("select * from myuniversity.student where StudentId = '" + StudentHome.sid + "';", myConn);

                MySqlDataReader myReader;

                myReader = SelectCommand.ExecuteReader();

                if (myReader.Read())
                {
                    credit = Convert.ToInt32(myReader.GetString("totalCredit"));
                }
                myConn.Close();
                return credit;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }﻿
        }

        internal static string getSDepartment()
        {
            string sadd = "";
            try
            {
                
                MySqlConnection myConn = new MySqlConnection(myConnection);
                myConn.Open();
                MySqlCommand SelectCommand = new MySqlCommand("select * from myuniversity.student where StudentId = '" + StudentHome.sid + "';", myConn);

                MySqlDataReader myReader;

                myReader = SelectCommand.ExecuteReader();

                if (myReader.Read())
                {
                    sadd = myReader.GetString("Department");
                }
                myConn.Close();
                return sadd;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }﻿
        }

        internal static string getSFName()
        {
            string sadd = "";
            try
            {
                
                MySqlConnection myConn = new MySqlConnection(myConnection);
                myConn.Open();
                MySqlCommand SelectCommand = new MySqlCommand("select * from myuniversity.student where StudentId = '" + StudentHome.sid + "';", myConn);

                MySqlDataReader myReader;

                myReader = SelectCommand.ExecuteReader();

                if (myReader.Read())
                {
                    sadd = myReader.GetString("FirstName");
                }
                myConn.Close();
                return sadd;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }﻿
        }





        internal static string getSLName()
        {
            string sadd = "";
            try
            {
                
                MySqlConnection myConn = new MySqlConnection(myConnection);
                myConn.Open();
                MySqlCommand SelectCommand = new MySqlCommand("select * from myuniversity.student where StudentId = '" + StudentHome.sid + "';", myConn);

                MySqlDataReader myReader;

                myReader = SelectCommand.ExecuteReader();

                if (myReader.Read())
                {
                    sadd = myReader.GetString("LastName");
                }
                myConn.Close();
                return sadd;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }﻿
        }

        internal static string getSPassword()
        {
            string sadd = "";
            try
            {
                
                MySqlConnection myConn = new MySqlConnection(myConnection);
                myConn.Open();
                MySqlCommand SelectCommand = new MySqlCommand("select * from myuniversity.student where StudentId = '" + StudentHome.sid + "';", myConn);

                MySqlDataReader myReader;

                myReader = SelectCommand.ExecuteReader();

                if (myReader.Read())
                {
                    sadd = myReader.GetString("password");
                }
                myConn.Close();
                return sadd;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }﻿
        }

        internal static int getSNID()
        {
            int sn=0;
            try
            {
                
                MySqlConnection myConn = new MySqlConnection(myConnection);
                myConn.Open();
                MySqlCommand SelectCommand = new MySqlCommand("select * from myuniversity.student where StudentId = '" + StudentHome.sid + "';", myConn);

                MySqlDataReader myReader;

                myReader = SelectCommand.ExecuteReader();

                if (myReader.Read())
                {
                    sn = Convert.ToInt32( myReader.GetString("NID"));
                }
                myConn.Close();
                return sn;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }﻿
        }

        internal static double getSCgpa()
        {
            double sn = 0;
            try
            {
                
                MySqlConnection myConn = new MySqlConnection(myConnection);
                myConn.Open();
                MySqlCommand SelectCommand = new MySqlCommand("select * from myuniversity.student where StudentId = '" + StudentHome.sid + "';", myConn);

                MySqlDataReader myReader;

                myReader = SelectCommand.ExecuteReader();

                if (myReader.Read())
                {
                    sn = Convert.ToDouble(myReader.GetString("cgpa"));
                }
                myConn.Close();
                return sn;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }﻿
        }

        internal static bool setComplain(string p, string p_2)
        {
            try
            {
               
                MySqlConnection myConn = new MySqlConnection(myConnection);
                myConn.Open();
                MySqlCommand SelectCommand = new MySqlCommand("insert into myuniversity.complain values ('"+p+"' , '"+p_2+"');", myConn);

                MySqlDataReader myReader;

                myReader = SelectCommand.ExecuteReader();
                myConn.Close();
                return true;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }﻿
        }

        internal static string[] getTeacherIDs()
        {
            string[] ti = new string[8];
            for (int i = 0; i < 8; i++)
            {
                try
                {
                    
                    MySqlConnection myConn = new MySqlConnection(myConnection);
                    myConn.Open();
                    MySqlCommand SelectCommand = new MySqlCommand("select * from myuniversity.class where classID = '" + StudentHome.student.sClassID[i] + "';", myConn);

                    MySqlDataReader myReader;

                    myReader = SelectCommand.ExecuteReader();

                    if (myReader.Read())
                    {
                        ti[i] = myReader.GetString("TeacherID");
                    }
                    myConn.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return null;
                }﻿
            }
             return ti;
        }



        internal static string getTeacherName(string p)
        {
            string sadd = "";
            try
            {
                
                MySqlConnection myConn = new MySqlConnection(myConnection);
                myConn.Open();
                MySqlCommand SelectCommand = new MySqlCommand("select * from myuniversity.teacher where TeacherID = '" + p + "';", myConn);

                MySqlDataReader myReader;

                myReader = SelectCommand.ExecuteReader();

                if (myReader.Read())
                {
                    sadd = myReader.GetString("FirstName");
                    sadd = sadd + " " + myReader.GetString("LastName");
                }
                myConn.Close();
                return sadd;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }﻿
        }

        internal static bool sendMessages(string sid, string tid, string text,int seen,int toTeacher, int toStudent)
        {
            try
            {
                
                MySqlConnection myConn = new MySqlConnection(myConnection);
                myConn.Open();
                MySqlCommand SelectCommand = new MySqlCommand("insert into myuniversity.messages values ('" + sid + "' , '" + tid + "', '"+text+"', "+seen+","+toTeacher+", "+toStudent+");", myConn);

                MySqlDataReader myReader;

                myReader = SelectCommand.ExecuteReader();
                myConn.Close();
                return true;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }﻿
        }

        internal static string getGradeByCourse()
        {
            string str="";
            string cID="";
            string grade="";
            string CourseID="";
            string CourseName="";
            try
            {
                
                MySqlConnection myConn = new MySqlConnection(myConnection);
                myConn.Open();
                MySqlCommand SelectCommand = new MySqlCommand("select * from myuniversity.gradeTable where sID = '" + StudentHome.sid + "';", myConn);
                

                MySqlDataReader myReader;

                myReader = SelectCommand.ExecuteReader();

                while (myReader.Read())
                {
                   // myConn.Open();
                    cID = myReader.GetString("ClassID");
                    grade = myReader.GetString("Grade");
                  //  myConn.Close();

                    MySqlConnection myConn1 = new MySqlConnection(myConnection);
                    myConn1.Open();

                    MySqlCommand SelectCommand1 = new MySqlCommand("select * from myuniversity.class where classID = '" + cID + "';", myConn1);
                    MySqlDataReader myReader1;

                    myReader1 = SelectCommand1.ExecuteReader();

                    if (myReader1.Read())
                    {
                        CourseID = myReader1.GetString("CourseID");

                        myConn1.Close();

                        MySqlConnection myConn2 = new MySqlConnection(myConnection);
                        myConn2.Open();

                        MySqlCommand SelectCommand2 = new MySqlCommand("select * from myuniversity.course where CourseID = '" + CourseID + "';", myConn2);
                        MySqlDataReader myReader2;

                        myReader2 = SelectCommand2.ExecuteReader();

                        if (myReader2.Read())
                        {
                            CourseName = myReader2.GetString("Name");
                            myConn2.Close();
                            
                        }
                    }

                    str = str + "\r\n" + CourseID +
                        "                                                       " +
                        CourseName +
                        "                                     " + 
                        grade;
                }

    

                myConn.Close();
                return str;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }﻿
        }

        internal static string getGradeBySemester(string sem)
        {
            string str = "";
            string cID = "";
            string grade = "";
            string CourseID = "";
            string CourseName = "";
            try
            {
                
                MySqlConnection myConn = new MySqlConnection(myConnection);
                myConn.Open();
                MySqlCommand SelectCommand = new MySqlCommand("select * from myuniversity.gradeTable where sID = '" + StudentHome.sid + "';", myConn);


                MySqlDataReader myReader;

                myReader = SelectCommand.ExecuteReader();

                while (myReader.Read())
                {
                    // myConn.Open();
                    cID = myReader.GetString("ClassID");
                    grade = myReader.GetString("Grade");
                    //  myConn.Close();

                    MySqlConnection myConn1 = new MySqlConnection(myConnection);
                    myConn1.Open();

                    MySqlCommand SelectCommand1 = new MySqlCommand("select * from myuniversity.class where classID = '" + cID + "' and semester= '"+sem+"';", myConn1);
                    MySqlDataReader myReader1;

                    myReader1 = SelectCommand1.ExecuteReader();

                    if (myReader1.Read())
                    {
                        CourseID = myReader1.GetString("CourseID");

                        myConn1.Close();

                        MySqlConnection myConn2 = new MySqlConnection(myConnection);
                        myConn2.Open();

                        MySqlCommand SelectCommand2 = new MySqlCommand("select * from myuniversity.course where CourseID = '" + CourseID + "';", myConn2);
                        MySqlDataReader myReader2;

                        myReader2 = SelectCommand2.ExecuteReader();

                        if (myReader2.Read())
                        {
                            CourseName = myReader2.GetString("Name");
                            myConn2.Close();

                        }
                        str = str + "\r\n" + CourseID +
                        "                                                       " +
                        CourseName +
                        "                                     " +
                        grade;
                    }

                    
                }



                myConn.Close();
                return str;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }﻿
        
        }

        internal static bool ifRated(string sid, string tid)
        {
            
            try
            {
                
                MySqlConnection myConn = new MySqlConnection(myConnection);
                myConn.Open();
                MySqlCommand SelectCommand = new MySqlCommand("select * from myuniversity.ratingtable where sID = '" + sid + "' and tid ='"+tid+"';", myConn);

                MySqlDataReader myReader;

                myReader = SelectCommand.ExecuteReader();

                if (myReader.Read())
                {
                    return true;
                }
                myConn.Close();
                return false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }﻿
        }

        internal static bool setTeacherRating(string teacher_id, int r)
        {
            double rating=0.0;
            int nRating=0;
            double total;
            double res;
            try
            {
                
                MySqlConnection myConn = new MySqlConnection(myConnection);
                myConn.Open();
                MySqlCommand SelectCommand = new MySqlCommand("select * from myuniversity.teacher where teacherID = '" + teacher_id + "';", myConn);

                MySqlDataReader myReader;

                myReader = SelectCommand.ExecuteReader();

                if (myReader.Read())
                {
                     rating = myReader.GetDouble("rating");
                     nRating = myReader.GetInt32("nRating");
                }
                myConn.Close();

                total = (rating * nRating)+r;
                nRating++;

                res = total / nRating;

                myConn.Open();

                MySqlCommand SelectCommand1 = new MySqlCommand("update myuniversity.teacher set rating ="+res+", nRating ="+nRating+" where TeacherId='"+teacher_id+"';", myConn);
                MySqlDataReader myReader1;

                myReader1 = SelectCommand1.ExecuteReader();

               
                myConn.Close();
                myConn.Open();

                MySqlCommand SelectCommand2 = new MySqlCommand("insert into myuniversity.ratingtable values('"+StudentHome.sid+"', '"+teacher_id+"',0);", myConn);
                MySqlDataReader myReader2;

                myReader2 = SelectCommand2.ExecuteReader();

                myConn.Close();
                return true;
                    
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }﻿
        }

        static int[] reCredit;

        internal static string[] getRetakeSubjects()
        {
            string[] reClassID = new string[5];
            string[] reCourseID = new string[5];
            string[] reSub = new string[5];
            reCredit = new int[5];
            try
            {
                
                MySqlConnection myConn = new MySqlConnection(myConnection);
                myConn.Open();
                MySqlCommand SelectCommand = new MySqlCommand("select * from myuniversity.gradeTable where sID = '" + StudentHome.sid +
                    "' AND (grade ='C+' OR grade ='C' OR grade ='C-' OR grade ='D+' OR grade ='D' OR grade ='D-');"
                    , myConn);

                MySqlDataReader myReader;

                myReader = SelectCommand.ExecuteReader();
                int i = 0;

                while (myReader.Read())
                {
                    reClassID[i] = myReader.GetString("classID");
                    i++;
                    if (i > 5)
                    {
                        break;
                    }
                }
                myConn.Close();

                for (int j = 0; j < i; j++)
                {
                    myConn.Open();

                    MySqlCommand SelectCommand1 = new MySqlCommand("select * from myuniversity.class where classID = '" + reClassID[j] + "';", myConn);
                    MySqlDataReader myReader1;

                    myReader1 = SelectCommand1.ExecuteReader();

                    if (myReader1.Read())
                    {
                        reCourseID[j] = myReader1.GetString("CourseID");
                    }
                    myConn.Close();
                }

                for (int j = 0; j < i; j++)
                {
                    myConn.Open();

                    MySqlCommand SelectCommand1 = new MySqlCommand("select * from myuniversity.course where courseID = '" + reCourseID[j] + "';", myConn);
                    MySqlDataReader myReader1;

                    myReader1 = SelectCommand1.ExecuteReader();

                    if (myReader1.Read())
                    {
                        reSub[j] = myReader1.GetString("Name");
                        reCredit[j] = myReader1.GetInt32("Credit");
                    }
                    myConn.Close();
                }



                return reSub;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }﻿
        }

        internal static int[] getRetakeSubjectCredit()
        {
            return reCredit;
        }

        internal static string[] getRetakeSubjectGrades()
        {
            string[] reGrade = new string[5];
            try
            {
                
                MySqlConnection myConn = new MySqlConnection(myConnection);
                myConn.Open();
                MySqlCommand SelectCommand = new MySqlCommand("select * from myuniversity.gradeTable where sID = '" + StudentHome.sid +
                    "' AND (grade ='C+' OR grade ='C' OR grade ='C-' OR grade ='D+' OR grade ='D' OR grade ='D-');"
                    , myConn);

                MySqlDataReader myReader;

                myReader = SelectCommand.ExecuteReader();
                int i = 0;

                while (myReader.Read())
                {
                    reGrade[i] = myReader.GetString("Grade");
                    i++;
                    if (i > 5)
                    {
                        break;
                    }
                }
                myConn.Close();

                return reGrade;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }﻿
        }

        internal static string getCourseNameByClassID(int classID)
        {
            string courseName = "";
            int courseID=0;
            try
            {
                
                MySqlConnection myConn = new MySqlConnection(myConnection);
                myConn.Open();
                MySqlCommand SelectCommand = new MySqlCommand("select * from myuniversity.class where classID = " + classID + ";", myConn);

                MySqlDataReader myReader;

                myReader = SelectCommand.ExecuteReader();

                if (myReader.Read())
                {
                    courseID = myReader.GetInt32("CourseID");
                }
                myConn.Close();

                courseName = getCourseNameByCourseID(courseID);
                return courseName;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }﻿
        }

        private static string getCourseNameByCourseID(int courseID)
        {
            string courseName = "";
            
            try
            {
               
                MySqlConnection myConn = new MySqlConnection(myConnection);
                myConn.Open();
                MySqlCommand SelectCommand = new MySqlCommand("select * from myuniversity.course where courseID = " + courseID + ";", myConn);

                MySqlDataReader myReader;

                myReader = SelectCommand.ExecuteReader();

                if (myReader.Read())
                {
                    courseName = myReader.GetString("Name");
                }
                myConn.Close();

                return courseName;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }﻿
        }

        internal static int getCouseIDByClassID(int classID)
        {
           
            int courseID = 0;
            try
            {
                
                MySqlConnection myConn = new MySqlConnection(myConnection);
                myConn.Open();
                MySqlCommand SelectCommand = new MySqlCommand("select * from myuniversity.class where classID = " + classID + ";", myConn);

                MySqlDataReader myReader;

                myReader = SelectCommand.ExecuteReader();

                if (myReader.Read())
                {
                    courseID = myReader.GetInt32("CourseID");
                }
                myConn.Close();

                
                return courseID;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        internal static string getClassDetailsByClassID(int classID)
        {
            int courseID = getCouseIDByClassID(classID);
            int roomNum = 0;
            string teacherID = "";
            string time = "";
            string weekDays = "";
            string courseName = "";
            string Department = "";
            try
            {
                
                MySqlConnection myConn = new MySqlConnection(myConnection);
                myConn.Open();
                MySqlCommand SelectCommand = new MySqlCommand("select * from myuniversity.class where classID = " + classID + ";", myConn);

                MySqlDataReader myReader;

                myReader = SelectCommand.ExecuteReader();

                if (myReader.Read())
                {
                    roomNum = myReader.GetInt32("roomNo");
                    teacherID = myReader.GetString("TeacherID");
                    time = myReader.GetString("Time");
                    weekDays = myReader.GetString("WeekDays");
                }
                myConn.Close();

                myConn.Open();
                MySqlCommand SelectCommand1 = new MySqlCommand("select * from myuniversity.course where courseID = " + courseID + ";", myConn);
                MySqlDataReader myReader1;

                myReader1 = SelectCommand1.ExecuteReader();
                if (myReader1.Read())
                {
                    courseName = myReader1.GetString("Name");
                    Department = myReader1.GetString("Department");
                }
                myConn.Close();

                string final= "Course: "+courseName+"\r\nTime: "+weekDays+" -> "+time+"\r\n"+"Roome Number: "+roomNum+"\r\nDepartment: "+Department+"\r\nTeacherName: "+getTeacherName(teacherID)+"\r\n";

                return final;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

        }

        internal static int[] getCompletedCourseIDs()
        {
            int[] courseIDs = new int[100];
            int temp;
            try
            {
                
                MySqlConnection myConn = new MySqlConnection(myConnection);
                myConn.Open();
                MySqlCommand SelectCommand = new MySqlCommand("select * from myuniversity.gradeTable where sID = " + StudentHome.sid + ";", myConn);

                MySqlDataReader myReader;

                myReader = SelectCommand.ExecuteReader();
                int i = 0;

                while (myReader.Read())
                {
                    if (i < 100)
                    {
                        temp = myReader.GetInt32("ClassID");
                        courseIDs[i] = DataProvider.getCouseIDByClassID(temp);
                        i++;
                    }
                    
                }
                myConn.Close();


                return courseIDs;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

       public static int[] nextSemesterClassIDs= new int[100];
       public static int[] nextSemesterCourseIDs = new int[100];
       public static string[] nextSemesterCourseNames = new string[100];
       public static string[] nextSemesterCouseTimes = new string[100];

       internal static BindingSource getNextSemesterClassInfos(int[] completedCourseIDs)
        {
            int i = completedCourseIDs.Length;
            
            try
            {
                
                MySqlConnection myConn = new MySqlConnection(myConnection);
                myConn.Open();
                MySqlCommand cmdDatabase = new MySqlCommand("select classID,courseID,Time,WeekDays,Capacity,Enrolled,roomNo from myuniversity.class where semester = 'Spring 2018' and classID NOT IN ( " + completedCourseIDs[0] + "," + completedCourseIDs[1] + ");", myConn);

                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
                    dataAdapter.SelectCommand = cmdDatabase;

                    DataTable dataSet = new DataTable();
                    dataAdapter.Fill(dataSet);

                    BindingSource bSource = new BindingSource();

                    bSource.DataSource = dataSet;
                    

                    dataAdapter.Update(dataSet);

                    myConn.Close();

                    return bSource;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

       internal static string generatePassword()
       {
           string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
           var stringChars = new char[8];
           var random = new Random();

           for (int i = 0; i < stringChars.Length; i++)
           {
               stringChars[i] = chars[random.Next(chars.Length)];
           }

           string finalString = new String(stringChars);

           return finalString;
       }

       internal static string generateStudentID()
       {
           DateTime today = DateTime.Today;
           string year = today.Year.ToString();

           year= year.Substring(year.Length - 2);

           int n = 0;

           
           MySqlConnection myConn = new MySqlConnection(myConnection);
           myConn.Open();
           MySqlCommand SelectCommand = new MySqlCommand("select * from myuniversity.total;", myConn);

           MySqlDataReader myReader;

           myReader = SelectCommand.ExecuteReader();

           if (myReader.Read())
           {
               n = myReader.GetInt32("totalStudents");
           }
           myConn.Close();

           n++;

           var result = n.ToString().PadLeft(4, '0');

           string sID = year + "-"+result+"-1";

           return sID;

       }

       internal static bool AddStudents(string id, string fn, string ln,string dep, string pass, string gen, string add, string nid, string tel, string email)
       {
           try
           {
              
               MySqlConnection myConn = new MySqlConnection(myConnection);
               myConn.Open();
               MySqlCommand SelectCommand = new MySqlCommand(
"insert into myuniversity.student values ('"+id+"','"+fn+"','"+ln+"','"+dep+"','"+pass+"','"+gen+"','"+add+"','"+nid+"',0,'"+tel+"','"+email+"',13,17,20,0,0,0,0,0,0);"
                   , myConn);

               MySqlDataReader myReader;

               myReader = SelectCommand.ExecuteReader();
               myConn.Close();

               myConn.Open();
               MySqlCommand SelectCommand1 = new MySqlCommand("UPDATE myuniversity.total SET totalStudents = totalStudents + 1 WHERE pk=1", myConn);

               MySqlDataReader myReader1;

               myReader1 = SelectCommand1.ExecuteReader();
               myConn.Close();

               return true;
           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.Message);
               return false;
           }﻿
       }

       internal static BindingSource editTable(string p)
       {
           try
           {
              
               MySqlConnection myConn = new MySqlConnection(myConnection);
               myConn.Open();
               MySqlCommand cmdDatabase = new MySqlCommand("select * from myuniversity."+p+";", myConn);

               MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
               dataAdapter.SelectCommand = cmdDatabase;

               DataTable dataSet = new DataTable();
               dataAdapter.Fill(dataSet);

               BindingSource bSource = new BindingSource();

               bSource.DataSource = dataSet;


               dataAdapter.Update(dataSet);

               myConn.Close();

               return bSource;

           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.Message);
               return null;
           }
       }

       internal static string generateTeacherID()
       {
           DateTime today = DateTime.Today;
           string year = today.Year.ToString();

           year = year.Substring(year.Length - 2);

           int n = 0;

           
           MySqlConnection myConn = new MySqlConnection(myConnection);
           myConn.Open();
           MySqlCommand SelectCommand = new MySqlCommand("select * from myuniversity.total;", myConn);

           MySqlDataReader myReader;

           myReader = SelectCommand.ExecuteReader();

           if (myReader.Read())
           {
               n = myReader.GetInt32("totalTeacher");
           }
           myConn.Close();

           n++;

           var result = n.ToString().PadLeft(4, '0');

           string tID = year + "-" + result;

           return tID;
       }

       internal static bool addTeachers(string id, string fn, string ln, string dep, string pass, string gen, string add, string nid, string tel, string email,string dob,int salary)
       {
           try
           {
               DateTime today = DateTime.Today;
               
               MySqlConnection myConn = new MySqlConnection(myConnection);
               myConn.Open();
               MySqlCommand SelectCommand = new MySqlCommand(
"insert into myuniversity.teacher values ('" + id + "','" + fn + "','" + ln + "','" + dep + "','" + pass + "','" + gen + "','" + add + "','" + nid + "','" + tel + "','" + email + "',"+salary+",'"+today.ToString()+"','"+dob+"',5,1);"
                   , myConn);

               MySqlDataReader myReader;

               myReader = SelectCommand.ExecuteReader();
               myConn.Close();

               myConn.Open();
               MySqlCommand SelectCommand1 = new MySqlCommand("UPDATE myuniversity.total SET totalTeacher = totalTeacher + 1 WHERE pk=1", myConn);

               MySqlDataReader myReader1;

               myReader1 = SelectCommand1.ExecuteReader();
               myConn.Close();

               return true;
           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.Message);
               return false;
           }﻿
       }

       internal static int generateAdminID()
       {
           int n = 0;

           MySqlConnection myConn = new MySqlConnection(myConnection);
           myConn.Open();
           MySqlCommand SelectCommand = new MySqlCommand("select * from myuniversity.total;", myConn);

           MySqlDataReader myReader;

           myReader = SelectCommand.ExecuteReader();

           if (myReader.Read())
           {
               n = myReader.GetInt32("totalTeacher");
           }
           myConn.Close();

           n++;


           return n;
       }

       internal static bool addLibrarian(int i, string p, string p_2, string p_3, string p_4, string p_5)
       {
           try
           {
               
               MySqlConnection myConn = new MySqlConnection(myConnection);
               myConn.Open();
               MySqlCommand SelectCommand = new MySqlCommand(
                    "insert into myuniversity.librarian values("+i+",'"+p+"','"+p_2+"','"+p_3+"','"+p_4+"','"+p_5+"');"
                   , myConn);

               MySqlDataReader myReader;

               myReader = SelectCommand.ExecuteReader();
               myConn.Close();

               myConn.Open();
               MySqlCommand SelectCommand1 = new MySqlCommand("UPDATE myuniversity.total SET totalLibrarian = totalLibrarian + 1 WHERE pk=1", myConn);

               MySqlDataReader myReader1;

               myReader1 = SelectCommand1.ExecuteReader();
               myConn.Close();

               return true;
           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.Message);
               return false;
           }﻿
       }

       internal static int generateCourseID()
       {
           int n = 0;

           MySqlConnection myConn = new MySqlConnection(myConnection);
           myConn.Open();
           MySqlCommand SelectCommand = new MySqlCommand("select * from myuniversity.total;", myConn);

           MySqlDataReader myReader;

           myReader = SelectCommand.ExecuteReader();

           if (myReader.Read())
           {
               n = myReader.GetInt32("totalCourse");
           }
           myConn.Close();

           n++;


           return n;
       }

       internal static bool addCourse(int id, string name, int credit, string dep, int preReq)
       {
           try
           {

               MySqlConnection myConn = new MySqlConnection(myConnection);
               myConn.Open();
               MySqlCommand SelectCommand = new MySqlCommand(
                    "insert into myuniversity.course values("+id+",'"+name+"',"+credit+",'"+dep+"',"+preReq+");"
                   , myConn);

               MySqlDataReader myReader;

               myReader = SelectCommand.ExecuteReader();
               myConn.Close();

               myConn.Open();
               MySqlCommand SelectCommand1 = new MySqlCommand("UPDATE myuniversity.total SET totalCourse = totalCourse + 1 WHERE pk=1", myConn);

               MySqlDataReader myReader1;

               myReader1 = SelectCommand1.ExecuteReader();
               myConn.Close();

               return true;
           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.Message);
               return false;
           }﻿
       }

       internal static bool delete(string tableName, string id)
       {
           try
           {

               MySqlConnection myConn = new MySqlConnection(myConnection);
               myConn.Open();
               MySqlCommand SelectCommand = new MySqlCommand(
                    "DELETE FROM myuniversity."+tableName+" WHERE "+tableName+"ID = "+id+";"
                   , myConn);

               MySqlDataReader myReader;

               myReader = SelectCommand.ExecuteReader();
               myConn.Close();

               return true;
           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.Message);
               return false;
           }﻿
       }

       internal static string getLibrarianName(int id)
       {
           string Name = "";
           
           try
           {

               MySqlConnection myConn = new MySqlConnection(myConnection);
               myConn.Open();
               MySqlCommand SelectCommand = new MySqlCommand("select * from myuniversity.librarian where Librarianid = " + id + ";", myConn);

               MySqlDataReader myReader;

               myReader = SelectCommand.ExecuteReader();

               if (myReader.Read())
               {
                   Name = myReader.GetString("Name");
               }
               myConn.Close();


               return Name;

           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.Message);
               return null;
           }﻿
       }

       internal static int generateBookID()
       {
           int n = 0;

           MySqlConnection myConn = new MySqlConnection(myConnection);
           myConn.Open();
           MySqlCommand SelectCommand = new MySqlCommand("select * from myuniversity.total;", myConn);

           MySqlDataReader myReader;

           myReader = SelectCommand.ExecuteReader();

           if (myReader.Read())
           {
               n = myReader.GetInt32("totalBook");
           }
           myConn.Close();

           n++;


           return n;
       }

       internal static bool addNewBook(int id, string name, string author, int quantity, string type)
       {
           try
           {
               MySqlConnection myConn = new MySqlConnection(myConnection);
               myConn.Open();
               MySqlCommand SelectCommand = new MySqlCommand(
                    "insert into myuniversity.library values(" + id + ",'" + name + "','" + author + "'," + quantity + ",'" + type + "');"
                   , myConn);

               MySqlDataReader myReader;

               myReader = SelectCommand.ExecuteReader();
               myConn.Close();

               myConn.Open();
               MySqlCommand SelectCommand1 = new MySqlCommand("UPDATE myuniversity.total SET totalBook = totalBook + 1 WHERE pk=1", myConn);

               MySqlDataReader myReader1;

               myReader1 = SelectCommand1.ExecuteReader();
               myConn.Close();

               return true;
           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.Message);
               return false;
           }﻿
       }

       internal static bool addExistingBook(string p, int quantity)
       {
           try
           {
               MySqlConnection myConn = new MySqlConnection(myConnection);
               myConn.Open();
               MySqlCommand SelectCommand1 = new MySqlCommand("UPDATE myuniversity.library SET available = available + "+quantity+" WHERE bookName='"+p+"';", myConn);

               MySqlDataReader myReader1;

               myReader1 = SelectCommand1.ExecuteReader();
               myConn.Close();

               return true;
           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.Message);
               return false;
           }﻿
       }

       internal static bool lendBooks(string bookName, string sID)
       {
           int id = generateLendBookID();
           int q = 0;
           try
           {
               MySqlConnection myConn = new MySqlConnection(myConnection);
               myConn.Open();

               MySqlCommand SelectCommand2 = new MySqlCommand(
                    "select * from myuniversity.library where BookName ='"+bookName+"';"
                   , myConn);

               MySqlDataReader myReader2;

               myReader2 = SelectCommand2.ExecuteReader();

               if (myReader2.Read())
               {
                   q = myReader2.GetInt32("available");
               }
               myConn.Close();

               if (q < 3)
               {
                   return false;
               }
               else
               {
                   DateTime today = DateTime.Today;
                   myConn.Open();

                   MySqlCommand SelectCommand = new MySqlCommand(
                        "insert into myuniversity.lendBook values(" + id + ",'" + bookName + "','" + sID + "','" + today.ToString("yyyy-MM-dd HH:mm:ss") + "');"
                       , myConn);

                   MySqlDataReader myReader;

                   myReader = SelectCommand.ExecuteReader();
                   myConn.Close();

                   myConn.Open();
                   MySqlCommand SelectCommand1 = new MySqlCommand("UPDATE myuniversity.total SET totalLendBook = totalLendBook + 1 WHERE pk=1", myConn);

                   MySqlDataReader myReader1;

                   myReader1 = SelectCommand1.ExecuteReader();
                   myConn.Close();

                   myConn.Open();
                   MySqlCommand SelectCommand3 = new MySqlCommand("UPDATE myuniversity.library SET available = available - 1 WHERE bookName= '"+bookName+"';", myConn);

                   MySqlDataReader myReader3;

                   myReader3 = SelectCommand3.ExecuteReader();
                   myConn.Close();

                   return true;
               }
               
           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.Message);
               return false;
           }﻿
       }

       private static int generateLendBookID()
       {
           int n = 0;

           MySqlConnection myConn = new MySqlConnection(myConnection);
           myConn.Open();
           MySqlCommand SelectCommand = new MySqlCommand("select * from myuniversity.total;", myConn);

           MySqlDataReader myReader;

           myReader = SelectCommand.ExecuteReader();

           if (myReader.Read())
           {
               n = myReader.GetInt32("totalLendBook");
           }
           myConn.Close();

           n++;


           return n;
       }

       internal static int checkForFine(int lendID)
       {
           DateTime today = DateTime.Today;
           DateTime lend;
           string str="";

           MySqlConnection myConn = new MySqlConnection(myConnection);
           myConn.Open();
           MySqlCommand SelectCommand = new MySqlCommand("select * from myuniversity.lendBook where id="+lendID+";", myConn);

           MySqlDataReader myReader;

           myReader = SelectCommand.ExecuteReader();

           if (myReader.Read())
           {
               str = myReader.GetString("lendedDate");
           }
           lend = DateTime.Parse(str);

           int fine = 0;
           int p = Convert.ToInt32((today - lend).TotalDays)-1;
           if (p > 5)
           {
                fine = (p * 20); //20 tk per day
           }
           

           myConn.Close();

           return fine;
       }

       internal static void addLibraryIncome(int fine)
       {
           DateTime today = DateTime.Today;
           MySqlConnection myConn = new MySqlConnection(myConnection);
           myConn.Open();

           MySqlCommand SelectCommand = new MySqlCommand(
                "insert into myuniversity.libraryIncome values('"+today.ToString("yyyy-MM-dd HH:mm:ss") + "',"+fine+");"
               , myConn);

           MySqlDataReader myReader;

           myReader = SelectCommand.ExecuteReader();
           myConn.Close();

           

       }

       internal static int getTodaysLibraryIncome()
       {
           DateTime today = DateTime.Today;
           int total = 0;
           MySqlConnection myConn = new MySqlConnection(myConnection);
           myConn.Open();

           MySqlCommand SelectCommand = new MySqlCommand(
                "select * from myuniversity.libraryIncome where date='" + today.ToString("yyyy-MM-dd HH:mm:ss") + "';"
               , myConn);

           MySqlDataReader myReader;

           myReader = SelectCommand.ExecuteReader();

           while (myReader.Read())
           {
               total = total + myReader.GetInt32("income");
           }

           myConn.Close();

           return total;
       }
    }
}
