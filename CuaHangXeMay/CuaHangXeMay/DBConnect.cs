using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using CuaHangXeMay.Properties;
namespace CuaHangXeMay
{
  class DBConnect
    {
        SqlConnection connect;

        public SqlConnection Connect
        {
            get { return connect; }
            set { connect = value; }
        }
        //static string strConnect = @"data source = LAPTOP-4UK5DRJR\SQLEXPRESS; initial catalog= Qly_CHXeGanMay; user id = sa; password= 123";
        static string strConnect = "data source = A204PC31; initial catalog= QL_CuaHangXeGanMayDB; Integrated Security = true";

        public static string StrConnect
        {
            get { return DBConnect.strConnect; }
            set { DBConnect.strConnect = value; }
        }
        public DBConnect()
        {
            connect = new SqlConnection(DBConnect.StrConnect);
        }
        public void open()
        {

            if (connect.State == ConnectionState.Closed)
                connect.Open();
        }
        public void close()
        {
            if (connect.State == ConnectionState.Open)

                connect.Close();
        }
        public void kiemtraketnoi()
        {
            open();
            if (connect.State == ConnectionState.Open)
            {
                MessageBox.Show("Kết nối thành công");
            }
            else
            {
                MessageBox.Show("Kết nối thất bại");
            }

        }
        public int getnonquery(string sql)
        {
            //b3 mo ket noi
            open();
            //buoc 4: khai bao sqlcommand
            SqlCommand cmd = new SqlCommand(sql, connect);
            //buoc 5 gọi thực thi
            int kq = cmd.ExecuteNonQuery();
            // buoc 6 đóng kết nối
            close();
            return kq;
        }
        public SqlDataReader getexcuteReader(string sql)
        {
            //b3 mo ket noi
            open();
            //buoc 4: khai bao sqlcommand
            SqlCommand cmd = new SqlCommand(sql, connect);
            //buoc 5 gọi thực thi
            SqlDataReader rd = cmd.ExecuteReader();
           // close();
            return rd;
            // buoc 6 đóng kết nối
           
        }
        public DataTable getDataset(string sql)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, connect);
            da.Fill(dt);
            return dt;
        }
        public void ClearAllTextBoxes(Control control)
        {
            foreach (Control ctrl in control.Controls)
            {
                if (ctrl is TextBox)
                {
                    ((TextBox)ctrl).Text = string.Empty;
                }
                else if (ctrl.HasChildren)
                {
                    ClearAllTextBoxes(ctrl);
                }
            }
        }
        public void onlyNumber(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
        }
        public void closefrom(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn đóng không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
                e.Cancel = true;
        }
        public  void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho phép nhập số
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        public object getScalar(string sql)
        {
            open();
            SqlCommand cmd = new SqlCommand(sql, connect);
            object kq = cmd.ExecuteScalar();
            close();
            return kq;
        }
       
      public DataTable getDatatable(string sql)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, connect);
            da.Fill(dt);
            return dt;
        }
      public int updateDatabase(DataTable dt, string sql)
      {
          SqlDataAdapter da_dtb = new SqlDataAdapter(sql, connect);
          SqlCommandBuilder cb = new SqlCommandBuilder(da_dtb);
          int kq = da_dtb.Update(dt);
          return kq;
      }
      public string GetFieldValues(string sql)
      {
          string ma = "";
          open();
          SqlCommand cmd = new SqlCommand(sql, connect);
          SqlDataReader reader;
          reader = cmd.ExecuteReader();
          while (reader.Read())
              ma = reader.GetValue(0).ToString();
          reader.Close();
          close();
          return ma;
      }
      public  string CreateKey(string tiento)
      {
          string key = tiento;
          string[] partsDay;
          partsDay = DateTime.Now.ToShortDateString().Split('/');
          //Ví dụ 07/08/2009
          string d = String.Format("{0}{1}{2}", partsDay[0], partsDay[1], partsDay[2]);
          key = key + d;
          string[] partsTime;
          partsTime = DateTime.Now.ToLongTimeString().Split(':');
          //Ví dụ 7:08:03 PM hoặc 7:08:03 AM

          if (partsTime.Length >= 3)
          {
              if (partsTime[2].Length >= 5 && partsTime[2].Substring(3, 2) == "PM")
                  partsTime[0] = ConvertTimeTo24(partsTime[0]);
              if (partsTime[2].Length >= 5 && partsTime[2].Substring(3, 2) == "AM")
                  if (partsTime[0].Length == 1)
                      partsTime[0] = "0" + partsTime[0];
              //Xóa ký tự trắng và PM hoặc AM
              if (partsTime[2].Length >= 5)
                  partsTime[2] = partsTime[2].Remove(2, 3);
          }

          string t;
          t = String.Format("_{0}{1}{2}", partsTime[0], partsTime[1], partsTime[2]);
          key = key + t;
          return key;

      }
      public string ConvertTimeTo24(string hour)
      {
          string h = "";
          switch (hour)
          {
              case "1":
                  h = "13";
                  break;
              case "2":
                  h = "14";
                  break;
              case "3":
                  h = "15";
                  break;
              case "4":
                  h = "16";
                  break;
              case "5":
                  h = "17";
                  break;
              case "6":
                  h = "18";
                  break;
              case "7":
                  h = "19";
                  break;
              case "8":
                  h = "20";
                  break;
              case "9":
                  h = "21";
                  break;
              case "10":
                  h = "22";
                  break;
              case "11":
                  h = "23";
                  break;
              case "12":
                  h = "0";
                  break;
          }
          return h;
      }
      public string taomatudong(string kytudau, string query)
      {
          string ma = string.Empty;
          object rdr = getScalar(query);
          if (rdr != null)
          {
              // Nếu có mã hóa đơn cuối cùng, tách số thứ tự và tăng giá trị đó lên 1
              string lastInvoiceNumber = rdr.ToString();
              int lastInvoiceNumberInt = int.Parse(lastInvoiceNumber.Replace(kytudau, ""));
              int nextInvoiceNumberInt = lastInvoiceNumberInt + 1;
              ma = kytudau + nextInvoiceNumberInt.ToString("D4");
          }
          else
          {
              // Nếu không có mã hóa đơn nào trong CSDL, tạo mã hóa đơn đầu tiên
              ma = kytudau + "0001";
          }
          return ma;
      }
     
