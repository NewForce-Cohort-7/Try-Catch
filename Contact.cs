public class Contact
{
    //null conditional operator
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
    public string? Address { get; set; }

//for anyone who cares, you can also use a => to replace the get { return $"{firstname} {lastname} } in that fullname thing
    public string FullName
    {
        get
        {
            return $"{FirstName} {LastName}";
        }
    }
}