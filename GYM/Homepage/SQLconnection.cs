using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Step 1
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Homepage
{
    class SQLconnection
    {
        public static SqlConnection Connection()
        {
            // Connection String
            string str = @"Data Source=DESKTOP-85497MC\SQLEXPRESS02;Initial Catalog=GYM;Integrated Security=True;";

            // SqlConnection --> Object Create
            SqlConnection connection = new SqlConnection(str);

            try
            {
                connection.Open();
                //MessageBox.Show("Connected Successfully ...");
            }
            catch (SqlException)
            {
                MessageBox.Show("Connection to DB Failed!!!");
            }

            // Return Connection
            return connection;
        }




        //queries----->



        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //Queries Related to members

        public static void Add_new_member(Member m1)
        {
            //member save
            SqlConnection connection = Connection();
            string qry = "INSERT INTO MEMBER(MemberID, MemberName, Gender,DateOfJoining, Add_ress, Contactno, Weigh , HeightFT, HeightIN,FatherName,Purpose,Admissionfee,Category)VALUES('" + m1.Memberid + "','" + m1.Name + "','" + m1.Gender + "','" + m1.Dateof_joining + "','" + m1.Address + "','" + m1.Contact + "','" + m1.Weight + "','" + m1.Height_Ft + "','" + m1.Height_IN + "','" + m1.Father_name + "','" + m1.Purpose + "','" + m1.Admission_fee + "','" + m1.Category + "')";
            SqlCommand command = new SqlCommand(qry, connection);
            command.CommandType = CommandType.Text;

            try
            {
                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Record can not be added!!!");
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connection.Close();
            }
        }

        //gym no existence check
        public static object Memberid_chk(Member m1)
        {
            
            //gymno already exist check
            SqlConnection connection = Connection();
            string qry_chk_memberid = "SELECT MemberID FROM MEMBER WHERE MemberID = '" + m1.Memberid + "'";
            SqlCommand command1 = new SqlCommand(qry_chk_memberid, connection);
            //try
            //{
               object result = command1.ExecuteScalar();
            //}
            //catch (SqlException ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}
            //finally
            //{
                connection.Close();
            //}
            return result;
        }

        public static void del_member_record(Member m1)
        {
            //member deletion
            SqlConnection connection = Connection();
            string qry_delmember = "DELETE FROM MEMBER WHERE MemberID = @memberid";
            SqlCommand command1 = new SqlCommand(qry_delmember, connection);
            command1.Parameters.AddWithValue("@memberid", m1.Memberid);
            command1.CommandType = CommandType.Text;
            try
            {
                command1.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connection.Close();
            }
        }








        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //Queries Related to purchased packages
        public static void Add_member_purchased_package(Purchased_package p1)
        {
            //package save
            SqlConnection Connection = SQLconnection.Connection();
            string qryfillstd = "SELECT PackageID FROM PACKAGE_LINE WHERE PackageName = '" + p1.Packagename + "'";
            SqlCommand command2 = new SqlCommand(qryfillstd, Connection);
            try
            {
                SqlDataReader read1;
                read1 = command2.ExecuteReader();
                command2.CommandType = CommandType.Text;
                while (read1.Read())
                {
                    int packageselected = (int)read1.GetValue(0);
                    SqlConnection c1 = SQLconnection.Connection();
                    string qryfillpkg = "INSERT INTO PACKAGE(MemberID,PackageID) VALUES('" + p1.Memberid + "','" + packageselected + "') ";
                    SqlCommand command3 = new SqlCommand(qryfillpkg, c1);
                    command3.CommandType = CommandType.Text;
                    try
                    {
                        command3.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    finally
                    {
                        c1.Close();
                    }

                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                Connection.Close();
            }
        }










        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //Queries Related to Packageline


        //fetch student packages
        public static SqlDataReader fetch_student_packsges()
        {
            SqlConnection connection = Connection();
            string qryfillnonstd = "SELECT PackageName FROM PACKAGE_LINE WHERE kategory = 'Student'";
            SqlCommand command = new SqlCommand(qryfillnonstd, connection);
            command.CommandType = CommandType.Text;
            //try
            //{
            SqlDataReader cat_nonstd;
            cat_nonstd = command.ExecuteReader();
            //}
            //catch (SqlException ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}
            //finally
            //{
            // connection.Close();
            //}
            return cat_nonstd;
        }


        //fetch non student packages
        public static SqlDataReader fetch_nonstudent_packsges()
        {
            SqlConnection connection = Connection();
            string qryfillnonstd = "SELECT PackageName FROM PACKAGE_LINE WHERE kategory = 'Non Student'";
            SqlCommand command = new SqlCommand(qryfillnonstd, connection);
            command.CommandType = CommandType.Text;
            //try
            //{
            SqlDataReader cat_nonstd;
            cat_nonstd = command.ExecuteReader();
            //}
            //catch (SqlException ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}
            //finally
            //{
               // connection.Close();
            //}
            return cat_nonstd;
        }




        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //Queries Related to purchased packages and members
        public static SqlDataAdapter fetch_all_member_n_purchased_package()
        {

            SqlConnection connection = Connection();
            string qry_getmember = "SELECT MEMBER.MemberID,MEMBER.Category,MEMBER.MemberName,MEMBER.FatherName,MEMBER.Contactno,MEMBER.Add_ress,MEMBER.DateOfJoining,MEMBER.Gender,MEMBER.Admissionfee,MEMBER.Purpose,MEMBER.Weigh,MEMBER.HeightFT,MEMBER.HeightIN,PACKAGE_LINE.PackageName FROM ((MEMBER FULL OUTER JOIN PACKAGE ON MEMBER.MemberID = PACKAGE.MemberID) LEFT JOIN PACKAGE_LINE ON PACKAGE_LINE.PackageID = PACKAGE.PackageID)";
            SqlCommand command = new SqlCommand(qry_getmember, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            command.CommandType = CommandType.Text;
            try
            {
                DataTable d1 = new DataTable();
                adapter.Fill(d1);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connection.Close();
            }
            return adapter;
        }

        public static SqlDataAdapter serch_member_all_data_byName(Member m1)
        {
            //search gym member by name
            string membername;
            membername = m1.Name;
            SqlConnection connection = Connection();
            string qry_chk_memberid = "SELECT MEMBER.MemberID,MEMBER.Category,MEMBER.MemberName,MEMBER.FatherName,MEMBER.Contactno,MEMBER.Add_ress,MEMBER.DateOfJoining,MEMBER.Gender,MEMBER.Admissionfee,MEMBER.Purpose,MEMBER.Weigh,MEMBER.HeightFT,MEMBER.HeightIN,PACKAGE.PackageID FROM MEMBER FULL OUTER JOIN PACKAGE ON MEMBER.MemberID = PACKAGE.MemberID WHERE MEMBER.MemberName LIKE @membername ORDER BY MEMBER.MemberName";
            SqlCommand command = new SqlCommand(qry_chk_memberid, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            command.Parameters.AddWithValue("@membername", "%" + membername + "%");
            command.CommandType = CommandType.Text;

            try
            {
                DataSet d1 = new DataSet();
                adapter.Fill(d1);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connection.Close();
            }
            return adapter;
        }
        public static SqlDataAdapter serch_member_all_data_byGymno(Member m1)
        {
            //search gym member by gym no
            int memberid;
            memberid = m1.Memberid;
            SqlConnection connection = Connection();
            string qry_chk_memberid = "SELECT MEMBER.MemberID,MEMBER.Category,MEMBER.MemberName,MEMBER.FatherName,MEMBER.Contactno,MEMBER.Add_ress,MEMBER.DateOfJoining,MEMBER.Gender,MEMBER.Admissionfee,MEMBER.Purpose,MEMBER.Weigh,MEMBER.HeightFT,MEMBER.HeightIN,PACKAGE.PackageID FROM MEMBER FULL OUTER JOIN PACKAGE ON MEMBER.MemberID = PACKAGE.MemberID WHERE MEMBER.MemberID = @memberid ORDER BY MEMBER.MemberID";
            SqlCommand command = new SqlCommand(qry_chk_memberid, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            command.Parameters.AddWithValue("@memberid", memberid);
            command.CommandType = CommandType.Text;

            try
            {
                DataTable d1 = new DataTable();
                adapter.Fill(d1);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connection.Close();
            }
            return adapter;
        }

        public static void del_member_pkg(Member m1)
        {
            //member package deletion
            SqlConnection connection = Connection();
            string qry_delmemberpkg = "DELETE FROM PACKAGE WHERE MemberID = @memberid";
            SqlCommand command0 = new SqlCommand(qry_delmemberpkg, connection);
            command0.Parameters.AddWithValue("@memberid", m1.Memberid);
            command0.CommandType = CommandType.Text;
            try
            {
                command0.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connection.Close();
            }
        }

        public static SqlDataReader fetch_unique_member_n_purchased_package(Member m1)
        {

            SqlConnection connection = Connection();
            string qry_getmember = "SELECT MEMBER.MemberID,MEMBER.Category,MEMBER.MemberName,MEMBER.FatherName,MEMBER.Contactno,MEMBER.Add_ress,MEMBER.DateOfJoining,MEMBER.Gender,MEMBER.Admissionfee,MEMBER.Purpose,MEMBER.Weigh,MEMBER.HeightFT,MEMBER.HeightIN,PACKAGE_LINE.PackageName,PACKAGE_LINE.Price FROM ((MEMBER FULL OUTER JOIN PACKAGE ON MEMBER.MemberID = PACKAGE.MemberID) LEFT JOIN PACKAGE_LINE ON PACKAGE_LINE.PackageID = PACKAGE.PackageID) WHERE MEMBER.MemberID = @memberid";
            SqlCommand command = new SqlCommand(qry_getmember, connection);
            command.Parameters.AddWithValue("@memberid", m1.Memberid);
            command.CommandType = CommandType.Text;
            //try
            //{
                SqlDataReader read;
                read = command.ExecuteReader();
            //}
            //catch (SqlException ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}
            //finally
            //{
            //    connection.Close();
            //}
            return read;
        }


        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //Queries Related to PackageLine
        public static void save_package_line_record(Package_line p1)
        {
            SqlConnection konnection = Connection();
            string qry = "INSERT INTO PACKAGE_LINE(PackageName,Duration,Price,kategory) VALUES ('" + p1.Package_name + "','" + p1.Duration + "','" + p1.Price + "','" + p1.Category + "') ";
            SqlCommand command = new SqlCommand(qry, konnection);
            command.CommandType = CommandType.Text;

            try
            {
                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Record can not be added!!!");
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                konnection.Close();
            }
        }

        public static SqlDataAdapter fetch_all_packages()
        {
            SqlConnection connection = Connection();
            string qry_getpackage = "SELECT PACKAGE_LINE.PackageName,PACKAGE_LINE.Price,PACKAGE_LINE.kategory,PACKAGE_LINE.Duration FROM PACKAGE_LINE ORDER BY kategory";
            SqlCommand command = new SqlCommand(qry_getpackage, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            command.CommandType = CommandType.Text;
            try
            {
                DataTable d2 = new DataTable();
                adapter.Fill(d2);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connection.Close();
            }
            return adapter;
        }

        public static SqlDataAdapter fetch_pkg_by_name(Package_line p1)
        {
            //search package by name
            string pkgname = p1.Package_name;
            SqlConnection connection = Connection();
            string qry_chk_pkgid = "SELECT * FROM PACKAGE_LINE WHERE PackageName LIKE @pkgname";
            SqlCommand command = new SqlCommand(qry_chk_pkgid, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            command.Parameters.AddWithValue("@pkgname", "%" + pkgname + "%");
            command.CommandType = CommandType.Text;

            try
            {
                DataTable d2 = new DataTable();
                adapter.Fill(d2);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connection.Close();
            }
            return adapter;
        }


        public static SqlDataAdapter fetch_pkg_by_price(Package_line p1)
        {
            //search package by price
            double min = p1.Minprice;
            double max = p1.Maxprice;
            SqlConnection connection = Connection();
            string qry_chk_pkgid = "SELECT * FROM PACKAGE_LINE WHERE Price BETWEEN @min AND @max ORDER BY Price";
            SqlCommand command = new SqlCommand(qry_chk_pkgid, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            command.Parameters.AddWithValue("@min", min);
            command.Parameters.AddWithValue("@max", max);
            command.CommandType = CommandType.Text;

            try
            {
                DataTable d2 = new DataTable();
                adapter.Fill(d2);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connection.Close();
            }
            return adapter;
        }

        public static SqlDataReader count_pakages_by_price(Package_line p1)
        {
            //count all packages by price
            double Min = p1.Minprice;
            double Max = p1.Maxprice;
            SqlConnection konnection = Connection();
            string qry = "SELECT COUNT(PackageID) FROM PACKAGE_LINE WHERE Price BETWEEN @Min AND @Max ";
            SqlCommand command = new SqlCommand(qry, konnection);
            command.Parameters.AddWithValue("@Min", Min);
            command.Parameters.AddWithValue("@Max", Max);
            //try
            //{
                SqlDataReader read;
                read = command.ExecuteReader();
            //}
            //catch (SqlException ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}
            //finally
            //{
            //    konnection.Close();
            //}
            return read;
        }

        public static void delete_packageline_record(Package_line p1)
        {
            //package deletion
            SqlConnection connection = Connection();
            string qry_delmemberpkg = "DELETE FROM PACKAGE_LINE WHERE PackageName LIKE @packagename";
            SqlCommand command0 = new SqlCommand(qry_delmemberpkg, connection);
            command0.Parameters.AddWithValue("@packagename", p1.Package_name);
            command0.CommandType = CommandType.Text;
            try
            {
                command0.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }

            finally
            {
                connection.Close();
            }
        }

        public static SqlDataAdapter srch_pkg_by_category(Package_line p1)
        {
            SqlConnection connection = Connection();
            string qry_getpackage = "SELECT PACKAGE_LINE.PackageName,PACKAGE_LINE.Price,PACKAGE_LINE.kategory,PACKAGE_LINE.Duration FROM PACKAGE_LINE WHERE kategory='" + p1.Category + "'";
            SqlCommand command = new SqlCommand(qry_getpackage, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            command.CommandType = CommandType.Text;
            try
            {
                DataTable d2 = new DataTable();
                adapter.Fill(d2);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connection.Close();
            }
            return adapter;
        }

        public static SqlDataReader count_student_pkg(Package_line p1)
        {
            //count all packages
            SqlConnection konnection = Connection();
            string qry = "SELECT COUNT(PackageID) FROM PACKAGE_LINE WHERE kategory ='" + p1.Category + "'";
            SqlCommand command1 = new SqlCommand(qry, konnection);
            //try
            //{
                SqlDataReader read;
                read = command1.ExecuteReader();
            //}
            //catch (SqlException ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}
            //finally
            //{
            //    konnection.Close();
            //}
            return read;
        }




        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //Queries Related to fee,member,pakage line
        
        public static SqlDataReader fetch_old_fee_record_of_gym(Member m1)
        {
            SqlConnection connection = Connection();
            string qry = "SELECT FEE.FeeID,PACKAGE_LINE.PackageID,PACKAGE_LINE.Duration,PACKAGE_LINE.Price,FEE.Remaining_dues FROM (((FEE LEFT OUTER JOIN MEMBER ON FEE.MemberID=MEMBER.MemberID) LEFT OUTER JOIN PACKAGE ON PACKAGE.MemberID=MEMBER.MemberID) LEFT OUTER JOIN PACKAGE_LINE ON PACKAGE_LINE.PackageID=PACKAGE.PackageID) WHERE FEE.MemberID = '" + m1.Memberid + "'";
            SqlCommand command = new SqlCommand(qry, connection); SqlCommand command1 = new SqlCommand(qry, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            //try
            //{

                SqlDataReader read;
                read = command.ExecuteReader();
            //}
            //catch (SqlException)
            //{
            //    MessageBox.Show("Enter correct value!!!");
            //}
            //finally
            //{
            //    connection.Close();
            //}
            return read;
        }








        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //Queries Related to fee

        public static void fee_transaction(Fee f1)
        {
            //all conditions true fee transaction
            SqlConnection konnection = Connection();
            string qry = "INSERT INTO FEE VALUES( '" + f1.Memberid + "','" + f1.Date_paid + "','" + f1.Amount_paid + "','" + f1.Served_by + "','" + f1.Amount_due + "')";
            SqlCommand command = new SqlCommand(qry, konnection);
            command.CommandType = CommandType.Text;
            try
            {
                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                konnection.Close();
            }
        }


        public static SqlDataAdapter fetch_fee_record()
        {
            SqlConnection connection = Connection();
            string qry_getmember = "SELECT FEE.MemberID,FEE.Date_fee_paid,FEE.Amount_paid,FEE.Remaining_dues,PACKAGE_LINE.PackageName,PACKAGE_LINE.Duration,FEE.Served_by,FEE.FeeID FROM ((FEE LEFT OUTER JOIN PACKAGE ON FEE.MemberID = PACKAGE.MemberID) LEFT OUTER JOIN PACKAGE_LINE ON PACKAGE_LINE.PackageID=PACKAGE.PackageID) ORDER BY FEE.Date_fee_paid DESC";
            SqlCommand command = new SqlCommand(qry_getmember, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            command.CommandType = CommandType.Text;
            try
            {
                DataTable d1 = new DataTable();
                adapter.Fill(d1);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connection.Close();
            }
            return adapter;
        }

        public static SqlDataAdapter fetch_fee_record_by_gymno(Fee f1)
        {
            //search fee record by gym no

            int memberid;
            memberid = f1.Memberid;
            SqlConnection connection = Connection();
            string qry = "SELECT FEE.MemberID,FEE.Date_fee_paid,FEE.Amount_paid,FEE.Remaining_dues,PACKAGE_LINE.PackageName,PACKAGE_LINE.Duration,FEE.Served_by,FEE.FeeID FROM ((FEE LEFT OUTER JOIN PACKAGE ON FEE.MemberID = PACKAGE.MemberID) LEFT OUTER JOIN PACKAGE_LINE ON PACKAGE_LINE.PackageID=PACKAGE.PackageID) WHERE FEE.MemberID = @memberid ORDER BY FEE.Date_fee_paid";
            SqlCommand command = new SqlCommand(qry, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            command.Parameters.AddWithValue("@memberid", memberid);
            command.CommandType = CommandType.Text;

            try
            {
                DataTable d1 = new DataTable();
                adapter.Fill(d1);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connection.Close();
            }
            return adapter;
        }

        public static SqlDataReader calculate_Netincome()
        {
            //count net income
            SqlConnection connection = Connection();
            string qry = "SELECT SUM(Amount_paid) FROM FEE";
            SqlCommand command = new SqlCommand(qry, connection);
            //try
            //{
                SqlDataReader read;
                read = command.ExecuteReader();
            //}
            //catch (SqlException ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}
            //finally
            //{
            //    connection.Close();
            //}
            return read;
        }


        public static SqlDataReader net_remaining_dues()
        {
            //count net due fee
            SqlConnection connection = Connection();
            string qry = "SELECT SUM(Remaining_dues) FROM FEE";
            SqlCommand command = new SqlCommand(qry, connection);
            //try
            //{
                SqlDataReader read;
                read = command.ExecuteReader();
            //}
            //catch (SqlException ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}
            //finally
            //{
            //    connection.Close();
            //}
            return read;
        }


        public static SqlDataAdapter search_fee_record_by_date(Fee f1)
        {
            //search fee record by date
            SqlConnection connection = Connection();
            string qry = "SELECT FEE.MemberID,FEE.Date_fee_paid,FEE.Amount_paid,FEE.Remaining_dues,PACKAGE_LINE.PackageName,PACKAGE_LINE.Duration,FEE.Served_by,FEE.FeeID FROM ((FEE LEFT OUTER JOIN PACKAGE ON FEE.MemberID = PACKAGE.MemberID) LEFT OUTER JOIN PACKAGE_LINE ON PACKAGE_LINE.PackageID=PACKAGE.PackageID) WHERE FEE.Date_fee_paid BETWEEN '" + f1.Date_paid_first + "' AND '" + f1.Date_paid_last + "' ORDER BY FEE.Date_fee_paid";
            SqlCommand command = new SqlCommand(qry, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            command.CommandType = CommandType.Text;

            try
            {
                DataTable d1 = new DataTable();
                adapter.Fill(d1);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connection.Close();
            }
            return adapter;
        }



        public static void delete_fee_record(Fee f1)
        {
            //package deletion
            SqlConnection connection = Connection();
            string qry_delmemberpkg = "DELETE FROM FEE WHERE MemberID = @memberid";
            SqlCommand command0 = new SqlCommand(qry_delmemberpkg, connection);
            command0.Parameters.AddWithValue("@memberid", f1.Memberid);
            command0.CommandType = CommandType.Text;
            try
            {
                command0.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }

            finally
            {
                connection.Close();
            }
        }

    }
}
