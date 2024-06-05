public class Tb_User
{
    /// <summary>
    /// 无参构造方法
    /// </summary>
    public Tb_User() { }

    /// <summary>
    /// 数据库非空字段的构造方法
    /// </summary>
    public Tb_User(long userID, string username, string password, long realID, bool isEnabled)
    {
        this.userID = userID;
        this.username = username;
        this.password = password;
        this.realID = realID;
        this.isEnabled = isEnabled;
    }

    /// <summary>
    /// 指定字段的构造方法
    /// </summary>
    public Tb_User(long userID, string username, string password, string email, long realID, bool isEnabled)
    {
        this.userID = userID;
        this.username = username;
        this.password = password;
        this.email = email;
        this.realID = realID;
        this.isEnabled = isEnabled;
    }
    /// <summary>
    /// 
    /// </summary>
    private long userID;
    public long UserID
    {
        get { return userID; }
        set { userID = value; }
    }

    private string username;
    public string Username
    {
        get { return username; }
        set { username = value; }
    }

    private string password;

    public string Password
    {
        get { return password; }
        set { password = value; }
    }

    private string email;
    public string Email
    {
        get { return email; }
        set { email = value; }
    }

    /// <summary>
    /// 角色ID
    /// </summary>
    private long realID;
    public long RealID
    {
        get { return realID; }
        set { realID = value; }
    }

    /// <summary>
    /// 是否启用
    /// </summary>
    private bool isEnabled;
    public bool IsEnabled
    {
        get { return isEnabled; }
        set { isEnabled = value; }
    }
}