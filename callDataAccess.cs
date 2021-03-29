﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CallCenterProgram
{
    class callDataAccess
    {

        string connect = "Data Source=.; Initial Catalog= CallCenterDatabase; Integrated Security= SSPI";
        SqlConnection conn;
        SqlCommand command;
        SqlDataReader reader;


        public void InsertCall(float callTime, DateTime initialTimestamp, DateTime finalTimestamp, string faultReport, string callReport, string problemInfo, string workRequest, int callDuration)
        {
            string query = @"
                            INSERT INTO 
                                Call 
                            VALUES 
                                ( '" + callTime + "', '" + initialTimestamp + "', '" + finalTimestamp + "', '" + faultReport + "', '" + callReport + "', '" + problemInfo + "', '" + workRequest + "', '" + callDuration + "' )";

            conn = new SqlConnection(connect);

            conn.Open();

            command = new SqlCommand(query, conn);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Call inserted into the database successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not insert call due to error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
