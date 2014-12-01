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
    public class SelectState : BasePageObject
    {

        public Element stateOptionButton(string text)
        {
            return new Element("StateOptionButton", By.XPath("//div[@class='directProRegionToRegister']/strong[contains(.,'" + text + "')]"));
        }
        
        public override void WaitForElements()
        {

        }

        public LicenseNumOverlay SelectAStateBtn(string text)
        {
            stateOptionButton(text).Click();

            return new LicenseNumOverlay();
        }





    }
}
