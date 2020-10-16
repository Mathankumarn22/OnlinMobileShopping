using System.Text.RegularExpressions;


namespace OnlineMobileShop.Common
{
    public class Validation
    {
        public static bool IsValidName(string name)
        {
            Regex regex = new Regex(@"^[A-Za-z]+$", RegexOptions.IgnoreCase);
            return regex.IsMatch(name);
        }
        public static bool IsValidMailId(string mail)
        {
            Regex regex = new Regex("^[a-z0-9][-a-z0-9._]+@([-a-z0-9]+.)+[a-z]{2,5}$");
            return regex.IsMatch(mail);
        }
        public static bool IsValidMobileNumber(string number)
        {
            Regex regex = new Regex(@"^[6789]\d{9}$");
            return regex.IsMatch(number);
        }
        public static bool IsValidPassword(string password)
        {
            Regex regex = new Regex("^(?=.{8,})(?=.*[a-z])(?=.*[A-Z])(?!.*s).*$");
            return regex.IsMatch(password);
        }
        public static bool IsValidBrand(string brand)
        {
            Regex regex = new Regex(@"^[A-Za-z]+$", RegexOptions.IgnoreCase);
            return regex.IsMatch(brand);
        }
        public static bool IsValidModel(string model)
        {
            Regex regex = new Regex("^^[A-Za-z]+$");
            return regex.IsMatch(model);
        }
        public static bool IsValidBattery(string battery)
        {
            Regex regex = new Regex(@"^[1-4]\d{4}$");
            return regex.IsMatch(battery);
        }
        public static bool IsValidPrice(string price)
        {
            Regex regex = new Regex(@"^[1-4]\d{4,5}$");
            return regex.IsMatch(price);
        }

        public bool IsValidRole(string role)
        {
            if (role == "Admin" || role == "User")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
