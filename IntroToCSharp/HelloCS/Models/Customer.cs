namespace HelloCS;

public class Customer
    {
        #region Properties
    public string FirstName {get; private set;}
    public string LastName {get; private set;}
    public string FullName{
    get => Firstname + " " LastName;}
    public string Email {get; private set;}
    #endregion
    
    #region Methods
    public void UpdateInfo(string firstName, string lastName)
    {
        if(string.IsNullOrWhiteSpace(firstName) && string.IsNullOrWhiteSpace(lastName)){
            return;
        }
        if(!string.IsNullOrWhiteSpace(firstName) && !string.IsNullOrWhiteSpace(lastName)){
            FirstName = firstName;
            LastName = lastName;
        }
        else if(!string.IsNullOrWhiteSpace(firstName)){
            FirstName = firstName;
        }
        else if(!string.IsNullOrWhiteSpace(lastName)){
            LastName = lastName;
        }
    }
}