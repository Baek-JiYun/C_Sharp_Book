# ๐ C# ๋์๊ด๋ฆฌ ํ๋ก๊ทธ๋จ
- <b>Language</b> : <img alt="C#" src="https://img.shields.io/badge/C%23-239120?style=flat-square&logo=c-sharp&logoColor=white"/>
- <b>Database</b> : <img alt="MSSQL" src ="https://img.shields.io/badge/MsSQL-CC2927?style=flat-square&logo=microsoft SQL Server&logoColor=white" />
- <b>Tool</b> : <img alt="Visual Studio" src="https://img.shields.io/badge/Visual Studio-5C2D91?style=flat-square&logo=Visual Studio&logoColor=white"/>
- ๋์๊ด๋ฆฌ๋ฅผ ๋ชฉ์ ์ผ๋ก ํ์์ต๋๋ค.

<br>

## ๐ ์ ์๊ธฐ๊ฐ ๋ฐ ๊ฐ๋ฐ ์ธ์
- ๊ธฐ๊ฐ : 2022.02 ~ 2022.02 (์ฝ 1์ฃผ)
- ์ธ์ : 1๋ช ( ๊ฐ์ธ ํ๋ก์ ํธ )

<br>

## ๐ ์ฃผ์ ๊ธฐ๋ฅ

### ๐ธ ๋ฉ์ธํ๋ฉด
- ์ ์ฒด์ ์ธ ๋์ ๋ชฉ๋ก๊ณผ ์ฌ์ฉ์ ๋ชฉ๋ก์ ํ์ธํ  ์ ์์ต๋๋ค.
- <b>๋์ฌ / ๋ฐ๋ฉ</b> : ๋์ฌ์ค์ธ ์ฑ์ isBorrowed๊ฐ 1๋ก ํ๊ธฐ๋๋ฉฐ, ๋น๋ ค๊ฐ ์๊ฐ๊ณผ ID๊ฐ ์ ์ฅ๋ฉ๋๋ค.
- ๋์ฌํ๋ ค๋ ์ฑ์ isBorrowed๊ฐ 1์ด๋ผ๋ฉด ๋์ฌ๊ฐ ๋ถ๊ฐ๋ฅํฉ๋๋ค.
- <b>๋์ ๊ฒ์</b> : ์ ๋ชฉ์ ๋น๊ตํด ์ ๋ณด๋ฅผ ๋ถ๋ฌ์ต๋๋ค. reset๋ฒํผ์ ๋๋ฅด๋ฉด ๋ค์ ์ ์ฒด๋ชฉ๋ก์ผ๋ก ๋ฐ๋๋๋ค.
- <b>๋์ ๋ฐ ์ฌ์ฉ์ ๊ด๋ฆฌ</b> : ํ๋ก๊ทธ๋จ ์ผ์ชฝ ๋ฒํผ์ผ๋ก ๋์๊ด๋ฆฌ์ ์ฌ์ฉ์๊ด๋ฆฌ ํผ์ผ๋ก ์ด๋๋ฉ๋๋ค.

<img src="img/main.PNG" width="560" height="360" >


<img src="img/search.PNG" width="560" height="360" >

<details>
<summary>์ฝ๋๋ณด๊ธฐ</summary>
<div markdown="1">
  
