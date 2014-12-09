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
    public class EditRegistrationPage : BasePageObject
    {

        Button browseButton = new Button(By.XPath("//input[@type='file']"));
        Element commentTextBox = new Element("CommentTextBox", By.XPath("//textarea[@id='LabelPacketComments']"));
        Button saveButton = new Button(By.XPath("//span[@id='save-existing']"));
        
        
        public override void WaitForElements()
        {

        }

        public EditRegistrationPage UploadFranchiseLetter(string franchisefilepath)
        {
            browseButton.SendKeys(franchisefilepath);

            return new EditRegistrationPage();
        }

        public EditRegistrationPage TypeFranchiseComment(string franchisecomment)
        {
            commentTextBox.WaitUntil().Visible().Text = franchisecomment;

            return this;
        }

        public RegistrationDetailsPage SelectSaveButton()
        {
            saveButton.Click();

            return new RegistrationDetailsPage();
        }





    }
}
