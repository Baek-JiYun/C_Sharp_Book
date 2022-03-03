# 📖 C# 도서관리 프로그램
- <b>Language</b> : <img alt="C#" src="https://img.shields.io/badge/C%23-239120?style=flat-square&logo=c-sharp&logoColor=white"/>
- <b>Database</b> : <img alt="MSSQL" src ="https://img.shields.io/badge/MsSQL-CC2927?style=flat-square&logo=microsoft SQL Server&logoColor=white" />
- <b>Tool</b> : <img alt="Visual Studio" src="https://img.shields.io/badge/Visual Studio-5C2D91?style=flat-square&logo=Visual Studio&logoColor=white"/>
- 도서관리를 목적으로 하였습니다.

<br>

## 🔖 제작기간 및 개발 인원
- 기간 : 2022.02 ~ 2022.02 (약 1주)
- 인원 : 1명 ( 개인 프로젝트 )

<br>

## 🔖 주요 기능

### 🔸 메인화면
- 전체적인 도서 목록과 사용자 목록을 확인할 수 있습니다.
- <b>대여 / 반납</b> : 대여중인 책은 isBorrowed가 1로 표기되며, 빌려간 시간과 ID가 저장됩니다.
- 대여하려는 책의 isBorrowed가 1이라면 대여가 불가능합니다.
- <b>도서 검색</b> : 제목을 비교해 정보를 불러옵니다. reset버튼을 누르면 다시 전체목록으로 바뀝니다.
- <b>도서 및 사용자 관리</b> : 프로그램 왼쪽 버튼으로 도서관리와 사용자관리 폼으로 이동됩니다.

<img src="img/main.PNG" width="560" height="360" >


<img src="img/search.PNG" width="560" height="360" >

<details>
<summary>코드보기</summary>
<div markdown="1">
  
```C#
  
//
private void button_search_Click(object sender, EventArgs e)
{ 
    bool chkBook = false;
    if (textBox_search.Text.Trim() == "")
        MessageBox.Show("도서 제목을 입력하세요.");
    else
    {
        string[] search_book = textBox_search.Text.Split(' '); //공백기준으로 단어 나눔
        string search_book_Name=search_book[0].Trim(); // 첫번째 단어 공백제거 후 저장

        for(int i=0; i < DataManager.Books.Count; i++)
        {
             if(DataManager.Books[i].Name.Contains(search_book_Name)) //책 제목에 search_book_Name가 포함되어있다면 실행
             {
                  DataManager.BookSearch(search_book_Name);
                  chkBook = true;
             }
        }
        if (chkBook==false)
        {
             MessageBox.Show("조회된 도서가 없습니다.");
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
  
//새로고침
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
<summary>대여 / 반납 </summary>
<div markdown="1">
  
```C#
  
//대여
private void button_Borrow_Click(object sender, EventArgs e)
{
    if (textBox_Isbn.Text.Trim() == "")
        MessageBox.Show("Isbn을 입력하세요.");
    else if (textBox_userId.Text.Trim()=="")
        MessageBox.Show("사용자 Id를 입력하세요.");
    else
    {
        try
        {
            Book book = DataManager.Books.Single((x) => x.Isbn == textBox_Isbn.Text);
            if (book.isBorrowed == 0) //대여 가능
            {
                User user = DataManager.Users.Single((x) => x.UserId.ToString() == textBox_userId.Text);
                book.Isbn = textBox_Isbn.Text;
                book.UserId = user.UserId;
                book.isBorrowed = 1;

                DataManager.Save(book.Isbn, book.UserId, book.isBorrowed);
                MessageBox.Show($"{user.Name}님께 정상 대여되었습니다.");
  
                ReLoad();
            }
            else
            {
                MessageBox.Show("현재 대여중인 도서입니다.");
            }
        }
        catch (Exception)
        {
            MessageBox.Show("존재하지 않는 도서 혹은 사용자입니다.");
        }
    }
}
  
//반납
private void button_Return_Click(object sender, EventArgs e)
{
    if (textBox_Isbn.Text.Trim() == "")
        MessageBox.Show("isbn을 입력하세요.");
    else
    {
        try
        {
            Book book = DataManager.Books.Single((x) => x.Isbn == textBox_Isbn.Text);
            if (book.isBorrowed == 1) // 대여된 상태
            {
                DateTime date = book.BorrowedAt;
                book.Isbn = textBox_Isbn.Text;
                book.isBorrowed=0;

                DataManager.Save(book.Isbn, "", book.isBorrowed);
                        
                TimeSpan timeDiff = DateTime.Now - date;
                if(timeDiff.Days > 7)
                {
                    MessageBox.Show(timeDiff.Days+"일 연체된 도서입니다.");
                }
                else
                {
                    MessageBox.Show("정상반납 되었습니다.");

                    ReLoad();
                }
            }
            else
            {
               MessageBox.Show("대여 상태가 아닙니다.\n다시 확인해주세요.");
            }
        }
        catch (Exception)
        {
            MessageBox.Show("Isbn을 다시 확인해주세요.");
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
        if (isBorrowed == 1) // 넘어온 isBorrowed값이 1이라면 대여
        {
            sqlcommand = "update bookmanager set UserId=@p1,isBorrowed=@p2,BorrowedAt=@p3 where isbn=@p4";

            cmd.Parameters.AddWithValue("@p1", userId);
            cmd.Parameters.AddWithValue("@p2", isBorrowed);
            cmd.Parameters.AddWithValue("@p3", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff"));
            cmd.Parameters.AddWithValue("@p4", isbn);
        }
        else //넘어온 isBorrowed값이 0이라면 반납
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
  
### 🔸 도서 관리 화면
- 도서 관리 기능(추가, 수정, 삭제)이 있으며, isbn이 겹치면 등록되지 않습니다. 
- isBorrowed는 DB에서 Default 값으로 0이 자동으로 입력됩니다. 
  
<img src="img/bookForm.PNG" width="560" height="350" >
  

  
  <br>
  
### 🔸 사용자 관리 화면
- 사용자 관리 기능(추가, 수정, 삭제)이 있으며, ID가 겹치면 등록되지 않습니다.
- <b>사용자 검색</b> : ID와 DB에 저장된 ID를 비교해 정보를 불러옵니다. reset버튼을 누르면 다시 전체 사용자 목록으로 바뀝니다.
  
<img src="img/userForm.PNG" width="460" height="370" >
  
<img src="img/UserSearch.PNG" width="460" height="370" >

<details>
<summary>코드보기</summary>
<div markdown="1">
  
```C#
  
//사용자 검색
private void button_search_Click(object sender, EventArgs e)
{
    string searchUser = textBox_search.Text.Trim();
    bool chkUser = false;
    if(textBox_search.Text.Trim() =="")
        MessageBox.Show("ID를 입력해주세요");
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
            MessageBox.Show("조회된 사용자가 없습니다.");
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

# 😘 감사합니다.
