using System;
using Microsoft.Data.Sqlite;
using System.Collections.Generic;
using System.Linq;
using Dapper;


namespace SQLiteLoader
{
    public class Sqlader
    {
        public static List<getBiilmodel> getQuery()
        {
            
            using(SqliteConnection connect = new SqliteConnection("Data Source=ZiDataBase.db"))
            {
                var output = connect.Query<getBiilmodel>("SELECT * FROM faktury");
                return output.ToList();
            }
        }
        public static List<string> getValue(string field, string wherefield, string concret_item)
        {
            List<string> rValue = new List<string>();
            
            using (var connection = new SqliteConnection("Data Source=ZiDataBase.db"))
            {
                connection.Open();
                var command = connection.CreateCommand();
                if (int.TryParse(concret_item, out _))
                {
                    command.CommandText = $"SELECT {field} FROM faktury WHERE {wherefield} = {concret_item}";
                }
                else
                {
                    command.CommandText = $"SELECT {field} FROM faktury WHERE {wherefield} = '{concret_item}'";
                }
               
                



                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        rValue.Add(reader.GetString(0));
                    }
                    
                }
                return rValue;
            }
            
            
            
        }
        public static List<string> getColumn(string field)
        {
            List<string> rValue = new List<string>();

            using (SqliteConnection connection = new SqliteConnection("Data Source=ZiDataBase.db;"))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText =
                    @$"
                        SELECT {field}
                        FROM faktury
                        
                       ";
                
                
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        rValue.Add(reader.GetString(0));
                    }
                }
                return rValue;
            }
        }
        public static List<string> getColumnSort(string field,string sortby, string asc="ASC")
        {
            List<string> rValue = new List<string>();

            using (SqliteConnection connection = new SqliteConnection("Data Source=ZiDataBase.db;"))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText =
                    @$"
                        SELECT {field}
                        FROM faktury
                        ORDER BY {sortby} {asc}
                        
                       ";


                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        rValue.Add(reader.GetString(0));
                    }
                }
                return rValue;
            }
        }
        public static void SaveBill(BillModel bill)
        {
            using( var connection = new SqliteConnection("Data Source=ZiDataBase.db"))
            {
                connection.Open();
                SqliteCommand insertsql = new SqliteCommand(@"INSERT INTO faktury (Dokument,Imie,Nazwisko,NIP,Adres,Kod_pocztowy,Miasto,Data_wystawienia,Data_sprzedazy,Netto,Vat,Brutto,Sposob_platnosci, Kraj) 
                                                              values ($Document,$First,$Last,$nip,$address,$postcode,$city,$dateofissue,$dateofsale,$netto,$vat,$brutto,$payme,$country)", connection);
                insertsql.Parameters.AddWithValue("$Document",bill.Document);
                insertsql.Parameters.AddWithValue("$First",bill.FirstName);
                insertsql.Parameters.AddWithValue("$Last",bill.LastName);
                insertsql.Parameters.AddWithValue("$nip",bill.NIP);
                insertsql.Parameters.AddWithValue("$address",bill.Address);
                insertsql.Parameters.AddWithValue("$postcode",bill.Postcode);
                insertsql.Parameters.AddWithValue("$city",bill.City);
                insertsql.Parameters.AddWithValue("$dateofissue", bill.dateofissue);
                insertsql.Parameters.AddWithValue("$dateofsale",bill.dateofsale);
                insertsql.Parameters.AddWithValue("$netto",bill.Netto.ToString());
                insertsql.Parameters.AddWithValue("$vat",bill.Vat.ToString());
                insertsql.Parameters.AddWithValue("$brutto",bill.Brutto.ToString());
                insertsql.Parameters.AddWithValue("$payme",bill.Payment);
                insertsql.Parameters.AddWithValue("$country",bill.Country);
                try
                {
                    insertsql.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                    throw new Exception(ex.Message);
                }


            }
        }
        public static void SaveBillv2(getBiilmodel bill)
        {
            using (var connection = new SqliteConnection("Data Source=ZiDataBase.db"))
            {
                connection.Open();
                SqliteCommand insertsql = new SqliteCommand(@"INSERT INTO faktury (Dokument,Imie,Nazwisko,NIP,Adres,Kod_pocztowy,Miasto,Data_wystawienia,Data_sprzedazy,Netto,Vat,Brutto,Sposob_platnosci, Kraj) 
                                                              values ($Document,$First,$Last,$nip,$address,$postcode,$city,$dateofissue,$dateofsale,$netto,$vat,$brutto,$payme,$country)", connection);
                insertsql.Parameters.AddWithValue("$Document", bill.Dokument);
                insertsql.Parameters.AddWithValue("$First", bill.Imie);
                insertsql.Parameters.AddWithValue("$Last", bill.Nazwisko);
                insertsql.Parameters.AddWithValue("$nip", bill.NIP);
                insertsql.Parameters.AddWithValue("$address", bill.Adres);
                insertsql.Parameters.AddWithValue("$postcode", bill.Kod_pocztowy);
                insertsql.Parameters.AddWithValue("$city", bill.Miasto);
                insertsql.Parameters.AddWithValue("$dateofissue", bill.Data_wystawienia);
                insertsql.Parameters.AddWithValue("$dateofsale", bill.Data_sprzedazy);
                insertsql.Parameters.AddWithValue("$netto", bill.Netto.ToString());
                insertsql.Parameters.AddWithValue("$vat", bill.Vat.ToString());
                insertsql.Parameters.AddWithValue("$brutto", bill.Brutto.ToString());
                insertsql.Parameters.AddWithValue("$payme", bill.Sposob_platonosci);
                insertsql.Parameters.AddWithValue("$country", bill.Kraj);
                try
                {
                    insertsql.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                    throw new Exception(ex.Message);
                }


            }
        }

    }
}
