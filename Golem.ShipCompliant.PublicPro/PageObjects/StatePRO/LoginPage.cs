using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using ProtoTest.Golem.WebDriver;
using ProtoTest.Golem.WebDriver.Elements.Types;

namespace Golem.ShipCompliant.PublicPro.PageObjects.StatePRO
{
    public class LoginPage : BasePageObject
    {

        Element stateLogo = new Element("StateLogo", By.XPath("//div[@id='state-logo']"));
        Element stateUserNameField = new Element("StateUserNameField", By.XPath("//input[@id='userName']"));
        Element statePasswordField = new Element("StatePasswordField", By.XPath("//input[@id='password']"));
        Button stateLoginButton = new Button(By.XPath("//input[@type='submit']"));


        public override void WaitForElements()
        {
            stateLogo.WaitUntil().Present();
        }

        public ProcessRegistrationsPage LoginStatePro(string stateusername, string statepassword)
        {
            stateUserNameField.Text = stateusername;
            statePasswordField.Text = statepassword;
            stateLoginButton.Click();

            return new ProcessRegistrationsPage();
        }



    }
}
