using System;
using System.ComponentModel.DataAnnotations;

namespace Files
{
  public class HireAdminViewModel
{
    public string Email { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }
    public DateTime DOB { get; set; }
    public string Password { get; set; }
}
