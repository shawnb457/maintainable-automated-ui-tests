using MvcMusicStore.FunctionalTests.Framework;
using OpenQA.Selenium;

namespace MvcMusicStore.FunctionalTests.PageObjects
{
    public class ShoppingCartPage : Page
    {
        public AddressAndPaymentPage Checkout()
        {
            return NavigateTo<AddressAndPaymentPage>(By.LinkText("Checkout >>"));
        }
    }
}