public string ChuyenSoSangChu(string sNumber)
{
    int mLen, mDigit;
    string mTemp = "";
    string[] mNumText;
    //Xóa các dấu "," nếu có
    sNumber = sNumber.Replace(",", "");
    mNumText = "không;một;hai;ba;bốn;năm;sáu;bảy;tám;chín".Split(';');
    mLen = sNumber.Length - 1; // trừ 1 vì thứ tự đi từ 0
    for (int i = 0; i <= mLen; i++)
    {
        mDigit = Convert.ToInt32(sNumber.Substring(i, 1));
        mTemp = mTemp + " " + mNumText[mDigit];
        if (mLen == i) // Chữ số cuối cùng không cần xét tiếp break; 
            switch ((mLen - i) % 9)
            {
                case 0:
                    mTemp = mTemp + " tỷ";
                    if (mLen >= i + 3 && sNumber.Substring(i + 1, 3) == "000") i = i + 3;
                    if (mLen >= i + 3 && sNumber.Substring(i + 1, 3) == "000") i = i + 3;
                    if (mLen >= i + 3 && sNumber.Substring(i + 1, 3) == "000") i = i + 3;
                    break;
                case 6:
                    mTemp = mTemp + " triệu";
                    if (mLen >= i + 3 && sNumber.Substring(i + 1, 3) == "000") i = i + 3;
                    if (mLen >= i + 3 && sNumber.Substring(i + 1, 3) == "000") i = i + 3;
                    break;
                case 3:
                    mTemp = mTemp + " nghìn";
                    if (mLen >= i + 3 && sNumber.Substring(i + 1, 3) == "000") i = i + 3;
                    break;
                default:
                    switch ((mLen - i) % 3)
                    {
                        case 2:
                            mTemp = mTemp + " trăm";
                            break;
                        case 1:
                            mTemp = mTemp + " mươi";
                            break;
                    }
                    break;
            }
    }
    //Loại bỏ trường hợp x00
    mTemp = mTemp.Replace("không mươi không ", "");
    mTemp = mTemp.Replace("không mươi không", ""); //Loại bỏ trường hợp 00x 
    mTemp = mTemp.Replace("không mươi ", "linh "); //Loại bỏ trường hợp x0, x>=2
    mTemp = mTemp.Replace("mươi không", "mươi");
    //Fix trường hợp 10
    mTemp = mTemp.Replace("một mươi", "mười");
    //Fix trường hợp x4, x>=2
    mTemp = mTemp.Replace("mươi bốn", "mươi tư");
    //Fix trường hợp x04
    mTemp = mTemp.Replace("linh bốn", "linh tư");
    //Fix trường hợp x5, x>=2
    mTemp = mTemp.Replace("mươi năm", "mươi lăm");
    //Fix trường hợp x1, x>=2
    mTemp = mTemp.Replace("mươi một", "mươi mốt");
    //Fix trường hợp x15
    mTemp = mTemp.Replace("mười năm", "mười lăm");
    //Bỏ ký tự space
    mTemp = mTemp.Trim();
    //Viết hoa ký tự đầu tiên
    mTemp = mTemp.Substring(0, 1).ToUpper() + mTemp.Substring(1) + " đồng";
    return mTemp;
}


    }
}
