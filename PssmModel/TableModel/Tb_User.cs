public class Tb_User
{
    /// <summary>
    /// �޲ι��췽��
    /// </summary>
    public Tb_User() { }

    /// <summary>
    /// ���ݿ�ǿ��ֶεĹ��췽��
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
    /// ָ���ֶεĹ��췽��
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
    /// ��ɫID
    /// </summary>
    private long realID;
    public long RealID
    {
        get { return realID; }
        set { realID = value; }
    }

    /// <summary>
    /// �Ƿ�����
    /// </summary>
    private bool isEnabled;
    public bool IsEnabled
    {
        get { return isEnabled; }
        set { isEnabled = value; }
    }
}