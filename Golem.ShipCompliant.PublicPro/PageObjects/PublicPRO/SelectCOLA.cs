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
    public class SelectCOLA : BasePageObject
    {
        Element selectCOLASlider = new Element("SelectCOLASlider", By.XPath("//div[@class='step first active']/a[contains(Select, COLA)]"));
        Element permitNumSearchField = new Element("PermitNumSearchField", By.XPath("//input[@id='searchKeyword' and contains(@placeholder, 'permit number')]"));
        Element colaNumSearchField = new Element("COLANumSearchField", By.XPath("//input[@id='searchKeyword' and contains(@placeholder, 'COLA')]"));
        
        
        
        public Element dropdownPermitOption(string text)
        {
            //return new Element("DropdownPermitOption", By.XPath("//div[(contains(@style, 'display: block;'))]/div[(contains(@title, '" + text + "'))]"));
            return new Element("DropdownPermitOption", By.ClassName("selected"));

        }

        public Element welcomeLicenseMessage(string text)
        {
            return new Element("WelcomeLicenseMessage", By.XPath("//strong[@id='welcomeLicenseeMessage' and contains(.,'" + text + "')]"));
        }

        public Element dropdownCOLAOption(string text)
        {
            //return new Element("DropdownCOLAOption", By.XPath("//div[(contains(@style, 'display: block;'))]/div[(contains(@title, '" + text + "'))]"));
            return new Element("DropdownCOLAOption", By.ClassName("selected"));
        }

        public Element colaNumLabel(string text)
        {
            return new Element("LabelCOLANumber", By.XPath("//div[@class='cola-number' and contains(.,'" + text + "')]"));
        }

        public Text ColaNumLabelText = new Text(By.XPath("//div[@class='cola-number']"));
        
   
        
        public override void WaitForElements()
        {
            
        }

        public SelectCOLA VerifySelectCOLAHighlighted()
        {
            selectCOLASlider.Verify().Visible();
            selectCOLASlider.Highlight();

            return this;
        }

        public SelectCOLA TypePermitNum(string text)
        {
            permitNumSearchField.SendKeys(text);
            
            return new SelectCOLA();
        }

        //Ara - Webdriver can't find the dropdown element so I use sendkeys instead of clicking it
        public SelectCOLA SelectDropdownOption(string text)
        {
            Thread.Sleep(1000);
            permitNumSearchField.SendKeys(Keys.ArrowDown);
            permitNumSearchField.SendKeys(Keys.Enter);

            return new SelectCOLA();
        }

        public SelectCOLA VerifyWelcomeLicenseMessage(string text)
        {
            welcomeLicenseMessage(text).Verify().Visible();

            return this;
        }

        public SelectCOLA TypeCOLANum(string text)
        {
            colaNumSearchField.SendKeys(text);

            return new SelectCOLA();
        }

        public SelectCOLA SelectCOLADropdownOption(string text)
        {
            Thread.Sleep(1000);
            colaNumSearchField.SendKeys(Keys.ArrowDown);
            colaNumSearchField.SendKeys(Keys.Enter);

            return new SelectCOLA();
        }

        public SelectCOLA VerifyLabelCOLANum(string colanumber)
        {
            //string initialCOLANum = colanumber;
            //string currentCOLANum = colaNumLabel(text).Text;

            //Equals(initialCOLANum, currentCOLANum);
            ColaNumLabelText.Verify().Text(colanumber);
            


            return this;
        }

        public SelectThisLabelOverlay SelectTheLable(string text)
        {
            colaNumLabel(text).Click();

            return new SelectThisLabelOverlay();
        }

        

        


    }
}
