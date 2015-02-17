﻿using System;
using System.Data;
using System.Data.Common;


public struct Leads
{
    public int LeadId;
    public string Name;
    public string Trip;
	 
		
		public string Phone; 
		public string Email; 
		public string From;
		public string FromDate;
		public string To; 
		public string ToDate;
		public string Passengers; 
		public string Cabin; 
		public string DateSubmitted;
        
}
/// <summary>
/// Product catalog business tier component
/// </summary>
public static class LeadAccess
{
    static LeadAccess()
    {
        //
        // TODO: Add constructor logic here
        //
    }


    

    // Create a new product
    public static bool CreateLead(string trip, string name, string phone, string email, string from, string fromdate, string to, string todate, 
        string passengers, string cabin, string datesubmitted)
    {
        // get a configured DbCommand object
        DbCommand comm = GenericDataAccess.CreateCommand();
        // set the stored procedure name
        comm.CommandText = "CreateLead";
        // create a new parameter
        DbParameter param = comm.CreateParameter();
        param.ParameterName = "@Trip";
        param.Value = trip;
        param.DbType = DbType.String;
        param.Size = 10;
        comm.Parameters.Add(param);

        // create a new parameter
        param = comm.CreateParameter();
        param.ParameterName = "@Name";
        param.Value = name;
        param.DbType = DbType.String;
        param.Size = 50;
        comm.Parameters.Add(param);
        // create a new parameter
        param = comm.CreateParameter();
        param.ParameterName = "@Phone";
        param.Value = phone;
        param.DbType = DbType.String;
        comm.Parameters.Add(param);
        // create a new parameter
        param = comm.CreateParameter();
        param.ParameterName = "@Email";
        param.Value = email;
        param.DbType = DbType.String;
        comm.Parameters.Add(param);
        // create a new parameter
        param = comm.CreateParameter();
        param.ParameterName = "@From";
        param.Value = from;
        param.DbType = DbType.String;
        param.Size = 10;
        comm.Parameters.Add(param);
        // create a new parameter
        param = comm.CreateParameter();
        param.ParameterName = "@FromDate";
        param.Value = fromdate;
        param.DbType = DbType.String;
        comm.Parameters.Add(param);
        // create a new parameter
        param = comm.CreateParameter();
        param.ParameterName = "@To";
        param.Value = to;
        param.DbType = DbType.String;
        param.Size = 10;
        comm.Parameters.Add(param);
        // create a new parameter
        param = comm.CreateParameter();
        param.ParameterName = "@ToDate";
        param.Value = todate;
        param.DbType = DbType.String;
        comm.Parameters.Add(param);
        // create a new parameter
        param = comm.CreateParameter();
        param.ParameterName = "@Passengers";
        param.Value = passengers;
        param.DbType = DbType.String;
        comm.Parameters.Add(param);
        // create a new parameter
        param = comm.CreateParameter();
        param.ParameterName = "@Cabin";
        param.Value = cabin;
        param.DbType = DbType.String;
        param.Size = 10;
        comm.Parameters.Add(param);
        // create a new parameter
        param = comm.CreateParameter();
        param.ParameterName = "@DateSubmitted";
        param.Value = datesubmitted;
        param.DbType = DbType.String;
        comm.Parameters.Add(param);
        


        int result = -1;
        try
        {
            // execute the stored procedure
            result = GenericDataAccess.ExecuteNonQuery(comm);
        }
        catch
        {
            // any errors are logged in GenericDataAccess, we ignore them here
        }
        // result will be 1 in case of success
        return (result != -1);

        
    }



   
}