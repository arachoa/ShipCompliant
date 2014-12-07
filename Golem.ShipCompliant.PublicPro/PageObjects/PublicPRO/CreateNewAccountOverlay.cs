using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using ProtoTest.Golem.WebDriver;
using ProtoTest.Golem.WebDriver.Elements.Types;

namespace Golem.ShipCompliant.PublicPro.PageObjects
{
    public class CreateNewAccountOverlay : BasePageObject
    {

        Element createNewTab = new Element("CreateNewTab", By.XPath("//div[@class='login-tab' and contains(.,'Create New')]"));
        Element loginTab = new Element("LoginTab", By.XPath("//div[@class='login-tab' and contains(.,'Login')]"));
        Element loginEmail = new Element("LoginEmail", By.XPath("//input[@id='login-username']"));
        Element loginPassword = new Element("LoginPassword", By.XPath("//input[@id='login-password']"));
        Element loginButton = new Element("LoginButton", By.XPath("//button[@class='button button-blue' and contains(.,'Login')]"));
        Element createNewSelected = new Element("CreateNewSelected", By.XPath("//div[@class='login-tab selected' and contains(.,'Create New')]"));
        Element emailAddTextbox = new Element("EmailAddressTextbox", By.XPath("//input[@id='username']"));
        Element termsConditionsCheckbox = new Element("TermsConditionsCheckbox", By.XPath("//input[@id='agree-to-terms']"));
        Element createNewButton = new Element("CreateNewButton", By.XPath("//a[@id='continue-registration' and contains(.,'Create new')]"));
        Element firstNameTextbox = new Element("FirstNameTextbox", By.XPath("//input[@name='registration.User.FirstName']"));
        Element lastNameTextbox = new Element("LastNameTextbox", By.XPath("//input[@name='registration.User.LastName']"));
        Element passwordTextbox = new Element("PasswordTextbox", By.XPath("//input[@name='registration.User.Password']"));
        Element phoneNumTextbox = new Element("PhoneNumTextbox", By.XPath("//input[@name='registration.User.PhoneNumber']"));
        Element address1Textbox = new Element("Address1Textbox", By.XPath("//input[@name='registration.Supplier.Street1']"));
        Element address2Textbox = new Element("Address2Textbox", By.XPath("//input[@name='registration.Supplier.Street2']"));
        Element cityTextbox = new Element("CityTextbox", By.XPath("//input[@name='registration.Supplier.City']"));
        Dropdown stateDropdown = new Dropdown(By.XPath("//select[@name='registration.Supplier.State']"));
        Element zipTextbox = new Element("Zip", By.XPath("//input[@name='registration.Supplier.ZipCode']"));
        Element createMyAccountBtn = new Element("CreateMyAccountBtn", By.XPath("//button[@class='button button-blue prompt-registration']"));

        
        public override void WaitForElements()
        {

        }

        public CreateNewAccountOverlay SelectCreateNewTab()
        {
            bool createNewTabSelected;
            createNewTabSelected = createNewSelected.Present;

            if (createNewTabSelected == false)
            {
                createNewTab.Click();
                return new CreateNewAccountOverlay();
            }
            else
                return this;
        }

        //public CreateNewAccountOverlay SelectLogInTab()
        //{
        //    loginTab.Click();

        //}

        //I combined step 17, 18, and 19 into one below
        public CreateNewAccountOverlay CreateNewEmailAddress(string firstname, string lastname)
        {
            string emailFormat = "";

            //for (int i = 1; i <= 1; i++)
            //{
            //    emailFormat += firstname + lastname + i.ToString("0000") + "@six88.com";
            //}

            //emailAddTextbox.Text = emailFormat;

            //var emailExistsAlert = driver.SwitchTo().Alert();
            //var emailExistsAlert = driver.FindVisibleElement(By.)
            //if (emailExistsAlert.Text = "This email address is already in use. Please log in.")
            //{
            //    emailExistsAlert.Accept();
            //}
            
            int i = 1;
            do
            {
                emailFormat = firstname + lastname + i.ToString("0000") + "@six88.com";
                emailAddTextbox.Text = emailFormat;
                termsConditionsCheckbox.Click();
                createNewButton.Click();
               
                i++;

                //if (firstNameTextbox.Present)
                //{
                //    break;
                //}
            } while (!firstNameTextbox.Present);

            return new CreateNewAccountOverlay();
            
        }

        public CreateNewAccountOverlay EnterNewAccoutInformation(string firstname, string lastname, string password, string phonenumber, string address1, string address2, 
            string city, string state, string zip)
        {
            firstNameTextbox.Text = firstname;
            lastNameTextbox.Text = lastname;
            passwordTextbox.Text = password;
            phoneNumTextbox.Text = phonenumber;
            address1Textbox.Text = address1;
            address2Textbox.Text = address2;
            cityTextbox.Text = city;
            stateDropdown.SelectOption(state);
            zipTextbox.Text = zip;

            return this;
        }

        public SelectState SelectCreateMyAccoutBtn()
        {
            createMyAccountBtn.Click();

            return new SelectState();
        }



        
        

        

            






    }
}
