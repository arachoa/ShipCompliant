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
    public class eSignatureOverlay : BasePageObject
    {

        Element eSignitueField = new Element("ESignitureField", By.XPath("//object[@id='ESignOnline']"));
        Button continueButton = new Button(By.XPath("//a[@id='save']"));
        
        
        
        public override void WaitForElements()
        {

        }

        public eSignatureOverlay EnterSigniture()
        {
            eSignitueField.Click();

            return new eSignatureOverlay();
        }
        
        public Review SelectContinueButton() 
        {
            continueButton.Click();

            return new Review();
        }
    }
}