```C#
  
//
private void button_search_Click(object sender, EventArgs e)
{ 
    bool chkBook = false;
    if (textBox_search.Text.Trim() == "")
        MessageBox.Show("๋์ ์ ๋ชฉ์ ์๋ ฅํ์ธ์.");
    else
    {
        string[] search_book = textBox_search.Text.Split(' '); //๊ณต๋ฐฑ๊ธฐ์ค์ผ๋ก ๋จ์ด ๋๋
        string search_book_Name=search_book[0].Trim(); // ์ฒซ๋ฒ์งธ ๋จ์ด ๊ณต๋ฐฑ์ ๊ฑฐ ํ ์ ์ฅ

        for(int i=0; i < DataManager.Books.Count; i++)
        {
             if(DataManager.Books[i].Name.Contains(search_book_Name)) //์ฑ ์ ๋ชฉ์ search_book_Name๊ฐ ํฌํจ๋์ด์๋ค๋ฉด ์คํ
             {
                  DataManager.BookSearch(search_book_Name);
                  chkBook = true;
             }
        }
        if (chkBook==false)
        {
             MessageBox.Show("์กฐํ๋ ๋์๊ฐ ์์ต๋๋ค.");
        }
        else
        {
             dataGridView_bookManager.DataSource = null;
             if (DataManager.Books.Count > 0)
                 dataGridView_bookManager.DataSource = DataManager.Books;
        }
    }
}
  
//DataManager.cs
public static void BookSearch(string search_book_Name)
{
   try
   {
     DBHelper.BookSearch(search_book_Name);
     Books.Clear();
     foreach (DataRow item in DBHelper.ds.Tables[0].Rows)
     {
        Book book = new Book();
        book.Isbn = item["Isbn"].ToString();
        book.Name = item["name"].ToString();
        book.Publisher = item["Publisher"].ToString();
        book.Page = int.Parse(item["Page"].ToString());
        book.UserId = item["UserId"].ToString();
        book.isBorrowed = int.Parse(item["isBorrowed"].ToString());
        book.BorrowedAt = item["BorrowedAt"].ToString() == "" ? new DateTime() : DateTime.Parse(item["BorrowedAt"].ToString());
        Books.Add(book);
      }
    }
    catch (Exception ex)
    {
      System.Windows.Forms.MessageBox.Show(ex.Message + Environment.NewLine + ex.StackTrace);
    }
}
  
//DBHelper.cs
public static void BookSearch(string search_book)
{
   try
   {
     ConnectDB();

      SqlCommand cmd = new SqlCommand();
      cmd.Connection = conn;
      cmd.CommandText = "select * from BookManager where Name like '%" + search_book + "%'";

      da = new SqlDataAdapter(cmd);
      ds = new DataSet();
      da.Fill(ds, "BookManager");
      dt = ds.Tables[0];

      conn.Close();
    }
    catch (Exception ex)
   {
      conn.Close();
      System.Windows.Forms.MessageBox.Show(ex.Message);
    }
}
  
//์๋ก๊ณ ์นจ
private void button_reset_Click(object sender, EventArgs e)
{
    ReLoad();
}
private void ReLoad()
{
    DataManager.Load();
    dataGridView_bookManager.DataSource = null;
    if (DataManager.Books.Count > 0)
        dataGridView_bookManager.DataSource = DataManager.Books;

        dataGridView_user.DataSource = null;
    if (DataManager.Users.Count > 0)
         dataGridView_user.DataSource = DataManager.Users;
}
  
```
  
</div>
</details>
  
<details>
<summary>๋์ฌ / ๋ฐ๋ฉ </summary>
<div markdown="1">
  
