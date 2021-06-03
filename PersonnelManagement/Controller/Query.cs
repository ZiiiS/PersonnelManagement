using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace PersonnelManagement.Controller
{
	class Query
	{
		OleDbConnection		connection;
		OleDbCommand		command;
		OleDbDataAdapter	dataAdapter;
		DataTable			bufferTable;

		public Query(string Conn)
		{
			connection = new OleDbConnection(Conn);
			bufferTable = new DataTable();
		}

		public DataTable UpdateTable(string NameTable = null)
		{
			connection.Open();
			dataAdapter = new OleDbDataAdapter($"SELECT * FROM {NameTable}", connection) ;
			bufferTable.Clear();
			dataAdapter.Fill(bufferTable);
			connection.Close();
			return bufferTable;

		}

		public void Delete(int ID)
		{
			connection.Open();
			command = new OleDbCommand($"DELETE FROM WHERE ID = {ID}", connection);
			command.ExecuteNonQuery();
			connection.Close();
		}
	}
}
