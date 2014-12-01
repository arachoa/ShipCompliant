using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using ProtoTest.Golem.WebDriver;
using ProtoTest.Golem.WebDriver.Elements.Types;
using System.Threading;


namespace Golem.ShipCompliant.PublicPro.PageObjects
{
    public class LicenseNumOverlay : BasePageObject
    {

        //Element licenseNumSearchField = new Element(By.Id("stateLicenseNumber"));
        Element licenseNumSearchField = new Element("LicenseNumSearchField", By.XPath("//input[@id='stateLicenseNumber']"));
        Element NewBrandRegistrationBtn = new Element("NewBrandRegistrationBtn", By.XPath("//div[@id='new-brand-registration']"));
        
        public Element licenseNumValue(string text)
        {
            return new Element("LicenseNumValue", By.XPath("//input[@id='stateLicenseNumber_value' and contains(@value, '" + text + "')]"));
        }

        public override void WaitForElements()
        {

        }

        public LicenseNumOverlay EnterLicenseNumber(string licensenumber)
        {
            Thread.Sleep(1000);
            licenseNumSearchField.SendKeys(licensenumber);

            return new LicenseNumOverlay();
        }

        public LicenseNumOverlay SelectLicenseNumOption(string text)
        {
            //Thread.Sleep(1000);
            licenseNumSearchField.SendKeys(Keys.ArrowDown);
            licenseNumSearchField.SendKeys(Keys.Enter);

            return new LicenseNumOverlay();
        }

        public LicenseNumOverlay VerifyLicenseNumber(string text)
        {

            licenseNumSearchField.Verify().Value(text);

            return this;
        }

        public ProductDetails SelectNewBrandRegistration()
        {
            NewBrandRegistrationBtn.Click();

            return new ProductDetails();
        }


    }
}