```C#
  
//๋์ฌ
private void button_Borrow_Click(object sender, EventArgs e)
{
    if (textBox_Isbn.Text.Trim() == "")
        MessageBox.Show("Isbn์ ์๋ ฅํ์ธ์.");
    else if (textBox_userId.Text.Trim()=="")
        MessageBox.Show("์ฌ์ฉ์ Id๋ฅผ ์๋ ฅํ์ธ์.");
    else
    {
        try
        {
            Book book = DataManager.Books.Single((x) => x.Isbn == textBox_Isbn.Text);
            if (book.isBorrowed == 0) //๋์ฌ ๊ฐ๋ฅ
            {
                User user = DataManager.Users.Single((x) => x.UserId.ToString() == textBox_userId.Text);
                book.Isbn = textBox_Isbn.Text;
                book.UserId = user.UserId;
                book.isBorrowed = 1;

                DataManager.Save(book.Isbn, book.UserId, book.isBorrowed);
                MessageBox.Show($"{user.Name}๋๊ป ์ ์ ๋์ฌ๋์์ต๋๋ค.");
  
                ReLoad();
            }
            else
            {
                MessageBox.Show("ํ์ฌ ๋์ฌ์ค์ธ ๋์์๋๋ค.");
            }
        }
        catch (Exception)
        {
            MessageBox.Show("์กด์ฌํ์ง ์๋ ๋์ ํน์ ์ฌ์ฉ์์๋๋ค.");
        }
    }
}
  
//๋ฐ๋ฉ
private void button_Return_Click(object sender, EventArgs e)
{
    if (textBox_Isbn.Text.Trim() == "")
        MessageBox.Show("isbn์ ์๋ ฅํ์ธ์.");
    else
    {
        try
        {
            Book book = DataManager.Books.Single((x) => x.Isbn == textBox_Isbn.Text);
            if (book.isBorrowed == 1) // ๋์ฌ๋ ์ํ
            {
                DateTime date = book.BorrowedAt;
                book.Isbn = textBox_Isbn.Text;
                book.isBorrowed=0;

                DataManager.Save(book.Isbn, "", book.isBorrowed);
                        
                TimeSpan timeDiff = DateTime.Now - date;
                if(timeDiff.Days > 7)
                {
                    MessageBox.Show(timeDiff.Days+"์ผ ์ฐ์ฒด๋ ๋์์๋๋ค.");
                }
                else
                {
                    MessageBox.Show("์ ์๋ฐ๋ฉ ๋์์ต๋๋ค.");

                    ReLoad();
                }
            }
            else
            {
               MessageBox.Show("๋์ฌ ์ํ๊ฐ ์๋๋๋ค.\n๋ค์ ํ์ธํด์ฃผ์ธ์.");
            }
        }
        catch (Exception)
        {
            MessageBox.Show("Isbn์ ๋ค์ ํ์ธํด์ฃผ์ธ์.");
        }
    }
}
  
//DataManager
public static void Save(string isbn, string userId, int isBorrowed)
{
    try
    {
        DBHelper.updateBorrowQuery(isbn, userId, isBorrowed);
    }
    catch (Exception exception)
    {
        System.Windows.Forms.MessageBox.Show(exception.Message + Environment.NewLine + exception.StackTrace);
    }
}
  
//DBHelper
public static void updateBorrowQuery(string isbn, string userId, int isBorrowed)
{
    try
    {
        ConnectDB();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = conn;
        cmd.CommandType = CommandType.Text;

        string sqlcommand;
        if (isBorrowed == 1) // ๋์ด์จ isBorrowed๊ฐ์ด 1์ด๋ผ๋ฉด ๋์ฌ
        {
            sqlcommand = "update bookmanager set UserId=@p1,isBorrowed=@p2,BorrowedAt=@p3 where isbn=@p4";

            cmd.Parameters.AddWithValue("@p1", userId);
            cmd.Parameters.AddWithValue("@p2", isBorrowed);
            cmd.Parameters.AddWithValue("@p3", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff"));
            cmd.Parameters.AddWithValue("@p4", isbn);
        }
        else //๋์ด์จ isBorrowed๊ฐ์ด 0์ด๋ผ๋ฉด ๋ฐ๋ฉ
        {
            sqlcommand = "update bookmanager set userId=null,isBorrowed=0,BorrowedAt=null where isbn=@p1";

            cmd.Parameters.AddWithValue("@p1", isbn);
        }

        cmd.CommandText = sqlcommand;
        cmd.ExecuteNonQuery();

        conn.Close();
    }
    catch (Exception ex)
    {
        conn.Close();
        System.Windows.Forms.MessageBox.Show(ex.Message);
    }
}
  
```
  
</div>
</details>
  
  <br>
  
