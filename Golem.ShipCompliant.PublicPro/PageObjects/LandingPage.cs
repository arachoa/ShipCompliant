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
    public class LandingPage : BasePageObject
    {
        Element beginRegistrationButton = new Element("BeginRegistrationButton", By.XPath("//a[@class='button big-orange']"));

        public override void WaitForElements()
        {
            //beginRegistrationButton.Verify().Present();
        }

        public SelectCOLA ClickBeginRegistrationButton()
        {
            beginRegistrationButton.Click();

            return new SelectCOLA();
        }


        
    }
}
