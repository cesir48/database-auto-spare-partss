﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltinYedek.DL
{
    public static class DataLayer
    {
        static MySqlConnection conn = new MySqlConnection(
            new MySqlConnectionStringBuilder()
            {
                Server = "***.*.*.*" ,
                Database = "altin_yedek",
                UserID = "****",
                Password = "*********",
            }.ConnectionString
            );


        public static int MüşteriEkle(Musteri m)
        {

            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("altin_MusteriEkle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", m.ID);
                komut.Parameters.AddWithValue("@ad", m.Ad);
                komut.Parameters.AddWithValue("@soy", m.Soyad);
                komut.Parameters.AddWithValue("@tel", m.Telefon);
                komut.Parameters.AddWithValue("@mail", m.Mail);
                komut.Parameters.AddWithValue("@adr", m.Adres);

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;  
 
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
             
        }

        internal static int SatisEkle(Satis s)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("altin_SatisEkle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@sid", s.ID);
                komut.Parameters.AddWithValue("@mid", s.MusteriID);
                komut.Parameters.AddWithValue("@uid", s.UrunID);
                komut.Parameters.AddWithValue("@tarih", s.Tarih);
                komut.Parameters.AddWithValue("@fiyat", s.Fiyat);
                

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static DataSet SatisDetay()
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("altin_SatisDetay", conn);
                
                    komut.CommandType = System.Data.CommandType.StoredProcedure;

                DataSet dataSet = new DataSet();
                MySqlDataAdapter adp = new MySqlDataAdapter(komut);
                adp.Fill(dataSet);
                return dataSet;
            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static int SatisGüncelle(Satis s)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("altin_SatisGuncelle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@sid", s.ID);
                komut.Parameters.AddWithValue("@mid", s.MusteriID);
                komut.Parameters.AddWithValue("@uid", s.UrunID);
                komut.Parameters.AddWithValue("@tarih", s.Tarih);
                komut.Parameters.AddWithValue("@fiyat", s.Fiyat);
                

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static int OdemeEkle(Odeme o)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("altin_OdemeEkle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@oid", o.ID);
                komut.Parameters.AddWithValue("@mid", o.MusteriID);
                komut.Parameters.AddWithValue("@tarih", o.Tarih);
                komut.Parameters.AddWithValue("@tutar", o.Tutar);
                komut.Parameters.AddWithValue("@tur", o.Tur);
                komut.Parameters.AddWithValue("@aciklama", o.Aciklama);

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static int OdemeGüncelle(Odeme o)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("altin_OdemeGuncelle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@oid", o.ID);
                komut.Parameters.AddWithValue("@mid", o.MusteriID);
                komut.Parameters.AddWithValue("@tarih", o.Tarih);
                komut.Parameters.AddWithValue("@tutar", o.Tutar);
                komut.Parameters.AddWithValue("@tur", o.Tur);
                komut.Parameters.AddWithValue("@aciklama", o.Aciklama);

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static int OdemeSil(string id)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("altin_OdemeSil", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@oid", id);


                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static DataSet OdemeDetay()
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("altin_OdemeDetay", conn);

                komut.CommandType = System.Data.CommandType.StoredProcedure;

                DataSet dataSet = new DataSet();
                MySqlDataAdapter adp = new MySqlDataAdapter(komut);
                adp.Fill(dataSet);
                return dataSet;
            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static int SatisSil(string id)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("altin_SatisSil", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", id);


                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static int MüşteriSil(string id)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("altin_MusteriSil", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id",id);
                

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static DataSet UrunGetir(string filtre)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut;
                if (string.IsNullOrEmpty(filtre))
                {
                    komut = new MySqlCommand("altin_UrunlerHepsi", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;

                }
                else
                {
                    komut = new MySqlCommand("altin_UrunBul", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                    komut.Parameters.AddWithValue("@filtre", filtre);
                }
                DataSet dataSet = new DataSet();
                MySqlDataAdapter adp = new MySqlDataAdapter(komut);
                adp.Fill(dataSet);
                return dataSet;
            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static int UrunSil(string id)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("altin_UrunSil", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", id);


                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static int UrunGüncelle(Urun u)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("altin_UrunGuncelle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", u.ID);
                komut.Parameters.AddWithValue("@ad", u.Ad);
                komut.Parameters.AddWithValue("@kategori", u.Kategori);
                komut.Parameters.AddWithValue("@fiyat", u.Fiyat);
                komut.Parameters.AddWithValue("@stok", u.Stok);
                komut.Parameters.AddWithValue("@birim", u.Birim);
                komut.Parameters.AddWithValue("@detay", u.Detay);

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static int UrunEkle(Urun u)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("altin_UrunEkle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", u.ID);
                komut.Parameters.AddWithValue("@ad", u.Ad);
                komut.Parameters.AddWithValue("@kategori", u.Kategori);
                komut.Parameters.AddWithValue("@fiyat", u.Fiyat);
                komut.Parameters.AddWithValue("@stok", u.Stok);
                komut.Parameters.AddWithValue("@birim", u.Birim);
                komut.Parameters.AddWithValue("@detay", u.Detay);

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static int MüşteriGüncelle(Musteri m)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("altin_MusteriGüncelle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", m.ID);
                komut.Parameters.AddWithValue("@ad", m.Ad);
                komut.Parameters.AddWithValue("@soy", m.Soyad);
                komut.Parameters.AddWithValue("@tel", m.Telefon);
                komut.Parameters.AddWithValue("@mail", m.Mail);
                komut.Parameters.AddWithValue("@adr", m.Adres);

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static DataSet MüşteriGetir(string filtre)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut;
                if (string.IsNullOrEmpty(filtre))
                {
                    komut = new MySqlCommand("altin_MusterilerHepsi", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                    
                }
                else
                {
                    komut = new MySqlCommand("altin_MusteriBul", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                    komut.Parameters.AddWithValue("@filtre", filtre);
                }
                DataSet dataSet = new DataSet();
                MySqlDataAdapter adp = new MySqlDataAdapter(komut);
                adp.Fill(dataSet);
                return dataSet;
            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }
    }
}