### ๐ธ ๋์ ๊ด๋ฆฌ ํ๋ฉด
- ๋์ ๊ด๋ฆฌ ๊ธฐ๋ฅ(์ถ๊ฐ, ์์ , ์ญ์ )์ด ์์ผ๋ฉฐ, isbn์ด ๊ฒน์น๋ฉด ๋ฑ๋ก๋์ง ์์ต๋๋ค. 
- isBorrowed๋ DB์์ Default ๊ฐ์ผ๋ก 0์ด ์๋์ผ๋ก ์๋ ฅ๋ฉ๋๋ค. 
  
<img src="img/bookForm.PNG" width="560" height="350" >
  

  
  <br>
  
### ๐ธ ์ฌ์ฉ์ ๊ด๋ฆฌ ํ๋ฉด
- ์ฌ์ฉ์ ๊ด๋ฆฌ ๊ธฐ๋ฅ(์ถ๊ฐ, ์์ , ์ญ์ )์ด ์์ผ๋ฉฐ, ID๊ฐ ๊ฒน์น๋ฉด ๋ฑ๋ก๋์ง ์์ต๋๋ค.
- <b>์ฌ์ฉ์ ๊ฒ์</b> : ID์ DB์ ์ ์ฅ๋ ID๋ฅผ ๋น๊ตํด ์ ๋ณด๋ฅผ ๋ถ๋ฌ์ต๋๋ค. reset๋ฒํผ์ ๋๋ฅด๋ฉด ๋ค์ ์ ์ฒด ์ฌ์ฉ์ ๋ชฉ๋ก์ผ๋ก ๋ฐ๋๋๋ค.
  
<img src="img/userForm.PNG" width="460" height="370" >
  
<img src="img/UserSearch.PNG" width="460" height="370" >

<details>
<summary>์ฝ๋๋ณด๊ธฐ</summary>
<div markdown="1">
  
```C#
  
//์ฌ์ฉ์ ๊ฒ์
private void button_search_Click(object sender, EventArgs e)
{
    string searchUser = textBox_search.Text.Trim();
    bool chkUser = false;
    if(textBox_search.Text.Trim() =="")
        MessageBox.Show("ID๋ฅผ ์๋ ฅํด์ฃผ์ธ์");
    else
    {
        for(int i = 0; i<DataManager.Users.Count; i++)
       {
          if(DataManager.Users[i].UserId == textBox_search.Text)
          {
              DataManager.UserSearch(searchUser);
              chkUser = true;
          }
        }
        if (chkUser == false)
        {
            MessageBox.Show("์กฐํ๋ ์ฌ์ฉ์๊ฐ ์์ต๋๋ค.");
        }
        else
        {
            dataGridView_user.DataSource = null;
            if(DataManager.Users.Count > 0)
                dataGridView_user.DataSource=DataManager.Users;
          }
      }
}
  
//DataManager.cs
public static void UserSearch(string searchUser)
{
    try
    {
        DBHelper.UserSearch(searchUser);
        Users.Clear();
        foreach (DataRow item in DBHelper.ds.Tables[0].Rows)
        {
            User user = new User();
            user.UserId = item["UserId"].ToString();
            user.Name = item["name"].ToString();
            Users.Add(user);
        }
    }
    catch (Exception ex)
    {
        System.Windows.Forms.MessageBox.Show(ex.Message + Environment.NewLine + ex.StackTrace);
    }
}
  
//DBHelper.cs
public static void UserSearch(string searchUser)
{
    try
    {
        ConnectDB();

        SqlCommand cmd = new SqlCommand();
        cmd.Connection = conn;
        cmd.CommandText = "select * from BookUser where userId like '%" + searchUser + "%'";

        da = new SqlDataAdapter(cmd);
        ds = new DataSet();
        da.Fill(ds, "UserManager");
        dt = ds.Tables[0];

        conn.Close();
    }
    catch (Exception ex)
    {
        conn.Close();
        System.Windows.Forms.MessageBox.Show(ex.Message);
    }
}
  
```
  
</div>
</details>

# ๐ ๊ฐ์ฌํฉ๋๋ค.
