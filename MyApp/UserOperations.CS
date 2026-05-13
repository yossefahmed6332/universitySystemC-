interface IUserOperations
{

    public bool login(String username, String password, List <User>users);
    public  bool  register(String name, String email, String password, String ID, String phoneNumber, List <User>users);

}
